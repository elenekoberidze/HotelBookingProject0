using HotelBookingProject0.Data;
using HotelBookingProject0.Models.DTO.RoomDTOs;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingProject0.Services
{
    public class RoomService(HotelBookingContext context) : IRoomService
    {
        private readonly HotelBookingContext context = context;
        //<inheritdoc/>
        public async Task<PagedRoomResponseDTO> GetFilteredRoomsAsync(RoomFilterDTO filter)
        {
            var query = context.Rooms
                .Include(r => r.RoomType)
                .Include(r => r.Hotel)
                .Include(r => r.Images)
                .Include(r => r.Amenities)
                .Include(r => r.Bookings)
                .AsQueryable();

            if (filter.MinPrice.HasValue)
            {
                query = query.Where(r => r.Price >= filter.MinPrice.Value);
            }

            if (filter.MaxPrice.HasValue)
            {
                query = query.Where(r => r.Price <= filter.MaxPrice.Value);
            }

            if (!string.IsNullOrEmpty(filter.City))
            {
                query = query.Where(r => r.Hotel.City.Contains(filter.City));
            }

            if (filter.HotelId.HasValue)
            {
                query = query.Where(r => r.HotelID == filter.HotelId.Value);
            }

            if (filter.StarRating.HasValue)
            {
                query = query.Where(r => (int)r.Hotel.StarRating == filter.StarRating.Value);
            }

            if (!string.IsNullOrEmpty(filter.RoomType))
            {
                query = query.Where(r => r.RoomType.TypeName == filter.RoomType);
            }

            if (filter.CheckIn.HasValue && filter.CheckOut.HasValue)
            {
                query = query.Where(r => !r.Bookings.Any(b =>
                    b.Status != "Cancelled" &&
                    b.CheckInDate < filter.CheckOut.Value &&
                    b.CheckOutDate > filter.CheckIn.Value));
            }

            query = filter.SortBy switch
            {
                "price_asc" => query.OrderBy(r => r.Price),
                "price_desc" => query.OrderByDescending(r => r.Price),
                "rating_desc" => query.OrderByDescending(r => r.Hotel.StarRating),
                _ => query.OrderBy(r => r.RoomID)
            };

            var totalCount = await query.CountAsync();

            var rooms = await query
                .Skip((filter.Page - 1) * filter.PageSize)
                .Take(filter.PageSize)
                .Select(r => new RoomResponseDTO
                {
                    RoomID = r.RoomID,
                    RoomNumber = r.RoomNumber,
                    Price = r.Price,
                    IsAvailable = r.IsAvailable,
                    RoomType = r.RoomType.TypeName,
                    HotelId = r.HotelID,
                    HotelName = r.Hotel.Name,
                    City = r.Hotel.City,
                    StarRating = (int)r.Hotel.StarRating,
                    Images = r.Images.Select(i => i.ImageURL).ToList(),
                    Amenities = r.Amenities.Select(a => a.Name).ToList()
                })
                .ToListAsync();

            return new PagedRoomResponseDTO
            {
                Rooms = rooms,
                TotalCount = totalCount,
                Page = filter.Page,
                PageSize = filter.PageSize,
                TotalPages = (int)Math.Ceiling(totalCount / (double)filter.PageSize)
            };
        }
        //<inheritdoc/>
        public async Task<RoomResponseDTO?> GetRoomByIdAsync(int id)
        {
            return await context.Rooms
                .Include(r => r.RoomType)
                .Include(r => r.Hotel)
                .Include(r => r.Images)
                .Include(r => r.Amenities)
                .Where(r => r.RoomID == id)
                .Select(r => new RoomResponseDTO
                {
                    RoomID = r.RoomID,
                    RoomNumber = r.RoomNumber,
                    Price = r.Price,
                    IsAvailable = r.IsAvailable,
                    RoomType = r.RoomType.TypeName,
                    HotelId = r.HotelID,
                    HotelName = r.Hotel.Name,
                    City = r.Hotel.City,
                    StarRating = (int)r.Hotel.StarRating,
                    Images = r.Images.Select(i => i.ImageURL).ToList(),
                    Amenities = r.Amenities.Select(a => a.Name).ToList()
                })
                .FirstOrDefaultAsync();
        }
        //<inheritdoc/>
        public async Task<IEnumerable<string>> GetRoomTypesAsync()
        {
            return await context.RoomTypes
                .Select(rt => rt.TypeName)
                .Distinct()
                .ToListAsync();
        }
    }
}

