namespace HotelBookingProject0.Models.DTO.AuthDTOs
{
    public class AuthResponseDTO
    {
        public string? Token { get; set; } 
        public string Email { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Role { get; set; } = null!;
    }
}
