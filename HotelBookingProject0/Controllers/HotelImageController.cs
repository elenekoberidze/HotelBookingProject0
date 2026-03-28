using HotelBookingProject0.Constants;
using HotelBookingProject0.Models.DTO;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingProject0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelImageController(IHotelImageService hotelImageService) : ControllerBase
    {
        private readonly IHotelImageService hotelImageService = hotelImageService;

        [HttpGet("hotel/{hotelId}")]
        public async Task<IActionResult> GetByHotel(int hotelId)
        {
            var images = await hotelImageService.GetImagesByHotelIdAsync(hotelId);
            return Ok(images);
        }

        [HttpPost]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Add([FromForm] HotelImageDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var created = await hotelImageService.AddHotelImageAsync(dto);
            return StatusCode(201, created);
        }

        [HttpDelete("{imageId}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Delete(int imageId)
        {
            await hotelImageService.DeleteHotelImageAsync(imageId);
            return NoContent();
        }

        [HttpPatch("{imageId}/set-primary")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> SetPrimary(int imageId)
        {
            await hotelImageService.SetPrimaryImageAsync(imageId);
            return NoContent();
        }
    }
}
