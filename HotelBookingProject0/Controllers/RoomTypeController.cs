using HotelBookingProject0.Constants;
using HotelBookingProject0.Models.DTO.RoomTypeDTOs;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingProject0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController(IRoomTypeService roomTypeService) : ControllerBase
    {
        private readonly IRoomTypeService roomTypeService = roomTypeService;

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var types = await roomTypeService.GetAllRoomTypesAsync();
            return Ok(types);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var type = await roomTypeService.GetRoomTypeByIdAsync(id);
            if (type is null)
            {
                return NotFound(new { message = $"Room type with ID {id} not found." });
            }

            return Ok(type);
        }

        [HttpPost]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Create([FromBody] RoomTypeDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var created = await roomTypeService.CreateRoomTypeAsync(dto);
            return StatusCode(201, created);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Update(int id, [FromBody] RoomTypeDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var updated = await roomTypeService.UpdateRoomTypeAsync(id, dto);
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Delete(int id)
        {
            await roomTypeService.DeleteRoomTypeAsync(id);
            return NoContent();
        }
    }
}
