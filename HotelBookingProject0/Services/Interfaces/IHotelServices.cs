using HotelBookingProject0.Models.DTO;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IHotelServices
    {
        /// <summary>
        /// This method returns a list of all hotels in the system. 
        /// It retrieves hotel data from the database and maps it to a collection of HotelDTO objects,
        /// which are then returned to the caller.
        /// </summary>
        Task<IEnumerable<HotelDTO>> GetAllHotelsAsync();
        /// <summary>
        /// This method retrieves a specific hotel by its unique identifier (ID).
        /// </summary>
        Task<HotelDTO?> GetHotelByIdAsync(int id);
        /// <summary>
        /// Asynchronously retrieves hotel information for the specified city.
        /// </summary>
        Task<HotelDTO?> GetHotelByCityAsync(string city);

    }
}
