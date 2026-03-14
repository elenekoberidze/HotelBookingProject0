using HotelBookingProject0.Models.Entities;
using System.ComponentModel.DataAnnotations;

namespace HotelBookingProject0.Models.DTO
{
    public class AmenityDTO
    {
        [Required, StringLength(50)]
        public string Name { get; set; } = null!;
    }
}
