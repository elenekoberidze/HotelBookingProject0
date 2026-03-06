using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.Entities
{
    public class HotelImage
    {
        [Key]
        public int ImageID { get; set; }

        public int HotelID { get; set; }
        [ForeignKey("HotelID")]
        public virtual Hotel Hotel { get; set; }

        [Required]
        public string ImageURL { get; set; }

        public bool IsPrimary { get; set; } = false;
    }
}
