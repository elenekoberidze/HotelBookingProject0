using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingProject0.Migrations
{
    /// <inheritdoc />
    public partial class CreateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenity_hotels_HotelID",
                table: "Amenity");

            migrationBuilder.DropForeignKey(
                name: "FK_AmenityRoom_Amenity_AmenitiesAmenityID",
                table: "AmenityRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_AmenityRoom_Room_RoomsRoomID",
                table: "AmenityRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_AspNetUsers_UserID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Room_RoomID",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelImage_hotels_HotelID",
                table: "HotelImage");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_AspNetUsers_UserID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_hotels_HotelID",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_RoomType_TypeID",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_hotels_HotelID",
                table: "Room");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomImage_Room_RoomID",
                table: "RoomImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomType",
                table: "RoomType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomImage",
                table: "RoomImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Room",
                table: "Room");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelImage",
                table: "HotelImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Booking",
                table: "Booking");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Amenity",
                table: "Amenity");

            migrationBuilder.RenameTable(
                name: "RoomType",
                newName: "RoomTypes");

            migrationBuilder.RenameTable(
                name: "RoomImage",
                newName: "RoomImages");

            migrationBuilder.RenameTable(
                name: "Room",
                newName: "Rooms");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "HotelImage",
                newName: "HotelImages");

            migrationBuilder.RenameTable(
                name: "Booking",
                newName: "Bookings");

            migrationBuilder.RenameTable(
                name: "Amenity",
                newName: "Amenities");

            migrationBuilder.RenameIndex(
                name: "IX_RoomImage_RoomID",
                table: "RoomImages",
                newName: "IX_RoomImages_RoomID");

            migrationBuilder.RenameIndex(
                name: "IX_Room_TypeID",
                table: "Rooms",
                newName: "IX_Rooms_TypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Room_HotelID",
                table: "Rooms",
                newName: "IX_Rooms_HotelID");

            migrationBuilder.RenameIndex(
                name: "IX_Review_UserID",
                table: "Reviews",
                newName: "IX_Reviews_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Review_HotelID",
                table: "Reviews",
                newName: "IX_Reviews_HotelID");

            migrationBuilder.RenameIndex(
                name: "IX_HotelImage_HotelID",
                table: "HotelImages",
                newName: "IX_HotelImages_HotelID");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_UserID",
                table: "Bookings",
                newName: "IX_Bookings_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Booking_RoomID",
                table: "Bookings",
                newName: "IX_Bookings_RoomID");

            migrationBuilder.RenameIndex(
                name: "IX_Amenity_HotelID",
                table: "Amenities",
                newName: "IX_Amenities_HotelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomTypes",
                table: "RoomTypes",
                column: "TypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomImages",
                table: "RoomImages",
                column: "ImageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms",
                column: "RoomID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "ReviewID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelImages",
                table: "HotelImages",
                column: "ImageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings",
                column: "BookingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Amenities",
                table: "Amenities",
                column: "AmenityID");

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

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Amenities_hotels_HotelID",
                table: "Amenities",
                column: "HotelID",
                principalTable: "hotels",
                principalColumn: "HotelID");

            migrationBuilder.AddForeignKey(
                name: "FK_AmenityRoom_Amenities_AmenitiesAmenityID",
                table: "AmenityRoom",
                column: "AmenitiesAmenityID",
                principalTable: "Amenities",
                principalColumn: "AmenityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AmenityRoom_Rooms_RoomsRoomID",
                table: "AmenityRoom",
                column: "RoomsRoomID",
                principalTable: "Rooms",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_AspNetUsers_UserID",
                table: "Bookings",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Rooms_RoomID",
                table: "Bookings",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelImages_hotels_HotelID",
                table: "HotelImages",
                column: "HotelID",
                principalTable: "hotels",
                principalColumn: "HotelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_AspNetUsers_UserID",
                table: "Reviews",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_hotels_HotelID",
                table: "Reviews",
                column: "HotelID",
                principalTable: "hotels",
                principalColumn: "HotelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomImages_Rooms_RoomID",
                table: "RoomImages",
                column: "RoomID",
                principalTable: "Rooms",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomTypes_TypeID",
                table: "Rooms",
                column: "TypeID",
                principalTable: "RoomTypes",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_hotels_HotelID",
                table: "Rooms",
                column: "HotelID",
                principalTable: "hotels",
                principalColumn: "HotelID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amenities_hotels_HotelID",
                table: "Amenities");

            migrationBuilder.DropForeignKey(
                name: "FK_AmenityRoom_Amenities_AmenitiesAmenityID",
                table: "AmenityRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_AmenityRoom_Rooms_RoomsRoomID",
                table: "AmenityRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_AspNetUsers_UserID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Rooms_RoomID",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelImages_hotels_HotelID",
                table: "HotelImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_AspNetUsers_UserID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_hotels_HotelID",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_RoomImages_Rooms_RoomID",
                table: "RoomImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomTypes_TypeID",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_hotels_HotelID",
                table: "Rooms");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomTypes",
                table: "RoomTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rooms",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RoomImages",
                table: "RoomImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HotelImages",
                table: "HotelImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bookings",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Amenities",
                table: "Amenities");

            migrationBuilder.RenameTable(
                name: "RoomTypes",
                newName: "RoomType");

            migrationBuilder.RenameTable(
                name: "Rooms",
                newName: "Room");

            migrationBuilder.RenameTable(
                name: "RoomImages",
                newName: "RoomImage");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "HotelImages",
                newName: "HotelImage");

            migrationBuilder.RenameTable(
                name: "Bookings",
                newName: "Booking");

            migrationBuilder.RenameTable(
                name: "Amenities",
                newName: "Amenity");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_TypeID",
                table: "Room",
                newName: "IX_Room_TypeID");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_HotelID",
                table: "Room",
                newName: "IX_Room_HotelID");

            migrationBuilder.RenameIndex(
                name: "IX_RoomImages_RoomID",
                table: "RoomImage",
                newName: "IX_RoomImage_RoomID");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_UserID",
                table: "Review",
                newName: "IX_Review_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_HotelID",
                table: "Review",
                newName: "IX_Review_HotelID");

            migrationBuilder.RenameIndex(
                name: "IX_HotelImages_HotelID",
                table: "HotelImage",
                newName: "IX_HotelImage_HotelID");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_UserID",
                table: "Booking",
                newName: "IX_Booking_UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_RoomID",
                table: "Booking",
                newName: "IX_Booking_RoomID");

            migrationBuilder.RenameIndex(
                name: "IX_Amenities_HotelID",
                table: "Amenity",
                newName: "IX_Amenity_HotelID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomType",
                table: "RoomType",
                column: "TypeID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Room",
                table: "Room",
                column: "RoomID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RoomImage",
                table: "RoomImage",
                column: "ImageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "ReviewID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HotelImage",
                table: "HotelImage",
                column: "ImageID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Booking",
                table: "Booking",
                column: "BookingID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Amenity",
                table: "Amenity",
                column: "AmenityID");

            migrationBuilder.AddForeignKey(
                name: "FK_Amenity_hotels_HotelID",
                table: "Amenity",
                column: "HotelID",
                principalTable: "hotels",
                principalColumn: "HotelID");

            migrationBuilder.AddForeignKey(
                name: "FK_AmenityRoom_Amenity_AmenitiesAmenityID",
                table: "AmenityRoom",
                column: "AmenitiesAmenityID",
                principalTable: "Amenity",
                principalColumn: "AmenityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AmenityRoom_Room_RoomsRoomID",
                table: "AmenityRoom",
                column: "RoomsRoomID",
                principalTable: "Room",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_AspNetUsers_UserID",
                table: "Booking",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Room_RoomID",
                table: "Booking",
                column: "RoomID",
                principalTable: "Room",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelImage_hotels_HotelID",
                table: "HotelImage",
                column: "HotelID",
                principalTable: "hotels",
                principalColumn: "HotelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_AspNetUsers_UserID",
                table: "Review",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_hotels_HotelID",
                table: "Review",
                column: "HotelID",
                principalTable: "hotels",
                principalColumn: "HotelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_RoomType_TypeID",
                table: "Room",
                column: "TypeID",
                principalTable: "RoomType",
                principalColumn: "TypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_hotels_HotelID",
                table: "Room",
                column: "HotelID",
                principalTable: "hotels",
                principalColumn: "HotelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomImage_Room_RoomID",
                table: "RoomImage",
                column: "RoomID",
                principalTable: "Room",
                principalColumn: "RoomID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
