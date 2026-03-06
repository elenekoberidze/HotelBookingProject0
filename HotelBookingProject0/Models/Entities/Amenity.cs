using System.ComponentModel.DataAnnotations;

namespace HotelBookingProject0.Models.Entities
{
    public class Amenity
    {
        [Key]
        public int AmenityID { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; } 

        public string Icon { get; set; } 

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
