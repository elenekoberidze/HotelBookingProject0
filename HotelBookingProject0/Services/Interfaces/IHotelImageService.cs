using HotelBookingProject0.Models.DTO;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IHotelImageService
    {
        /// <summary>
        /// this method retrieves all images associated with a specific hotel, identified by its unique hotel ID.
        /// </summary>
        Task<IEnumerable<HotelImageDTO>> GetImagesByHotelIdAsync(int hotelId);
        /// <summary>
        /// this method allows you to add a new image for a hotel.
        /// </summary>
        Task<HotelImageDTO> AddHotelImageAsync(HotelImageDTO dto);
        /// <summary>
        /// this method allows you to delete an existing hotel image by its unique image ID.
        /// </summary>
        Task DeleteHotelImageAsync(int imageId);
        /// <summary>
        /// this method allows you to set a specific image as the primary image for a hotel.
        /// The primary image is typically the main image that represents the hotel in listings and details pages.
        /// </summary>
        Task SetPrimaryImageAsync(int imageId);
    }
}
