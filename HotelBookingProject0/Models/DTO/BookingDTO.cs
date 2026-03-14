using System.ComponentModel.DataAnnotations;

namespace HotelBookingProject0.Models.DTO
{
    public class BookingDTO
    {
        [Required]
        public int RoomID { get; set; }

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }
    }
}
