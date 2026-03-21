using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.Entities
{
    [Table("RoomTypes")]
    public class RoomType
    {
        [Key]
        [Column("TypeID")]
        public int TypeID { get; set; }

        [Required, StringLength(50)]
        [Column("TypeName", TypeName = "nvarchar(50)")]
        public string TypeName { get; set; } = null!;

        [Required, Range(0.01, double.MaxValue)]
        [Column("BasePrice", TypeName = "decimal(18,2)")]
        public decimal BasePrice { get; set; }

        public virtual ICollection<Room> Rooms { get; set; } = [];
    }
}
