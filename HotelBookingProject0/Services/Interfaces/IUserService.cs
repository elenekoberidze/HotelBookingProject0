using HotelBookingProject0.Models.DTO.AuthDTOs;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// Asynchronously retrieves a user by their unique identifier.
        /// </summary>
        Task<UserDTO> GetUserAsync(string Id);
    }
}
