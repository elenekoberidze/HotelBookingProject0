using HotelBookingProject0.Models.DTO.AuthDTOs;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IUserProfileService
    {
        /// <summary>
        /// Asynchronously retrieves the user profile associated with the specified user identifier.
        /// </summary>
        Task<UserProfileDTO> GetProfileAsync(string userId);
        /// <summary>
        /// Updates the user profile for the specified user asynchronously.
        /// </summary>
        Task<UserProfileDTO> UpdateProfileAsync(string userId, UserProfileDTO dto);
    }
}
