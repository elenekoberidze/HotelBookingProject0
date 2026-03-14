using System.ComponentModel.DataAnnotations;

namespace HotelBookingProject0.Models.DTO
{
    public class ReviewDTO
    {
        [Required]
        public int HotelID { get; set; }
        [Range(1, 5)]
        public int Rating { get; set; }
        public string Comment { get; set; } = null!;
    }
}
