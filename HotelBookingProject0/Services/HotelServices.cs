using HotelBookingProject0.Data;
using HotelBookingProject0.Models.DTO.HotelDTOs;
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
        public async Task<PagedHotelResponseDTO> GetAllHotelsAsync(int page = 1, int pageSize = 10)
        {
            var query = hotelBookingContext.Hotels
                .Include(h => h.Images)
                .Include(h => h.Reviews)
                .AsQueryable();

            var totalCount = await query.CountAsync();

            var hotels = await query
                .OrderBy(h => h.HotelID)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(h => new HotelDTO
                {
                    HotelID = h.HotelID,
                    Name = h.Name,
                    City = h.City,
                    Address = h.Address,
                    Description = h.Description,
                    StarRating = (Models.DTO.HotelDTOs.HotelStarRating)h.StarRating,
                    Status = (Models.DTO.HotelDTOs.HotelStatus)h.Status,
                    Images = h.Images.Select(i => i.ImageURL).ToList(),
                    PrimaryImage = h.Images.Where(i => i.IsPrimary).Select(i => i.ImageURL).FirstOrDefault()
                        ?? h.Images.Select(i => i.ImageURL).FirstOrDefault(),
                    AverageReviewScore = h.Reviews.Count != 0
                        ? Math.Round(h.Reviews.Average(r => r.Rating), 1)
                        : 0
                })
                .ToListAsync();

            return new PagedHotelResponseDTO
            {
                Hotels = hotels,
                TotalCount = totalCount,
                Page = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize)
            };
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
                .Include(h => h.Reviews)
                .Where(h => h.City.Equals(city, StringComparison.CurrentCultureIgnoreCase)
                    && h.Status == Models.Entities.HotelStatus.Active)
                .Select(h => new HotelDTO
                {
                    HotelID = h.HotelID,
                    Name = h.Name,
                    City = h.City,
                    Address = h.Address,
                    Description = h.Description,
                    StarRating = (Models.DTO.HotelDTOs.HotelStarRating)h.StarRating,
                    Status = (Models.DTO.HotelDTOs.HotelStatus)h.Status,
                    Images = h.Images.Select(i => i.ImageURL).ToList(),
                    PrimaryImage = h.Images.Where(i => i.IsPrimary).Select(i => i.ImageURL).FirstOrDefault()
                        ?? h.Images.Select(i => i.ImageURL).FirstOrDefault(),
                    AverageReviewScore = h.Reviews.Count != 0
                        ? Math.Round(h.Reviews.Average(r => r.Rating), 1)
                        : 0
                })
                .ToListAsync();
        }

        //<inheritdoc/>
        public async Task<HotelDTO?> GetHotelByIdAsync(int id)
        {
            var hotel = await hotelBookingContext.Hotels
                .Include(h => h.Rooms)
                    .ThenInclude(r => r.Images)
                .Include(h => h.Rooms)
                    .ThenInclude(r => r.RoomType)
                .Include(h => h.Images)
                .Include(h => h.Reviews)
                .FirstOrDefaultAsync(h => h.HotelID == id);

            if (hotel is null) { return null; }

            return new HotelDTO
            {
                HotelID = hotel.HotelID,
                Name = hotel.Name,
                City = hotel.City,
                Address = hotel.Address,
                Description = hotel.Description,
                StarRating = (Models.DTO.HotelDTOs.HotelStarRating)hotel.StarRating,
                Status = (Models.DTO.HotelDTOs.HotelStatus)hotel.Status,
                Rooms = hotel.Rooms.Select(r => new RoomDTO
                {
                    RoomID = r.RoomID,
                    HotelID = r.HotelID,
                    TypeID = r.TypeID,
                    RoomNumber = r.RoomNumber,
                    IsAvailable = r.IsAvailable,
                    Images = r.Images.Select(i => i.ImageURL).ToList()
                }).ToList(),
                Images = hotel.Images.Select(i => i.ImageURL).ToList(),
                PrimaryImage = hotel.Images.Where(i => i.IsPrimary).Select(i => i.ImageURL).FirstOrDefault()
                    ?? hotel.Images.Select(i => i.ImageURL).FirstOrDefault(),
                AverageReviewScore = hotel.Reviews.Count != 0
                    ? Math.Round(hotel.Reviews.Average(r => r.Rating), 1)
                    : 0
            };
        }
    }
}
