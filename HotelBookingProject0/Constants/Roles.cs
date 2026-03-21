namespace HotelBookingProject0.Constants
{
    /// <summary>
    /// The roles used for authorization in the application.
    /// Stored as strings in the database and used in [Authorize] attributes.
    /// </summary>
    public static class Roles
    {
        public const string Admin = "Admin";
        public const string Customer = "Customer";
       
        public static readonly IReadOnlyList<string> All =
        [Admin, Customer];
    }
}
