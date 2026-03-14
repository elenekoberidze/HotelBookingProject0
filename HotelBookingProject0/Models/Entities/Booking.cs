using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.Entities
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; }
        public string UserID { get; set; } = null!;
        [ForeignKey("UserID")]
        public virtual User User { get; set; } = null!;

        public int RoomID { get; set; }
        [ForeignKey("RoomID")]
        public virtual Room Room { get; set; } = null!;

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
