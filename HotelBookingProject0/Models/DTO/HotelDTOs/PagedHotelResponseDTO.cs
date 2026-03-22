namespace HotelBookingProject0.Models.DTO.HotelDTOs
{
    public class PagedHotelResponseDTO
    {
        public IEnumerable<HotelDTO> Hotels { get; set; } = [];
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
    }
}
