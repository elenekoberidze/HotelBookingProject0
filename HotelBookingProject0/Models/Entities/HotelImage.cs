using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.Entities
{
    [Table("HotelImages")]  
    public class HotelImage
    {
        [Key]
        [Column("ImageID")]
        public int ImageID { get; set; }
        [Column("HotelID")]
        public int HotelID { get; set; }
        [ForeignKey("HotelID")]
        public virtual Hotel Hotel { get; set; } = null!;

        [Required]
        [Column("ImageURL")]
        public string ImageURL { get; set; } = null!;
        [Column("IsPrimary")]
        public bool IsPrimary { get; set; } = false;
    }
}
