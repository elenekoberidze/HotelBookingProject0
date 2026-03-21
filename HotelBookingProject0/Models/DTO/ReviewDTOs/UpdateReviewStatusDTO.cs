using System.ComponentModel.DataAnnotations;

namespace HotelBookingProject0.Models.DTO.ReviewDTOs
{
    public class UpdateReviewStatusDTO
    {
        [Required]
        [RegularExpression("Approved|Rejected", ErrorMessage = "Status must be Approved or Rejected")]
        public string Status { get; set; } = null!;
        [StringLength(500)]
        public string? AdminNote { get; set; }
    }
}
