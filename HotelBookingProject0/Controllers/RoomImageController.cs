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
    public class RoomImageController(IRoomImageService roomImageService) : ControllerBase
    {
        private readonly IRoomImageService roomImageService = roomImageService;

        [HttpGet("room/{roomId}")]
        public async Task<IActionResult> GetByRoom(int roomId)
        {
            var images = await roomImageService.GetImagesByRoomIdAsync(roomId);
            return Ok(images);
        }

        [HttpPost]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Add([FromBody] RoomImageDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var created = await roomImageService.AddRoomImageAsync(dto);
            return StatusCode(201, created);
        }

        [HttpDelete("{imageId}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Delete(int imageId)
        {
            await roomImageService.DeleteRoomImageAsync(imageId);
            return NoContent();
        }
    }
}
