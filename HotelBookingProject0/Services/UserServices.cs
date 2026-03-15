using HotelBookingProject0.Constants;
using HotelBookingProject0.Models.DTO.AuthDTOs;
using HotelBookingProject0.Models.Entities;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace HotelBookingProject0.Services
{
    public class UserServices(UserManager<User> userManager) : IUserService
    {
        //<inheritdoc/>
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
    }
}
