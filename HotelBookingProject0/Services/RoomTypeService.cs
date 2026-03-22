using HotelBookingProject0.Data;
using HotelBookingProject0.Models.DTO.RoomTypeDTOs;
using HotelBookingProject0.Models.Entities;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingProject0.Services
{
    public class RoomTypeService(HotelBookingContext context) : IRoomTypeService
    {
        private readonly HotelBookingContext context = context;

        //<inheritdoc/>
        public async Task<IEnumerable<RoomTypeResponseDTO>> GetAllRoomTypesAsync()
        {
            return await context.RoomTypes
                .Select(rt => new RoomTypeResponseDTO
                {
                    TypeID = rt.TypeID,
                    TypeName = rt.TypeName,
                    BasePrice = rt.BasePrice,
                    RoomCount = rt.Rooms.Count
                })
                .OrderBy(rt => rt.BasePrice)
                .ToListAsync();
        }

        //<inheritdoc/>
        public async Task<RoomTypeResponseDTO?> GetRoomTypeByIdAsync(int id)
        {
            return await context.RoomTypes
                .Where(rt => rt.TypeID == id)
                .Select(rt => new RoomTypeResponseDTO
                {
                    TypeID = rt.TypeID,
                    TypeName = rt.TypeName,
                    BasePrice = rt.BasePrice,
                    RoomCount = rt.Rooms.Count
                })
                .FirstOrDefaultAsync();
        }

        //<inheritdoc/>
        public async Task<RoomTypeResponseDTO> CreateRoomTypeAsync(RoomTypeDTO dto)
        {
            bool nameExists = await context.RoomTypes
                .AnyAsync(rt => rt.TypeName.Equals(dto.TypeName, StringComparison.CurrentCultureIgnoreCase));

            if (nameExists)
            {
                throw new InvalidOperationException($"A room type named '{dto.TypeName}' already exists.");
            }

            var roomType = new RoomType
            {
                TypeName = dto.TypeName,
                BasePrice = dto.BasePrice
            };

            context.RoomTypes.Add(roomType);
            await context.SaveChangesAsync();

            return new RoomTypeResponseDTO
            {
                TypeID = roomType.TypeID,
                TypeName = roomType.TypeName,
                BasePrice = roomType.BasePrice,
                RoomCount = 0
            };
        }

        //<inheritdoc/>
        public async Task<RoomTypeResponseDTO> UpdateRoomTypeAsync(int id, RoomTypeDTO dto)
        {
            var roomType = await context.RoomTypes.FindAsync(id)
                ?? throw new KeyNotFoundException($"Room type with ID {id} not found.");

            bool nameTaken = await context.RoomTypes
                .AnyAsync(rt => rt.TypeName.Equals(dto.TypeName, StringComparison.CurrentCultureIgnoreCase) && rt.TypeID != id);

            if (nameTaken)
            {
                throw new InvalidOperationException($"A room type named '{dto.TypeName}' already exists.");
            }

            roomType.TypeName = dto.TypeName;
            roomType.BasePrice = dto.BasePrice;

            await context.SaveChangesAsync();

            int roomCount = await context.Rooms.CountAsync(r => r.TypeID == id);

            return new RoomTypeResponseDTO
            {
                TypeID = roomType.TypeID,
                TypeName = roomType.TypeName,
                BasePrice = roomType.BasePrice,
                RoomCount = roomCount
            };
        }

        //<inheritdoc/>
        public async Task DeleteRoomTypeAsync(int id)
        {
            var roomType = await context.RoomTypes
                .Include(rt => rt.Rooms)
                .FirstOrDefaultAsync(rt => rt.TypeID == id)
                ?? throw new KeyNotFoundException($"Room type with ID {id} not found.");

            if (roomType.Rooms.Count != 0)
            {
                throw new InvalidOperationException(
                    $"Cannot delete room type '{roomType.TypeName}' because {roomType.Rooms.Count} room(s) are assigned to it.");
            }

            context.RoomTypes.Remove(roomType);
            await context.SaveChangesAsync();
        }
    }
}
