using System;
using System.Collections.Generic;
using System.Linq;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

          
            
            var roomTypes = new List<RoomType>
            {
                new() { TypeID = 1, TypeName = "Single", BasePrice = 59.00m },
                new() { TypeID = 2, TypeName = "Double", BasePrice = 89.00m },
                new() { TypeID = 3, TypeName = "Twin", BasePrice = 99.00m },
                new() { TypeID = 4, TypeName = "Suite", BasePrice = 189.00m },
                new() { TypeID = 5, TypeName = "Deluxe", BasePrice = 249.00m }
            };
            modelBuilder.Entity<RoomType>().HasData(roomTypes);

            var hotels = new List<Hotel>
            {
                new() { HotelID = 1, Name = "Grandview Hotel", City = "New York", Address = "123 Madison Ave, New York, NY", Description = "Classic luxury hotel with skyline views, close to central attractions.", StarRating = HotelStarRating.FiveStars, Status = HotelStatus.Active },
                new() { HotelID = 2, Name = "Pacific Bay Resort", City = "Los Angeles", Address = "200 Ocean Drive, Santa Monica, CA", Description = "Beachfront resort with pools and spa, perfect for seaside getaways.", StarRating = HotelStarRating.FourStars, Status = HotelStatus.Active },
                new() { HotelID = 3, Name = "Riverside Inn", City = "Chicago", Address = "45 River St, Chicago, IL", Description = "Comfortable riverside hotel near downtown and cultural sites.", StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
                new() { HotelID = 4, Name = "Sunset Bay Hotel", City = "Miami", Address = "77 Ocean Blvd, Miami, FL", Description = "Modern rooms with sea views, rooftop bar and pool.", StarRating = HotelStarRating.FourStars, Status = HotelStatus.Active },
                new() { HotelID = 5, Name = "Market Street Suites", City = "San Francisco", Address = "10 Market St, San Francisco, CA", Description = "Upscale suites in the heart of the city, near shops and dining.", StarRating = HotelStarRating.FourStars, Status = HotelStatus.Active },
                new() { HotelID = 6, Name = "Evergreen Lodge", City = "Seattle", Address = "300 Pine St, Seattle, WA", Description = "Cozy lodge-style hotel near parks and waterfront.", StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
                new() { HotelID = 7, Name = "Beacon Hill Hotel", City = "Boston", Address = "88 Beacon St, Boston, MA", Description = "Historic hotel with classic rooms and easy access to universities and museums.", StarRating = HotelStarRating.FourStars, Status = HotelStatus.Active },
                new() { HotelID = 8, Name = "Lone Star Inn", City = "Austin", Address = "150 Congress Ave, Austin, TX", Description = "Boutique hotel close to live music venues and nightlife.", StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
                new() { HotelID = 9, Name = "Highland Peaks Resort", City = "Denver", Address = "1 Mountain Road, Denver, CO", Description = "Mountain-adjacent resort offering ski access and outdoor activities.", StarRating = HotelStarRating.FourStars, Status = HotelStatus.Active },
                new() { HotelID = 10, Name = "Orlando Family Suites", City = "Orlando", Address = "500 Theme Park Way, Orlando, FL", Description = "Family-friendly suites steps from major attractions.", StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
                new() { HotelID = 11, Name = "Desert Oasis Hotel", City = "Las Vegas", Address = "777 Strip Ave, Las Vegas, NV", Description = "Luxury hotel on the Strip with entertainment and dining.", StarRating = HotelStarRating.FiveStars, Status = HotelStatus.Active },
                new() { HotelID = 12, Name = "Willamette Riverside", City = "Portland", Address = "21 Riverbank Dr, Portland, OR", Description = "Eco-friendly hotel with farm-to-table dining and river views.", StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
                new() { HotelID = 13, Name = "Cabrillo Seaside", City = "San Diego", Address = "123 Harbor Ln, San Diego, CA", Description = "Seaside hotel with family activities and marina access.", StarRating = HotelStarRating.FourStars, Status = HotelStatus.Active },
                new() { HotelID = 14, Name = "Honolulu Beach Resort", City = "Honolulu", Address = "250 Waikiki Beach Rd, Honolulu, HI", Description = "Tropical resort with beach access and cultural activities.", StarRating = HotelStarRating.FiveStars, Status = HotelStatus.Active },
                new() { HotelID = 15, Name = "Peachtree Plaza", City = "Atlanta", Address = "75 Peachtree St, Atlanta, GA", Description = "Downtown hotel with panoramic city views and conference facilities.", StarRating = HotelStarRating.FourStars, Status = HotelStatus.Active },
                new() { HotelID = 16, Name = "Liberty House", City = "Philadelphia", Address = "45 Independence Mall, Philadelphia, PA", Description = "Historic-area hotel, ideal for sightseeing and business travel.", StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
                new() { HotelID = 17, Name = "Lakeside Retreat", City = "Dallas", Address = "12 Lakeview Dr, Dallas, TX", Description = "Quiet lakeside hotel with modern amenities and meeting space.", StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
                new() { HotelID = 18, Name = "Desert Sun Resort", City = "Phoenix", Address = "900 Desert Rd, Phoenix, AZ", Description = "Resort with pools, spa, and golf nearby.", StarRating = HotelStarRating.FourStars, Status = HotelStatus.Active },
                new() { HotelID = 19, Name = "Midtown Commons", City = "Minneapolis", Address = "330 Hennepin Ave, Minneapolis, MN", Description = "Urban hotel with convenient transit access and dining.", StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
                new() { HotelID = 20, Name = "Music City Suites", City = "Nashville", Address = "200 Broadway, Nashville, TN", Description = "Boutique suites close to music venues and nightlife.", StarRating = HotelStarRating.FourStars, Status = HotelStatus.Active }
            };
            modelBuilder.Entity<Hotel>().HasData(hotels);

            
            var rooms = new List<Room>
            {
                new() { RoomID = 1, HotelID = 1, TypeID = 5, RoomNumber = "101", IsAvailable = true },
                new() { RoomID = 2, HotelID = 2, TypeID = 4, RoomNumber = "202", IsAvailable = true },
                new() { RoomID = 3, HotelID = 3, TypeID = 2, RoomNumber = "103", IsAvailable = true },
                new() { RoomID = 4, HotelID = 4, TypeID = 4, RoomNumber = "204", IsAvailable = true },
                new() { RoomID = 5, HotelID = 5, TypeID = 5, RoomNumber = "305", IsAvailable = true },
                new() { RoomID = 6, HotelID = 6, TypeID = 3, RoomNumber = "106", IsAvailable = true },
                new() { RoomID = 7, HotelID = 7, TypeID = 2, RoomNumber = "207", IsAvailable = true },
                new() { RoomID = 8, HotelID = 8, TypeID = 1, RoomNumber = "108", IsAvailable = true },
                new() { RoomID = 9, HotelID = 9, TypeID = 4, RoomNumber = "309", IsAvailable = true },
                new() { RoomID = 10, HotelID = 10, TypeID = 3, RoomNumber = "110", IsAvailable = true },
                new() { RoomID = 11, HotelID = 11, TypeID = 5, RoomNumber = "511", IsAvailable = true },
                new() { RoomID = 12, HotelID = 12, TypeID = 2, RoomNumber = "212", IsAvailable = true },
                new() { RoomID = 13, HotelID = 13, TypeID = 4, RoomNumber = "313", IsAvailable = true },
                new() { RoomID = 14, HotelID = 14, TypeID = 5, RoomNumber = "414", IsAvailable = true },
                new() { RoomID = 15, HotelID = 15, TypeID = 3, RoomNumber = "115", IsAvailable = true },
                new() { RoomID = 16, HotelID = 16, TypeID = 2, RoomNumber = "216", IsAvailable = true },
                new() { RoomID = 17, HotelID = 17, TypeID = 1, RoomNumber = "117", IsAvailable = true },
                new() { RoomID = 18, HotelID = 18, TypeID = 4, RoomNumber = "318", IsAvailable = true },
                new() { RoomID = 19, HotelID = 19, TypeID = 2, RoomNumber = "219", IsAvailable = true },
                new() { RoomID = 20, HotelID = 20, TypeID = 4, RoomNumber = "220", IsAvailable = true }
            };
            modelBuilder.Entity<Room>().HasData(rooms);

          
            var unsplash = new[]
            {
                "https://images.unsplash.com/photo-1501117716987-c8e6f8b7a6f8?auto=format&fit=crop&w=1600&q=80",
                "https://images.unsplash.com/photo-1501117619481-8dde0d6d6aef?auto=format&fit=crop&w=1600&q=80",
                "https://images.unsplash.com/photo-150Hotelsample-1?auto=format&fit=crop&w=1600&q=80",
                "https://images.unsplash.com/photo-150Hotelsample-2?auto=format&fit=crop&w=1600&q=80",
                "https://images.unsplash.com/photo-1496417263034-38ec4f0b665a?auto=format&fit=crop&w=1600&q=80"
            };

            var hotelImages = new List<HotelImage>();
            int imgId = 1;
            for (int i = 0; i < hotels.Count; i++)
            {
                hotelImages.Add(new HotelImage { ImageID = imgId++, HotelID = hotels[i].HotelID, ImageURL = unsplash[i % unsplash.Length], IsPrimary = true });
                hotelImages.Add(new HotelImage { ImageID = imgId++, HotelID = hotels[i].HotelID, ImageURL = unsplash[(i + 1) % unsplash.Length], IsPrimary = false });
            }
            modelBuilder.Entity<HotelImage>().HasData(hotelImages);

            
            var roomImages = new List<RoomImage>();
            for (int i = 0; i < rooms.Count; i++)
            {
                roomImages.Add(new RoomImage { ImageID = imgId++, RoomID = rooms[i].RoomID, ImageURL = unsplash[(i + 2) % unsplash.Length] });
            }
            modelBuilder.Entity<RoomImage>().HasData(roomImages);

        
            var amenities = new List<Amenity>
            {
                new() { AmenityID = 1, Name = "Free Wi-Fi" },
                new() { AmenityID = 2, Name = "Air Conditioning" },
                new() { AmenityID = 3, Name = "Breakfast Included" },
                new() { AmenityID = 4, Name = "Free Parking" },
                new() { AmenityID = 5, Name = "Swimming Pool" },
                new() { AmenityID = 6, Name = "Spa" },
                new() { AmenityID = 7, Name = "Fitness Center" },
                new() { AmenityID = 8, Name = "On-site Restaurant" },
                new() { AmenityID = 9, Name = "Bar / Lounge" },
                new() { AmenityID = 10, Name = "24-hour Room Service" },
                new() { AmenityID = 11, Name = "Pet Friendly" },
                new() { AmenityID = 12, Name = "Non-smoking Rooms" },
                new() { AmenityID = 13, Name = "Airport Shuttle" },
                new() { AmenityID = 14, Name = "Laundry Service" },
                new() { AmenityID = 15, Name = "24-hour Front Desk" },
                new() { AmenityID = 16, Name = "Business Center" },
                new() { AmenityID = 17, Name = "Concierge" },
                new() { AmenityID = 18, Name = "Children's Activities" },
                new() { AmenityID = 19, Name = "Sauna" },
                new() { AmenityID = 20, Name = "Beach Access" }
            };
            modelBuilder.Entity<Amenity>().HasData(amenities);

           
            var amenityRooms = new List<object>();
            for (int i = 0; i < rooms.Count; i++)
            {
                var room = rooms[i];
                amenityRooms.Add(new { AmenitiesAmenityID = ((room.RoomID - 1) % 20) + 1, RoomsRoomID = room.RoomID });
                amenityRooms.Add(new { AmenitiesAmenityID = ((room.RoomID) % 20) + 1, RoomsRoomID = room.RoomID });
            }
            modelBuilder.Entity("AmenityRoom").HasData(amenityRooms);

            // Seed Users (20) - minimal fields for FK relationships
            var users = new List<User>
            {
                new() { Id = "u1", UserName = "alice.smith", NormalizedUserName = "ALICE.SMITH", Email = "alice.smith@example.com", NormalizedEmail = "ALICE.SMITH@EXAMPLE.COM", FirstName = "Alice", LastName = "Smith", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u2", UserName = "bob.johnson", NormalizedUserName = "BOB.JOHNSON", Email = "bob.johnson@example.com", NormalizedEmail = "BOB.JOHNSON@EXAMPLE.COM", FirstName = "Bob", LastName = "Johnson", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u3", UserName = "carol.williams", NormalizedUserName = "CAROL.WILLIAMS", Email = "carol.williams@example.com", NormalizedEmail = "CAROL.WILLIAMS@EXAMPLE.COM", FirstName = "Carol", LastName = "Williams", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u4", UserName = "david.brown", NormalizedUserName = "DAVID.BROWN", Email = "david.brown@example.com", NormalizedEmail = "DAVID.BROWN@EXAMPLE.COM", FirstName = "David", LastName = "Brown", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u5", UserName = "emma.jones", NormalizedUserName = "EMMA.JONES", Email = "emma.jones@example.com", NormalizedEmail = "EMMA.JONES@EXAMPLE.COM", FirstName = "Emma", LastName = "Jones", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u6", UserName = "frank.miller", NormalizedUserName = "FRANK.MILLER", Email = "frank.miller@example.com", NormalizedEmail = "FRANK.MILLER@EXAMPLE.COM", FirstName = "Frank", LastName = "Miller", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u7", UserName = "grace.davis", NormalizedUserName = "GRACE.DAVIS", Email = "grace.davis@example.com", NormalizedEmail = "GRACE.DAVIS@EXAMPLE.COM", FirstName = "Grace", LastName = "Davis", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u8", UserName = "henry.garcia", NormalizedUserName = "HENRY.GARCIA", Email = "henry.garcia@example.com", NormalizedEmail = "HENRY.GARCIA@EXAMPLE.COM", FirstName = "Henry", LastName = "Garcia", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u9", UserName = "isabel.martin", NormalizedUserName = "ISABEL.MARTIN", Email = "isabel.martin@example.com", NormalizedEmail = "ISABEL.MARTIN@EXAMPLE.COM", FirstName = "Isabel", LastName = "Martin", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u10", UserName = "jack.thompson", NormalizedUserName = "JACK.THOMPSON", Email = "jack.thompson@example.com", NormalizedEmail = "JACK.THOMPSON@EXAMPLE.COM", FirstName = "Jack", LastName = "Thompson", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u11", UserName = "kate.white", NormalizedUserName = "KATE.WHITE", Email = "kate.white@example.com", NormalizedEmail = "KATE.WHITE@EXAMPLE.COM", FirstName = "Kate", LastName = "White", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u12", UserName = "leo.harris", NormalizedUserName = "LEO.HARRIS", Email = "leo.harris@example.com", NormalizedEmail = "LEO.HARRIS@EXAMPLE.COM", FirstName = "Leo", LastName = "Harris", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u13", UserName = "mia.clark", NormalizedUserName = "MIA.CLARK", Email = "mia.clark@example.com", NormalizedEmail = "MIA.CLARK@EXAMPLE.COM", FirstName = "Mia", LastName = "Clark", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u14", UserName = "noah.lewis", NormalizedUserName = "NOAH.LEWIS", Email = "noah.lewis@example.com", NormalizedEmail = "NOAH.LEWIS@EXAMPLE.COM", FirstName = "Noah", LastName = "Lewis", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u15", UserName = "olivia.walker", NormalizedUserName = "OLIVIA.WALKER", Email = "olivia.walker@example.com", NormalizedEmail = "OLIVIA.WALKER@EXAMPLE.COM", FirstName = "Olivia", LastName = "Walker", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u16", UserName = "paul.young", NormalizedUserName = "PAUL.YOUNG", Email = "paul.young@example.com", NormalizedEmail = "PAUL.YOUNG@EXAMPLE.COM", FirstName = "Paul", LastName = "Young", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u17", UserName = "quinn.hernandez", NormalizedUserName = "QUINN.HERNANDEZ", Email = "quinn.hernandez@example.com", NormalizedEmail = "QUINN.HERNANDEZ@EXAMPLE.COM", FirstName = "Quinn", LastName = "Hernandez", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u18", UserName = "rachel.king", NormalizedUserName = "RACHEL.KING", Email = "rachel.king@example.com", NormalizedEmail = "RACHEL.KING@EXAMPLE.COM", FirstName = "Rachel", LastName = "King", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u19", UserName = "sam.porter", NormalizedUserName = "SAM.PORTER", Email = "sam.porter@example.com", NormalizedEmail = "SAM.PORTER@EXAMPLE.COM", FirstName = "Sam", LastName = "Porter", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow },
                new() { Id = "u20", UserName = "tina.bell", NormalizedUserName = "TINA.BELL", Email = "tina.bell@example.com", NormalizedEmail = "TINA.BELL@EXAMPLE.COM", FirstName = "Tina", LastName = "Bell", IsActive = true, CreatedAt = DateTime.UtcNow, UpdatedAt = DateTime.UtcNow }
            };
            modelBuilder.Entity<User>().HasData(users);

            // UserProfiles (one per user)
            var profiles = new List<UserProfile>();
            for (int i = 0; i < users.Count; i++)
            {
                profiles.Add(new UserProfile
                {
                    Id = i + 1,
                    UserId = users[i].Id,
                    Address = $"{100 + i} Example St",
                    City = hotels[i % hotels.Count].City,
                    DateOfBirth = DateTime.UtcNow.AddYears(-30).AddDays(i),
                    AvatarUrl = $"https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80",
                    Bio = "Enthusiastic traveler and reviewer.",
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                });
            }
            modelBuilder.Entity<UserProfile>().HasData(profiles);

            // Reviews (20) - each user leaves a review for a hotel
            var reviews = new List<Review>();
            for (int i = 0; i < 20; i++)
            {
                reviews.Add(new Review
                {
                    ReviewID = i + 1,
                    UserID = users[i].Id,
                    HotelID = ((i) % hotels.Count) + 1,
                    Rating = (i % 5) + 1,
                    Comment = new[] { "Excellent stay, highly recommend.", "Very comfortable and well located.", "Good value for money.", "Service could be improved.", "Outstanding amenities and staff." }[i % 5],
                    ReviewDate = DateTime.UtcNow.AddDays(-i * 2)
                });
            }
            modelBuilder.Entity<Review>().HasData(reviews);

            // Bookings (20) - each user books a room
            var bookings = new List<Booking>();
            for (int i = 0; i < 20; i++)
            {
                var room = rooms[i % rooms.Count];
                var nights = 2 + (i % 3);
                var basePrice = roomTypes.First(rt => rt.TypeID == room.TypeID).BasePrice;
                bookings.Add(new Booking
                {
                    BookingID = i + 1,
                    UserID = users[i].Id,
                    RoomID = room.RoomID,
                    CheckInDate = DateTime.UtcNow.AddDays(7 + i),
                    CheckOutDate = DateTime.UtcNow.AddDays(7 + i + nights),
                    TotalPrice = basePrice * nights,
                    CreatedAt = DateTime.UtcNow.AddDays(-1)
                });
            }
            modelBuilder.Entity<Booking>().HasData(bookings);
        }

    }
}

