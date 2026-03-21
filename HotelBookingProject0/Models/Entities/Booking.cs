using HotelBookingProject0.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.Entities
{
    [Table("Bookings")]
    public class Booking
    {
        [Key]
        [Column("BookingID")]
        public int BookingID { get; set; }
        [Required]
        [Column("UserID")]
        public string UserID { get; set; } = null!;
        [ForeignKey("UserID")]
        public virtual User User { get; set; } = null!;
        [Column("RoomID")]
        public int RoomID { get; set; }
        [ForeignKey("RoomID")]
        public virtual Room Room { get; set; } = null!;

        [Required]
        [Column("CheckInDate")]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [Required]
        [Column("CheckOutDate")]
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }
        [Column("TotalPrice")]
        [DataType(DataType.Currency)]
        public decimal TotalPrice { get; set; }
        [Column("CreatedAt")]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("Status")]
        [StringLength(20)]
        public string Status { get; set; } = BookingStatuses.Pending;
    }
}
