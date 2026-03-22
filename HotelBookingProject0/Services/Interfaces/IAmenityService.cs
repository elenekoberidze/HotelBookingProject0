using HotelBookingProject0.Models.DTO;
using HotelBookingProject0.Models.DTO.AmenityDTOs;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IAmenityService
    {
       /// <summary>
       /// This method gets all amenities.
       /// </summary>
        Task<IEnumerable<AmenityResponseDTO>> GetAllAmenitiesAsync();
       /// <summary>
       /// This Methods gets amenity by their id.
       /// </summary>
       /// <param name="id"></param>
        Task<AmenityResponseDTO?> GetAmenityByIdAsync(int id);
        /// <summary>
        /// This Methods adds amenity created by admin.
        /// </summary>
        Task<AmenityResponseDTO> CreateAmenityAsync(AmenityDTO dto);
        /// <summary>
        ///  This Methods updates amenity created by admin.
        /// </summary>
        Task<AmenityResponseDTO> UpdateAmenityAsync(int id, AmenityDTO dto);
        /// <summary>
        ///  This Methods deletes amenity created by admin.
        /// </summary>
        Task DeleteAmenityAsync(int id);
    }
}
