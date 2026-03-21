using HotelBookingProject0.Models.DTO;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IAmenityService
    {
        /// <summary>
        /// this method gets Amenity by Name
        /// </summary>


        Task<AmenityDTO?> GetAmenityByNameAsync(string name);
    }
}
