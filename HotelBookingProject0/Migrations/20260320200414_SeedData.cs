using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable


namespace HotelBookingProject0.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Amenities",
                columns: ["AmenityID", "HotelID", "Name"],
                values: new object[,]
                {
                    { 1, null, "Amenity 1" },
                    { 2, null, "Amenity 2" },
                    { 3, null, "Amenity 3" },
                    { 4, null, "Amenity 4" },
                    { 5, null, "Amenity 5" },
                    { 6, null, "Amenity 6" },
                    { 7, null, "Amenity 7" },
                    { 8, null, "Amenity 8" },
                    { 9, null, "Amenity 9" },
                    { 10, null, "Amenity 10" },
                    { 11, null, "Amenity 11" },
                    { 12, null, "Amenity 12" },
                    { 13, null, "Amenity 13" },
                    { 14, null, "Amenity 14" },
                    { 15, null, "Amenity 15" },
                    { 16, null, "Amenity 16" },
                    { 17, null, "Amenity 17" },
                    { 18, null, "Amenity 18" },
                    { 19, null, "Amenity 19" },
                    { 20, null, "Amenity 20" }
                });

            migrationBuilder.InsertData(
                table: "RoomTypes",
                columns: new[] { "TypeID", "BasePrice", "TypeName" },
                values: new object[,]
                {
                    { 1, 50m, "Single" },
                    { 2, 75m, "Double" },
                    { 3, 90m, "Twin" },
                    { 4, 150m, "Suite" },
                    { 5, 200m, "Deluxe" }
                });

           
            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 1)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (1, 'Address 1', 'City1', 'Description for hotel 1', 'Hotel 1', 1, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 2)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (2, 'Address 2', 'City2', 'Description for hotel 2', 'Hotel 2', 2, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 3)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (3, 'Address 3', 'City3', 'Description for hotel 3', 'Hotel 3', 3, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 4)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (4, 'Address 4', 'City4', 'Description for hotel 4', 'Hotel 4', 4, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 5)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (5, 'Address 5', 'City5', 'Description for hotel 5', 'Hotel 5', 5, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 6)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (6, 'Address 6', 'City1', 'Description for hotel 6', 'Hotel 6', 1, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 7)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (7, 'Address 7', 'City2', 'Description for hotel 7', 'Hotel 7', 2, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 8)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (8, 'Address 8', 'City3', 'Description for hotel 8', 'Hotel 8', 3, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 9)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (9, 'Address 9', 'City4', 'Description for hotel 9', 'Hotel 9', 4, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 10)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (10, 'Address 10', 'City5', 'Description for hotel 10', 'Hotel 10', 5, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 11)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (11, 'Address 11', 'City1', 'Description for hotel 11', 'Hotel 11', 1, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 12)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (12, 'Address 12', 'City2', 'Description for hotel 12', 'Hotel 12', 2, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 13)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (13, 'Address 13', 'City3', 'Description for hotel 13', 'Hotel 13', 3, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 14)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (14, 'Address 14', 'City4', 'Description for hotel 14', 'Hotel 14', 4, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 15)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (15, 'Address 15', 'City5', 'Description for hotel 15', 'Hotel 15', 5, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 16)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (16, 'Address 16', 'City1', 'Description for hotel 16', 'Hotel 16', 1, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 17)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (17, 'Address 17', 'City2', 'Description for hotel 17', 'Hotel 17', 2, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 18)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (18, 'Address 18', 'City3', 'Description for hotel 18', 'Hotel 18', 3, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 19)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (19, 'Address 19', 'City4', 'Description for hotel 19', 'Hotel 19', 4, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.Sql(@"
IF NOT EXISTS (SELECT 1 FROM hotels WHERE HotelID = 20)
BEGIN
 SET IDENTITY_INSERT hotels ON;
 INSERT INTO hotels (HotelID, address, city, description, name, rating, status) VALUES (20, 'Address 20', 'City5', 'Description for hotel 20', 'Hotel 20', 5, 0);
 SET IDENTITY_INSERT hotels OFF;
END");

            migrationBuilder.InsertData(
                table: "HotelImages",
                columns: new[] { "ImageID", "HotelID", "ImageURL", "IsPrimary" },
                values: new object[,]
                {
                    { 1, 1, "https://example.com/hotels/1/image1.jpg", true },
                    { 2, 1, "https://example.com/hotels/1/image2.jpg", false },
                    { 3, 2, "https://example.com/hotels/2/image1.jpg", true },
                    { 4, 2, "https://example.com/hotels/2/image2.jpg", false },
                    { 5, 3, "https://example.com/hotels/3/image1.jpg", true },
                    { 6, 3, "https://example.com/hotels/3/image2.jpg", false },
                    { 7, 4, "https://example.com/hotels/4/image1.jpg", true },
                    { 8, 4, "https://example.com/hotels/4/image2.jpg", false },
                    { 9, 5, "https://example.com/hotels/5/image1.jpg", true },
                    { 10, 5, "https://example.com/hotels/5/image2.jpg", false },
                    { 11, 6, "https://example.com/hotels/6/image1.jpg", true },
                    { 12, 6, "https://example.com/hotels/6/image2.jpg", false },
                    { 13, 7, "https://example.com/hotels/7/image1.jpg", true },
                    { 14, 7, "https://example.com/hotels/7/image2.jpg", false },
                    { 15, 8, "https://example.com/hotels/8/image1.jpg", true },
                    { 16, 8, "https://example.com/hotels/8/image2.jpg", false },
                    { 17, 9, "https://example.com/hotels/9/image1.jpg", true },
                    { 18, 9, "https://example.com/hotels/9/image2.jpg", false },
                    { 19, 10, "https://example.com/hotels/10/image1.jpg", true },
                    { 20, 10, "https://example.com/hotels/10/image2.jpg", false },
                    { 21, 11, "https://example.com/hotels/11/image1.jpg", true },
                    { 22, 11, "https://example.com/hotels/11/image2.jpg", false },
                    { 23, 12, "https://example.com/hotels/12/image1.jpg", true },
                    { 24, 12, "https://example.com/hotels/12/image2.jpg", false },
                    { 25, 13, "https://example.com/hotels/13/image1.jpg", true },
                    { 26, 13, "https://example.com/hotels/13/image2.jpg", false },
                    { 27, 14, "https://example.com/hotels/14/image1.jpg", true },
                    { 28, 14, "https://example.com/hotels/14/image2.jpg", false },
                    { 29, 15, "https://example.com/hotels/15/image1.jpg", true },
                    { 30, 15, "https://example.com/hotels/15/image2.jpg", false },
                    { 31, 16, "https://example.com/hotels/16/image1.jpg", true },
                    { 32, 16, "https://example.com/hotels/16/image2.jpg", false },
                    { 33, 17, "https://example.com/hotels/17/image1.jpg", true },
                    { 34, 17, "https://example.com/hotels/17/image2.jpg", false },
                    { 35, 18, "https://example.com/hotels/18/image1.jpg", true },
                    { 36, 18, "https://example.com/hotels/18/image2.jpg", false },
                    { 37, 19, "https://example.com/hotels/19/image1.jpg", true },
                    { 38, 19, "https://example.com/hotels/19/image2.jpg", false },
                    { 39, 20, "https://example.com/hotels/20/image1.jpg", true },
                    { 40, 20, "https://example.com/hotels/20/image2.jpg", false }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomID", "HotelID", "IsAvailable", "RoomNumber", "TypeID" },
                values: new object[,]
                {
                    { 1, 1, true, "R101", 1 },
                    { 2, 2, true, "R102", 2 },
                    { 3, 3, true, "R103", 3 },
                    { 4, 4, true, "R104", 4 },
                    { 5, 5, true, "R105", 5 },
                    { 6, 6, true, "R106", 1 },
                    { 7, 7, true, "R107", 2 },
                    { 8, 8, true, "R108", 3 },
                    { 9, 9, true, "R109", 4 },
                    { 10, 10, true, "R110", 5 },
                    { 11, 11, true, "R111", 1 },
                    { 12, 12, true, "R112", 2 },
                    { 13, 13, true, "R113", 3 },
                    { 14, 14, true, "R114", 4 },
                    { 15, 15, true, "R115", 5 },
                    { 16, 16, true, "R116", 1 },
                    { 17, 17, true, "R117", 2 },
                    { 18, 18, true, "R118", 3 },
                    { 19, 19, true, "R119", 4 },
                    { 20, 20, true, "R120", 5 }
                });

            migrationBuilder.InsertData(
                table: "AmenityRoom",
                columns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 20 },
                    { 2, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 3, 3 },
                    { 4, 3 },
                    { 4, 4 },
                    { 5, 4 },
                    { 5, 5 },
                    { 6, 5 },
                    { 6, 6 },
                    { 7, 6 },
                    { 7, 7 },
                    { 8, 7 },
                    { 8, 8 },
                    { 9, 8 },
                    { 9, 9 },
                    { 10, 9 },
                    { 10, 10 },
                    { 11, 10 },
                    { 11, 11 },
                    { 12, 11 },
                    { 12, 12 },
                    { 13, 12 },
                    { 13, 13 },
                    { 14, 13 },
                    { 14, 14 },
                    { 15, 14 },
                    { 15, 15 },
                    { 16, 15 },
                    { 16, 16 },
                    { 17, 16 },
                    { 17, 17 },
                    { 18, 17 },
                    { 18, 18 },
                    { 19, 18 },
                    { 19, 19 },
                    { 20, 19 },
                    { 20, 20 }
                });

            migrationBuilder.InsertData(
                table: "RoomImages",
                columns: new[] { "ImageID", "ImageURL", "RoomID" },
                values: new object[,]
                {
                    { 41, "https://example.com/rooms/1/image1.jpg", 1 },
                    { 42, "https://example.com/rooms/2/image1.jpg", 2 },
                    { 43, "https://example.com/rooms/3/image1.jpg", 3 },
                    { 44, "https://example.com/rooms/4/image1.jpg", 4 },
                    { 45, "https://example.com/rooms/5/image1.jpg", 5 },
                    { 46, "https://example.com/rooms/6/image1.jpg", 6 },
                    { 47, "https://example.com/rooms/7/image1.jpg", 7 },
                    { 48, "https://example.com/rooms/8/image1.jpg", 8 },
                    { 49, "https://example.com/rooms/9/image1.jpg", 9 },
                    { 50, "https://example.com/rooms/10/image1.jpg", 10 },
                    { 51, "https://example.com/rooms/11/image1.jpg", 11 },
                    { 52, "https://example.com/rooms/12/image1.jpg", 12 },
                    { 53, "https://example.com/rooms/13/image1.jpg", 13 },
                    { 54, "https://example.com/rooms/14/image1.jpg", 14 },
                    { 55, "https://example.com/rooms/15/image1.jpg", 15 },
                    { 56, "https://example.com/rooms/16/image1.jpg", 16 },
                    { 57, "https://example.com/rooms/17/image1.jpg", 17 },
                    { 58, "https://example.com/rooms/18/image1.jpg", 18 },
                    { 59, "https://example.com/rooms/19/image1.jpg", 19 },
                    { 60, "https://example.com/rooms/20/image1.jpg", 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 1, 20 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 5, 4 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 6, 6 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 7, 6 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 7, 7 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 8, 7 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 8, 8 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 9, 8 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 9, 9 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 10, 9 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 10, 10 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 11, 10 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 11, 11 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 12, 11 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 12, 12 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 13, 12 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 13, 13 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 14, 13 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 14, 14 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 15, 14 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 15, 15 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 16, 15 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 16, 16 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 17, 16 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 17, 17 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 18, 17 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 18, 18 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 19, 18 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 19, 19 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 20, 19 });

            migrationBuilder.DeleteData(
                table: "AmenityRoom",
                keyColumns: new[] { "AmenitiesAmenityID", "RoomsRoomID" },
                keyValues: new object[] { 20, 20 });

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "HotelImages",
                keyColumn: "ImageID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "RoomImages",
                keyColumn: "ImageID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Amenities",
                keyColumn: "AmenityID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "TypeID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "TypeID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "TypeID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "TypeID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RoomTypes",
                keyColumn: "TypeID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "hotels",
                keyColumn: "HotelID",
                keyValue: 20);
        }
    }
}
