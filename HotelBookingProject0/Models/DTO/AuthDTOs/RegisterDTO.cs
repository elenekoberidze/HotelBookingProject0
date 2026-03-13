using System.ComponentModel.DataAnnotations;

namespace HotelBookingProject0.Models.DTO.AuthDTOs
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Firstname is required")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Lastname is required")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, MinimumLength = 2)]
        public string Username { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(100, MinimumLength = 6)]
        public string Password { get; set; } = null!;
    }
}
