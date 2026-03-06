using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.Entities
{
    public class RoomImage
    {
        [Key]
        public int ImageID { get; set; }

        [Required]
        public int RoomID { get; set; }

        [ForeignKey("RoomID")]
        public virtual Room Room { get; set; }

        [Required]
        public string ImageURL { get; set; }
    }
}
