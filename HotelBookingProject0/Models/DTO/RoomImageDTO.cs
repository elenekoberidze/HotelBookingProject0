using System.ComponentModel.DataAnnotations;

namespace HotelBookingProject0.Models.DTO
{
    public class RoomImageDTO
    {
        [Required]
        public int RoomID { get; set; }
        [Required]
        public string ImageURL { get; set; } = null!;
    }
}
