using HotelBookingProject0.Models.DTO.AmenityDTOs;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IAmenityService
    {
        /// <summary>
        /// this method gets all amenities
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<AmenityResponseDTO>> GetAllAmenitiesAsync();
        /// <summary>
        /// this method gets amenitys by id
        /// </summary>
        
        Task<AmenityResponseDTO?> GetAmenityByIdAsync(int id);
        /// <summary>
        /// this method creates a new amenity
        /// </summary>

        Task<AmenityResponseDTO> CreateAmenityAsync(AmenityDTO dto);
        /// <summary>
        /// this method updates amenity
        /// </summary>

        Task<AmenityResponseDTO> UpdateAmenityAsync(int id, AmenityDTO dto);
        /// <summary>
        /// this method deletes amenity
        /// </summary>

        Task DeleteAmenityAsync(int id);
    }
}
