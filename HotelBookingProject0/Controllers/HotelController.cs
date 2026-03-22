using HotelBookingProject0.Models.DTO.HotelDTOs;
using HotelBookingProject0.Services;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingProject0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController(IHotelServices hotelServices) : ControllerBase
    {
        private readonly IHotelServices hotelServices = hotelServices;

        [HttpGet("GetAllHotels")]
        public async Task<ActionResult<PagedHotelResponseDTO>> GetAll(
            [FromQuery] int page = 1,
            [FromQuery] int pageSize = 10)
        {
            if (page < 1) { page = 1; }
            if (pageSize < 1 || pageSize > 100) { pageSize = 10; }

            var result = await hotelServices.GetAllHotelsAsync(page, pageSize);
            return Ok(result);
        }

        [HttpGet("GetHotelBy{id}")]
        public async Task<ActionResult<HotelDTO>> GetById(int id)
        {
            var hotel = await hotelServices.GetHotelByIdAsync(id);
            if (hotel is null)
            {
                return NotFound(new { message = $"Hotel with ID {id} was not found." });
            }

            return Ok(hotel);
        }

        [HttpGet("GetHotelsBy{city}")]
        public async Task<IActionResult> GetHotelsByCity(string city)
        {
            var hotels = await hotelServices.GetHotelsByCityAsync(city);
            if (!hotels.Any())
            {
                return NotFound(new { message = $"No hotels found in {city}." });
            }

            return Ok(hotels);
        }

        [HttpGet("GetCities")]
        public async Task<ActionResult<IEnumerable<string>>> GetCities()
        {
            var cities = await hotelServices.GetCitiesAsync();
            return Ok(cities);
        }
    }
}

