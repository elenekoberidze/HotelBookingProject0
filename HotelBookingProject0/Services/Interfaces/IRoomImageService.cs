using HotelBookingProject0.Models.DTO;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IRoomImageService
    {
        /// <summary>
        /// This method retrieves a list of RoomImageDTO objects associated with a specific room ID.
        /// </summary>
        Task<IEnumerable<RoomImageDTO>> GetImagesByRoomIdAsync(int roomId);
        /// <summary>
        /// This method adds a new RoomImageDTO to the system. It takes a RoomImageDTO object as input,
        /// </summary>
        Task<RoomImageDTO> AddRoomImageAsync(RoomImageDTO dto);
        /// <summary>
        /// This method deletes a room image based on its unique identifier (imageId).
        /// It allows you to remove an image from the system,
        /// </summary>
        Task DeleteRoomImageAsync(int imageId);
    }
}
