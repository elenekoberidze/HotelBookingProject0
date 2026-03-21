using HotelBookingProject0.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.Entities
{
    [Table("Reviews")]
    public class Review
    {
        [Key]
        [Column("ReviewID")]
        public int ReviewID { get; set; }
        [Column("UserID", TypeName = "nvarchar(450)")]
        public string UserID { get; set; } = null!;
        [ForeignKey("UserID")]
        public virtual User User { get; set; } = null!;
        [Column("HotelID")]
        public int HotelID { get; set; }
        [ForeignKey("HotelID")]
        public virtual Hotel Hotel { get; set; } = null!;

        [Range(1, 5)]
        [Column("Rating")]
        public int Rating { get; set; }
        [Column("Comment", TypeName = "nvarchar(max)")]
        public string Comment { get; set; } = null!;
        [Column("Status", TypeName = "nvarchar(20)")]
        public string Status { get; set; } = ReviewStatuses.Pending;

        [StringLength(500)]
        [Column("AdminNote", TypeName = "nvarchar(500)")]
        public string? AdminNote { get; set; }
        [Column("ReviewDate")]
        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; } = DateTime.UtcNow;
    }
}
