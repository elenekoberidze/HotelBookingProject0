using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.Entities
{
    [Table("RefreshTokens")]
    public class RefreshToken
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }

        [Required]
        [Column("Token", TypeName = "nvarchar(500)")]
        public string Token { get; set; } = null!;
        [Column("Expires")]
        [DataType(DataType.Date)]
        public DateTime Expires { get; set; }
        [Column("Created")]
        [DataType(DataType.Date)]
        public DateTime Created { get; set; }
        [Column("Revoked")]
        [DataType(DataType.Date)]   
        public DateTime? Revoked { get; set; }
        [Column("ReplacedByToken", TypeName = "nvarchar(500)")]
        public string? ReplacedByToken { get; set; }

        [Required]
        [Column("UserId", TypeName = "nvarchar(450)")]
        public string UserId { get; set; } = null!;

        public virtual User? User { get; set; }

        [NotMapped]
        public bool IsExpired => DateTime.UtcNow >= Expires;

        [NotMapped]
        public bool IsActive => Revoked == null && !IsExpired;
    }
}
