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
    public class AuthServices(UserManager<User> userManager, SignInManager<User> signInManager,
                       IConfiguration config, HotelBookingContext db) : IAuthService
    {
        private readonly UserManager<User> userManager = userManager;
        private readonly SignInManager<User> signInManager = signInManager;
        private readonly IConfiguration config = config;
        private readonly HotelBookingContext db = db;

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
                var errors = string.Join("; ", result.Errors.Select(e => e.Description));
                throw new InvalidOperationException(errors);
            }

            
            var roleResult = await userManager.AddToRoleAsync(user, Roles.Customer);

            if (!roleResult.Succeeded)
            {
                throw new InvalidOperationException("User created but role assignment failed.");
            }

            return new AuthResponseDTO
            {
                Email = user.Email!,
                Username = user.UserName!,
                Role = Roles.Customer,
            };
        }

        public async Task<AuthResponseDTO> LoginAsync(LoginDTO dto)
        {
            var user = await userManager.FindByEmailAsync(dto.Email)
                ?? throw new UnauthorizedAccessException("Email or password is incorrect");

            var result = await signInManager.CheckPasswordSignInAsync(user, dto.Password, false);
            if (!result.Succeeded)
            { throw new UnauthorizedAccessException("Email or password is incorrect"); }

            var roles = await userManager.GetRolesAsync(user);
            var role = roles.FirstOrDefault() ?? Roles.Customer;

            return new AuthResponseDTO
            {
                Email = user.Email!,
                Username = user.UserName!,
                Role = role
            };
        }

        public async Task<UserDTO> GetUserAsync(string userId)
        {
            var user = await userManager.FindByIdAsync(userId)
                ?? throw new KeyNotFoundException("User not found");
            var roles = await userManager.GetRolesAsync(user);

            return new UserDTO
            {
                Username = user.UserName!,
                Email = user.Email!,
                Role = roles.FirstOrDefault() ?? Roles.Customer,
                IsActive = user.IsActive
            };
        }

        public async Task<UserProfileDTO> GetProfileAsync(string userId)
        {
            var profile = await db.UserProfiles.FirstOrDefaultAsync(p => p.UserId == userId)
                ?? throw new KeyNotFoundException("Profile not found");

            return MapToProfileDto(profile);
        }

        public async Task<UserProfileDTO> UpdateProfileAsync(string userId, UserProfileDTO dto)
        {
            var profile = await db.UserProfiles.FirstOrDefaultAsync(p => p.UserId == userId);

            if (profile == null)
            {
                profile = new UserProfile { UserId = userId };
                db.UserProfiles.Add(profile);
            }

            profile.Address = dto.Address;
            profile.City = dto.City;
            profile.DateOfBirth = dto.DateOfBirth;
            profile.AvatarUrl = dto.AvatarUrl;
            profile.Bio = dto.Bio;
            profile.UpdatedAt = DateTime.UtcNow;

            await db.SaveChangesAsync();
            return MapToProfileDto(profile);
        }

        private static UserProfileDTO MapToProfileDto(UserProfile p) => new()
        {
            Address = p.Address,
            City = p.City,
            DateOfBirth = p.DateOfBirth,
            AvatarUrl = p.AvatarUrl,
            Bio = p.Bio
        };
    }
}
