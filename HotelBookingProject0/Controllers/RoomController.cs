using HotelBookingProject0.Models.DTO.RoomDTOs;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingProject0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController(IRoomService roomService) : ControllerBase
    {
        private readonly IRoomService roomService = roomService;

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll([FromQuery] RoomFilterDTO filter)
        {
            var result = await roomService.GetFilteredRoomsAsync(filter);
            return Ok(result);
        }

        [HttpGet("GetBy{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var room = await roomService.GetRoomByIdAsync(id);
            if (room == null)
            {
                return NotFound(new { message = $"Room with ID {id} not found." });
            }
            return Ok(room);
        }

        [HttpGet("GetRoomTypes")]
        public async Task<IActionResult> GetRoomTypes()
        {
            var types = await roomService.GetRoomTypesAsync();
            return Ok(types);
        }
    }
}

