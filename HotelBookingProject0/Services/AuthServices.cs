using HotelBookingProject0.Constants;
using HotelBookingProject0.Data;
using HotelBookingProject0.Models.DTO.AuthDTOs;
using HotelBookingProject0.Models.Entities;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HotelBookingProject0.Services
{
    public class AuthServices(UserManager<User> userManager, SignInManager<User> signInManager, IConfiguration configuration, HotelBookingContext context) : IAuthService
    {
        private readonly IConfiguration configuration = configuration;
        private readonly HotelBookingContext context = context;
        //<inheritdoc/>
        public async Task<AuthResponseDTO> RegisterAsync(RegisterDTO dto)
        {
            var existing = await userManager.FindByEmailAsync(dto.Email);
            if (existing != null)
            { 
                throw new InvalidOperationException("User with this email already exists");
            }

            var user = new User
            {
                UserName = dto.Username,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                IsActive = true,
                CreatedAt = DateTime.UtcNow
            };

            var result = await userManager.CreateAsync(user, dto.Password);
            if (!result.Succeeded)
            {
                throw new InvalidOperationException(string.Join("; ", result.Errors.Select(e => e.Description)));
            }

            var roleResult = await userManager.AddToRoleAsync(user, Roles.Customer);
            if (!roleResult.Succeeded)
            {
                throw new InvalidOperationException("Role assignment failed");
            }

            return new AuthResponseDTO
            {
                Email = user.Email!,
                Username = user.UserName!,
                Role = Roles.Customer
            };
        }
        //<inheritdoc/>
        public async Task<AuthResponseDTO> LoginAsync(LoginDTO dto)
        {
            var user = await userManager.FindByEmailAsync(dto.Email)
                ?? throw new UnauthorizedAccessException("Email or password is incorrect");

            var result = await signInManager.CheckPasswordSignInAsync(user, dto.Password, false);
            if (!result.Succeeded)
            {
                throw new UnauthorizedAccessException("Email or password is incorrect");
            }

            var roles = await userManager.GetRolesAsync(user);

           
            var jwt = GenerateJwtToken(user, roles);
            var refreshToken = GenerateRefreshToken();

            
            var rtEntity = new Models.Entities.RefreshToken
            {
                Token = refreshToken,
                Expires = DateTime.UtcNow.AddDays(configuration.GetValue<int>("Jwt:RefreshTokenTTLDays")),
                Created = DateTime.UtcNow,
                UserId = user.Id
            };
            context.RefreshTokens.Add(rtEntity);
            await context.SaveChangesAsync();

            return new AuthResponseDTO
            {
                Email = user.Email!,
                Username = user.UserName!,
                Role = roles.FirstOrDefault() ?? Roles.Customer,
                Token = jwt,
                RefreshToken = refreshToken
            };
        }
        //<inheritdoc/>
        public async Task LogoutAsync(string email, string password)
        {
            var user = await userManager.FindByEmailAsync(email)
                ?? throw new UnauthorizedAccessException("Email or password is incorrect");

            var result = await signInManager.CheckPasswordSignInAsync(user, password, false);
            if (!result.Succeeded)
            {
                throw new UnauthorizedAccessException("Email or password is incorrect");
            }

            await signInManager.SignOutAsync();
        }
        //<inheritdoc/>
        public async Task<AuthResponseDTO> RefreshTokenAsync(string token)
        {
            var rt = await context.RefreshTokens.Include(r => r.User).FirstOrDefaultAsync(r => r.Token == token);
            if (rt == null || !rt.IsActive)
            {
                throw new UnauthorizedAccessException("Invalid refresh token");
            }

            var user = await userManager.FindByIdAsync(rt.UserId) ?? throw new UnauthorizedAccessException("Invalid token user");
            var roles = await userManager.GetRolesAsync(user);

           
            rt.Revoked = DateTime.UtcNow;
            var newToken = GenerateRefreshToken();
            rt.ReplacedByToken = newToken;

            var newRt = new Models.Entities.RefreshToken
            {
                Token = newToken,
                Expires = DateTime.UtcNow.AddDays(configuration.GetValue<int>("Jwt:RefreshTokenTTLDays")),
                Created = DateTime.UtcNow,
                UserId = user.Id
            };

            context.RefreshTokens.Add(newRt);
            await context.SaveChangesAsync();

            var jwt = GenerateJwtToken(user, roles);

            return new AuthResponseDTO
            {
                Email = user.Email!,
                Username = user.UserName!,
                Role = roles.FirstOrDefault() ?? Roles.Customer,
                Token = jwt,
                RefreshToken = newToken
            };
        }
        //<inheritdoc/>
        public async Task RevokeRefreshTokenAsync(string token)
        {
            var rt = await context.RefreshTokens.FirstOrDefaultAsync(r => r.Token == token);
            if (rt == null || !rt.IsActive) return;
            rt.Revoked = DateTime.UtcNow;
            await context.SaveChangesAsync();
        }
       

        private string GenerateJwtToken(User user, IList<string> roles)
        {
            var secret = configuration["Jwt:Secret"] ?? throw new InvalidOperationException("JWT secret is not configured");
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secret));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var claims = new List<Claim>
            {
                new(ClaimTypes.NameIdentifier, user.Id),
                new(ClaimTypes.Name, user.UserName ?? string.Empty),
                new(ClaimTypes.Email, user.Email ?? string.Empty)
            };

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var token = new JwtSecurityToken(
                issuer: configuration["Jwt:Issuer"],
                audience: configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(60),
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private string GenerateRefreshToken()
        {
            var randomBytes = new byte[64];
            using var rng = System.Security.Cryptography.RandomNumberGenerator.Create();
            rng.GetBytes(randomBytes);
            return Convert.ToBase64String(randomBytes);
        }
    }
}