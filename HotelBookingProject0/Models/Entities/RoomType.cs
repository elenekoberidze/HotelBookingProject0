using System.ComponentModel.DataAnnotations;

namespace HotelBookingProject0.Models.Entities
{
    public class RoomType
    {
        [Key]
        public int TypeID { get; set; }

        [Required, StringLength(50)]
        public string TypeName { get; set; }

        [Required, Range(0.01, double.MaxValue)]
        public decimal BasePrice { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
