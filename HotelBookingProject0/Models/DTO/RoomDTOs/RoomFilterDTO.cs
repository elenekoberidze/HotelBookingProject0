namespace HotelBookingProject0.Models.DTO.RoomDTOs
{
    public class RoomFilterDTO
    {
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public int? MaxGuests { get; set; }
        public string? City { get; set; }
        public int? HotelId { get; set; }
        public int? StarRating { get; set; }
        public string? RoomType { get; set; }
        public string? SortBy { get; set; }
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
    }
}
