using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.DTO.AuthDTOs
{
    public class UserProfileDTO
    {
        [StringLength(200)]
        public string? Address { get; set; }

        [StringLength(100)]
        public string? City { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }

        [Url(ErrorMessage = "Enter right URL")]
        [StringLength(500)]
        public string? AvatarUrl { get; set; }
        [StringLength(1000)]
        public string? Bio { get; set; }
    }
}
