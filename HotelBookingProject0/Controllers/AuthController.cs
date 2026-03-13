using HotelBookingProject0.Constants;
using HotelBookingProject0.Models.DTO.AuthDTOs;
using HotelBookingProject0.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HotelBookingProject0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController(IAuthService auth) : ControllerBase
    {
        private readonly IAuthService auth = auth;

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromForm] RegisterDTO dto)
        {
            if (!ModelState.IsValid) { return BadRequest(ValidationError()); }
            var result = await auth.RegisterAsync(dto);
            return StatusCode(201, result);
        }

        
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromForm] LoginDTO dto)
        {
            if (!ModelState.IsValid) { return BadRequest(ValidationError()); }
            var result = await auth.LoginAsync(dto);
            return Ok(result);
        }

     
        [Authorize]
        [HttpGet("current-user")]
        public async Task<IActionResult> GetMe()
        {
            var result = await auth.GetUserAsync(UserId());
            return Ok(result);
        }

        
        [Authorize]
        [HttpGet("current-user/profile")]
        public async Task<IActionResult> GetMyProfile()
        {
            var result = await auth.GetProfileAsync(UserId());
            return Ok(result);
        }

        
        [Authorize]
        [HttpPut("current-user/profile")]
        public async Task<IActionResult> UpdateMyProfile([FromForm] UserProfileDTO dto)
        {
            var result = await auth.UpdateProfileAsync(UserId(), dto);
            return Ok(result);
        }
        private string UserId() => User.FindFirstValue(ClaimTypes.NameIdentifier)!;

        private object ValidationError() => new
        {
            statusCode = 400,
            message = "Validation failed.",
            errors = ModelState.Values
                .SelectMany(v => v.Errors)
                .Select(e => e.ErrorMessage)
                .ToList()
        };
    }
}
