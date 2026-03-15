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
    public class AuthServices(UserManager<User> userManager, SignInManager<User> signInManager) : IAuthService
    {
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

            return new AuthResponseDTO
            {
                Email = user.Email!,
                Username = user.UserName!,
                Role = roles.FirstOrDefault() ?? Roles.Customer
            };
        }
    }
}