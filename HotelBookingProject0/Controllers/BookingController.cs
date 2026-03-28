using HotelBookingProject0.Constants;
using HotelBookingProject0.Models.DTO.BookingDTOs;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HotelBookingProject0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController(IBookingService bookingService) : ControllerBase
    {
        private readonly IBookingService bookingService = bookingService;

        [HttpPost("CreateBooking")]
        [Authorize(Roles = Roles.Customer)]
        public async Task<IActionResult> CreateBooking([FromBody] BookingDTO dto)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            try
            {
                var result = await bookingService.CreateBookingAsync(userId, dto);
                return CreatedAtAction(nameof(GetCurrentUserBookingById), new { bookingId = result.BookingID }, result);
            }
            catch (KeyNotFoundException ex) { return NotFound(new { message = ex.Message }); }
            catch (InvalidOperationException ex) { return Conflict(new { message = ex.Message }); }
            catch (ArgumentException ex) { return BadRequest(new { message = ex.Message }); }
        }

        [HttpGet("GetCurrentUserBookings")]
        [Authorize(Roles = Roles.Customer)]
        public async Task<IActionResult> GetCurrentUserBookings()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            var result = await bookingService.GetMyBookingsAsync(userId);
            return Ok(result);
        }

        [HttpGet("GetCurrentUserBookingBy{bookingId}")]
        [Authorize(Roles = Roles.Customer)]
        public async Task<IActionResult> GetCurrentUserBookingById(int bookingId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            try
            {
                var result = await bookingService.GetMyBookingByIdAsync(bookingId, userId);
                return Ok(result);
            }
            catch (KeyNotFoundException ex) { return NotFound(new { message = ex.Message }); }
        }

        [HttpPatch("CancelBookingBy{bookingId}")]
        [Authorize(Roles = Roles.Customer)]
        public async Task<IActionResult> CancelBooking(int bookingId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            try
            {
                await bookingService.CancelBookingAsync(bookingId, userId);
                return NoContent();
            }
            catch (KeyNotFoundException ex) { return NotFound(new { message = ex.Message }); }
            catch (InvalidOperationException ex) { return BadRequest(new { message = ex.Message }); }
        }

        [HttpGet("AdminGetAllBookings")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> GetAllBookings(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 20)
        {
            if (page < 1) { page = 1; }
            if (pageSize < 1 || pageSize > 100) { pageSize = 20; }

            var result = await bookingService.GetAllBookingsAsync(page, pageSize);
            return Ok(result);
        }

        [HttpGet("AdminGetBookingsBy{status}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> GetBookingsByStatus(string status)
        {
            var result = await bookingService.GetBookingsByStatusAsync(status);
            return Ok(result);
        }

        [HttpGet("AdminGetBookingBy{hotelId}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> GetBookingsByHotel(int hotelId)
        {
            var result = await bookingService.GetBookingsByHotelAsync(hotelId);
            return Ok(result);
        }

        [HttpPatch("AdminUpdateBookingStatus{bookingId}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> UpdateBookingStatus(
            int bookingId, [FromForm] UpdateBookingStatusDTO dto)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            try
            {
                var result = await bookingService.UpdateBookingStatusAsync(bookingId, dto.Status);
                return Ok(result);
            }
            catch (KeyNotFoundException ex) { return NotFound(new { message = ex.Message }); }
            catch (InvalidOperationException ex) { return BadRequest(new { message = ex.Message }); }
        }

        [HttpDelete("AdminDeleteBooking{bookingId}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> DeleteBooking(int bookingId)
        {
            try
            {
                await bookingService.DeleteBookingAsync(bookingId);
                return NoContent();
            }
            catch (KeyNotFoundException ex) { return NotFound(new { message = ex.Message }); }
        }
    }
}

