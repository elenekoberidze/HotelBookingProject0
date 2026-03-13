using HotelBookingProject0.Models.DTO.AuthDTOs;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IAuthService
    {
        Task<AuthResponseDTO> RegisterAsync(RegisterDTO dto);
        Task<AuthResponseDTO> LoginAsync(LoginDTO dto);
        Task<UserDTO> GetUserAsync(string userId);
        Task<UserProfileDTO> GetProfileAsync(string userId);
        Task<UserProfileDTO> UpdateProfileAsync(string userId, UserProfileDTO dto);
    }
}
