using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.Entities
{
    [Table("UserProfiles")]
    public class UserProfile
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [ForeignKey("User")]
        [Column("UserId", TypeName = "nvarchar(450)")]
        public string UserId { get; set; } = string.Empty;

        [StringLength(200)]
        [Column("Address", TypeName = "nvarchar(200)")]
        public string? Address { get; set; }

        [StringLength(100)]
        [Column("City", TypeName = "nvarchar(100)")]
        public string? City { get; set; }

        [DataType(DataType.Date)]
        [Column("DateOfBirth")]
        public DateTime? DateOfBirth { get; set; }

        [StringLength(500)]
        [Column("AvatarUrl", TypeName = "nvarchar(500)")]
        public string? AvatarUrl { get; set; }

        [StringLength(1000)]
        [Column("Bio", TypeName = "nvarchar(1000)")]
        public string? Bio { get; set; }

        [DataType(DataType.Date)]
        [Column("CreatedAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [DataType(DataType.Date)]
        [Column("UpdatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public virtual User User { get; set; } = null!;
    }
}
