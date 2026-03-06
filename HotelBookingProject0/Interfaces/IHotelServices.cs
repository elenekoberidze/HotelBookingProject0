using HotelBookingProject0.Models.DTO;

namespace HotelBookingProject0.Interfaces
{
    public interface IHotelServices
    {
        Task<IEnumerable<HotelDTO>> GetAllHotelsAsync();
        Task<HotelDTO?> GetHotelByIdAsync(int id);
        Task<HotelDTO> CreateHotelAsync(HotelDTO hotelDTO);
    }
}
