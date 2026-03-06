using HotelBookingProject0.Data;
using HotelBookingProject0.Interfaces;
using HotelBookingProject0.Models.DTO;
using HotelBookingProject0.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingProject0.Services
{
    public class HotelServices(HotelBookingContext hotelBookingContext) : IHotelServices
    {
        private readonly HotelBookingContext hotelBookingContext = hotelBookingContext;

        public async Task<HotelDTO> CreateHotelAsync([FromForm] HotelDTO hotelDTO)
        {
            Hotel hotel = new()
            {
                Name = hotelDTO.Name,
                City = hotelDTO.City,
                Address = hotelDTO.Address,
                StarRating = (Models.Entities.HotelStarRating)hotelDTO.StarRating,
                Status = (Models.Entities.HotelStatus)hotelDTO.Status,
            };
            hotelBookingContext.Add(hotel);
            await hotelBookingContext.SaveChangesAsync();

            return hotelDTO;
        }

        public async Task<IEnumerable<HotelDTO>> GetAllHotelsAsync()
        {

            return (IEnumerable<HotelDTO>)await hotelBookingContext.Hotels.ToListAsync();
        }


        public async Task<HotelDTO?> GetHotelByIdAsync(int id)
        {
            var hotel = await hotelBookingContext.Hotels
                       .FirstOrDefaultAsync(h => h.HotelID == id);

            if (hotel == null) return null;

            return new HotelDTO
            {
                Name = hotel.Name,
                City = hotel.City,
                Address = hotel.Address,
                StarRating = (Models.DTO.HotelStarRating)hotel.StarRating,
                Status = (Models.DTO.HotelStatus)hotel.Status
            };
        }
    }
}
