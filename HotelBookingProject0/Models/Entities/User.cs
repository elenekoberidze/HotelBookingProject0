using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace HotelBookingProject0.Models.Entities
{
    [Table("Users")]
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "Firstname is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "name should be 2-50 simbols")]
        [Column("FirstName", TypeName = "nvarchar(50)")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Lastname is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "name should be 2-50 simbols")]
        [Column("LastName", TypeName = "nvarchar(50)")]
        public string LastName { get; set; } = null!;
        [Column("IsActive")]
        public bool IsActive { get; set; } = true;
        [Column("CreatedAt")]
        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        [Column("UpdatedAt")]
        [DataType(DataType.Date)]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public virtual UserProfile? Profile { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; } = [];
        public virtual ICollection<Review> Reviews { get; set; } = [];
    }
}
