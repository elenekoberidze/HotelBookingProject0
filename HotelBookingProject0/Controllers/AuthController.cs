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
            if (!ModelState.IsValid)
            {
                return BadRequest(ValidationError());
            }

            try
            {
                var result = await auth.RegisterAsync(dto);
                return StatusCode(201, result);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout([FromForm] LoginDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ValidationError());
            }

            try
            {
                await auth.LogoutAsync(dto.Email, dto.Password);
                return NoContent();
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { message = ex.Message });
            }
        }

        [HttpPost("refresh")]
        public async Task<IActionResult> Refresh([FromForm] string refreshToken)
        {
            if (string.IsNullOrEmpty(refreshToken)) return BadRequest(new { message = "Refresh token is required" });

            try
            {
                var result = await auth.RefreshTokenAsync(refreshToken);
                return Ok(result);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { message = ex.Message });
            }
        }

        [HttpPost("revoke")]
        public async Task<IActionResult> Revoke([FromForm] string refreshToken)
        {
            if (string.IsNullOrEmpty(refreshToken)) return BadRequest(new { message = "Refresh token is required" });
            await auth.RevokeRefreshTokenAsync(refreshToken);
            return NoContent();
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login([FromForm] LoginDTO dto)
        {
            if (!ModelState.IsValid) 
            {
                return BadRequest(ValidationError()); 
            }

            try
            {
                var result = await auth.LoginAsync(dto);
                return Ok(result);
            }
            catch (UnauthorizedAccessException ex)
            {
                return Unauthorized(new { message = ex.Message });
            }
        }

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
