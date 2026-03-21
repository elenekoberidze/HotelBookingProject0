namespace HotelBookingProject0.Models.DTO.ReviewDTOs
{
    public class ReviewResponseDTO
    {
        public int ReviewID { get; set; }
        public string UserID { get; set; } = null!;
        public string Username { get; set; } = null!;
        public int HotelID { get; set; }
        public string HotelName { get; set; } = null!;
        public int Rating { get; set; }
        public string Comment { get; set; } = null!;
        public DateTime ReviewDate { get; set; }
        public string Status { get; set; } = null!;
    }
}
