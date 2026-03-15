using HotelBookingProject0.Models.DTO.AuthDTOs;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IAuthService
    {
        /// <summary>
        /// Registers a new user account asynchronously using the specified registration details.
        /// </summary>
        Task<AuthResponseDTO> RegisterAsync(RegisterDTO dto);
        /// <summary>
        /// Authenticates a user asynchronously using the provided login credentials.
        /// </summary>
        Task<AuthResponseDTO> LoginAsync(LoginDTO dto);
    }
}
