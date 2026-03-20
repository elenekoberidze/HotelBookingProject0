using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelBookingProject0.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "IsActive", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { "u1", 0, "afec4969-9a7a-4ae1-97ee-d3db3f2fc7d1", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4016), "alice.smith@example.com", false, "Alice", true, "Smith", false, null, "ALICE.SMITH@EXAMPLE.COM", "ALICE.SMITH", null, null, false, "795444ee-7006-4678-9303-f42e2febe9b1", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4017), "alice.smith" },
                    { "u10", 0, "fb33b0ca-478e-4850-9bfc-4c2d3265c077", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4172), "jack.thompson@example.com", false, "Jack", true, "Thompson", false, null, "JACK.THOMPSON@EXAMPLE.COM", "JACK.THOMPSON", null, null, false, "8928903b-4e48-4601-b394-20f9d21cf8fe", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4172), "jack.thompson" },
                    { "u11", 0, "6a0ebe0c-be1b-4952-9e1e-8e827b7badde", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4185), "kate.white@example.com", false, "Kate", true, "White", false, null, "KATE.WHITE@EXAMPLE.COM", "KATE.WHITE", null, null, false, "073f5bc0-28c3-45d4-a35b-a5cc07c70334", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4186), "kate.white" },
                    { "u12", 0, "b5d9599b-663d-4196-9f47-ced6e466e5d7", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4199), "leo.harris@example.com", false, "Leo", true, "Harris", false, null, "LEO.HARRIS@EXAMPLE.COM", "LEO.HARRIS", null, null, false, "f824c420-1edf-4bbe-a301-949fd3fc3064", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4200), "leo.harris" },
                    { "u13", 0, "9526db9c-6c91-4583-b598-4dd4837b300a", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4215), "mia.clark@example.com", false, "Mia", true, "Clark", false, null, "MIA.CLARK@EXAMPLE.COM", "MIA.CLARK", null, null, false, "960c9456-de28-4472-b504-fe6b62f70cf5", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4216), "mia.clark" },
                    { "u14", 0, "db3d314b-47d2-494a-b25e-f64202aa1814", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4228), "noah.lewis@example.com", false, "Noah", true, "Lewis", false, null, "NOAH.LEWIS@EXAMPLE.COM", "NOAH.LEWIS", null, null, false, "49c81f82-694e-4169-ac7b-44d0e790b0e2", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4228), "noah.lewis" },
                    { "u15", 0, "49c04bac-8d4a-4e7e-93ff-430cbffa6b26", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4240), "olivia.walker@example.com", false, "Olivia", true, "Walker", false, null, "OLIVIA.WALKER@EXAMPLE.COM", "OLIVIA.WALKER", null, null, false, "cd48c5a4-4af9-4e71-81c5-b5b90b9d99dd", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4241), "olivia.walker" },
                    { "u16", 0, "6d84f93f-d934-4c46-986b-db8fe42acff3", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4254), "paul.young@example.com", false, "Paul", true, "Young", false, null, "PAUL.YOUNG@EXAMPLE.COM", "PAUL.YOUNG", null, null, false, "49ab6175-9b7c-4938-9fc3-348cbacca357", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4254), "paul.young" },
                    { "u17", 0, "b0d4b5da-8c52-45df-b88d-2888b185049c", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4295), "quinn.hernandez@example.com", false, "Quinn", true, "Hernandez", false, null, "QUINN.HERNANDEZ@EXAMPLE.COM", "QUINN.HERNANDEZ", null, null, false, "05d9b697-8967-461b-a63c-73ba765ad626", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4295), "quinn.hernandez" },
                    { "u18", 0, "aa069726-f270-4537-91a0-850ebe645568", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4308), "rachel.king@example.com", false, "Rachel", true, "King", false, null, "RACHEL.KING@EXAMPLE.COM", "RACHEL.KING", null, null, false, "e108010f-d2b9-4e13-9885-b0f1f79e38b1", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4309), "rachel.king" },
                    { "u19", 0, "98ceff2c-c868-4025-b1be-5e0bcaa8e584", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4322), "sam.porter@example.com", false, "Sam", true, "Porter", false, null, "SAM.PORTER@EXAMPLE.COM", "SAM.PORTER", null, null, false, "5c913023-2824-4423-9331-2ecddc2fd3b3", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4323), "sam.porter" },
                    { "u2", 0, "0490df12-6c77-4e51-b485-9af9fcd6a349", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4061), "bob.johnson@example.com", false, "Bob", true, "Johnson", false, null, "BOB.JOHNSON@EXAMPLE.COM", "BOB.JOHNSON", null, null, false, "a1564412-107f-4bbd-a46d-3d58c91dd05f", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4061), "bob.johnson" },
                    { "u20", 0, "86c40641-126c-4f69-990e-71a66f0bee3a", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4335), "tina.bell@example.com", false, "Tina", true, "Bell", false, null, "TINA.BELL@EXAMPLE.COM", "TINA.BELL", null, null, false, "3989b3ef-0ef8-4540-809a-f9573ee99267", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4335), "tina.bell" },
                    { "u3", 0, "32e500a4-0c40-484b-8c3c-19ab1cbbcdab", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4080), "carol.williams@example.com", false, "Carol", true, "Williams", false, null, "CAROL.WILLIAMS@EXAMPLE.COM", "CAROL.WILLIAMS", null, null, false, "c1205fd0-1dbb-4d9f-becd-6df5b046c4f4", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4080), "carol.williams" },
                    { "u4", 0, "507558a5-9800-449c-9c7d-6157e4257617", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4092), "david.brown@example.com", false, "David", true, "Brown", false, null, "DAVID.BROWN@EXAMPLE.COM", "DAVID.BROWN", null, null, false, "fd5bf479-ad4b-442c-9f7d-0b35b0993b41", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4093), "david.brown" },
                    { "u5", 0, "bd5d7c3a-3f8e-44b0-8d28-f08885a9bee2", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4107), "emma.jones@example.com", false, "Emma", true, "Jones", false, null, "EMMA.JONES@EXAMPLE.COM", "EMMA.JONES", null, null, false, "74101804-762d-4a9d-87d5-f3cf880e9ccc", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4107), "emma.jones" },
                    { "u6", 0, "1e82b9d8-807b-4b8a-a378-711f6aa1ad72", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4120), "frank.miller@example.com", false, "Frank", true, "Miller", false, null, "FRANK.MILLER@EXAMPLE.COM", "FRANK.MILLER", null, null, false, "6c0e6b7d-2ea1-4870-85dc-c075c4851006", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4120), "frank.miller" },
                    { "u7", 0, "eb056b41-8a7c-483b-a026-b2e3c766bf81", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4132), "grace.davis@example.com", false, "Grace", true, "Davis", false, null, "GRACE.DAVIS@EXAMPLE.COM", "GRACE.DAVIS", null, null, false, "0febfc9e-9ff6-4206-b373-8a732002eb22", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4133), "grace.davis" },
                    { "u8", 0, "de570394-64f4-4fa2-9f10-ade5d86734d8", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4146), "henry.garcia@example.com", false, "Henry", true, "Garcia", false, null, "HENRY.GARCIA@EXAMPLE.COM", "HENRY.GARCIA", null, null, false, "6b88c427-537a-4deb-947b-2b2719b9e0e5", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4146), "henry.garcia" },
                    { "u9", 0, "98716687-3bac-4abf-b017-141d85555c8f", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4158), "isabel.martin@example.com", false, "Isabel", true, "Martin", false, null, "ISABEL.MARTIN@EXAMPLE.COM", "ISABEL.MARTIN", null, null, false, "1927250c-d8e1-4ed4-b134-0fa4feca6fa3", false, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4159), "isabel.martin" }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingID", "CheckInDate", "CheckOutDate", "CreatedAt", "RoomID", "TotalPrice", "UserID" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 3, 27, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4610), new DateTime(2026, 3, 29, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4610), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4619), 1, 498.00m, "u1" },
                    { 2, new DateTime(2026, 3, 28, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4625), new DateTime(2026, 3, 31, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4625), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4625), 2, 567.00m, "u2" },
                    { 3, new DateTime(2026, 3, 29, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4627), new DateTime(2026, 4, 2, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4627), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4628), 3, 356.00m, "u3" },
                    { 4, new DateTime(2026, 3, 30, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4630), new DateTime(2026, 4, 1, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4630), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4631), 4, 378.00m, "u4" },
                    { 5, new DateTime(2026, 3, 31, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4633), new DateTime(2026, 4, 3, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4633), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4634), 5, 747.00m, "u5" },
                    { 6, new DateTime(2026, 4, 1, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4636), new DateTime(2026, 4, 5, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4636), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4637), 6, 396.00m, "u6" },
                    { 7, new DateTime(2026, 4, 2, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4638), new DateTime(2026, 4, 4, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4638), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4639), 7, 178.00m, "u7" },
                    { 8, new DateTime(2026, 4, 3, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4640), new DateTime(2026, 4, 6, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4640), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4641), 8, 177.00m, "u8" },
                    { 9, new DateTime(2026, 4, 4, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4643), new DateTime(2026, 4, 8, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4643), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4644), 9, 756.00m, "u9" },
                    { 10, new DateTime(2026, 4, 5, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4646), new DateTime(2026, 4, 7, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4647), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4647), 10, 198.00m, "u10" },
                    { 11, new DateTime(2026, 4, 6, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4649), new DateTime(2026, 4, 9, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4649), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4649), 11, 747.00m, "u11" },
                    { 12, new DateTime(2026, 4, 7, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4651), new DateTime(2026, 4, 11, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4651), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4651), 12, 356.00m, "u12" },
                    { 13, new DateTime(2026, 4, 8, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4653), new DateTime(2026, 4, 10, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4653), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4654), 13, 378.00m, "u13" },
                    { 14, new DateTime(2026, 4, 9, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4655), new DateTime(2026, 4, 12, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4656), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4656), 14, 747.00m, "u14" },
                    { 15, new DateTime(2026, 4, 10, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4657), new DateTime(2026, 4, 14, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4658), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4658), 15, 396.00m, "u15" },
                    { 16, new DateTime(2026, 4, 11, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4659), new DateTime(2026, 4, 13, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4660), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4660), 16, 178.00m, "u16" },
                    { 17, new DateTime(2026, 4, 12, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4661), new DateTime(2026, 4, 15, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4662), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4662), 17, 177.00m, "u17" },
                    { 18, new DateTime(2026, 4, 13, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4684), new DateTime(2026, 4, 17, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4685), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4685), 18, 756.00m, "u18" },
                    { 19, new DateTime(2026, 4, 14, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4688), new DateTime(2026, 4, 16, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4688), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4688), 19, 178.00m, "u19" },
                    { 20, new DateTime(2026, 4, 15, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4691), new DateTime(2026, 4, 18, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4691), new DateTime(2026, 3, 19, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4691), 20, 567.00m, "u20" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewID", "Comment", "HotelID", "Rating", "ReviewDate", "UserID" },
                values: new object[,]
                {
                    { 1, "Excellent stay, highly recommend.", 1, 1, new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4494), "u1" },
                    { 2, "Very comfortable and well located.", 2, 2, new DateTime(2026, 3, 18, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4496), "u2" },
                    { 3, "Good value for money.", 3, 3, new DateTime(2026, 3, 16, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4553), "u3" },
                    { 4, "Service could be improved.", 4, 4, new DateTime(2026, 3, 14, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4555), "u4" },
                    { 5, "Outstanding amenities and staff.", 5, 5, new DateTime(2026, 3, 12, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4556), "u5" },
                    { 6, "Excellent stay, highly recommend.", 6, 1, new DateTime(2026, 3, 10, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4559), "u6" },
                    { 7, "Very comfortable and well located.", 7, 2, new DateTime(2026, 3, 8, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4560), "u7" },
                    { 8, "Good value for money.", 8, 3, new DateTime(2026, 3, 6, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4561), "u8" },
                    { 9, "Service could be improved.", 9, 4, new DateTime(2026, 3, 4, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4562), "u9" },
                    { 10, "Outstanding amenities and staff.", 10, 5, new DateTime(2026, 3, 2, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4563), "u10" },
                    { 11, "Excellent stay, highly recommend.", 11, 1, new DateTime(2026, 2, 28, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4564), "u11" },
                    { 12, "Very comfortable and well located.", 12, 2, new DateTime(2026, 2, 26, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4565), "u12" },
                    { 13, "Good value for money.", 13, 3, new DateTime(2026, 2, 24, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4566), "u13" },
                    { 14, "Service could be improved.", 14, 4, new DateTime(2026, 2, 22, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4567), "u14" },
                    { 15, "Outstanding amenities and staff.", 15, 5, new DateTime(2026, 2, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4567), "u15" },
                    { 16, "Excellent stay, highly recommend.", 16, 1, new DateTime(2026, 2, 18, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4568), "u16" },
                    { 17, "Very comfortable and well located.", 17, 2, new DateTime(2026, 2, 16, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4569), "u17" },
                    { 18, "Good value for money.", 18, 3, new DateTime(2026, 2, 14, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4570), "u18" },
                    { 19, "Service could be improved.", 19, 4, new DateTime(2026, 2, 12, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4571), "u19" },
                    { 20, "Outstanding amenities and staff.", 20, 5, new DateTime(2026, 2, 10, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4572), "u20" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Address", "AvatarUrl", "Bio", "City", "CreatedAt", "DateOfBirth", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { 1, "100 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "New York", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4416), new DateTime(1996, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4401), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4417), "u1" },
                    { 2, "101 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Los Angeles", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4422), new DateTime(1996, 3, 21, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4421), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4422), "u2" },
                    { 3, "102 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Chicago", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4424), new DateTime(1996, 3, 22, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4424), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4425), "u3" },
                    { 4, "103 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Miami", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4427), new DateTime(1996, 3, 23, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4427), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4427), "u4" },
                    { 5, "104 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "San Francisco", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4429), new DateTime(1996, 3, 24, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4429), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4430), "u5" },
                    { 6, "105 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Seattle", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4432), new DateTime(1996, 3, 25, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4432), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4433), "u6" },
                    { 7, "106 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Boston", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4435), new DateTime(1996, 3, 26, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4434), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4435), "u7" },
                    { 8, "107 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Austin", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4437), new DateTime(1996, 3, 27, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4437), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4438), "u8" },
                    { 9, "108 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Denver", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4439), new DateTime(1996, 3, 28, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4439), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4440), "u9" },
                    { 10, "109 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Orlando", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4442), new DateTime(1996, 3, 29, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4442), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4442), "u10" },
                    { 11, "110 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Las Vegas", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4444), new DateTime(1996, 3, 30, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4444), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4444), "u11" },
                    { 12, "111 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Portland", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4446), new DateTime(1996, 3, 31, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4446), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4446), "u12" },
                    { 13, "112 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "San Diego", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4448), new DateTime(1996, 4, 1, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4448), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4448), "u13" },
                    { 14, "113 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Honolulu", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4450), new DateTime(1996, 4, 2, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4450), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4450), "u14" },
                    { 15, "114 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Atlanta", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4452), new DateTime(1996, 4, 3, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4452), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4452), "u15" },
                    { 16, "115 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Philadelphia", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4454), new DateTime(1996, 4, 4, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4454), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4454), "u16" },
                    { 17, "116 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Dallas", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4456), new DateTime(1996, 4, 5, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4456), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4456), "u17" },
                    { 18, "117 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Phoenix", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4459), new DateTime(1996, 4, 6, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4458), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4459), "u18" },
                    { 19, "118 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Minneapolis", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4461), new DateTime(1996, 4, 7, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4460), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4461), "u19" },
                    { 20, "119 Example St", "https://images.unsplash.com/photo-1502685104226-ee32379fefbe?auto=format&fit=crop&w=400&q=80", "Enthusiastic traveler and reviewer.", "Nashville", new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4463), new DateTime(1996, 4, 8, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4462), new DateTime(2026, 3, 20, 20, 25, 18, 811, DateTimeKind.Utc).AddTicks(4463), "u20" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Bookings",
                keyColumn: "BookingID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UserProfiles",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u20");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "u9");
        }
    }
}
