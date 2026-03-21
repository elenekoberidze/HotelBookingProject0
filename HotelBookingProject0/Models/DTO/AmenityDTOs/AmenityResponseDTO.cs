namespace HotelBookingProject0.Models.DTO.AmenityDTOs
{
    public class AmenityResponseDTO
    {
        public int AmenityID { get; set; }
        public string Name { get; set; } = null!;
        public List<string> Rooms { get; set; } = [];
    }
}
