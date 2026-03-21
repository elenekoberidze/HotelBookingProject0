using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.Entities
{
    [Table("Amenities")]
    public class Amenity
    {
        [Key]
        [Column("AmenityID")]   
        public int AmenityID { get; set; }

        [Required, StringLength(50)]
        [Column("Name", TypeName = "nvarchar(50)")]
        public string Name { get; set; } = null!;

        public virtual ICollection<Room> Rooms { get; set; } = [];
    }
}
