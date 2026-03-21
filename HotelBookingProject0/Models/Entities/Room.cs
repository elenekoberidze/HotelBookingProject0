using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.Entities
{
    [Table("Rooms")]
    public class Room
    {
        [Key]
        [Column("RoomID")]
        public int RoomID { get; set; }
        [Column("HotelID")]
        public int HotelID { get; set; }
        [ForeignKey("HotelID")]
        public virtual Hotel Hotel { get; set; } = null!;
        [Column("TypeID")]
        public int TypeID { get; set; }
        [ForeignKey("TypeID")]
        public virtual RoomType RoomType { get; set; } = null!;

        [Required, StringLength(10)]
        [Column("RoomNumber", TypeName = "nvarchar(10)")]
        public string RoomNumber { get; set; } = null!;
        [Column("Price", TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Column("IsAvailable")]
        public bool IsAvailable { get; set; } = true;

        public virtual ICollection<Booking> Bookings { get; set; } = [];
        public virtual ICollection<RoomImage> Images { get; set; } = [];

        public virtual ICollection<Amenity> Amenities { get; set; } = [];
    }
}

