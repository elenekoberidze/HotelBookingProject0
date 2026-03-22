using System.ComponentModel.DataAnnotations;

namespace HotelBookingProject0.Models.DTO.RoomTypeDTOs
{
    public class RoomTypeDTO
    {
        [Required, StringLength(50)]
        public string TypeName { get; set; } = null!;

        [Required, Range(0.01, double.MaxValue)]
        public decimal BasePrice { get; set; }
    }
}
