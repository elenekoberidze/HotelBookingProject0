using System.ComponentModel.DataAnnotations;

namespace HotelBookingProject0.Models.DTO.RoomDTOs
{
    public class RoomDTO
    {
        public int RoomID { get; set; }
        [Required]
        public int HotelID { get; set; }
        [Required]
        public int TypeID { get; set; }
        [Required, StringLength(10)]
        public string RoomNumber { get; set; } = null!;
        public bool IsAvailable { get; set; } = true;
        public List<string> Images { get; set; } = [];
    }
}
