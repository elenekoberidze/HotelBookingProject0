using HotelBookingProject0.Models.DTO;
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
        public async Task<ActionResult<IEnumerable<HotelDTO>>> GetAll()
        {
            var hotels = await hotelServices.GetAllHotelsAsync();
            return Ok(hotels);
        }

        [HttpGet("GetHotelBy{id}")]
        public async Task<ActionResult<HotelDTO>> GetById(int id)
        {
            var hotel = await hotelServices.GetHotelByIdAsync(id);

            if (hotel == null)
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
        public async Task<ActionResult<IEnumerable<HotelDTO>>> GetCities()
        {
            var hotels = await hotelServices.GetCitiesAsync();
            return Ok(hotels);
        }
    }
}

