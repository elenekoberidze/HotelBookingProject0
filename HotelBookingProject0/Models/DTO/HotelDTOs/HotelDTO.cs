using HotelBookingProject0.Models.DTO.RoomDTOs;
using HotelBookingProject0.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingProject0.Models.DTO.HotelDTOs
{
    public enum HotelStarRating
    {
        OneStar = 1,
        TwoStars = 2,
        ThreeStars = 3,
        FourStars = 4,
        FiveStars = 5
    }

    public enum HotelStatus
    {
        Active = 1,
        Inactive = 0
    }

    public class HotelDTO
    {
        public int HotelID { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = null!;

        [Required, StringLength(100)]
        public string City { get; set; } = null!;

        [Required, StringLength(200)]
        public string Address { get; set; } = null!;

        public string? Description { get; set; }

        public HotelStarRating StarRating { get; set; }

        public HotelStatus Status { get; set; }

        public List<RoomDTO> Rooms { get; set; } = [];

        public List<string> Images { get; set; } = [];
        public string? PrimaryImage { get; set; }
        public double AverageReviewScore { get; set; }
    }
}

