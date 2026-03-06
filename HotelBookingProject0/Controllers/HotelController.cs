using HotelBookingProject0.Interfaces;
using HotelBookingProject0.Models.DTO;
using HotelBookingProject0.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelBookingProject0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController(IHotelServices hotelServices) : ControllerBase
    {
        private readonly IHotelServices hotelServices = hotelServices;
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelDTO>>> GetAll()
        {
            var hotels = await hotelServices.GetAllHotelsAsync();
            return Ok(hotels); 
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<HotelDTO>> GetById(int id)
        {
            var hotel = await hotelServices.GetHotelByIdAsync(id);

            if (hotel == null)
            {
                return NotFound(new { message = $"Hotel with ID {id} was not found." });
            }
            return Ok(hotel);
        }

        [HttpPost]
        public async Task<ActionResult<HotelDTO>> Create([FromForm] HotelDTO hotelDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var createdHotel = await hotelServices.CreateHotelAsync(hotelDTO);
            return Created();
        }
    }
}

