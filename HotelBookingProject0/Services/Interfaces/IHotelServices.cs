using HotelBookingProject0.Models.DTO.HotelDTOs;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IHotelServices
    {
        /// <summary>
        /// Returns a paginated list of all hotels. Use page=1 and pageSize=10 by default.
        /// </summary>
        Task<PagedHotelResponseDTO> GetAllHotelsAsync(int page = 1, int pageSize = 10);

        /// <summary>
        /// Returns a specific hotel by its ID including rooms and reviews.
        /// </summary>
        Task<HotelDTO?> GetHotelByIdAsync(int id);

        /// <summary>
        /// Returns all active hotels in a given city.
        /// </summary>
        Task<IEnumerable<HotelDTO>> GetHotelsByCityAsync(string city);

        /// <summary>
        /// Returns a distinct list of all cities that have at least one hotel.
        /// </summary>
        Task<IEnumerable<string>> GetCitiesAsync();

    }
}
