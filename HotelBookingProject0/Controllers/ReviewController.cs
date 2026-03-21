using HotelBookingProject0.Constants;
using HotelBookingProject0.Models.DTO.ReviewDTOs;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


namespace HotelBookingProject0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController(IReviewService reviewService) : ControllerBase
    {
        private readonly IReviewService reviewService = reviewService;

        [HttpGet("GetHotelReviewsBy{hotelId}")]
        public async Task<IActionResult> GetHotelReviews(int hotelId)
        {
            var reviews = await reviewService.GetApprovedReviewsByHotelAsync(hotelId);
            return Ok(reviews);
        }

      
        [HttpPost("CreateReview")]
        [Authorize(Roles = Roles.Customer)]
        public async Task<IActionResult> CreateReview([FromForm] ReviewDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            try
            {
                var result = await reviewService.CreateReviewAsync(userId, dto);
                return CreatedAtAction(nameof(GetCurrentUsersReviews), result);
            }
            catch (InvalidOperationException ex) { return Conflict(new { message = ex.Message }); }
            catch (KeyNotFoundException ex) { return NotFound(new { message = ex.Message }); }
        }

        [HttpGet("CurrentUsersReview")]
        [Authorize(Roles = Roles.Customer)]
        public async Task<IActionResult> GetCurrentUsersReviews()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            var reviews = await reviewService.GetMyReviewsAsync(userId);
            return Ok(reviews);
        }

       
        [HttpDelete("DeleteReviewBy{reviewId}")]
        [Authorize(Roles = Roles.Customer)]
        public async Task<IActionResult> DeleteCurrentUsersReview(int reviewId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            try
            {
                await reviewService.DeleteReviewAsync(reviewId, userId);
                return NoContent();
            }
            catch (KeyNotFoundException ex) { return NotFound(new { message = ex.Message }); }
            catch (InvalidOperationException ex) { return BadRequest(new { message = ex.Message }); }
        }

      
        [HttpGet("AdminGetAllReviews")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> GetAllReviews()
        {
            var reviews = await reviewService.GetAllReviewsAsync();
            return Ok(reviews);
        }

      
        [HttpGet("AdminGetPendingReviews")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> GetPendingReviews()
        {
            var reviews = await reviewService.GetPendingReviewsAsync();
            return Ok(reviews);
        }

      
        [HttpPatch("AdminUpdateReviewStatusBy{reviewId}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> UpdateReviewStatus(
            int reviewId, [FromForm] UpdateReviewStatusDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            try
            {
                var result = await reviewService.UpdateReviewStatusAsync(
                    reviewId, dto.Status, dto.AdminNote);
                return Ok(result);
            }
            catch (KeyNotFoundException ex) { return NotFound(new { message = ex.Message }); }
        }

        [HttpDelete("AdminDeleteReviewBy{reviewId}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> AdminDeleteReview(int reviewId)
        {
            try
            {
                await reviewService.AdminDeleteReviewAsync(reviewId);
                return NoContent();
            }
            catch (KeyNotFoundException ex) { return NotFound(new { message = ex.Message }); }
        }
    }
}
