using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.Entities
{
    public enum HotelStatus
    {
        Active,        
        UnderRenovation,
        Inactive,      
        OnBoarding      
    }
    public enum HotelStarRating
    {
        Unrated = 0,
        OneStar = 1,
        TwoStars = 2,
        ThreeStars = 3,
        FourStars = 4,
        FiveStars = 5
    }
   
    [Table("hotels")]
    public class Hotel
    {
        [Key]
        public int HotelID { get; set; }

        [Required(ErrorMessage = "Hotel name is mandatory")]
        [StringLength(100, MinimumLength = 3)]
        [Column("name")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(500)]
        [Column("description")]
        public string? Description { get; set; }

        [Required]
        [StringLength(50)]
        [Column("city")]
        public string City { get; set; } = null!;

        [Required]
        [StringLength(255)]
        [Column("address")]
        public string Address { get; set; } = null!;

        [Required]
        [Column("rating")]
        public HotelStarRating StarRating { get; set; } = HotelStarRating.ThreeStars;

        [Required]
        [Column("status")]
        public HotelStatus Status { get; set; } = HotelStatus.Active;

        public virtual ICollection<Room> Rooms { get; set; } = [];
        public virtual ICollection<HotelImage> Images { get; set; } = [];    
        public virtual ICollection<Review> Reviews { get; set; } = [];
        public virtual ICollection<Amenity> Amenities { get; set; } = [];

        [NotMapped]
        public double AverageReviewScore => Reviews.Count != 0 ? Reviews.Average(r => r.Rating) : 0;
    }
}

