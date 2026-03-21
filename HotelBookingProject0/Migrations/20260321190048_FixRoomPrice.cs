using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingProject0.Migrations
{
    /// <inheritdoc />
    public partial class FixRoomPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAvailable",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "731bfe36-1735-4c8c-b1f2-552c850197c2", "AQAAAAIAAYagAAAAEIwPs+tcYwamz6kohGj/Z4THlar/u/OnpiGioRSl4LDdxPxe4qekKPaeRYt1jaae7g==", "4d4a7af7-f829-439c-9f8c-da229dc35996" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u02",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94f04cbe-f052-4578-9dbd-1d43032ad679", "AQAAAAIAAYagAAAAENVW4x1K6Wmpaw4IWjZ4FdwUjQgnSyAMLR+noGS43PZgo0A0n8bb5PV1jL7MIX3bJQ==", "dc13cff3-5e7d-483b-ab05-8523158715ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u03",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32771590-5950-4f91-9f67-cad83d6565d6", "AQAAAAIAAYagAAAAEB0TsOhruGwcNI/o3uZBBYrMBfkiXwLS7XkXldige/KV9GDOroBiZNXjL8IhL6cbKA==", "8d636ed0-bd48-4546-b529-73e063b5b9e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u04",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d7ac104-e984-4ed0-9887-0db8be5f1efc", "AQAAAAIAAYagAAAAEEcm8qjRbpWqP2EhUeLMHdaXPk00RRn2mOT7woq3anX31Md2JJJ5ET2e/ji/Ec/pRA==", "5a2ed94e-6043-41ed-ba5b-bd7442493160" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u05",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fdf9b77-13f1-43f8-88fb-e6ac3a3e932b", "AQAAAAIAAYagAAAAEBIHmKctaSranOESM5X9TlAjyqZR2+tZIh7TlYmta6xGyLa/w/+/YBPMfCvIgYYvSA==", "57384986-df38-4b58-a9eb-77ad467f2463" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u06",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a04f249-9451-4816-b27d-7b29bbf53373", "AQAAAAIAAYagAAAAEIxiMY+GuvhyeCGg5Jjh20YvugmpOG2KZBc/dOYa+wjJmE8Z/5hG/AEI6+WNrm7grw==", "21c59b29-847d-45a1-9f48-5d4275afe818" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u07",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "051e2ea0-b9ef-4654-82b7-bca81e1b6cbe", "AQAAAAIAAYagAAAAEFyqqTtrmLX2tqxwgKRkWF0ETotzgt0lUzUNGRMzugJO1IG8JsxU4Zff/DWvxMAPGQ==", "d5a5eb46-2fc1-446b-973e-29e0b2c3f333" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u08",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c7d7133-26ad-4f46-a0ee-c1d78245e78b", "AQAAAAIAAYagAAAAEJ6VcGKPGTZIQdG+uvTe5rPNJ+zca5ofqv/PyszNHr4cDtt6CjMXw7/Oenn+5c7i8w==", "7ad02ea7-047d-4f7f-873d-a426d8fafea1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u09",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e7fb84c-a68a-463c-9fc2-63e1b7b30351", "AQAAAAIAAYagAAAAEFZbSXpfYwfup3AzTKJlzAmZjHO8PaFmIxTGN0anNIsnmNkXUF3L9ua2bjDZ93AGCQ==", "50896e85-662b-4731-a21c-35edc6e39932" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u10",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5be6588-c64c-42a4-b469-d3d90d27264c", "AQAAAAIAAYagAAAAEE/QzXGYuYjGmSpFkEW+r8RgAb5QZaBWSsUu2KlpJ5kc3/6O1EyTm1/XqjCweHhVpg==", "49b2c815-6f2a-4830-af6b-3404b2101683" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u11",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77d1095f-635e-43c0-babd-14d8a6e8338e", "AQAAAAIAAYagAAAAEGyO9JZeZpSwkZm4wufHpCoa7N2RMm3WGdVJTZvwtCpJR7zEvpqin6MK9S6HQKS/zw==", "fc88c979-c2fe-4b7d-851b-72f57359c338" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b090bb2-ad4a-485e-a1de-e98091d60658", "AQAAAAIAAYagAAAAEONpikcPEAKih4BKWVw92Q3lrNB3ILO7wLJcvG4nZ73qtJWa5DbXXdvf6axqcU9+8g==", "44a9cd92-9174-4be2-a695-43850b1324df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u13",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "154e6a68-6c3a-4249-b3b9-bd6301450af1", "AQAAAAIAAYagAAAAEOSWqkKznJ/SU2v2jYdqBNTYKL668hsO1dCsBjuZC5aNpOe49swJAmWL5J04DYhcdw==", "454fddc8-1cf3-4cea-815e-3cfdbd558b58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u14",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea664dea-9f4c-481d-a059-cd91c7392a6a", "AQAAAAIAAYagAAAAEF9hSNqCbQTZrOtvofaSgzQuLF/oyKkz6pGP5r9x9XWoYXP7fodvpl/QMwHvl9RyvQ==", "96d36ebd-1337-484c-9f0b-689d44686e84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u15",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b521cf1-32b6-47e4-9221-7f18af77d9aa", "AQAAAAIAAYagAAAAENN6UYbz5r5X8yKWX58WtF7aAyi8GU39nDvglFdVequ3A4YU99BWV4ZenZ2Vq0MiTQ==", "95601ad1-cda2-4a3c-8d0d-7c0abe424349" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26dc871a-23eb-47cd-a598-7e9a63549a2d", "AQAAAAIAAYagAAAAEA23f8me6WTjftLWpAo3X0cnBQcIlQgmDhEYhUqYXWqH/tCjc3biMR8WMFu2KNd1/A==", "7533934c-ede3-4c1e-b785-0e3cf96f227b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u17",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c5e48da-e865-4fe8-a99f-0349e941c7b5", "AQAAAAIAAYagAAAAEO6rBrS0DJLxEYZlp/KMfTGcsN6sR3azUEZ0eD7g+Vu9GpryNcfKQLxvHf4BpWFS6g==", "43b23b0f-3f34-4f50-9584-6d9280d393cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u18",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "723593a8-0507-4c9d-8301-8e6af04a6ad2", "AQAAAAIAAYagAAAAENwsuMboUBr0y1KgVBDsJNQSFtX7GgSP9s0RdnnZLNf5vl4W9ZNk9Op+r6s1UItV8A==", "91af38a9-049e-47ca-b968-e3bf91db55cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u19",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "393f7700-22aa-407c-8e14-a5140ae51353", "AQAAAAIAAYagAAAAEJkgld8647oznDCwUbcvsDU4xjyU884yKXNKo386ecrWWBhcpfnyRJjwmDh5Asyt+Q==", "31893bdd-d81a-4364-a5fb-69734bd7036b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u20",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46073a6c-a6d3-4177-972e-fa44f3956dd2", "AQAAAAIAAYagAAAAEK8mILYBGV2RR0me7vBN9kN+Kb7u6jYAo+e0d8u6fMMP4mxaDc8WaMNUeVN4xw+gzg==", "448ecdad-78cc-458c-9db4-cec74e4f7cf3" });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 1,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 2,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

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
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 5,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 6,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 7,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 8,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

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
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 11,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 12,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 13,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 14,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 15,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 16,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

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
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 19,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 20,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 21,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 22,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

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
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 25,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 26,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 27,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 28,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

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
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 31,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 32,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 33,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 34,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

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
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 37,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 38,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 39,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 40,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "RoomID",
                keyValue: 41,
                columns: new[] { "IsAvailable", "Price" },
                values: new object[] { true, 0m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAvailable",
                table: "Rooms");

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
    }
}
