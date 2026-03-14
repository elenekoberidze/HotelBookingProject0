using HotelBookingProject0.Data;
using HotelBookingProject0.Models.DTO;
using HotelBookingProject0.Models.Entities;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingProject0.Services
{
    public class HotelServices(HotelBookingContext hotelBookingContext) : IHotelServices
    {
        private readonly HotelBookingContext hotelBookingContext = hotelBookingContext;
       
        //<inheritdoc/>
        public async Task<IEnumerable<HotelDTO>> GetAllHotelsAsync()
        {
            return await hotelBookingContext.Hotels.Select(h => new HotelDTO
            {
                Name = h.Name,
                City = h.City,
                Address = h.Address,
                StarRating = (Models.DTO.HotelStarRating)h.StarRating,
                Status = (Models.DTO.HotelStatus)h.Status
            }).ToListAsync();
        }

        //<inheritdoc/>
        public async Task<HotelDTO?> GetHotelByCityAsync(string city)
        {
            var hotel = await hotelBookingContext.Hotels
                       .FirstOrDefaultAsync(h => h.City == city);

            if (hotel is null) { return null; }
            return new HotelDTO
            {
                Name = hotel.Name,
                City = hotel.City,
                Address = hotel.Address,
                StarRating = (Models.DTO.HotelStarRating)hotel.StarRating,
                Status = (Models.DTO.HotelStatus)hotel.Status
            };
        }

        //<inheritdoc/>
        public async Task<HotelDTO?> GetHotelByIdAsync(int id)
        {
            var hotel = await hotelBookingContext.Hotels
                       .FirstOrDefaultAsync(h => h.HotelID == id);

            if (hotel is null) { return null; }
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
