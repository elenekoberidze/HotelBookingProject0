using System.ComponentModel.DataAnnotations;

namespace HotelBookingProject0.Models.DTO.BookingDTOs
{
    public class UpdateBookingStatusDTO
    {
        [Required]
        [RegularExpression("Pending|Confirmed|CheckedIn|CheckedOut|Cancelled",
        ErrorMessage = "Invalid status value.")]
        public string Status { get; set; } = null!;
    }
}
