using HotelBookingProject0.Data;
using HotelBookingProject0.Models.DTO.AmenityDTOs;
using HotelBookingProject0.Models.Entities;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingProject0.Services
{
    public class AmenityService(HotelBookingContext context) : IAmenityService
    {
        private readonly HotelBookingContext context = context;

        public async Task<IEnumerable<AmenityResponseDTO>> GetAllAmenitiesAsync()
        {
            return await context.Amenities
                .Include(a => a.Rooms)
                .Select(a => new AmenityResponseDTO
                {
                    AmenityID = a.AmenityID,
                    Name = a.Name,
                    Rooms = a.Rooms.Select(r => r.RoomNumber).ToList()
                })
                .ToListAsync();
        }
        public async Task<AmenityResponseDTO?> GetAmenityByIdAsync(int id)
        {
            return await context.Amenities
                .Include(a => a.Rooms)
                .Where(a => a.AmenityID == id)
                .Select(a => new AmenityResponseDTO
                {
                    AmenityID = a.AmenityID,
                    Name = a.Name,
                    Rooms = a.Rooms.Select(r => r.RoomNumber).ToList()
                })
                .FirstOrDefaultAsync();
        }
        public async Task<AmenityResponseDTO> CreateAmenityAsync(AmenityDTO dto)
        {
            var existing = await context.Amenities
                .FirstOrDefaultAsync(a => a.Name == dto.Name);
            if (existing != null)
                throw new InvalidOperationException($"Amenity '{dto.Name}' already exists.");

            var amenity = new Amenity { Name = dto.Name };
            context.Amenities.Add(amenity);
            await context.SaveChangesAsync();

            return new AmenityResponseDTO
            {
                AmenityID = amenity.AmenityID,
                Name = amenity.Name,
                Rooms = []
            };
        }
        public async Task<AmenityResponseDTO> UpdateAmenityAsync(int id, AmenityDTO dto)
        {
            var amenity = await context.Amenities
                .Include(a => a.Rooms)
                .FirstOrDefaultAsync(a => a.AmenityID == id)
                ?? throw new KeyNotFoundException($"Amenity with ID {id} not found.");

            amenity.Name = dto.Name;
            await context.SaveChangesAsync();

            return new AmenityResponseDTO
            {
                AmenityID = amenity.AmenityID,
                Name = amenity.Name,
                Rooms = amenity.Rooms.Select(r => r.RoomNumber).ToList()
            };
        }
        public async Task DeleteAmenityAsync(int id)
        {
            var amenity = await context.Amenities.FindAsync(id)
                ?? throw new KeyNotFoundException($"Amenity with ID {id} not found.");

            context.Amenities.Remove(amenity);
            await context.SaveChangesAsync();
        }
    }
}
