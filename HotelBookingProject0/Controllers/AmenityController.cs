using HotelBookingProject0.Constants;
using HotelBookingProject0.Models.DTO.AmenityDTOs;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingProject0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AmenityController(IAmenityService amenityService) : ControllerBase
    {
        private readonly IAmenityService amenityService = amenityService;

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var result = await amenityService.GetAllAmenitiesAsync();
            return Ok(result);
        }
        [HttpGet("GetBy{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await amenityService.GetAmenityByIdAsync(id);
            if (result == null)
            {
                return NotFound(new { message = $"Amenity with ID {id} not found." });
            }
            return Ok(result);
        }

        [HttpPost("Create")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Create([FromForm] AmenityDTO dto)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            try
            {
                var result = await amenityService.CreateAmenityAsync(dto);
                return StatusCode(201, result);
            }
            catch (InvalidOperationException ex)
            {
                return Conflict(new { message = ex.Message });
            }
        }
        [HttpPut("Update{id}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Update(int id, [FromForm] AmenityDTO dto)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }
            try
            {
                var result = await amenityService.UpdateAmenityAsync(id, dto);
                return Ok(result);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
        [HttpDelete("DeleteBy{id}")]
        [Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await amenityService.DeleteAmenityAsync(id);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(new { message = ex.Message });
            }
        }
    }

}
