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
        /// <summary>
        /// Signs out the current user asynchronously after verifying credentials.
        /// </summary>
        Task LogoutAsync(string email, string password);
        /// <summary>
        /// Refreshes JWT using refresh token.
        /// </summary>
        Task<AuthResponseDTO> RefreshTokenAsync(string token);

        /// <summary>
        /// Revokes a refresh token.
        /// </summary>
        Task RevokeRefreshTokenAsync(string token);
    }
}
