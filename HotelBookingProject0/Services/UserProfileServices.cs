using HotelBookingProject0.Data;
using HotelBookingProject0.Models.DTO.AuthDTOs;
using HotelBookingProject0.Models.Entities;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingProject0.Services
{
    public class UserProfileServices(HotelBookingContext db) : IUserProfileService
    {
        //<inheritdoc/>
        public async Task<UserProfileDTO> GetProfileAsync(string userId)
        {
            var profile = await db.UserProfiles.FirstOrDefaultAsync(p => p.UserId == userId)
                ?? throw new KeyNotFoundException("Profile not found");

            return MapToDto(profile);
        }
        //<inheritdoc/>
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
            return MapToDto(profile);
        }

        private static UserProfileDTO MapToDto(UserProfile p) => new()
        {
            Address = p.Address,
            City = p.City,
            DateOfBirth = p.DateOfBirth,
            AvatarUrl = p.AvatarUrl,
            Bio = p.Bio
        };
    }
}
