namespace HotelBookingProject0.Models.DTO.RoomTypeDTOs
{
    public class RoomTypeResponseDTO
    {
        public int TypeID { get; set; }

        public string TypeName { get; set; } = null!;

        public decimal BasePrice { get; set; }

        public int RoomCount { get; set; }
    }
}
