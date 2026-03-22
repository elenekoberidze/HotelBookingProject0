using HotelBookingProject0.Models.DTO.RoomDTOs;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IRoomService
    {
        /// <summary>
        /// This method retrieves a paginated list of rooms based on the provided filter criteria.
        /// </summary>
        Task<PagedRoomResponseDTO> GetFilteredRoomsAsync(RoomFilterDTO filter);
        /// <summary>
        /// This method retrieves detailed information about a specific room based on its unique identifier (ID).
        /// </summary>
        Task<RoomResponseDTO?> GetRoomByIdAsync(int id);
        /// <summary>
        /// This method retrieves a list of all available room types in the system.
        /// </summary>
        Task<IEnumerable<string>> GetRoomTypesAsync();
    }
}
