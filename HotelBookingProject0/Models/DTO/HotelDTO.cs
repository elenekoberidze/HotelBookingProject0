using HotelBookingProject0.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.DTO
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
    public class HotelDTO
    {
        [Required(ErrorMessage = "Hotel name is mandatory")]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(500)]
        public string? Description { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; } = null!;

        [Required]
        [StringLength(255)]
        public string Address { get; set; } = null!;

        [Required]
        public HotelStarRating StarRating { get; set; }

        [Required]
        public HotelStatus Status { get; set; }

    }
}

