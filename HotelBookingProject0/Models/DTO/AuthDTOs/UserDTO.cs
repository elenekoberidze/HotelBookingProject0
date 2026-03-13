namespace HotelBookingProject0.Models.DTO.AuthDTOs
{
    public class UserDTO
    {
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Role { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
