using HotelBookingProject0.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingProject0.Data
{
    public class HotelBookingContext : IdentityDbContext<User>
    {
        public HotelBookingContext()
        {
        }

        public HotelBookingContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Hotel> Hotels { get; set; } 


    }
}
