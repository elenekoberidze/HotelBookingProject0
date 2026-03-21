using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.Entities
{
    [Table("RoomImages")]
    public class RoomImage
    {
        [Key]
        [Column("ImageID")]
        public int ImageID { get; set; }

        [Required]
        [Column("RoomID")]
        public int RoomID { get; set; }

        [ForeignKey("RoomID")]
        public virtual Room Room { get; set; } = null!;

        [Required]
        [Column("ImageURL")]
        public string ImageURL { get; set; } = null!;
    }
}
