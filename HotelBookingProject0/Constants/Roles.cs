namespace HotelBookingProject0.Constants
{

    public static class Roles
    {
        public const string Admin = "Admin";
        public const string Customer = "Customer";
        public const string Manager = "Manager";

        public static readonly IReadOnlyList<string> All =
        [Admin, Customer, Manager];
    }
}
