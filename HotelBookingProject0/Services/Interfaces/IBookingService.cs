using HotelBookingProject0.Models.DTO.BookingDTOs;

namespace HotelBookingProject0.Services.Interfaces
{
    public interface IBookingService
    {
        /// <summary>
        /// This method allows a user to create a new booking. It takes the user's ID and a BookingDTO containing the booking details 
        /// (room, check-in/check-out dates). 
        /// </summary>
        Task<BookingResponseDTO> CreateBookingAsync(string userId, BookingDTO dto);
        /// <summary>
        /// This method retrieves all bookings made by a specific user.
        /// It takes the user's ID as a parameter and returns a list of BookingResponseDTOs,
        /// </summary>
        Task<IEnumerable<BookingResponseDTO>> GetMyBookingsAsync(string userId);
        /// <summary>
        /// This method retrieves the details of a specific booking made by the user.
        /// It takes the booking ID and user ID as parameters to ensure that the user can only access their own bookings.
        /// </summary>
        Task<BookingResponseDTO> GetMyBookingByIdAsync(int bookingId, string userId);
        /// <summary>
        /// This method allows a user to cancel one of their bookings. 
        /// It takes the booking ID and user ID as parameters to ensure that the user can only cancel their own bookings.
        /// </summary>
        Task CancelBookingAsync(int bookingId, string userId);

        /// <summary>
        /// This method retrieves all bookings in the system, regardless of the user.(Admin)
        /// </summary>
        Task<IEnumerable<BookingResponseDTO>> GetAllBookingsAsync();
        /// <summary>
        /// This method retrieves all bookings with a specific status (e.g., "Confirmed", "Cancelled", "Pending").(Admin)
        /// </summary>
        Task<IEnumerable<BookingResponseDTO>> GetBookingsByStatusAsync(string status);
        /// <summary>
        /// this method allows an admin to update the status of a booking (e.g., from "Pending" to "Confirmed" or "Cancelled").(Admin)
        /// </summary>
        Task<BookingResponseDTO> UpdateBookingStatusAsync(int bookingId, string status);
        /// <summary>
        /// this method retrieves all bookings for a specific hotel, which can be useful for hotel staff to manage their reservations.(Admin)
        /// </summary>
        Task<IEnumerable<BookingResponseDTO>> GetBookingsByHotelAsync(int hotelId);
        /// <summary>
        /// this method allows an admin to delete a booking from the system.
        /// It takes the booking ID as a parameter and removes the corresponding booking record from the database.(Admin)
        /// </summary>
        Task DeleteBookingAsync(int bookingId);
    }
}
