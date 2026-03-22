using HotelBookingProject0.Models.DTO.RoomTypeDTOs;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IRoomTypeService
    {
       
            /// <summary>
            /// Retrieves all room types with their base prices.
            /// </summary>
            Task<IEnumerable<RoomTypeResponseDTO>> GetAllRoomTypesAsync();

            /// <summary>
            /// Retrieves a single room type by ID.
            /// </summary>
            Task<RoomTypeResponseDTO?> GetRoomTypeByIdAsync(int id);

            /// <summary>
            /// Creates a new room type.
            /// </summary>
            Task<RoomTypeResponseDTO> CreateRoomTypeAsync(RoomTypeDTO dto);

            /// <summary>
            /// Updates an existing room type's name and base price.
            /// </summary>
            Task<RoomTypeResponseDTO> UpdateRoomTypeAsync(int id, RoomTypeDTO dto);

            /// <summary>
            /// Deletes a room type (fails if any rooms reference it).
            /// </summary>
            Task DeleteRoomTypeAsync(int id);
        }
}

