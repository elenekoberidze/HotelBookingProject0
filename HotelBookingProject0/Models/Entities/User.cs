using System.ComponentModel.DataAnnotations;

namespace HotelBookingProject0.Models.Entities
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required, StringLength(50)]
        public string Username { get; set; } = null!;

        [Required, EmailAddress, StringLength(100)]
        public string Email { get; set; } = null!;

        [Required]
        public string PasswordHash { get; set; } = null!;
        public bool IsActive { get; set; } = true;

        public virtual UserProfile Profile { get; set; } = null!;
        public virtual ICollection<Booking> Bookings { get; set; } = null!;
        public virtual ICollection<Review> Reviews { get; set; } = null!;
    }
}
