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
        public DbSet<RefreshToken> RefreshTokens { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomImage> RoomImages { get; set; }
        public DbSet<HotelImage> HotelImages { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Amenity> Amenities { get; set; }


    }
}
