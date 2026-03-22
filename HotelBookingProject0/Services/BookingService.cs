using HotelBookingProject0.Constants;
using HotelBookingProject0.Data;
using HotelBookingProject0.Models.DTO.BookingDTOs;
using HotelBookingProject0.Models.Entities;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingProject0.Services
{
    public class BookingService(HotelBookingContext context) : IBookingService
    {
        private readonly HotelBookingContext context = context;

        //<inheritdoc/>
        public async Task<BookingResponseDTO> CreateBookingAsync(string userId, BookingDTO dto)
        {
            if (dto.CheckInDate.Date < DateTime.UtcNow.Date)
            {
                throw new ArgumentException("Check-in date cannot be in the past.");
            }

            if (dto.CheckOutDate.Date <= dto.CheckInDate.Date)
            {
                throw new ArgumentException("Check-out date must be after check-in date.");
            }

            var room = await context.Rooms
                .Include(r => r.RoomType)
                .Include(r => r.Hotel)
                .FirstOrDefaultAsync(r => r.RoomID == dto.RoomID)
                ?? throw new KeyNotFoundException("Room not found.");

            if (!room.IsAvailable)
            {
                throw new InvalidOperationException("This room is not available.");
            }

            bool hasOverlap = await context.Bookings.AnyAsync(b =>
                b.RoomID == dto.RoomID &&
                b.Status != BookingStatuses.Cancelled &&
                b.CheckInDate < dto.CheckOutDate &&
                b.CheckOutDate > dto.CheckInDate);

            if (hasOverlap)
            {
                throw new InvalidOperationException("This room is already booked for the selected dates.");
            }

            int nights = (dto.CheckOutDate.Date - dto.CheckInDate.Date).Days;
            decimal total = room.RoomType.BasePrice * nights;

            var booking = new Booking
            {
                UserID = userId,
                RoomID = dto.RoomID,
                CheckInDate = dto.CheckInDate.Date,
                CheckOutDate = dto.CheckOutDate.Date,
                TotalPrice = total,
                Status = BookingStatuses.Pending,
                CreatedAt = DateTime.UtcNow,
            };

            context.Bookings.Add(booking);
            await context.SaveChangesAsync();

            await context.Entry(booking).Reference(b => b.User).LoadAsync();
            await context.Entry(booking).Reference(b => b.Room).LoadAsync();
            await context.Entry(booking.Room).Reference(r => r.RoomType).LoadAsync();
            await context.Entry(booking.Room).Reference(r => r.Hotel).LoadAsync();

            return MapToDTO(booking);
        }

        //<inheritdoc/>
        public async Task<IEnumerable<BookingResponseDTO>> GetMyBookingsAsync(string userId)
        {
            return await context.Bookings
                .Include(b => b.User)
                .Include(b => b.Room).ThenInclude(r => r.RoomType)
                .Include(b => b.Room).ThenInclude(r => r.Hotel)
                .Where(b => b.UserID == userId)
                .OrderByDescending(b => b.CreatedAt)
                .Select(b => MapToDTO(b))
                .ToListAsync();
        }

        //<inheritdoc/>
        public async Task<BookingResponseDTO> GetMyBookingByIdAsync(int bookingId, string userId)
        {
            var booking = await context.Bookings
                .Include(b => b.User)
                .Include(b => b.Room).ThenInclude(r => r.RoomType)
                .Include(b => b.Room).ThenInclude(r => r.Hotel)
                .FirstOrDefaultAsync(b => b.BookingID == bookingId && b.UserID == userId)
                ?? throw new KeyNotFoundException("Booking not found.");

            return MapToDTO(booking);
        }

        //<inheritdoc/>
        public async Task CancelBookingAsync(int bookingId, string userId)
        {
            var booking = await context.Bookings
                .FirstOrDefaultAsync(b => b.BookingID == bookingId && b.UserID == userId)
                ?? throw new KeyNotFoundException("Booking not found.");

            if (booking.Status == BookingStatuses.Cancelled)
            {
                throw new InvalidOperationException("Booking is already cancelled.");
            }

            if (booking.Status == BookingStatuses.CheckedIn || booking.Status == BookingStatuses.CheckedOut)
            {
                throw new InvalidOperationException($"Cannot cancel a booking with status '{booking.Status}'.");
            }

            if (booking.CheckInDate.Date <= DateTime.UtcNow.Date)
            {
                throw new InvalidOperationException("Cannot cancel a booking on or after the check-in date.");
            }

            booking.Status = BookingStatuses.Cancelled;
            await context.SaveChangesAsync();
        }

        //<inheritdoc/>
        public async Task<PagedBookingResponseDTO> GetAllBookingsAsync(int page = 1, int pageSize = 20)
        {
            var query = context.Bookings
                .Include(b => b.User)
                .Include(b => b.Room).ThenInclude(r => r.RoomType)
                .Include(b => b.Room).ThenInclude(r => r.Hotel)
                .OrderByDescending(b => b.CreatedAt)
                .AsQueryable();

            var totalCount = await query.CountAsync();

            var bookings = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .Select(b => MapToDTO(b))
                .ToListAsync();

            return new PagedBookingResponseDTO
            {
                Bookings = bookings,
                TotalCount = totalCount,
                Page = page,
                PageSize = pageSize,
                TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize)
            };
        }

        //<inheritdoc/>
        public async Task<IEnumerable<BookingResponseDTO>> GetBookingsByStatusAsync(string status)
        {
            return await context.Bookings
                .Include(b => b.User)
                .Include(b => b.Room).ThenInclude(r => r.RoomType)
                .Include(b => b.Room).ThenInclude(r => r.Hotel)
                .Where(b => b.Status == status)
                .OrderByDescending(b => b.CreatedAt)
                .Select(b => MapToDTO(b))
                .ToListAsync();
        }

        //<inheritdoc/>
        public async Task<BookingResponseDTO> UpdateBookingStatusAsync(int bookingId, string status)
        {
            var booking = await context.Bookings
                .Include(b => b.User)
                .Include(b => b.Room).ThenInclude(r => r.RoomType)
                .Include(b => b.Room).ThenInclude(r => r.Hotel)
                .FirstOrDefaultAsync(b => b.BookingID == bookingId)
                ?? throw new KeyNotFoundException("Booking not found.");

            var allowed = booking.Status switch
            {
                BookingStatuses.Pending => [BookingStatuses.Confirmed, BookingStatuses.Cancelled],
                BookingStatuses.Confirmed => [BookingStatuses.CheckedIn, BookingStatuses.Cancelled],
                BookingStatuses.CheckedIn => [BookingStatuses.CheckedOut],
                _ => Array.Empty<string>()
            };

            if (!allowed.Contains(status))
            {
                throw new InvalidOperationException($"Cannot transition from '{booking.Status}' to '{status}'.");
            }

            booking.Status = status;
            await context.SaveChangesAsync();

            return MapToDTO(booking);
        }

        //<inheritdoc/>
        public async Task<IEnumerable<BookingResponseDTO>> GetBookingsByHotelAsync(int hotelId)
        {
            return await context.Bookings
                .Include(b => b.User)
                .Include(b => b.Room).ThenInclude(r => r.RoomType)
                .Include(b => b.Room).ThenInclude(r => r.Hotel)
                .Where(b => b.Room.HotelID == hotelId)
                .OrderByDescending(b => b.CreatedAt)
                .Select(b => MapToDTO(b))
                .ToListAsync();
        }

        //<inheritdoc/>
        public async Task DeleteBookingAsync(int bookingId)
        {
            var booking = await context.Bookings.FindAsync(bookingId)
                ?? throw new KeyNotFoundException("Booking not found.");

            context.Bookings.Remove(booking);
            await context.SaveChangesAsync();
        }

        private static BookingResponseDTO MapToDTO(Booking b) => new()
        {
            BookingID = b.BookingID,
            UserID = b.UserID,
            Username = b.User.UserName ?? string.Empty,
            RoomID = b.RoomID,
            RoomNumber = b.Room.RoomNumber,
            HotelName = b.Room.Hotel.Name,
            HotelCity = b.Room.Hotel.City,
            CheckInDate = b.CheckInDate,
            CheckOutDate = b.CheckOutDate,
            Nights = (b.CheckOutDate - b.CheckInDate).Days,
            TotalPrice = b.TotalPrice,
            Status = b.Status,
            CreatedAt = b.CreatedAt,
        };
    }
}
