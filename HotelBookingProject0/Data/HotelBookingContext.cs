using HotelBookingProject0.Constants;
using HotelBookingProject0.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Collections.Specialized.BitVector32;

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
        new() { TypeID = 1, TypeName = "Single",  BasePrice = 79.00m  },
        new() { TypeID = 2, TypeName = "Double",  BasePrice = 119.00m },
        new() { TypeID = 3, TypeName = "Twin",    BasePrice = 129.00m },
        new() { TypeID = 4, TypeName = "Suite",   BasePrice = 249.00m },
        new() { TypeID = 5, TypeName = "Deluxe",  BasePrice = 319.00m },
    };
            modelBuilder.Entity<RoomType>().HasData(roomTypes);


            var hotels = new List<Hotel>
    {
        new() { HotelID =  1, Name = "The Whitmore Grand",         City = "New York",       Address = "12 West 57th Street, New York, NY 10019",           Description = "An iconic Midtown Manhattan hotel with Art Deco interiors, panoramic Central Park views, a rooftop lounge, and a Michelin-starred restaurant.",          StarRating = HotelStarRating.FiveStars,  Status = HotelStatus.Active },
        new() { HotelID =  2, Name = "Malibu Crest Resort",        City = "Los Angeles",    Address = "7220 Pacific Coast Highway, Malibu, CA 90265",       Description = "A cliffside resort hugging the California coastline, featuring private beach access, infinity pools, and sunset views over the Pacific.",                  StarRating = HotelStarRating.FiveStars,  Status = HotelStatus.Active },
        new() { HotelID =  3, Name = "Lakeshore Boutique Hotel",   City = "Chicago",        Address = "680 N Lake Shore Drive, Chicago, IL 60611",          Description = "A stylish boutique hotel on the shores of Lake Michigan, steps from Navy Pier and the Magnificent Mile, with a rooftop bar and spa.",                  StarRating = HotelStarRating.FourStars,  Status = HotelStatus.Active },
        new() { HotelID =  4, Name = "Brickell Bay Hotel",         City = "Miami",          Address = "1901 Brickell Avenue, Miami, FL 33129",              Description = "A sleek urban retreat in Miami's financial district, with bay views, a rooftop infinity pool, and a vibrant lobby bar.",                                   StarRating = HotelStarRating.FourStars,  Status = HotelStatus.Active },
        new() { HotelID =  5, Name = "Embarcadero Suites",         City = "San Francisco",  Address = "200 Embarcadero, San Francisco, CA 94105",            Description = "Luxury waterfront suites overlooking the Bay Bridge, offering farm-to-table dining, a wine cellar, and tech-forward amenities.",                         StarRating = HotelStarRating.FiveStars,  Status = HotelStatus.Active },
        new() { HotelID =  6, Name = "Pike Street Lodge",          City = "Seattle",        Address = "94 Pike Street, Seattle, WA 98101",                  Description = "A cozy lodge-inspired hotel a block from Pike Place Market, with locally sourced breakfast, fireside lounges, and mountain views.",                       StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
        new() { HotelID =  7, Name = "Beacon Hill Manor",          City = "Boston",         Description = "A landmark Federal-style manor on Beacon Hill, offering curated historical tours, a wood-panelled library bar, and rooms with four-poster beds.",         StarRating = HotelStarRating.FourStars,  Status = HotelStatus.Active, Address = "21 Mount Vernon Street, Boston, MA 02108" },
        new() { HotelID =  8, Name = "South Congress Inn",         City = "Austin",         Address = "1603 South Congress Ave, Austin, TX 78704",          Description = "An eclectic boutique inn in Austin's trendiest corridor, with live music on weekends, local craft cocktails, and a rooftop terrace.",                    StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
        new() { HotelID =  9, Name = "Rocky Peak Resort",          City = "Denver",         Address = "1600 Glenarm Place, Denver, CO 80202",               Description = "A mountain-modern resort with ski concierge services, heated outdoor pools, a summit-view spa, and direct Rocky Mountain trail access.",                  StarRating = HotelStarRating.FourStars,  Status = HotelStatus.Active },
        new() { HotelID = 10, Name = "International Drive Suites", City = "Orlando",        Address = "8978 International Drive, Orlando, FL 32819",        Description = "Spacious family suites minutes from Walt Disney World, Universal Studios, and SeaWorld, with a lazy river pool and nightly themed entertainment.",        StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
        new() { HotelID = 11, Name = "The Palazzo Venetian",       City = "Las Vegas",      Address = "3325 Las Vegas Boulevard S, Las Vegas, NV 89109",    Description = "An all-suite luxury tower inspired by Venetian palazzos, featuring a grand casino floor, celebrity chef restaurants, a canyon ranch spa, and butler service.", StarRating = HotelStarRating.FiveStars,  Status = HotelStatus.Active },
        new() { HotelID = 12, Name = "Pearl District Hotel",       City = "Portland",       Address = "314 NW 11th Avenue, Portland, OR 97209",             Description = "A design-forward hotel in Portland's Pearl District gallery neighbourhood, with locally roasted coffee, vegan menus, and bike rental.",                StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
        new() { HotelID = 13, Name = "Harbor View Hotel",          City = "San Diego",      Address = "1355 N Harbor Drive, San Diego, CA 92101",           Description = "A nautical-themed waterfront hotel overlooking San Diego Bay, with yacht charters, a sailor's taproom, and freshly caught seafood dining.",             StarRating = HotelStarRating.FourStars,  Status = HotelStatus.Active },
        new() { HotelID = 14, Name = "Waikiki Horizon Resort",     City = "Honolulu",       Address = "2552 Kalakaua Avenue, Honolulu, HI 96815",           Description = "A beachfront Hawaiian resort with oceanfront lanais, traditional luau evenings, snorkelling excursions, and a rejuvenating lomi-lomi spa.",              StarRating = HotelStarRating.FiveStars,  Status = HotelStatus.Active },
        new() { HotelID = 15, Name = "Midtown Atlanta Tower",      City = "Atlanta",        Address = "188 14th Street NE, Atlanta, GA 30309",              Description = "A glass-facade tower in Midtown Atlanta near the High Museum of Art, featuring a sky pool, craft cocktail bar, and executive conference suites.",       StarRating = HotelStarRating.FourStars,  Status = HotelStatus.Active },
        new() { HotelID = 16, Name = "Independence Square Hotel",  City = "Philadelphia",   Address = "235 Chestnut Street, Philadelphia, PA 19106",        Description = "A colonial-inspired hotel one block from Independence Hall, with cobblestone courtyards, a cheesesteak brunch menu, and period-accurate room décor.",   StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
        new() { HotelID = 17, Name = "Uptown Dallas Residences",   City = "Dallas",         Address = "2101 Cedar Springs Road, Dallas, TX 75201",          Description = "Contemporary urban residences in Dallas' Uptown neighbourhood, with a rooftop terrace, pool, fully equipped kitchens, and pet-friendly policies.",    StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
        new() { HotelID = 18, Name = "Camelback Desert Spa",       City = "Phoenix",        Address = "5402 E Lincoln Drive, Scottsdale, AZ 85253",         Description = "A Sonoran Desert retreat at the foot of Camelback Mountain, offering outdoor mineral pools, world-class spa treatments, and adobe casita rooms.",        StarRating = HotelStarRating.FourStars,  Status = HotelStatus.Active },
        new() { HotelID = 19, Name = "Nicollet Mall Hotel",        City = "Minneapolis",    Address = "100 Nicollet Mall, Minneapolis, MN 55402",           Description = "A well-appointed urban hotel on Minneapolis' main promenade, with skyway access, a jazz bar, and proximity to the Guthrie Theater.",                   StarRating = HotelStarRating.ThreeStars, Status = HotelStatus.Active },
        new() { HotelID = 20, Name = "Broadway Rhythm Hotel",      City = "Nashville",      Address = "301 Broadway, Nashville, TN 37201",                  Description = "Nashville's premier music-themed hotel steps from Honky Tonk Highway, with a recording studio lounge, live country music nightly, and guitar-shaped pool.", StarRating = HotelStarRating.FourStars,  Status = HotelStatus.Active },
    };
            modelBuilder.Entity<Hotel>().HasData(hotels);


            var rooms = new List<Room>
    {

        new() { RoomID =  1, HotelID =  1, TypeID = 1, RoomNumber = "101", IsAvailable = true },
        new() { RoomID =  2, HotelID =  1, TypeID = 4, RoomNumber = "412", IsAvailable = true },
        new() { RoomID =  3, HotelID =  1, TypeID = 5, RoomNumber = "PH1", IsAvailable = false },

        new() { RoomID =  4, HotelID =  2, TypeID = 2, RoomNumber = "201", IsAvailable = true },
        new() { RoomID =  5, HotelID =  2, TypeID = 5, RoomNumber = "OV1", IsAvailable = true },

        new() { RoomID =  6, HotelID =  3, TypeID = 2, RoomNumber = "205", IsAvailable = true },
        new() { RoomID =  7, HotelID =  3, TypeID = 3, RoomNumber = "307", IsAvailable = true },

        new() { RoomID =  8, HotelID =  4, TypeID = 1, RoomNumber = "102", IsAvailable = true },
        new() { RoomID =  9, HotelID =  4, TypeID = 4, RoomNumber = "501", IsAvailable = false },

        new() { RoomID = 10, HotelID =  5, TypeID = 4, RoomNumber = "WF2", IsAvailable = true },
        new() { RoomID = 11, HotelID =  5, TypeID = 5, RoomNumber = "WF5", IsAvailable = true },

        new() { RoomID = 12, HotelID =  6, TypeID = 1, RoomNumber = "G01", IsAvailable = true },
        new() { RoomID = 13, HotelID =  6, TypeID = 2, RoomNumber = "G02", IsAvailable = true },

        new() { RoomID = 14, HotelID =  7, TypeID = 3, RoomNumber = "203", IsAvailable = true },
        new() { RoomID = 15, HotelID =  7, TypeID = 4, RoomNumber = "401", IsAvailable = true },

        new() { RoomID = 16, HotelID =  8, TypeID = 1, RoomNumber = "108", IsAvailable = true },
        new() { RoomID = 17, HotelID =  8, TypeID = 2, RoomNumber = "210", IsAvailable = false },

        new() { RoomID = 18, HotelID =  9, TypeID = 2, RoomNumber = "302", IsAvailable = true },
        new() { RoomID = 19, HotelID =  9, TypeID = 5, RoomNumber = "MT1", IsAvailable = true },

        new() { RoomID = 20, HotelID = 10, TypeID = 3, RoomNumber = "120", IsAvailable = true },
        new() { RoomID = 21, HotelID = 10, TypeID = 4, RoomNumber = "220", IsAvailable = true },

        new() { RoomID = 22, HotelID = 11, TypeID = 4, RoomNumber = "V08", IsAvailable = true },
        new() { RoomID = 23, HotelID = 11, TypeID = 5, RoomNumber = "V12", IsAvailable = false },

        new() { RoomID = 24, HotelID = 12, TypeID = 1, RoomNumber = "104", IsAvailable = true },
        new() { RoomID = 25, HotelID = 12, TypeID = 2, RoomNumber = "204", IsAvailable = true },

        new() { RoomID = 26, HotelID = 13, TypeID = 2, RoomNumber = "HB3", IsAvailable = true },
        new() { RoomID = 27, HotelID = 13, TypeID = 4, RoomNumber = "HB8", IsAvailable = true },

        new() { RoomID = 28, HotelID = 14, TypeID = 3, RoomNumber = "OC2", IsAvailable = true },
        new() { RoomID = 29, HotelID = 14, TypeID = 5, RoomNumber = "OC9", IsAvailable = false },

        new() { RoomID = 30, HotelID = 15, TypeID = 2, RoomNumber = "315", IsAvailable = true },
        new() { RoomID = 31, HotelID = 15, TypeID = 4, RoomNumber = "615", IsAvailable = true },

        new() { RoomID = 32, HotelID = 16, TypeID = 1, RoomNumber = "103", IsAvailable = true },
        new() { RoomID = 33, HotelID = 16, TypeID = 3, RoomNumber = "303", IsAvailable = true },

        new() { RoomID = 34, HotelID = 17, TypeID = 2, RoomNumber = "202", IsAvailable = true },
        new() { RoomID = 35, HotelID = 17, TypeID = 4, RoomNumber = "402", IsAvailable = false },

        new() { RoomID = 36, HotelID = 18, TypeID = 3, RoomNumber = "C04", IsAvailable = true },
        new() { RoomID = 37, HotelID = 18, TypeID = 5, RoomNumber = "C10", IsAvailable = true },

        new() { RoomID = 38, HotelID = 19, TypeID = 1, RoomNumber = "107", IsAvailable = true },
        new() { RoomID = 39, HotelID = 19, TypeID = 2, RoomNumber = "207", IsAvailable = true },

        new() { RoomID = 40, HotelID = 20, TypeID = 2, RoomNumber = "201", IsAvailable = true },
        new() { RoomID = 41, HotelID = 20, TypeID = 4, RoomNumber = "401", IsAvailable = true },
    };
            modelBuilder.Entity<Room>().HasData(rooms);


            var amenities = new List<Amenity>
    {
        new() { AmenityID =  1, Name = "Free Wi-Fi" },
        new() { AmenityID =  2, Name = "Air Conditioning" },
        new() { AmenityID =  3, Name = "Breakfast Included" },
        new() { AmenityID =  4, Name = "Free Parking" },
        new() { AmenityID =  5, Name = "Swimming Pool" },
        new() { AmenityID =  6, Name = "Spa & Wellness Centre" },
        new() { AmenityID =  7, Name = "Fitness Center" },
        new() { AmenityID =  8, Name = "On-site Restaurant" },
        new() { AmenityID =  9, Name = "Rooftop Bar" },
        new() { AmenityID = 10, Name = "24-hour Room Service" },
        new() { AmenityID = 11, Name = "Pet Friendly" },
        new() { AmenityID = 12, Name = "Non-smoking Rooms" },
        new() { AmenityID = 13, Name = "Airport Shuttle" },
        new() { AmenityID = 14, Name = "Laundry Service" },
        new() { AmenityID = 15, Name = "24-hour Front Desk" },
        new() { AmenityID = 16, Name = "Business Center" },
        new() { AmenityID = 17, Name = "Concierge Service" },
        new() { AmenityID = 18, Name = "Children's Activities" },
        new() { AmenityID = 19, Name = "Sauna" },
        new() { AmenityID = 20, Name = "Beach / Waterfront Access" },
        new() { AmenityID = 21, Name = "Electric Vehicle Charging" },
        new() { AmenityID = 22, Name = "Bike Rental" },
    };
            modelBuilder.Entity<Amenity>().HasData(amenities);


            var amenityRooms = new List<object>();
            var rotatingAmenities = new[] { 3, 4, 5, 6, 7, 8, 9, 10, 11, 13, 14, 17, 19, 20, 21, 22 };
            foreach (var room in rooms)
            {
                amenityRooms.Add(new { AmenitiesAmenityID = 1, RoomsRoomID = room.RoomID });
                amenityRooms.Add(new { AmenitiesAmenityID = 2, RoomsRoomID = room.RoomID });
                int extra = rotatingAmenities[(room.RoomID - 1) % rotatingAmenities.Length];
                amenityRooms.Add(new { AmenitiesAmenityID = extra, RoomsRoomID = room.RoomID });
            }
            modelBuilder.Entity("AmenityRoom").HasData(amenityRooms);


            var hotelImageUrls = new[]
            {
        "https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1600&q=80",
        "https://images.unsplash.com/photo-1551882547-ff40c63fe5fa?w=1600&q=80",
        "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1600&q=80",
        "https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1600&q=80",
        "https://images.unsplash.com/photo-1496417263034-38ec4f0b665a?w=1600&q=80",
        "https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1600&q=80",
        "https://images.unsplash.com/photo-1571003123894-1f0594d2b5d9?w=1600&q=80",
        "https://images.unsplash.com/photo-1584132967334-10e028bd69f7?w=1600&q=80",
    };

            var hotelImages = new List<HotelImage>();
            int hImgId = 1;
            for (int i = 0; i < hotels.Count; i++)
            {
                hotelImages.Add(new HotelImage { ImageID = hImgId++, HotelID = hotels[i].HotelID, ImageURL = hotelImageUrls[i % hotelImageUrls.Length], IsPrimary = true });
                hotelImages.Add(new HotelImage { ImageID = hImgId++, HotelID = hotels[i].HotelID, ImageURL = hotelImageUrls[(i + 3) % hotelImageUrls.Length], IsPrimary = false });
                hotelImages.Add(new HotelImage { ImageID = hImgId++, HotelID = hotels[i].HotelID, ImageURL = hotelImageUrls[(i + 5) % hotelImageUrls.Length], IsPrimary = false });
            }
            modelBuilder.Entity<HotelImage>().HasData(hotelImages);


            var roomImageUrls = new[]
            {
        "https://images.unsplash.com/photo-1631049307264-da0ec9d70304?w=1200&q=80",
        "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80",
        "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80",
        "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80",
        "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80",
        "https://images.unsplash.com/photo-1540518614846-7eded433c457?w=1200&q=80",
    };

            var roomImages = new List<RoomImage>();
            int rImgId = hImgId;
            foreach (var room in rooms)
            {
                roomImages.Add(new RoomImage { ImageID = rImgId++, RoomID = room.RoomID, ImageURL = roomImageUrls[(room.RoomID - 1) % roomImageUrls.Length] });
                roomImages.Add(new RoomImage { ImageID = rImgId++, RoomID = room.RoomID, ImageURL = roomImageUrls[(room.RoomID) % roomImageUrls.Length] });
            }
            modelBuilder.Entity<RoomImage>().HasData(roomImages);


            var hasher = new PasswordHasher<User>();

            var users = new List<User>
    {
        new() { Id = "u01", UserName = "james.hartwell",   NormalizedUserName = "JAMES.HARTWELL",   Email = "james.hartwell@gmail.com",    NormalizedEmail = "JAMES.HARTWELL@GMAIL.COM",    FirstName = "James",     LastName = "Hartwell",   IsActive = true, CreatedAt = new DateTime(2024,1,15), UpdatedAt = new DateTime(2024,1,15) },
        new() { Id = "u02", UserName = "sophia.chen",      NormalizedUserName = "SOPHIA.CHEN",      Email = "sophia.chen@outlook.com",     NormalizedEmail = "SOPHIA.CHEN@OUTLOOK.COM",     FirstName = "Sophia",    LastName = "Chen",       IsActive = true, CreatedAt = new DateTime(2024,2,3),  UpdatedAt = new DateTime(2024,2,3)  },
        new() { Id = "u03", UserName = "luca.ferrari",     NormalizedUserName = "LUCA.FERRARI",     Email = "luca.ferrari@hotmail.com",    NormalizedEmail = "LUCA.FERRARI@HOTMAIL.COM",    FirstName = "Luca",      LastName = "Ferrari",    IsActive = true, CreatedAt = new DateTime(2024,2,18), UpdatedAt = new DateTime(2024,2,18) },
        new() { Id = "u04", UserName = "amelia.nguyen",    NormalizedUserName = "AMELIA.NGUYEN",    Email = "amelia.nguyen@yahoo.com",     NormalizedEmail = "AMELIA.NGUYEN@YAHOO.COM",     FirstName = "Amelia",    LastName = "Nguyen",     IsActive = true, CreatedAt = new DateTime(2024,3,7),  UpdatedAt = new DateTime(2024,3,7)  },
        new() { Id = "u05", UserName = "ethan.kovacs",     NormalizedUserName = "ETHAN.KOVACS",     Email = "ethan.kovacs@gmail.com",      NormalizedEmail = "ETHAN.KOVACS@GMAIL.COM",      FirstName = "Ethan",     LastName = "Kovacs",     IsActive = true, CreatedAt = new DateTime(2024,3,22), UpdatedAt = new DateTime(2024,3,22) },
        new() { Id = "u06", UserName = "isabella.ramos",   NormalizedUserName = "ISABELLA.RAMOS",   Email = "isabella.ramos@gmail.com",    NormalizedEmail = "ISABELLA.RAMOS@GMAIL.COM",    FirstName = "Isabella",  LastName = "Ramos",      IsActive = true, CreatedAt = new DateTime(2024,4,10), UpdatedAt = new DateTime(2024,4,10) },
        new() { Id = "u07", UserName = "noah.oconnell",    NormalizedUserName = "NOAH.OCONNELL",    Email = "noah.oconnell@icloud.com",    NormalizedEmail = "NOAH.OCONNELL@ICLOUD.COM",    FirstName = "Noah",      LastName = "O'Connell",  IsActive = true, CreatedAt = new DateTime(2024,4,28), UpdatedAt = new DateTime(2024,4,28) },
        new() { Id = "u08", UserName = "mia.vandenberg",   NormalizedUserName = "MIA.VANDENBERG",   Email = "mia.vandenberg@outlook.com",  NormalizedEmail = "MIA.VANDENBERG@OUTLOOK.COM",  FirstName = "Mia",       LastName = "van den Berg",IsActive = true, CreatedAt = new DateTime(2024,5,14), UpdatedAt = new DateTime(2024,5,14) },
        new() { Id = "u09", UserName = "oliver.smith",     NormalizedUserName = "OLIVER.SMITH",     Email = "oliver.smith@gmail.com",      NormalizedEmail = "OLIVER.SMITH@GMAIL.COM",      FirstName = "Oliver",    LastName = "Smith",      IsActive = true, CreatedAt = new DateTime(2024,5,30), UpdatedAt = new DateTime(2024,5,30) },
        new() { Id = "u10", UserName = "ava.petrakis",     NormalizedUserName = "AVA.PETRAKIS",     Email = "ava.petrakis@yahoo.com",      NormalizedEmail = "AVA.PETRAKIS@YAHOO.COM",      FirstName = "Ava",       LastName = "Petrakis",   IsActive = true, CreatedAt = new DateTime(2024,6,8),  UpdatedAt = new DateTime(2024,6,8)  },
        new() { Id = "u11", UserName = "william.oduya",    NormalizedUserName = "WILLIAM.ODUYA",    Email = "william.oduya@gmail.com",     NormalizedEmail = "WILLIAM.ODUYA@GMAIL.COM",     FirstName = "William",   LastName = "Oduya",      IsActive = true, CreatedAt = new DateTime(2024,6,21), UpdatedAt = new DateTime(2024,6,21) },
        new() { Id = "u12", UserName = "charlotte.dubois", NormalizedUserName = "CHARLOTTE.DUBOIS", Email = "charlotte.dubois@gmail.com",  NormalizedEmail = "CHARLOTTE.DUBOIS@GMAIL.COM",  FirstName = "Charlotte", LastName = "Dubois",     IsActive = true, CreatedAt = new DateTime(2024,7,5),  UpdatedAt = new DateTime(2024,7,5)  },
        new() { Id = "u13", UserName = "henry.mccallister",NormalizedUserName = "HENRY.MCCALLISTER",Email = "henry.mccallister@icloud.com",NormalizedEmail = "HENRY.MCCALLISTER@ICLOUD.COM",FirstName = "Henry",     LastName = "McCallister",IsActive = true, CreatedAt = new DateTime(2024,7,19), UpdatedAt = new DateTime(2024,7,19) },
        new() { Id = "u14", UserName = "grace.yamamoto",   NormalizedUserName = "GRACE.YAMAMOTO",   Email = "grace.yamamoto@outlook.com",  NormalizedEmail = "GRACE.YAMAMOTO@OUTLOOK.COM",  FirstName = "Grace",     LastName = "Yamamoto",   IsActive = true, CreatedAt = new DateTime(2024,8,2),  UpdatedAt = new DateTime(2024,8,2)  },
        new() { Id = "u15", UserName = "benjamin.torres",  NormalizedUserName = "BENJAMIN.TORRES",  Email = "benjamin.torres@gmail.com",   NormalizedEmail = "BENJAMIN.TORRES@GMAIL.COM",   FirstName = "Benjamin",  LastName = "Torres",     IsActive = true, CreatedAt = new DateTime(2024,8,17), UpdatedAt = new DateTime(2024,8,17) },
        new() { Id = "u16", UserName = "lily.brennan",     NormalizedUserName = "LILY.BRENNAN",     Email = "lily.brennan@yahoo.com",      NormalizedEmail = "LILY.BRENNAN@YAHOO.COM",      FirstName = "Lily",      LastName = "Brennan",    IsActive = true, CreatedAt = new DateTime(2024,9,1),  UpdatedAt = new DateTime(2024,9,1)  },
        new() { Id = "u17", UserName = "sebastian.nkosi",  NormalizedUserName = "SEBASTIAN.NKOSI",  Email = "sebastian.nkosi@gmail.com",   NormalizedEmail = "SEBASTIAN.NKOSI@GMAIL.COM",   FirstName = "Sebastian", LastName = "Nkosi",      IsActive = true, CreatedAt = new DateTime(2024,9,14), UpdatedAt = new DateTime(2024,9,14) },
        new() { Id = "u18", UserName = "emma.johansson",   NormalizedUserName = "EMMA.JOHANSSON",   Email = "emma.johansson@hotmail.com",  NormalizedEmail = "EMMA.JOHANSSON@HOTMAIL.COM",  FirstName = "Emma",      LastName = "Johansson",  IsActive = true, CreatedAt = new DateTime(2024,9,28), UpdatedAt = new DateTime(2024,9,28) },
        new() { Id = "u19", UserName = "lucas.murphy",     NormalizedUserName = "LUCAS.MURPHY",     Email = "lucas.murphy@gmail.com",      NormalizedEmail = "LUCAS.MURPHY@GMAIL.COM",      FirstName = "Lucas",     LastName = "Murphy",     IsActive = true, CreatedAt = new DateTime(2024,10,12),UpdatedAt = new DateTime(2024,10,12)},
        new() { Id = "u20", UserName = "chloe.martineau",  NormalizedUserName = "CHLOE.MARTINEAU",  Email = "chloe.martineau@outlook.com", NormalizedEmail = "CHLOE.MARTINEAU@OUTLOOK.COM", FirstName = "Chloe",     LastName = "Martineau",  IsActive = true, CreatedAt = new DateTime(2024,10,25),UpdatedAt = new DateTime(2024,10,25)},
    };


            foreach (var u in users)
                u.PasswordHash = hasher.HashPassword(u, "Password123!");

            modelBuilder.Entity<User>().HasData(users);


            var avatarUrls = new[]
            {
        "https://images.unsplash.com/photo-1500648767791-00dcc994a43e?w=400&q=80",
        "https://images.unsplash.com/photo-1494790108377-be9c29b29330?w=400&q=80",
        "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?w=400&q=80",
        "https://images.unsplash.com/photo-1438761681033-6461ffad8d80?w=400&q=80",
        "https://images.unsplash.com/photo-1472099645785-5658abf4ff4e?w=400&q=80",
        "https://images.unsplash.com/photo-1544005313-94ddf0286df2?w=400&q=80",
    };

            var bios = new[]
            {
        "Frequent business traveller and hotel enthusiast. Always hunting for the best rooftop bar.",
        "Digital nomad exploring a new city every month. Coffee lover and architecture geek.",
        "Family travel specialist — I always find the best suites with space for the kids.",
        "Solo adventurer with a passion for local cuisine and boutique properties.",
        "Luxury travel blogger. I review every hotel I stay in, honestly.",
        "Weekend road tripper. I prefer cozy inns over big chains whenever possible.",
        "Corporate consultant who lives out of hotel rooms. I value comfort and fast Wi-Fi above all.",
        "Retired teacher now ticking off her bucket-list destinations one hotel at a time.",
        "Nature photographer who needs hotels close to hiking trails and national parks.",
        "Honeymooner and romance travel specialist. Suites with a view are non-negotiable.",
    };

            var profileCities = new[] { "New York", "Los Angeles", "Chicago", "Miami", "San Francisco", "Seattle", "Boston", "Austin", "Denver", "Orlando", "Las Vegas", "Portland", "San Diego", "Honolulu", "Atlanta", "Philadelphia", "Dallas", "Phoenix", "Minneapolis", "Nashville" };

            var profiles = new List<UserProfile>();
            for (int i = 0; i < users.Count; i++)
            {
                profiles.Add(new UserProfile
                {
                    Id = i + 1,
                    UserId = users[i].Id,
                    Address = $"{100 + i * 7} {new[] { "Oak", "Maple", "Cedar", "Birch", "Elm", "Pine", "Walnut", "Ash" }[i % 8]} Street",
                    City = profileCities[i],
                    DateOfBirth = new DateTime(1985 + (i % 15), (i % 12) + 1, (i % 28) + 1),
                    AvatarUrl = avatarUrls[i % avatarUrls.Length],
                    Bio = bios[i % bios.Length],
                    CreatedAt = users[i].CreatedAt,
                    UpdatedAt = users[i].UpdatedAt,
                });
            }
            modelBuilder.Entity<UserProfile>().HasData(profiles);


            var reviewComments = new[]
            {
        "Absolutely stunning hotel. The rooftop bar had incredible views and the staff went out of their way to make our anniversary special. Will definitely return.",
        "Great location right in the heart of the city. Room was spotless and the bed was incredibly comfortable. Breakfast buffet was a highlight.",
        "The spa facilities were world-class. I spent two hours there and left feeling completely refreshed. The massage therapist was phenomenal.",
        "Decent hotel for the price. Check-in was smooth, room was clean, but the Wi-Fi was slow and the air conditioning made an odd noise at night.",
        "The suite was enormous and beautifully designed. We had a full living area, jacuzzi, and a private terrace overlooking the ocean. Worth every penny.",
        "Service was inconsistent — front desk staff were helpful but housekeeping missed our room on day two. Management did apologise and provided a discount.",
        "Perfect for families. The kids' pool area kept our children entertained all day and the on-site restaurant had a solid children's menu.",
        "The concierge arranged a private city tour for us which was the highlight of our trip. This hotel goes above and beyond for its guests.",
        "Average experience overall. The room was smaller than photos suggested and parking was expensive. Convenient location saved it from a lower rating.",
        "One of the best hotels I have ever stayed in. Every detail was considered, from the pillow menu to the complimentary evening wine hour.",
        "The mountain views from our room were breathtaking. Woke up every morning to misty peaks — an unforgettable experience.",
        "Check-in took over 45 minutes despite having a reservation. Once in the room, however, the experience improved significantly.",
        "The beachfront location is unmatched. We could step directly from our balcony onto the sand. The sunset cocktail hour was a lovely touch.",
        "Very stylish interiors. Instagram-worthy lobby, great playlist in the bar. Rooms were on the smaller side but perfectly appointed.",
        "The fitness centre had brand-new equipment and was open 24 hours — perfect for early morning workouts before conference sessions.",
        "Outstanding buffet breakfast with locally sourced ingredients. The smoked salmon and artisan cheeses were exceptional.",
        "Quiet and peaceful despite being in a central location. Soundproofing was impressive. Slept better here than I do at home.",
        "The pool area was crowded in the afternoon but the staff managed towels and sun loungers efficiently. Evening swim was perfect.",
        "Room service arrived within 20 minutes every time we ordered. The club sandwich was genuinely one of the best I have ever eaten.",
        "A true hidden gem. Not as well-known as nearby properties but far superior in service, comfort, and value for money.",
    };

            var reviewStatuses = new[]
            {
        ReviewStatuses.Approved, ReviewStatuses.Approved, ReviewStatuses.Approved,
        ReviewStatuses.Pending,  ReviewStatuses.Approved, ReviewStatuses.Approved,
        ReviewStatuses.Approved, ReviewStatuses.Pending,  ReviewStatuses.Rejected,
        ReviewStatuses.Approved, ReviewStatuses.Approved, ReviewStatuses.Approved,
        ReviewStatuses.Pending,  ReviewStatuses.Approved, ReviewStatuses.Approved,
        ReviewStatuses.Approved, ReviewStatuses.Rejected, ReviewStatuses.Approved,
        ReviewStatuses.Pending,  ReviewStatuses.Approved,
    };

            var reviews = new List<Review>();
            for (int i = 0; i < 20; i++)
            {
                reviews.Add(new Review
                {
                    ReviewID = i + 1,
                    UserID = users[i].Id,
                    HotelID = (i % hotels.Count) + 1,
                    Rating = new[] { 5, 4, 5, 3, 5, 3, 4, 5, 3, 5, 5, 2, 5, 4, 4, 5, 4, 4, 4, 5 }[i],
                    Comment = reviewComments[i],
                    ReviewDate = new DateTime(2024, 11, 1).AddDays(i * 3),
                    Status = reviewStatuses[i],
                });
            }
            modelBuilder.Entity<Review>().HasData(reviews);


            var bookingRoomIds = new[] { 1, 2, 4, 5, 6, 7, 8, 10, 12, 13, 14, 15, 16, 18, 19, 20, 21, 22, 24, 25 };
            var nights = new[] { 2, 3, 1, 4, 2, 3, 5, 2, 1, 3, 2, 3, 4, 2, 3, 1, 2, 4, 3, 2 };

            var bookings = new List<Booking>();
            for (int i = 0; i < 20; i++)
            {
                var room = rooms.First(r => r.RoomID == bookingRoomIds[i]);
                var roomType = roomTypes.First(rt => rt.TypeID == room.TypeID);
                var checkIn = new DateTime(2025, 1, 1).AddDays(i * 12);
                var checkOut = checkIn.AddDays(nights[i]);

                bookings.Add(new Booking
                {
                    BookingID = i + 1,
                    UserID = users[i].Id,
                    RoomID = room.RoomID,
                    CheckInDate = checkIn,
                    CheckOutDate = checkOut,
                    TotalPrice = roomType.BasePrice * nights[i],
                    CreatedAt = checkIn.AddDays(-14),
                });
            }
            modelBuilder.Entity<Booking>().HasData(bookings);
        }

    }
}

