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
    [Authorize]
    public class UserProfileController(IUserProfileService profileService) : ControllerBase
    {
        [HttpGet("current-user")]
        public async Task<IActionResult> GetProfile()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            var result = await profileService.GetProfileAsync(userId);
            return Ok(result);
        }

        [HttpPut("current-user")]
        public async Task<IActionResult> UpdateProfile([FromBody] UserProfileDTO dto)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier)!;
            var result = await profileService.UpdateProfileAsync(userId, dto);
            return Ok(result);
        }
    }
}
