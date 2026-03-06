using HotelBookingProject0.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingProject0.Data
{
    public class HotelBookingContext : DbContext
    {
        public HotelBookingContext()
        {
        }

        public HotelBookingContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
