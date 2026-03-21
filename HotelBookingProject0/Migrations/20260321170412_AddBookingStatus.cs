using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingProject0.Migrations
{
    /// <inheritdoc />
    public partial class AddBookingStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsAvailable",
                table: "Rooms",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "HotelID",
                table: "hotels",
                newName: "hotel_id");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Rooms",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Reviews",
                type: "nvarchar(20)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "RefreshTokens",
                type: "nvarchar(500)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ReplacedByToken",
                table: "RefreshTokens",
                type: "nvarchar(500)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Bookings",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14d38af4-527e-490c-b147-cd4e16c57478", "AQAAAAIAAYagAAAAEHfmztXIxH6LX0RD7Vi6WacD0e8bLDpLKvwvz8f+6ZWNHFL6qFQIoapt217Ovz9wCg==", "7d6e8801-1e01-4e9b-97af-2858c7ceea5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07fab586-b5ac-4a25-b99e-a37be195a665", "AQAAAAIAAYagAAAAEHJgYX0MFpjlVvekxdHl3ELfHCK1trJwqoLH1E6ruVXN8uTa10/n4E4iKs4hvJdO8A==", "42a37a07-f23c-431a-99ef-be1212a7d532" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u03",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9109bbc9-5eb7-4eaa-a7c5-8f292fe4a3fd", "AQAAAAIAAYagAAAAEONaGqRaHOutVxX321vIKnEewSmHYrNrLZbpAb+65wZorETrq5saEbIEfUG3ykeK1A==", "b8faae67-51df-4e5e-8ddd-a654a467e89e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u04",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4170397-8d76-4fe3-b60c-bdb26de68494", "AQAAAAIAAYagAAAAECzRNnYzkiWzivY2x2h2qBDe7Ex8eJ3XXeTW+3rzlIMLS9+LUh9aX/gGZfzn24ZpXQ==", "1c35c378-aa59-462e-b95f-600a4db60654" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u05",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ce88682-2279-4e4b-93c9-ebbdfcf00842", "AQAAAAIAAYagAAAAEN9BLegTl15mYEI3cuADuD4HEQ/zcdh3GUJewJsjEPrACSIBJUiGylXmJcNVWOOHMg==", "b3e3280d-7d3d-4158-9adf-859a72b6fbd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u06",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2acb201c-6742-4c64-94ff-eea1b49f7c8e", "AQAAAAIAAYagAAAAEOlXt2Z6NRXc75iiRuoiWVf/hUaK/EHmfae2z8THT9nxWx9+WeeECGbE2y/n/IW8lQ==", "73c12814-ccb8-4b29-8b4a-613edf645d9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u07",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51775472-61b5-4613-b51f-dacc6e793e53", "AQAAAAIAAYagAAAAEKJNi9dzV6Z3VxH8zyMba2Ha97TGNyI4fXZvB5rANUNiAUN0z+xGs5bXv7C1+PsaNQ==", "a2ac7ef8-4443-4387-81ab-a3f18f730482" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u08",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a288461a-bbc9-4bc1-8a5d-1bfa01e27351", "AQAAAAIAAYagAAAAEEgUvd6NSL0xpi+Chmuo3pk7WauvLl7g7gG8ajNXkBbgOx8Pllxqhvfz+49kiH1xaA==", "e3892956-7e6d-4145-9a21-4d581dc7f6c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a669e971-6027-4b18-8e61-f127838c0046", "AQAAAAIAAYagAAAAEFdSUZRAzbTdGd+9nqUgKnBY3VbOK3xkW2GO858JVtb+JSLIhvVv0vDsgBRqshQleA==", "3417f8af-2092-4515-9d24-6e66ef90c38c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64d69c12-aca2-4d13-9af3-462ffcd9faef", "AQAAAAIAAYagAAAAEHSs4fGwLshAoNpWPKmHMTK2YgGRs8mxjV4S/KfaFG6oAHYK05binv1e7Zc4QCAh5g==", "91700f1f-0aea-446a-b96d-ba55143dac9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b477a0c-c4c3-423b-a519-7f5b0d3ba11d", "AQAAAAIAAYagAAAAEN1QLXTtSYITb1qrmFZscqj4JwKbAgKM21Q7L/Sso7LTfrfx8CbAbYcvOUjtqxNQKA==", "bbe5f0e6-adb6-4608-85c5-c31dc84fa816" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "494e966e-e4a1-4660-8a45-380be6b19e87", "AQAAAAIAAYagAAAAEMf/Iyv3RJklcvXTGp6LXNOdGbG19cggmgSSwln+k+zG/tdwTH7OgK3QfAD9UZyPOw==", "b39e2b18-1ebc-46b3-911f-058eeae8997b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "737b09bf-b8f0-4749-853a-d26874430901", "AQAAAAIAAYagAAAAEBtNVf6crxIblK4XV7Axvx0FUTpj6RRvKP02mMoCUhC2bIhtPdgwgTqr1UTvg0fKlg==", "1ab9b870-beb7-4779-9a47-37cfdf7bd799" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3923475-a5ad-4d0a-9321-bfbda7baee71", "AQAAAAIAAYagAAAAEH6IPnKy470+R7Te55MFe3Kg4IDgFxE+1XOKv6Ipwrh1TTsm9mYky0tu9RUdOVKVtg==", "c5d90488-daff-4c27-ada1-6d38601ce450" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25209a6a-0bd3-4d4a-96f1-d27793142b6d", "AQAAAAIAAYagAAAAEPIdpYWs17Iv8Wq3MqQqWdb+UOHFJT4xoWWyr140JZIW7ifEKtc59B7MHemCdi4Wjw==", "77feae2d-33c1-492c-8bff-821624b0a99b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f90ecb4f-fc9a-4381-b0db-9011aed740c9", "AQAAAAIAAYagAAAAELj2jzxvJqBlukD5QFQ4PBMmhBmg3uetHOQAJQVy9ihl59zluv4SPR3wFApUqKwaSw==", "b7b7f129-378c-4d79-8e7d-b8449cfc148d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b711b2c-1c9e-48cf-85b9-4824e6ee652b", "AQAAAAIAAYagAAAAEJB+cWmRqcRKBpxXQvv+yvLDAODbI1GNOwKXR/XZuZsu/ASSIti4gwtGOBd3sbqSig==", "1fa2adc4-e132-47bc-8266-d4fc39575a21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65bc744a-a9da-4cba-ba00-e4d379d98917", "AQAAAAIAAYagAAAAEE+2S1nPU6kZyQtpKQqOU+DT2OhfAjmegxND3SIJyvfv+FfWntmqxWVhjbHZ9h60dw==", "5e2f1973-b258-47f9-a630-a305283c0b7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d9c8935-1ed9-4e9d-8bb5-0d0423232ef3", "AQAAAAIAAYagAAAAEPDRw56pLlKVAP9ZyGEy+Eezzpem5bMDPyD7qpmQq4J3ajweaeMH5ntP2Fc/Ndm2/A==", "411c7f76-e071-49df-82ba-e9f9ac3e395d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8fe58b4-40ea-4838-924c-c613d972c428", "AQAAAAIAAYagAAAAEBkE3hyAnFsLfgoyZXffRebdREkXRb1RQpURGbomIcG5Cetx5F/SvJFABU9sTUMHSw==", "b03a5abe-a5c3-402a-b514-1333ed85dd9a" });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 1,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 2,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 3,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 4,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 5,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 6,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 7,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 8,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 9,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 10,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 11,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 12,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 13,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 14,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 15,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 16,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 17,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 18,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 19,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 20,
                column: "Status",
                value: "Pending");

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 6,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 7,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 8,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 9,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 10,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 11,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 12,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 13,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 14,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 15,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 16,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 17,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 18,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 19,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 20,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 21,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 22,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 23,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 24,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 25,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 26,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 27,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 28,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 29,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 30,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 31,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 32,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 33,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 34,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 35,
                column: "Price",
                value: 0m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 36,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 37,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 38,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 39,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 40,
                column: "Price",
                value: 1m);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 41,
                column: "Price",
                value: 1m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Rooms",
                newName: "IsAvailable");

            migrationBuilder.RenameColumn(
                name: "hotel_id",
                table: "hotels",
                newName: "HotelID");

            migrationBuilder.AlterColumn<bool>(
                name: "IsAvailable",
                table: "Rooms",
                type: "bit",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Reviews",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "Token",
                table: "RefreshTokens",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)");

            migrationBuilder.AlterColumn<string>(
                name: "ReplacedByToken",
                table: "RefreshTokens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7408aea-340b-4256-a3d4-8554fa21e64a", "AQAAAAIAAYagAAAAEIlfhA4iuXbmCRfe3M1tNY8ggHsuglRn9gg4XWwVEo02XqgCdhumzrqH5bOzwAhorA==", "af333467-df8b-4cea-a696-2835c253140f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03deb43d-6e59-41a2-a9af-9e45e1cbbde3", "AQAAAAIAAYagAAAAEH/65N/F/ZmNHzRESlDm9uQq8yDRtsRrkCfoKSTKaC2dLFPw6qYrdjyY7O4wi2KUlw==", "2337a811-05bb-4118-b5a3-7d274493e1b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u03",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d5df4a0-d3f0-47e9-9947-f4279c4717fc", "AQAAAAIAAYagAAAAEKzIqq1N6jNBXV2GUPA5UAaLk8CoKRZ0eLo8LTdjAV4XEf3hEgFsJIGyMN3OxvP09A==", "e27fdd17-7891-4524-9f11-ca31fa4bca5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u04",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a7a2c96-82ff-4f8d-9c44-81ad40b25519", "AQAAAAIAAYagAAAAEHCJeHwWFekub/zYrSXYUS6GNOpMX6EcEgl4RvPYyFpkjOYe6qRv+28kGPl/iuKfpg==", "64facf6b-4173-44b7-bb28-b878f39853fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u05",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d26a5f15-7010-4487-b3a1-ec7f4bc52991", "AQAAAAIAAYagAAAAEKB4d9oehYHmwXuBvJbmfRx7Kw/aSdVsLscHbIyXKdglinDO3KjVCTSjc2nesOHiQQ==", "64199dc2-f7ba-4e3c-b0c3-f63fcdf576e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u06",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52bf9df6-a92f-417f-ac16-59b184aaea4f", "AQAAAAIAAYagAAAAEMUfXn+DAP1tqDklKFdNe9tscGOwu8E2vF/y228x7fMezpIE1M4PnWrY22I8iwpnTA==", "2f62caac-e6d7-448a-9b09-f7f9f4bfd6bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u07",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a22a0d2-68f2-45ae-b31d-02e6de0dbe20", "AQAAAAIAAYagAAAAECchBaYD2i3lqmrVEXcK7PbvxB8hZGNqtjoumkBJ6Kj8gcs9z+YA+lLcY5rR4INpsQ==", "21321a98-ad9f-4741-b8f5-7c64d318490d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u08",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff37fb25-aa3a-4352-ad47-1f5291d9ea44", "AQAAAAIAAYagAAAAEIyx3rZUrcpTrpxPEe9Yux7TYTE7kJae01JMJyvQ79zPm7DsQaGPIKGDvDq+1ZUvHw==", "5968e694-ccea-4ddd-a602-dc356312e9a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f654a4e-c4ad-4b55-a106-d381e5ac933c", "AQAAAAIAAYagAAAAEMMPBA0usdVVrXYLGgJL9TCOXgC7r1OZcATtzqSEMEAp9fdoA7lnOl7xQGn5V+lAIw==", "139c09f8-23f9-4bae-91cf-d65896eb97d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8cb0943-cbba-433d-8cac-fa3e42aea881", "AQAAAAIAAYagAAAAEFcNafZqUbuScKrnp4FCbJdkAvPwVcQQJ/KJkxX7Yhye8MmXf1Zvp0f9WGIz/G/EeA==", "5268ebb9-ab62-45f3-8cf1-43121f2f9c09" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "114d3b31-3cbc-4869-a9ab-fbda66afc6b4", "AQAAAAIAAYagAAAAEItjqX+LiVJcs/fMw43DKttDWI6pB+CJUOwJ/OoGsLCCIp4s8raWDPIY2DlMgj+5hA==", "7a20fd39-ed7d-478e-b6bb-29eac0ec545b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3aa2bf5a-78d5-473d-a452-47e05125e98e", "AQAAAAIAAYagAAAAEA7J8/R5FySFavEShmFEIQ1dsqV4gsh6OVDxeaht5x7btMzb5yZIz0XVLOrIMSMfSQ==", "8d8d7883-293a-4cb9-b4d8-b0bc0dc34ca9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cfbbd1c-c5d0-4fbd-9d50-c6d70d953d22", "AQAAAAIAAYagAAAAEHGmkqp8fqm+wS7c6blv+NXbQr/sf9f3ls5OVDGfoe6guTEtYmGe6Hb7hhhNlIxivA==", "474230dd-1753-43df-87d9-0beafcf51b6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad304ef6-7972-4520-8604-7e40b2844c48", "AQAAAAIAAYagAAAAELHJmlmz/FmFacNYZNl2xahOAJsUwyuM1gVSsYB4LgwEpdprrZT59u/WoZAw3ihfHA==", "07dd422d-250e-44e4-ab2e-d886459f31a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df9f9722-a5ef-44d3-8ad3-c9ee41bb8359", "AQAAAAIAAYagAAAAEM5gIpQ4cpRnnDbNCN9TBp/mRWX3f1xm4Q7NHM9kOrQZ7GikyMezV6lyz20bBVB/KA==", "b0c44ed0-6251-4d12-87ae-4a5fe1fc852b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29264aa8-2bac-47e6-89d3-eea33c2c30f4", "AQAAAAIAAYagAAAAEJ4VEEBbtYaCAEoE7mxs+2kyDdF7s7t9Ezn3BzEwWaLllu9Q2yavVDznwxGKitZUJg==", "e7975423-3cb6-41d7-8b7b-09e3702bbd8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcbffcd2-7525-4e86-a248-92c7ffa63a11", "AQAAAAIAAYagAAAAEL4cPe9YrigNoSJWJs13a9bw/2gKXctIc43osikBcLNQ5ulSsujTHcsCrwDKe1H/+w==", "087a7644-084e-4cb0-ae45-b6f2ec07335a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90729545-8c20-4e6e-8bea-95c4d6db1e27", "AQAAAAIAAYagAAAAEJY2PQPziIkj5k6OvWfgj64v3+URskxmoCeiyW0C/B2cI8TTJTMnvtinTVvZvvmHcw==", "33804e76-a215-47b1-8fda-4302ad6ca263" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "449046d6-526d-420a-a342-91b23c08c8bc", "AQAAAAIAAYagAAAAEA74uJ5xvjThQXSwIiPWjVsZ0BKulXMQSxZG8fh89+V6lM0H54CwFSyJY29ZqakwTg==", "86b76b34-aa11-49b4-9e0c-49dddb3663b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "350d116a-edcd-4170-8837-cda19ae44a81", "AQAAAAIAAYagAAAAECRj7vl7XsOHTEEZfyAGWmUoFPcfKttaRiwU5bZF8kJG0OpLP8UFL/Gt00VrXo8MfQ==", "ea415f16-9615-4916-8f55-29ffcd9189bb" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 3,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 4,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 6,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 7,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 8,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 9,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 10,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 11,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 12,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 13,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 14,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 15,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 16,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 17,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 18,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 19,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 20,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 21,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 22,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 23,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 24,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 25,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 26,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 27,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 28,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 29,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 30,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 31,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 32,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 33,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 34,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 35,
                column: "IsAvailable",
                value: false);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 36,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 37,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 38,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 39,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 40,
                column: "IsAvailable",
                value: true);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 41,
                column: "IsAvailable",
                value: true);
        }
    }
}
