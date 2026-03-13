using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.Entities
{
    public class Room
    {
        [Key]
        public int RoomID { get; set; }
        public int HotelID { get; set; }
        [ForeignKey("HotelID")]
        public virtual Hotel Hotel { get; set; } = null!;

        public int TypeID { get; set; }
        [ForeignKey("TypeID")]
        public virtual RoomType RoomType { get; set; } = null!;

        [Required, StringLength(10)]
        public string RoomNumber { get; set; } = null!;

        public bool IsAvailable { get; set; } = true;

        public virtual ICollection<Booking> Bookings { get; set; } = [];
        public virtual ICollection<RoomImage> Images { get; set; } = [];

        public virtual ICollection<Amenity> Amenities { get; set; } = [];
    }
}

