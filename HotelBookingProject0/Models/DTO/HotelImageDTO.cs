using System.ComponentModel.DataAnnotations;

namespace HotelBookingProject0.Models.DTO
{
    public class HotelImageDTO
    {
        [Required]
        public int HotelID { get; set; }
        [Required]
        public string ImageURL { get; set; } = null!;
        public bool IsPrimary { get; set; } = false;
    }
}
