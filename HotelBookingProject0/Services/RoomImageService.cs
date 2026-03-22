using HotelBookingProject0.Data;
using HotelBookingProject0.Models.DTO;
using HotelBookingProject0.Models.Entities;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingProject0.Services
{
    public class RoomImageService(HotelBookingContext context) : IRoomImageService
    {
        private readonly HotelBookingContext context = context;

        //<inheritdoc/>
        public async Task<IEnumerable<RoomImageDTO>> GetImagesByRoomIdAsync(int roomId)
        {
            var roomExists = await context.Rooms.AnyAsync(r => r.RoomID == roomId);
            if (!roomExists)
            {
                throw new KeyNotFoundException($"Room with ID {roomId} not found.");
            }

            return await context.RoomImages
                .Where(i => i.RoomID == roomId)
                .Select(i => new RoomImageDTO
                {
                    RoomID = i.RoomID,
                    ImageURL = i.ImageURL
                })
                .ToListAsync();
        }

        //<inheritdoc/>
        public async Task<RoomImageDTO> AddRoomImageAsync(RoomImageDTO dto)
        {
            var roomExists = await context.Rooms.AnyAsync(r => r.RoomID == dto.RoomID);
            if (!roomExists)
            {
                throw new KeyNotFoundException($"Room with ID {dto.RoomID} not found.");
            }

            var image = new RoomImage
            {
                RoomID = dto.RoomID,
                ImageURL = dto.ImageURL
            };

            context.RoomImages.Add(image);
            await context.SaveChangesAsync();

            return new RoomImageDTO
            {
                RoomID = image.RoomID,
                ImageURL = image.ImageURL
            };
        }

        //<inheritdoc/>
        public async Task DeleteRoomImageAsync(int imageId)
        {
            var image = await context.RoomImages.FindAsync(imageId)
                ?? throw new KeyNotFoundException($"Room image with ID {imageId} not found.");

            context.RoomImages.Remove(image);
            await context.SaveChangesAsync();
        }
    }
}

