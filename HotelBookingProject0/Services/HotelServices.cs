using HotelBookingProject0.Data;
using HotelBookingProject0.Models.DTO;
using HotelBookingProject0.Models.DTO.RoomDTOs;
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
            return await hotelBookingContext.Hotels
                .Include(h => h.Images)
                .Select(h => new HotelDTO
                {
                    Name = h.Name,
                    City = h.City,
                    Address = h.Address,
                    StarRating = (Models.DTO.HotelStarRating)h.StarRating,
                    Status = (Models.DTO.HotelStatus)h.Status,
                    Images = h.Images.Select(i => i.ImageURL).ToList(),
                    AverageReviewScore = h.Reviews.Count != 0 ? h.Reviews.Average(r => r.Rating) : 0
                }).ToListAsync();
        }
        //<inheritdoc/>
        public async Task<IEnumerable<string>> GetCitiesAsync()
        {
            return await hotelBookingContext.Hotels
                .Select(h => h.City)
                .Distinct()
                .OrderBy(c => c)
                .ToListAsync();
        }

        //<inheritdoc/>
        public async Task<IEnumerable<HotelDTO>> GetHotelsByCityAsync(string city)
        {
            return await hotelBookingContext.Hotels
                .Include(h => h.Images)
                .Where(h => h.City.ToLower() == city.ToLower()
                    && h.Status == Models.Entities.HotelStatus.Active)
                .Select(h => new HotelDTO
                {
                    Name = h.Name,
                    City = h.City,
                    Address = h.Address,
                    StarRating = (Models.DTO.HotelStarRating)h.StarRating,
                    Status = (Models.DTO.HotelStatus)h.Status
                })
                .ToListAsync();
        }

        //<inheritdoc/>
        public async Task<HotelDTO?> GetHotelByIdAsync(int id)
        {
            var hotel = await hotelBookingContext.Hotels
                       .Include(h => h.Rooms)
                           .ThenInclude(r => r.Images)
                       .Include(h => h.Images)
                       .Include(h => h.Reviews)
                       .FirstOrDefaultAsync(h => h.HotelID == id);

            if (hotel is null) { return null; }
            return new HotelDTO
            {
                Name = hotel.Name,
                City = hotel.City,
                Address = hotel.Address,
                StarRating = (Models.DTO.HotelStarRating)hotel.StarRating,
                Status = (Models.DTO.HotelStatus)hotel.Status,
                Rooms = hotel.Rooms.Select(r => new Models.DTO.RoomDTOs.RoomDTO
                {
                    RoomID = r.RoomID,
                    HotelID = r.HotelID,
                    TypeID = r.TypeID,
                    RoomNumber = r.RoomNumber,
                    IsAvailable = r.IsAvailable,
                    Images = r.Images.Select(i => i.ImageURL).ToList()
                }).ToList(),
                Images = hotel.Images.Select(i => i.ImageURL).ToList(),
                AverageReviewScore = hotel.Reviews.Count != 0 ? hotel.Reviews.Average(r => r.Rating) : 0
            };
        }
    }
}
