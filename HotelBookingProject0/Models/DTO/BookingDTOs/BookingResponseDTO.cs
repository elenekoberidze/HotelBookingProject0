namespace HotelBookingProject0.Models.DTO.BookingDTOs
{
    public class BookingResponseDTO
    {
        public int BookingID { get; set; }
        public string UserID { get; set; } = null!;
        public string Username { get; set; } = null!;
        public int RoomID { get; set; }
        public string RoomNumber { get; set; } = null!;
        public string HotelName { get; set; } = null!;
        public string HotelCity { get; set; } = null!;
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int Nights { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
