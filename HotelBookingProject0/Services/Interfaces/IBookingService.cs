using HotelBookingProject0.Models.DTO.BookingDTOs;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IBookingService
    {
        /// <summary>
        /// Creates a booking for the given user. Validates dates, checks room availability, and calculates total price.
        /// </summary>
        Task<BookingResponseDTO> CreateBookingAsync(string userId, BookingDTO dto);

        /// <summary>
        /// Returns all bookings for the specified user, newest first.
        /// </summary>
        Task<IEnumerable<BookingResponseDTO>> GetMyBookingsAsync(string userId);

        /// <summary>
        /// Returns a specific booking belonging to the given user.
        /// </summary>
        Task<BookingResponseDTO> GetMyBookingByIdAsync(int bookingId, string userId);

        /// <summary>
        /// Cancels one of the user's own bookings (before check-in date).
        /// </summary>
        Task CancelBookingAsync(int bookingId, string userId);

        /// <summary>
        /// Returns a paginated list of all bookings in the system. Admin only.
        /// </summary>
        Task<PagedBookingResponseDTO> GetAllBookingsAsync(int page = 1, int pageSize = 20);

        /// <summary>
        /// Returns all bookings that match the given status (e.g. Pending, Confirmed). Admin only.
        /// </summary>
        Task<IEnumerable<BookingResponseDTO>> GetBookingsByStatusAsync(string status);

        /// <summary>
        /// Updates the status of a booking following allowed transitions. Admin only.
        /// </summary>
        Task<BookingResponseDTO> UpdateBookingStatusAsync(int bookingId, string status);

        /// <summary>
        /// Returns all bookings for a specific hotel. Admin only.
        /// </summary>
        Task<IEnumerable<BookingResponseDTO>> GetBookingsByHotelAsync(int hotelId);

        /// <summary>
        /// Permanently deletes a booking record. Admin only.
        /// </summary>
        Task DeleteBookingAsync(int bookingId);
    }
}
