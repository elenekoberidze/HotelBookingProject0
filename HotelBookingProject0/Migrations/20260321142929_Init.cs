using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingProject0.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "hotels",
                columns: table => new
                {
                    HotelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    city = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotels", x => x.HotelID);
                });

            migrationBuilder.CreateTable(
                name: "RoomTypes",
                columns: table => new
                {
                    TypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomTypes", x => x.TypeID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReplacedByToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AvatarUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Amenities",
                columns: table => new
                {
                    AmenityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HotelID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amenities", x => x.AmenityID);
                    table.ForeignKey(
                        name: "FK_Amenities_hotels_HotelID",
                        column: x => x.HotelID,
                        principalTable: "hotels",
                        principalColumn: "HotelID");
                });

            migrationBuilder.CreateTable(
                name: "HotelImages",
                columns: table => new
                {
                    ImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelID = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HotelImages", x => x.ImageID);
                    table.ForeignKey(
                        name: "FK_HotelImages_hotels_HotelID",
                        column: x => x.HotelID,
                        principalTable: "hotels",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HotelID = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminNote = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewID);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_hotels_HotelID",
                        column: x => x.HotelID,
                        principalTable: "hotels",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelID = table.Column<int>(type: "int", nullable: false),
                    TypeID = table.Column<int>(type: "int", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_Rooms_RoomTypes_TypeID",
                        column: x => x.TypeID,
                        principalTable: "RoomTypes",
                        principalColumn: "TypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rooms_hotels_HotelID",
                        column: x => x.HotelID,
                        principalTable: "hotels",
                        principalColumn: "HotelID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AmenityRoom",
                columns: table => new
                {
                    AmenitiesAmenityID = table.Column<int>(type: "int", nullable: false),
                    RoomsRoomID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmenityRoom", x => new { x.AmenitiesAmenityID, x.RoomsRoomID });
                    table.ForeignKey(
                        name: "FK_AmenityRoom_Amenities_AmenitiesAmenityID",
                        column: x => x.AmenitiesAmenityID,
                        principalTable: "Amenities",
                        principalColumn: "AmenityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmenityRoom_Rooms_RoomsRoomID",
                        column: x => x.RoomsRoomID,
                        principalTable: "Rooms",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoomID = table.Column<int>(type: "int", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingID);
                    table.ForeignKey(
                        name: "FK_Bookings_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomImages",
                columns: table => new
                {
                    ImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomID = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomImages", x => x.ImageID);
                    table.ForeignKey(
                        name: "FK_RoomImages_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Amenities",
                columns: new[] { "AmenityID", "HotelID", "Name" },
                values: new object[,]
                {
                    { 1, null, "Free Wi-Fi" },
                    { 2, null, "Air Conditioning" },
                    { 3, null, "Breakfast Included" },
                    { 4, null, "Free Parking" },
                    { 5, null, "Swimming Pool" },
                    { 6, null, "Spa & Wellness Centre" },
                    { 7, null, "Fitness Center" },
                    { 8, null, "On-site Restaurant" },
                    { 9, null, "Rooftop Bar" },
                    { 10, null, "24-hour Room Service" },
                    { 11, null, "Pet Friendly" },
                    { 12, null, "Non-smoking Rooms" },
                    { 13, null, "Airport Shuttle" },
                    { 14, null, "Laundry Service" },
                    { 15, null, "24-hour Front Desk" },
                    { 16, null, "Business Center" },
                    { 17, null, "Concierge Service" },
                    { 18, null, "Children's Activities" },
                    { 19, null, "Sauna" },
                    { 20, null, "Beach / Waterfront Access" },
                    { 21, null, "Electric Vehicle Charging" },
                    { 22, null, "Bike Rental" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "u01", 0, "e7408aea-340b-4256-a3d4-8554fa21e64a", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.hartwell@gmail.com", false, "James", true, "Hartwell", false, null, "JAMES.HARTWELL@GMAIL.COM", "JAMES.HARTWELL", "AQAAAAIAAYagAAAAEIlfhA4iuXbmCRfe3M1tNY8ggHsuglRn9gg4XWwVEo02XqgCdhumzrqH5bOzwAhorA==", null, false, "af333467-df8b-4cea-a696-2835c253140f", false, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "james.hartwell" },
                    { "u02", 0, "03deb43d-6e59-41a2-a9af-9e45e1cbbde3", new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophia.chen@outlook.com", false, "Sophia", true, "Chen", false, null, "SOPHIA.CHEN@OUTLOOK.COM", "SOPHIA.CHEN", "AQAAAAIAAYagAAAAEH/65N/F/ZmNHzRESlDm9uQq8yDRtsRrkCfoKSTKaC2dLFPw6qYrdjyY7O4wi2KUlw==", null, false, "2337a811-05bb-4118-b5a3-7d274493e1b5", false, new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophia.chen" },
                    { "u03", 0, "6d5df4a0-d3f0-47e9-9947-f4279c4717fc", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "luca.ferrari@hotmail.com", false, "Luca", true, "Ferrari", false, null, "LUCA.FERRARI@HOTMAIL.COM", "LUCA.FERRARI", "AQAAAAIAAYagAAAAEKzIqq1N6jNBXV2GUPA5UAaLk8CoKRZ0eLo8LTdjAV4XEf3hEgFsJIGyMN3OxvP09A==", null, false, "e27fdd17-7891-4524-9f11-ca31fa4bca5d", false, new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "luca.ferrari" },
                    { "u04", 0, "7a7a2c96-82ff-4f8d-9c44-81ad40b25519", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "amelia.nguyen@yahoo.com", false, "Amelia", true, "Nguyen", false, null, "AMELIA.NGUYEN@YAHOO.COM", "AMELIA.NGUYEN", "AQAAAAIAAYagAAAAEHCJeHwWFekub/zYrSXYUS6GNOpMX6EcEgl4RvPYyFpkjOYe6qRv+28kGPl/iuKfpg==", null, false, "64facf6b-4173-44b7-bb28-b878f39853fa", false, new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "amelia.nguyen" },
                    { "u05", 0, "d26a5f15-7010-4487-b3a1-ec7f4bc52991", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ethan.kovacs@gmail.com", false, "Ethan", true, "Kovacs", false, null, "ETHAN.KOVACS@GMAIL.COM", "ETHAN.KOVACS", "AQAAAAIAAYagAAAAEKB4d9oehYHmwXuBvJbmfRx7Kw/aSdVsLscHbIyXKdglinDO3KjVCTSjc2nesOHiQQ==", null, false, "64199dc2-f7ba-4e3c-b0c3-f63fcdf576e5", false, new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "ethan.kovacs" },
                    { "u06", 0, "52bf9df6-a92f-417f-ac16-59b184aaea4f", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "isabella.ramos@gmail.com", false, "Isabella", true, "Ramos", false, null, "ISABELLA.RAMOS@GMAIL.COM", "ISABELLA.RAMOS", "AQAAAAIAAYagAAAAEMUfXn+DAP1tqDklKFdNe9tscGOwu8E2vF/y228x7fMezpIE1M4PnWrY22I8iwpnTA==", null, false, "2f62caac-e6d7-448a-9b09-f7f9f4bfd6bb", false, new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "isabella.ramos" },
                    { "u07", 0, "8a22a0d2-68f2-45ae-b31d-02e6de0dbe20", new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "noah.oconnell@icloud.com", false, "Noah", true, "O'Connell", false, null, "NOAH.OCONNELL@ICLOUD.COM", "NOAH.OCONNELL", "AQAAAAIAAYagAAAAECchBaYD2i3lqmrVEXcK7PbvxB8hZGNqtjoumkBJ6Kj8gcs9z+YA+lLcY5rR4INpsQ==", null, false, "21321a98-ad9f-4741-b8f5-7c64d318490d", false, new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "noah.oconnell" },
                    { "u08", 0, "ff37fb25-aa3a-4352-ad47-1f5291d9ea44", new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "mia.vandenberg@outlook.com", false, "Mia", true, "van den Berg", false, null, "MIA.VANDENBERG@OUTLOOK.COM", "MIA.VANDENBERG", "AQAAAAIAAYagAAAAEIyx3rZUrcpTrpxPEe9Yux7TYTE7kJae01JMJyvQ79zPm7DsQaGPIKGDvDq+1ZUvHw==", null, false, "5968e694-ccea-4ddd-a602-dc356312e9a4", false, new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "mia.vandenberg" },
                    { "u09", 0, "2f654a4e-c4ad-4b55-a106-d381e5ac933c", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "oliver.smith@gmail.com", false, "Oliver", true, "Smith", false, null, "OLIVER.SMITH@GMAIL.COM", "OLIVER.SMITH", "AQAAAAIAAYagAAAAEMMPBA0usdVVrXYLGgJL9TCOXgC7r1OZcATtzqSEMEAp9fdoA7lnOl7xQGn5V+lAIw==", null, false, "139c09f8-23f9-4bae-91cf-d65896eb97d7", false, new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "oliver.smith" },
                    { "u10", 0, "e8cb0943-cbba-433d-8cac-fa3e42aea881", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ava.petrakis@yahoo.com", false, "Ava", true, "Petrakis", false, null, "AVA.PETRAKIS@YAHOO.COM", "AVA.PETRAKIS", "AQAAAAIAAYagAAAAEFcNafZqUbuScKrnp4FCbJdkAvPwVcQQJ/KJkxX7Yhye8MmXf1Zvp0f9WGIz/G/EeA==", null, false, "5268ebb9-ab62-45f3-8cf1-43121f2f9c09", false, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "ava.petrakis" },
                    { "u11", 0, "114d3b31-3cbc-4869-a9ab-fbda66afc6b4", new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "william.oduya@gmail.com", false, "William", true, "Oduya", false, null, "WILLIAM.ODUYA@GMAIL.COM", "WILLIAM.ODUYA", "AQAAAAIAAYagAAAAEItjqX+LiVJcs/fMw43DKttDWI6pB+CJUOwJ/OoGsLCCIp4s8raWDPIY2DlMgj+5hA==", null, false, "7a20fd39-ed7d-478e-b6bb-29eac0ec545b", false, new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "william.oduya" },
                    { "u12", 0, "3aa2bf5a-78d5-473d-a452-47e05125e98e", new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "charlotte.dubois@gmail.com", false, "Charlotte", true, "Dubois", false, null, "CHARLOTTE.DUBOIS@GMAIL.COM", "CHARLOTTE.DUBOIS", "AQAAAAIAAYagAAAAEA7J8/R5FySFavEShmFEIQ1dsqV4gsh6OVDxeaht5x7btMzb5yZIz0XVLOrIMSMfSQ==", null, false, "8d8d7883-293a-4cb9-b4d8-b0bc0dc34ca9", false, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "charlotte.dubois" },
                    { "u13", 0, "9cfbbd1c-c5d0-4fbd-9d50-c6d70d953d22", new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "henry.mccallister@icloud.com", false, "Henry", true, "McCallister", false, null, "HENRY.MCCALLISTER@ICLOUD.COM", "HENRY.MCCALLISTER", "AQAAAAIAAYagAAAAEHGmkqp8fqm+wS7c6blv+NXbQr/sf9f3ls5OVDGfoe6guTEtYmGe6Hb7hhhNlIxivA==", null, false, "474230dd-1753-43df-87d9-0beafcf51b6f", false, new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "henry.mccallister" },
                    { "u14", 0, "ad304ef6-7972-4520-8604-7e40b2844c48", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "grace.yamamoto@outlook.com", false, "Grace", true, "Yamamoto", false, null, "GRACE.YAMAMOTO@OUTLOOK.COM", "GRACE.YAMAMOTO", "AQAAAAIAAYagAAAAELHJmlmz/FmFacNYZNl2xahOAJsUwyuM1gVSsYB4LgwEpdprrZT59u/WoZAw3ihfHA==", null, false, "07dd422d-250e-44e4-ab2e-d886459f31a9", false, new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "grace.yamamoto" },
                    { "u15", 0, "df9f9722-a5ef-44d3-8ad3-c9ee41bb8359", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "benjamin.torres@gmail.com", false, "Benjamin", true, "Torres", false, null, "BENJAMIN.TORRES@GMAIL.COM", "BENJAMIN.TORRES", "AQAAAAIAAYagAAAAEM5gIpQ4cpRnnDbNCN9TBp/mRWX3f1xm4Q7NHM9kOrQZ7GikyMezV6lyz20bBVB/KA==", null, false, "b0c44ed0-6251-4d12-87ae-4a5fe1fc852b", false, new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "benjamin.torres" },
                    { "u16", 0, "29264aa8-2bac-47e6-89d3-eea33c2c30f4", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lily.brennan@yahoo.com", false, "Lily", true, "Brennan", false, null, "LILY.BRENNAN@YAHOO.COM", "LILY.BRENNAN", "AQAAAAIAAYagAAAAEJ4VEEBbtYaCAEoE7mxs+2kyDdF7s7t9Ezn3BzEwWaLllu9Q2yavVDznwxGKitZUJg==", null, false, "e7975423-3cb6-41d7-8b7b-09e3702bbd8c", false, new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lily.brennan" },
                    { "u17", 0, "bcbffcd2-7525-4e86-a248-92c7ffa63a11", new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "sebastian.nkosi@gmail.com", false, "Sebastian", true, "Nkosi", false, null, "SEBASTIAN.NKOSI@GMAIL.COM", "SEBASTIAN.NKOSI", "AQAAAAIAAYagAAAAEL4cPe9YrigNoSJWJs13a9bw/2gKXctIc43osikBcLNQ5ulSsujTHcsCrwDKe1H/+w==", null, false, "087a7644-084e-4cb0-ae45-b6f2ec07335a", false, new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "sebastian.nkosi" },
                    { "u18", 0, "90729545-8c20-4e6e-8bea-95c4d6db1e27", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "emma.johansson@hotmail.com", false, "Emma", true, "Johansson", false, null, "EMMA.JOHANSSON@HOTMAIL.COM", "EMMA.JOHANSSON", "AQAAAAIAAYagAAAAEJY2PQPziIkj5k6OvWfgj64v3+URskxmoCeiyW0C/B2cI8TTJTMnvtinTVvZvvmHcw==", null, false, "33804e76-a215-47b1-8fda-4302ad6ca263", false, new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "emma.johansson" },
                    { "u19", 0, "449046d6-526d-420a-a342-91b23c08c8bc", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "lucas.murphy@gmail.com", false, "Lucas", true, "Murphy", false, null, "LUCAS.MURPHY@GMAIL.COM", "LUCAS.MURPHY", "AQAAAAIAAYagAAAAEA74uJ5xvjThQXSwIiPWjVsZ0BKulXMQSxZG8fh89+V6lM0H54CwFSyJY29ZqakwTg==", null, false, "86b76b34-aa11-49b4-9e0c-49dddb3663b6", false, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "lucas.murphy" },
                    { "u20", 0, "350d116a-edcd-4170-8837-cda19ae44a81", new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "chloe.martineau@outlook.com", false, "Chloe", true, "Martineau", false, null, "CHLOE.MARTINEAU@OUTLOOK.COM", "CHLOE.MARTINEAU", "AQAAAAIAAYagAAAAECRj7vl7XsOHTEEZfyAGWmUoFPcfKttaRiwU5bZF8kJG0OpLP8UFL/Gt00VrXo8MfQ==", null, false, "ea415f16-9615-4916-8f55-29ffcd9189bb", false, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "chloe.martineau" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "TypeID", "BasePrice", "TypeName" },
                values: new object[,]
                {
                    { 1, 79.00m, "Single" },
                    { 2, 119.00m, "Double" },
                    { 3, 129.00m, "Twin" },
                    { 4, 249.00m, "Suite" },
                    { 5, 319.00m, "Deluxe" }
                });

            migrationBuilder.InsertData(
                table: "hotels",
                columns: new[] { "HotelID", "address", "city", "description", "name", "rating", "status" },
                values: new object[,]
                {
                    { 1, "12 West 57th Street, New York, NY 10019", "New York", "An iconic Midtown Manhattan hotel with Art Deco interiors, panoramic Central Park views, a rooftop lounge, and a Michelin-starred restaurant.", "The Whitmore Grand", 5, 0 },
                    { 2, "7220 Pacific Coast Highway, Malibu, CA 90265", "Los Angeles", "A cliffside resort hugging the California coastline, featuring private beach access, infinity pools, and sunset views over the Pacific.", "Malibu Crest Resort", 5, 0 },
                    { 3, "680 N Lake Shore Drive, Chicago, IL 60611", "Chicago", "A stylish boutique hotel on the shores of Lake Michigan, steps from Navy Pier and the Magnificent Mile, with a rooftop bar and spa.", "Lakeshore Boutique Hotel", 4, 0 },
                    { 4, "1901 Brickell Avenue, Miami, FL 33129", "Miami", "A sleek urban retreat in Miami's financial district, with bay views, a rooftop infinity pool, and a vibrant lobby bar.", "Brickell Bay Hotel", 4, 0 },
                    { 5, "200 Embarcadero, San Francisco, CA 94105", "San Francisco", "Luxury waterfront suites overlooking the Bay Bridge, offering farm-to-table dining, a wine cellar, and tech-forward amenities.", "Embarcadero Suites", 5, 0 },
                    { 6, "94 Pike Street, Seattle, WA 98101", "Seattle", "A cozy lodge-inspired hotel a block from Pike Place Market, with locally sourced breakfast, fireside lounges, and mountain views.", "Pike Street Lodge", 3, 0 },
                    { 7, "21 Mount Vernon Street, Boston, MA 02108", "Boston", "A landmark Federal-style manor on Beacon Hill, offering curated historical tours, a wood-panelled library bar, and rooms with four-poster beds.", "Beacon Hill Manor", 4, 0 },
                    { 8, "1603 South Congress Ave, Austin, TX 78704", "Austin", "An eclectic boutique inn in Austin's trendiest corridor, with live music on weekends, local craft cocktails, and a rooftop terrace.", "South Congress Inn", 3, 0 },
                    { 9, "1600 Glenarm Place, Denver, CO 80202", "Denver", "A mountain-modern resort with ski concierge services, heated outdoor pools, a summit-view spa, and direct Rocky Mountain trail access.", "Rocky Peak Resort", 4, 0 },
                    { 10, "8978 International Drive, Orlando, FL 32819", "Orlando", "Spacious family suites minutes from Walt Disney World, Universal Studios, and SeaWorld, with a lazy river pool and nightly themed entertainment.", "International Drive Suites", 3, 0 },
                    { 11, "3325 Las Vegas Boulevard S, Las Vegas, NV 89109", "Las Vegas", "An all-suite luxury tower inspired by Venetian palazzos, featuring a grand casino floor, celebrity chef restaurants, a canyon ranch spa, and butler service.", "The Palazzo Venetian", 5, 0 },
                    { 12, "314 NW 11th Avenue, Portland, OR 97209", "Portland", "A design-forward hotel in Portland's Pearl District gallery neighbourhood, with locally roasted coffee, vegan menus, and bike rental.", "Pearl District Hotel", 3, 0 },
                    { 13, "1355 N Harbor Drive, San Diego, CA 92101", "San Diego", "A nautical-themed waterfront hotel overlooking San Diego Bay, with yacht charters, a sailor's taproom, and freshly caught seafood dining.", "Harbor View Hotel", 4, 0 },
                    { 14, "2552 Kalakaua Avenue, Honolulu, HI 96815", "Honolulu", "A beachfront Hawaiian resort with oceanfront lanais, traditional luau evenings, snorkelling excursions, and a rejuvenating lomi-lomi spa.", "Waikiki Horizon Resort", 5, 0 },
                    { 15, "188 14th Street NE, Atlanta, GA 30309", "Atlanta", "A glass-facade tower in Midtown Atlanta near the High Museum of Art, featuring a sky pool, craft cocktail bar, and executive conference suites.", "Midtown Atlanta Tower", 4, 0 },
                    { 16, "235 Chestnut Street, Philadelphia, PA 19106", "Philadelphia", "A colonial-inspired hotel one block from Independence Hall, with cobblestone courtyards, a cheesesteak brunch menu, and period-accurate room décor.", "Independence Square Hotel", 3, 0 },
                    { 17, "2101 Cedar Springs Road, Dallas, TX 75201", "Dallas", "Contemporary urban residences in Dallas' Uptown neighbourhood, with a rooftop terrace, pool, fully equipped kitchens, and pet-friendly policies.", "Uptown Dallas Residences", 3, 0 },
                    { 18, "5402 E Lincoln Drive, Scottsdale, AZ 85253", "Phoenix", "A Sonoran Desert retreat at the foot of Camelback Mountain, offering outdoor mineral pools, world-class spa treatments, and adobe casita rooms.", "Camelback Desert Spa", 4, 0 },
                    { 19, "100 Nicollet Mall, Minneapolis, MN 55402", "Minneapolis", "A well-appointed urban hotel on Minneapolis' main promenade, with skyway access, a jazz bar, and proximity to the Guthrie Theater.", "Nicollet Mall Hotel", 3, 0 },
                    { 20, "301 Broadway, Nashville, TN 37201", "Nashville", "Nashville's premier music-themed hotel steps from Honky Tonk Highway, with a recording studio lounge, live country music nightly, and guitar-shaped pool.", "Broadway Rhythm Hotel", 4, 0 }
                });

            migrationBuilder.InsertData(
                table: "HotelImages",
                columns: new[] { "ImageID", "HotelID", "ImageURL", "IsPrimary" },
                values: new object[,]
                {
                    { 1, 1, "https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1600&q=80", true },
                    { 2, 1, "https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1600&q=80", false },
                    { 3, 1, "https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1600&q=80", false },
                    { 4, 2, "https://images.unsplash.com/photo-1551882547-ff40c63fe5fa?w=1600&q=80", true },
                    { 5, 2, "https://images.unsplash.com/photo-1496417263034-38ec4f0b665a?w=1600&q=80", false },
                    { 6, 2, "https://images.unsplash.com/photo-1571003123894-1f0594d2b5d9?w=1600&q=80", false },
                    { 7, 3, "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1600&q=80", true },
                    { 8, 3, "https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1600&q=80", false },
                    { 9, 3, "https://images.unsplash.com/photo-1584132967334-10e028bd69f7?w=1600&q=80", false },
                    { 10, 4, "https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1600&q=80", true },
                    { 11, 4, "https://images.unsplash.com/photo-1571003123894-1f0594d2b5d9?w=1600&q=80", false },
                    { 12, 4, "https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1600&q=80", false },
                    { 13, 5, "https://images.unsplash.com/photo-1496417263034-38ec4f0b665a?w=1600&q=80", true },
                    { 14, 5, "https://images.unsplash.com/photo-1584132967334-10e028bd69f7?w=1600&q=80", false },
                    { 15, 5, "https://images.unsplash.com/photo-1551882547-ff40c63fe5fa?w=1600&q=80", false },
                    { 16, 6, "https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1600&q=80", true },
                    { 17, 6, "https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1600&q=80", false },
                    { 18, 6, "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1600&q=80", false },
                    { 19, 7, "https://images.unsplash.com/photo-1571003123894-1f0594d2b5d9?w=1600&q=80", true },
                    { 20, 7, "https://images.unsplash.com/photo-1551882547-ff40c63fe5fa?w=1600&q=80", false },
                    { 21, 7, "https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1600&q=80", false },
                    { 22, 8, "https://images.unsplash.com/photo-1584132967334-10e028bd69f7?w=1600&q=80", true },
                    { 23, 8, "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1600&q=80", false },
                    { 24, 8, "https://images.unsplash.com/photo-1496417263034-38ec4f0b665a?w=1600&q=80", false },
                    { 25, 9, "https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1600&q=80", true },
                    { 26, 9, "https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1600&q=80", false },
                    { 27, 9, "https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1600&q=80", false },
                    { 28, 10, "https://images.unsplash.com/photo-1551882547-ff40c63fe5fa?w=1600&q=80", true },
                    { 29, 10, "https://images.unsplash.com/photo-1496417263034-38ec4f0b665a?w=1600&q=80", false },
                    { 30, 10, "https://images.unsplash.com/photo-1571003123894-1f0594d2b5d9?w=1600&q=80", false },
                    { 31, 11, "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1600&q=80", true },
                    { 32, 11, "https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1600&q=80", false },
                    { 33, 11, "https://images.unsplash.com/photo-1584132967334-10e028bd69f7?w=1600&q=80", false },
                    { 34, 12, "https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1600&q=80", true },
                    { 35, 12, "https://images.unsplash.com/photo-1571003123894-1f0594d2b5d9?w=1600&q=80", false },
                    { 36, 12, "https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1600&q=80", false },
                    { 37, 13, "https://images.unsplash.com/photo-1496417263034-38ec4f0b665a?w=1600&q=80", true },
                    { 38, 13, "https://images.unsplash.com/photo-1584132967334-10e028bd69f7?w=1600&q=80", false },
                    { 39, 13, "https://images.unsplash.com/photo-1551882547-ff40c63fe5fa?w=1600&q=80", false },
                    { 40, 14, "https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1600&q=80", true },
                    { 41, 14, "https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1600&q=80", false },
                    { 42, 14, "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1600&q=80", false },
                    { 43, 15, "https://images.unsplash.com/photo-1571003123894-1f0594d2b5d9?w=1600&q=80", true },
                    { 44, 15, "https://images.unsplash.com/photo-1551882547-ff40c63fe5fa?w=1600&q=80", false },
                    { 45, 15, "https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1600&q=80", false },
                    { 46, 16, "https://images.unsplash.com/photo-1584132967334-10e028bd69f7?w=1600&q=80", true },
                    { 47, 16, "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1600&q=80", false },
                    { 48, 16, "https://images.unsplash.com/photo-1496417263034-38ec4f0b665a?w=1600&q=80", false },
                    { 49, 17, "https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1600&q=80", true },
                    { 50, 17, "https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1600&q=80", false },
                    { 51, 17, "https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1600&q=80", false },
                    { 52, 18, "https://images.unsplash.com/photo-1551882547-ff40c63fe5fa?w=1600&q=80", true },
                    { 53, 18, "https://images.unsplash.com/photo-1496417263034-38ec4f0b665a?w=1600&q=80", false },
                    { 54, 18, "https://images.unsplash.com/photo-1571003123894-1f0594d2b5d9?w=1600&q=80", false },
                    { 55, 19, "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?w=1600&q=80", true },
                    { 56, 19, "https://images.unsplash.com/photo-1582719478250-c89cae4dc85b?w=1600&q=80", false },
                    { 57, 19, "https://images.unsplash.com/photo-1584132967334-10e028bd69f7?w=1600&q=80", false },
                    { 58, 20, "https://images.unsplash.com/photo-1445019980597-93fa8acb246c?w=1600&q=80", true },
                    { 59, 20, "https://images.unsplash.com/photo-1571003123894-1f0594d2b5d9?w=1600&q=80", false },
                    { 60, 20, "https://images.unsplash.com/photo-1566073771259-6a8506099945?w=1600&q=80", false }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "AdminNote", "Comment", "HotelID", "Rating", "ReviewDate", "Status", "UserID" },
                values: new object[,]
                {
                    { 1, null, "Absolutely stunning hotel. The rooftop bar had incredible views and the staff went out of their way to make our anniversary special. Will definitely return.", 1, 5, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", "u01" },
                    { 2, null, "Great location right in the heart of the city. Room was spotless and the bed was incredibly comfortable. Breakfast buffet was a highlight.", 2, 4, new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", "u02" },
                    { 3, null, "The spa facilities were world-class. I spent two hours there and left feeling completely refreshed. The massage therapist was phenomenal.", 3, 5, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", "u03" },
                    { 4, null, "Decent hotel for the price. Check-in was smooth, room was clean, but the Wi-Fi was slow and the air conditioning made an odd noise at night.", 4, 3, new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", "u04" },
                    { 5, null, "The suite was enormous and beautifully designed. We had a full living area, jacuzzi, and a private terrace overlooking the ocean. Worth every penny.", 5, 5, new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", "u05" },
                    { 6, null, "Service was inconsistent — front desk staff were helpful but housekeeping missed our room on day two. Management did apologise and provided a discount.", 6, 3, new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", "u06" },
                    { 7, null, "Perfect for families. The kids' pool area kept our children entertained all day and the on-site restaurant had a solid children's menu.", 7, 4, new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", "u07" },
                    { 8, null, "The concierge arranged a private city tour for us which was the highlight of our trip. This hotel goes above and beyond for its guests.", 8, 5, new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", "u08" },
                    { 9, null, "Average experience overall. The room was smaller than photos suggested and parking was expensive. Convenient location saved it from a lower rating.", 9, 3, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected", "u09" },
                    { 10, null, "One of the best hotels I have ever stayed in. Every detail was considered, from the pillow menu to the complimentary evening wine hour.", 10, 5, new DateTime(2024, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", "u10" },
                    { 11, null, "The mountain views from our room were breathtaking. Woke up every morning to misty peaks — an unforgettable experience.", 11, 5, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", "u11" },
                    { 12, null, "Check-in took over 45 minutes despite having a reservation. Once in the room, however, the experience improved significantly.", 12, 2, new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", "u12" },
                    { 13, null, "The beachfront location is unmatched. We could step directly from our balcony onto the sand. The sunset cocktail hour was a lovely touch.", 13, 5, new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", "u13" },
                    { 14, null, "Very stylish interiors. Instagram-worthy lobby, great playlist in the bar. Rooms were on the smaller side but perfectly appointed.", 14, 4, new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", "u14" },
                    { 15, null, "The fitness centre had brand-new equipment and was open 24 hours — perfect for early morning workouts before conference sessions.", 15, 4, new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", "u15" },
                    { 16, null, "Outstanding buffet breakfast with locally sourced ingredients. The smoked salmon and artisan cheeses were exceptional.", 16, 5, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", "u16" },
                    { 17, null, "Quiet and peaceful despite being in a central location. Soundproofing was impressive. Slept better here than I do at home.", 17, 4, new DateTime(2024, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rejected", "u17" },
                    { 18, null, "The pool area was crowded in the afternoon but the staff managed towels and sun loungers efficiently. Evening swim was perfect.", 18, 4, new DateTime(2024, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", "u18" },
                    { 19, null, "Room service arrived within 20 minutes every time we ordered. The club sandwich was genuinely one of the best I have ever eaten.", 19, 4, new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", "u19" },
                    { 20, null, "A true hidden gem. Not as well-known as nearby properties but far superior in service, comfort, and value for money.", 20, 5, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Approved", "u20" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomID", "HotelID", "IsAvailable", "RoomNumber", "TypeID" },
                values: new object[,]
                {
                    { 1, 1, true, "101", 1 },
                    { 2, 1, true, "412", 4 },
                    { 3, 1, false, "PH1", 5 },
                    { 4, 2, true, "201", 2 },
                    { 5, 2, true, "OV1", 5 },
                    { 6, 3, true, "205", 2 },
                    { 7, 3, true, "307", 3 },
                    { 8, 4, true, "102", 1 },
                    { 9, 4, false, "501", 4 },
                    { 10, 5, true, "WF2", 4 },
                    { 11, 5, true, "WF5", 5 },
                    { 12, 6, true, "G01", 1 },
                    { 13, 6, true, "G02", 2 },
                    { 14, 7, true, "203", 3 },
                    { 15, 7, true, "401", 4 },
                    { 16, 8, true, "108", 1 },
                    { 17, 8, false, "210", 2 },
                    { 18, 9, true, "302", 2 },
                    { 19, 9, true, "MT1", 5 },
                    { 20, 10, true, "120", 3 },
                    { 21, 10, true, "220", 4 },
                    { 22, 11, true, "V08", 4 },
                    { 23, 11, false, "V12", 5 },
                    { 24, 12, true, "104", 1 },
                    { 25, 12, true, "204", 2 },
                    { 26, 13, true, "HB3", 2 },
                    { 27, 13, true, "HB8", 4 },
                    { 28, 14, true, "OC2", 3 },
                    { 29, 14, false, "OC9", 5 },
                    { 30, 15, true, "315", 2 },
                    { 31, 15, true, "615", 4 },
                    { 32, 16, true, "103", 1 },
                    { 33, 16, true, "303", 3 },
                    { 34, 17, true, "202", 2 },
                    { 35, 17, false, "402", 4 },
                    { 36, 18, true, "C04", 3 },
                    { 37, 18, true, "C10", 5 },
                    { 38, 19, true, "107", 1 },
                    { 39, 19, true, "207", 2 },
                    { 40, 20, true, "201", 2 },
                    { 41, 20, true, "401", 4 }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "AvatarUrl", "Bio", "City", "CreatedAt", "DateOfBirth", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, "100 Oak Street", "https://images.unsplash.com/photo-1500648767791-00dcc994a43e?w=400&q=80", "Frequent business traveller and hotel enthusiast. Always hunting for the best rooftop bar.", "New York", new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "u01" },
                    { 2, "107 Maple Street", "https://images.unsplash.com/photo-1494790108377-be9c29b29330?w=400&q=80", "Digital nomad exploring a new city every month. Coffee lover and architecture geek.", "Los Angeles", new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "u02" },
                    { 3, "114 Cedar Street", "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?w=400&q=80", "Family travel specialist — I always find the best suites with space for the kids.", "Chicago", new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "u03" },
                    { 4, "121 Birch Street", "https://images.unsplash.com/photo-1438761681033-6461ffad8d80?w=400&q=80", "Solo adventurer with a passion for local cuisine and boutique properties.", "Miami", new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "u04" },
                    { 5, "128 Elm Street", "https://images.unsplash.com/photo-1472099645785-5658abf4ff4e?w=400&q=80", "Luxury travel blogger. I review every hotel I stay in, honestly.", "San Francisco", new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "u05" },
                    { 6, "135 Pine Street", "https://images.unsplash.com/photo-1544005313-94ddf0286df2?w=400&q=80", "Weekend road tripper. I prefer cozy inns over big chains whenever possible.", "Seattle", new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1990, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "u06" },
                    { 7, "142 Walnut Street", "https://images.unsplash.com/photo-1500648767791-00dcc994a43e?w=400&q=80", "Corporate consultant who lives out of hotel rooms. I value comfort and fast Wi-Fi above all.", "Boston", new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1991, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "u07" },
                    { 8, "149 Ash Street", "https://images.unsplash.com/photo-1494790108377-be9c29b29330?w=400&q=80", "Retired teacher now ticking off her bucket-list destinations one hotel at a time.", "Austin", new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1992, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "u08" },
                    { 9, "156 Oak Street", "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?w=400&q=80", "Nature photographer who needs hotels close to hiking trails and national parks.", "Denver", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1993, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "u09" },
                    { 10, "163 Maple Street", "https://images.unsplash.com/photo-1438761681033-6461ffad8d80?w=400&q=80", "Honeymooner and romance travel specialist. Suites with a view are non-negotiable.", "Orlando", new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1994, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "u10" },
                    { 11, "170 Cedar Street", "https://images.unsplash.com/photo-1472099645785-5658abf4ff4e?w=400&q=80", "Frequent business traveller and hotel enthusiast. Always hunting for the best rooftop bar.", "Las Vegas", new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1995, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "u11" },
                    { 12, "177 Birch Street", "https://images.unsplash.com/photo-1544005313-94ddf0286df2?w=400&q=80", "Digital nomad exploring a new city every month. Coffee lover and architecture geek.", "Portland", new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1996, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "u12" },
                    { 13, "184 Elm Street", "https://images.unsplash.com/photo-1500648767791-00dcc994a43e?w=400&q=80", "Family travel specialist — I always find the best suites with space for the kids.", "San Diego", new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "u13" },
                    { 14, "191 Pine Street", "https://images.unsplash.com/photo-1494790108377-be9c29b29330?w=400&q=80", "Solo adventurer with a passion for local cuisine and boutique properties.", "Honolulu", new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1998, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "u14" },
                    { 15, "198 Walnut Street", "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?w=400&q=80", "Luxury travel blogger. I review every hotel I stay in, honestly.", "Atlanta", new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1999, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "u15" },
                    { 16, "205 Ash Street", "https://images.unsplash.com/photo-1438761681033-6461ffad8d80?w=400&q=80", "Weekend road tripper. I prefer cozy inns over big chains whenever possible.", "Philadelphia", new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1985, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "u16" },
                    { 17, "212 Oak Street", "https://images.unsplash.com/photo-1472099645785-5658abf4ff4e?w=400&q=80", "Corporate consultant who lives out of hotel rooms. I value comfort and fast Wi-Fi above all.", "Dallas", new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1986, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "u17" },
                    { 18, "219 Maple Street", "https://images.unsplash.com/photo-1544005313-94ddf0286df2?w=400&q=80", "Retired teacher now ticking off her bucket-list destinations one hotel at a time.", "Phoenix", new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1987, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "u18" },
                    { 19, "226 Cedar Street", "https://images.unsplash.com/photo-1500648767791-00dcc994a43e?w=400&q=80", "Nature photographer who needs hotels close to hiking trails and national parks.", "Minneapolis", new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1988, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "u19" },
                    { 20, "233 Birch Street", "https://images.unsplash.com/photo-1494790108377-be9c29b29330?w=400&q=80", "Honeymooner and romance travel specialist. Suites with a view are non-negotiable.", "Nashville", new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1989, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "u20" }
                });

            migrationBuilder.InsertData(
                table: "AmenityRoom",
                columns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 1, 11 },
                    { 1, 12 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 1, 21 },
                    { 1, 22 },
                    { 1, 23 },
                    { 1, 24 },
                    { 1, 25 },
                    { 1, 26 },
                    { 1, 27 },
                    { 1, 28 },
                    { 1, 29 },
                    { 1, 30 },
                    { 1, 31 },
                    { 1, 32 },
                    { 1, 33 },
                    { 1, 34 },
                    { 1, 35 },
                    { 1, 36 },
                    { 1, 37 },
                    { 1, 38 },
                    { 1, 39 },
                    { 1, 40 },
                    { 1, 41 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 2, 16 },
                    { 2, 17 },
                    { 2, 18 },
                    { 2, 19 },
                    { 2, 20 },
                    { 2, 21 },
                    { 2, 22 },
                    { 2, 23 },
                    { 2, 24 },
                    { 2, 25 },
                    { 2, 26 },
                    { 2, 27 },
                    { 2, 28 },
                    { 2, 29 },
                    { 2, 30 },
                    { 2, 31 },
                    { 2, 32 },
                    { 2, 33 },
                    { 2, 34 },
                    { 2, 35 },
                    { 2, 36 },
                    { 2, 37 },
                    { 2, 38 },
                    { 2, 39 },
                    { 2, 40 },
                    { 2, 41 },
                    { 3, 1 },
                    { 3, 17 },
                    { 3, 33 },
                    { 4, 2 },
                    { 4, 18 },
                    { 4, 34 },
                    { 5, 3 },
                    { 5, 19 },
                    { 5, 35 },
                    { 6, 4 },
                    { 6, 20 },
                    { 6, 36 },
                    { 7, 5 },
                    { 7, 21 },
                    { 7, 37 },
                    { 8, 6 },
                    { 8, 22 },
                    { 8, 38 },
                    { 9, 7 },
                    { 9, 23 },
                    { 9, 39 },
                    { 10, 8 },
                    { 10, 24 },
                    { 10, 40 },
                    { 11, 9 },
                    { 11, 25 },
                    { 11, 41 },
                    { 13, 10 },
                    { 13, 26 },
                    { 14, 11 },
                    { 14, 27 },
                    { 17, 12 },
                    { 17, 28 },
                    { 19, 13 },
                    { 19, 29 },
                    { 20, 14 },
                    { 20, 30 },
                    { 21, 15 },
                    { 21, 31 },
                    { 22, 16 },
                    { 22, 32 }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingID", "CheckInDate", "CheckOutDate", "CreatedAt", "RoomID", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 158.00m, "u01" },
                    { 2, new DateTime(2025, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 747.00m, "u02" },
                    { 3, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 119.00m, "u03" },
                    { 4, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1276.00m, "u04" },
                    { 5, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 238.00m, "u05" },
                    { 6, new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 387.00m, "u06" },
                    { 7, new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 395.00m, "u07" },
                    { 8, new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 498.00m, "u08" },
                    { 9, new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, 79.00m, "u09" },
                    { 10, new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, 357.00m, "u10" },
                    { 11, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, 258.00m, "u11" },
                    { 12, new DateTime(2025, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, 747.00m, "u12" },
                    { 13, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, 316.00m, "u13" },
                    { 14, new DateTime(2025, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, 238.00m, "u14" },
                    { 15, new DateTime(2025, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, 957.00m, "u15" },
                    { 16, new DateTime(2025, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, 129.00m, "u16" },
                    { 17, new DateTime(2025, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, 498.00m, "u17" },
                    { 18, new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, 996.00m, "u18" },
                    { 19, new DateTime(2025, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, 237.00m, "u19" },
                    { 20, new DateTime(2025, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, 238.00m, "u20" }
                });

            migrationBuilder.InsertData(
                table: "RoomImages",
                columns: new[] { "ImageID", "ImageURL", "RoomID" },
                values: new object[,]
                {
                    { 61, "https://images.unsplash.com/photo-1631049307264-da0ec9d70304?w=1200&q=80", 1 },
                    { 62, "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80", 1 },
                    { 63, "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80", 2 },
                    { 64, "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80", 2 },
                    { 65, "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80", 3 },
                    { 66, "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80", 3 },
                    { 67, "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80", 4 },
                    { 68, "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80", 4 },
                    { 69, "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80", 5 },
                    { 70, "https://images.unsplash.com/photo-1540518614846-7eded433c457?w=1200&q=80", 5 },
                    { 71, "https://images.unsplash.com/photo-1540518614846-7eded433c457?w=1200&q=80", 6 },
                    { 72, "https://images.unsplash.com/photo-1631049307264-da0ec9d70304?w=1200&q=80", 6 },
                    { 73, "https://images.unsplash.com/photo-1631049307264-da0ec9d70304?w=1200&q=80", 7 },
                    { 74, "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80", 7 },
                    { 75, "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80", 8 },
                    { 76, "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80", 8 },
                    { 77, "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80", 9 },
                    { 78, "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80", 9 },
                    { 79, "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80", 10 },
                    { 80, "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80", 10 },
                    { 81, "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80", 11 },
                    { 82, "https://images.unsplash.com/photo-1540518614846-7eded433c457?w=1200&q=80", 11 },
                    { 83, "https://images.unsplash.com/photo-1540518614846-7eded433c457?w=1200&q=80", 12 },
                    { 84, "https://images.unsplash.com/photo-1631049307264-da0ec9d70304?w=1200&q=80", 12 },
                    { 85, "https://images.unsplash.com/photo-1631049307264-da0ec9d70304?w=1200&q=80", 13 },
                    { 86, "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80", 13 },
                    { 87, "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80", 14 },
                    { 88, "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80", 14 },
                    { 89, "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80", 15 },
                    { 90, "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80", 15 },
                    { 91, "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80", 16 },
                    { 92, "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80", 16 },
                    { 93, "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80", 17 },
                    { 94, "https://images.unsplash.com/photo-1540518614846-7eded433c457?w=1200&q=80", 17 },
                    { 95, "https://images.unsplash.com/photo-1540518614846-7eded433c457?w=1200&q=80", 18 },
                    { 96, "https://images.unsplash.com/photo-1631049307264-da0ec9d70304?w=1200&q=80", 18 },
                    { 97, "https://images.unsplash.com/photo-1631049307264-da0ec9d70304?w=1200&q=80", 19 },
                    { 98, "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80", 19 },
                    { 99, "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80", 20 },
                    { 100, "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80", 20 },
                    { 101, "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80", 21 },
                    { 102, "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80", 21 },
                    { 103, "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80", 22 },
                    { 104, "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80", 22 },
                    { 105, "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80", 23 },
                    { 106, "https://images.unsplash.com/photo-1540518614846-7eded433c457?w=1200&q=80", 23 },
                    { 107, "https://images.unsplash.com/photo-1540518614846-7eded433c457?w=1200&q=80", 24 },
                    { 108, "https://images.unsplash.com/photo-1631049307264-da0ec9d70304?w=1200&q=80", 24 },
                    { 109, "https://images.unsplash.com/photo-1631049307264-da0ec9d70304?w=1200&q=80", 25 },
                    { 110, "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80", 25 },
                    { 111, "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80", 26 },
                    { 112, "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80", 26 },
                    { 113, "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80", 27 },
                    { 114, "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80", 27 },
                    { 115, "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80", 28 },
                    { 116, "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80", 28 },
                    { 117, "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80", 29 },
                    { 118, "https://images.unsplash.com/photo-1540518614846-7eded433c457?w=1200&q=80", 29 },
                    { 119, "https://images.unsplash.com/photo-1540518614846-7eded433c457?w=1200&q=80", 30 },
                    { 120, "https://images.unsplash.com/photo-1631049307264-da0ec9d70304?w=1200&q=80", 30 },
                    { 121, "https://images.unsplash.com/photo-1631049307264-da0ec9d70304?w=1200&q=80", 31 },
                    { 122, "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80", 31 },
                    { 123, "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80", 32 },
                    { 124, "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80", 32 },
                    { 125, "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80", 33 },
                    { 126, "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80", 33 },
                    { 127, "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80", 34 },
                    { 128, "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80", 34 },
                    { 129, "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80", 35 },
                    { 130, "https://images.unsplash.com/photo-1540518614846-7eded433c457?w=1200&q=80", 35 },
                    { 131, "https://images.unsplash.com/photo-1540518614846-7eded433c457?w=1200&q=80", 36 },
                    { 132, "https://images.unsplash.com/photo-1631049307264-da0ec9d70304?w=1200&q=80", 36 },
                    { 133, "https://images.unsplash.com/photo-1631049307264-da0ec9d70304?w=1200&q=80", 37 },
                    { 134, "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80", 37 },
                    { 135, "https://images.unsplash.com/photo-1611892440504-42a792e24d32?w=1200&q=80", 38 },
                    { 136, "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80", 38 },
                    { 137, "https://images.unsplash.com/photo-1595576508898-0ad5c879a061?w=1200&q=80", 39 },
                    { 138, "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80", 39 },
                    { 139, "https://images.unsplash.com/photo-1560185007-cde436f6a4d0?w=1200&q=80", 40 },
                    { 140, "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80", 40 },
                    { 141, "https://images.unsplash.com/photo-1522771739844-6a9f6d5f14af?w=1200&q=80", 41 },
                    { 142, "https://images.unsplash.com/photo-1540518614846-7eded433c457?w=1200&q=80", 41 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Amenities_HotelID",
                table: "Amenities",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_AmenityRoom_RoomsRoomID",
                table: "AmenityRoom",
                column: "RoomsRoomID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomID",
                table: "Bookings",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_UserID",
                table: "Bookings",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_HotelImages_HotelID",
                table: "HotelImages",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_HotelID",
                table: "Reviews",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserID",
                table: "Reviews",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_RoomImages_RoomID",
                table: "RoomImages",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelID",
                table: "Rooms",
                column: "HotelID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_TypeID",
                table: "Rooms",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_UserId",
                table: "UserProfiles",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmenityRoom");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "HotelImages");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "RoomImages");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "Amenities");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "RoomTypes");

            migrationBuilder.DropTable(
                name: "hotels");
        }
    }
}
