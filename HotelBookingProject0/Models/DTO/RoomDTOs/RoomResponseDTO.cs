namespace HotelBookingProject0.Models.DTO.RoomDTOs
{
    public class RoomResponseDTO
    {
        public int RoomID { get; set; }
        public string RoomNumber { get; set; } = null!;
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string RoomType { get; set; } = null!;
        public int HotelId { get; set; }
        public string HotelName { get; set; } = null!;
        public string City { get; set; } = null!;
        public int StarRating { get; set; }
        public List<string> Images { get; set; } = [];
        public List<string> Amenities { get; set; } = [];
    }
}
