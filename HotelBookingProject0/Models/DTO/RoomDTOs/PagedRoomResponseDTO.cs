namespace HotelBookingProject0.Models.DTO.RoomDTOs
{
    public class PagedRoomResponseDTO
    {
        public IEnumerable<RoomResponseDTO> Rooms { get; set; } = [];
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
    }
}
