using HotelBookingProject0.Data;
using HotelBookingProject0.Models.DTO;
using HotelBookingProject0.Models.Entities;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingProject0.Services
{
    public class HotelImageService(HotelBookingContext context) : IHotelImageService
    {
        private readonly HotelBookingContext context = context;

        //<inheritdoc/>
        public async Task<IEnumerable<HotelImageDTO>> GetImagesByHotelIdAsync(int hotelId)
        {
            var hotelExists = await context.Hotels.AnyAsync(h => h.HotelID == hotelId);
            if (!hotelExists)
            {
                throw new KeyNotFoundException($"Hotel with ID {hotelId} not found.");
            }

            return await context.HotelImages
                .Where(i => i.HotelID == hotelId)
                .Select(i => new HotelImageDTO
                {
                    HotelID = i.HotelID,
                    ImageURL = i.ImageURL,
                    IsPrimary = i.IsPrimary
                })
                .ToListAsync();
        }

        //<inheritdoc/>
        public async Task<HotelImageDTO> AddHotelImageAsync(HotelImageDTO dto)
        {
            var hotelExists = await context.Hotels.AnyAsync(h => h.HotelID == dto.HotelID);
            if (!hotelExists)
            {
                throw new KeyNotFoundException($"Hotel with ID {dto.HotelID} not found.");
            }

           
            if (dto.IsPrimary)
            {
                var existingPrimaries = await context.HotelImages
                    .Where(i => i.HotelID == dto.HotelID && i.IsPrimary)
                    .ToListAsync();

                foreach (var img in existingPrimaries)
                {
                    img.IsPrimary = false;
                }
            }

            var image = new HotelImage
            {
                HotelID = dto.HotelID,
                ImageURL = dto.ImageURL,
                IsPrimary = dto.IsPrimary
            };

            context.HotelImages.Add(image);
            await context.SaveChangesAsync();

            return new HotelImageDTO
            {
                HotelID = image.HotelID,
                ImageURL = image.ImageURL,
                IsPrimary = image.IsPrimary
            };
        }

        //<inheritdoc/>
        public async Task DeleteHotelImageAsync(int imageId)
        {
            var image = await context.HotelImages.FindAsync(imageId)
                ?? throw new KeyNotFoundException($"Hotel image with ID {imageId} not found.");

            context.HotelImages.Remove(image);
            await context.SaveChangesAsync();
        }

        //<inheritdoc/>
        public async Task SetPrimaryImageAsync(int imageId)
        {
            var image = await context.HotelImages.FindAsync(imageId)
                ?? throw new KeyNotFoundException($"Hotel image with ID {imageId} not found.");

            var siblings = await context.HotelImages
                .Where(i => i.HotelID == image.HotelID && i.IsPrimary)
                .ToListAsync();

            foreach (var sibling in siblings)
            {
                sibling.IsPrimary = false;
            }

            image.IsPrimary = true;
            await context.SaveChangesAsync();
        }
    }
}
