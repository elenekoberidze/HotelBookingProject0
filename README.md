# 🏨 Hotel Booking API — ASP.NET Core Backend
 
A robust **RESTful API** for a hotel booking platform, built with **ASP.NET Core 8** and **Entity Framework Core**. It powers hotel & room browsing, bookings, reviews, amenities, and secure JWT-based authentication with role-based access control.
 
<p align="center">
  <img alt=".NET" src="https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet&logoColor=white">
  <img alt="EF Core" src="https://img.shields.io/badge/EF%20Core-8.0-512BD4?logo=dotnet&logoColor=white">
  <img alt="SQL Server" src="https://img.shields.io/badge/SQL%20Server-LocalDB-CC2927?logo=microsoftsqlserver&logoColor=white">
  <img alt="JWT" src="https://img.shields.io/badge/Auth-JWT-000000?logo=jsonwebtokens&logoColor=white">
  <img alt="Swagger" src="https://img.shields.io/badge/API%20Docs-Swagger-85EA2D?logo=swagger&logoColor=black">
  <img alt="License" src="https://img.shields.io/badge/license-MIT-green">
</p>
---
 
## 📖 Overview
 
**HotelBookingProject0** is the backend REST API for a full hotel booking system. It exposes endpoints for browsing hotels and rooms, managing bookings, submitting and moderating reviews, and administering amenities and images — all secured with JWT authentication and ASP.NET Core Identity role-based authorization (`Admin` / `Customer`).
 
This is the API companion to a separate Angular frontend (the two are designed to run together — CORS is pre-configured for `localhost:4200`).
 
---
 
## ✨ Features
 
- 🔐 **JWT Authentication** — register, login, logout, access + refresh tokens, token revocation
- 👥 **Role-Based Authorization** — `Admin` and `Customer` roles via ASP.NET Core Identity
- 🏙️ **Hotels** — paginated hotel listings, hotel details, filter by city, list of cities
- 🛏️ **Rooms & Room Types** — browse/filter rooms, manage room types (admin)
- 📅 **Bookings** — create, view, and cancel bookings; admins can view/filter all bookings by status
- ⭐ **Reviews** — customers leave & manage reviews; admins moderate (approve/reject) reviews
- 🧰 **Amenities** — full CRUD for hotel/room amenities (admin)
- 🖼️ **Images** — manage hotel and room images, including setting a primary image
- 👤 **User Profiles** — retrieve and update the current user's profile
- 🌱 **Auto-seeded Admin** — an admin account and roles are seeded automatically on startup
- 📜 **Swagger / OpenAPI** — interactive API docs with built-in JWT bearer auth support
- 🛡️ **Global Exception Handling** — centralized error handling middleware with `ProblemDetails`
---
 
## 🧱 Tech Stack
 
| Layer                | Technology                                            |
|------------------------|---------------------------------------------------------|
| Framework               | ASP.NET Core 8 (Web API)                                |
| ORM                     | Entity Framework Core 8 (Code-First + Migrations)        |
| Database                | SQL Server (LocalDB by default)                          |
| Auth                    | ASP.NET Core Identity + JWT Bearer tokens                 |
| API Docs                | Swashbuckle (Swagger / OpenAPI)                            |
| Error Handling          | Custom `GlobalExceptionHandler` middleware + `ProblemDetails` |
 
---
 
## 📁 Project Structure
 
```
HotelBookingProject0/
├── Constants/              # Role names, booking & review status constants
├── Controllers/             # API controllers (Auth, Hotel, Room, Booking, Review, Amenity, Images, User...)
├── Data/                    # EF Core DbContext (HotelBookingContext)
├── Middleware/              # GlobalExceptionHandler
├── Migrations/               # EF Core database migrations
├── Models/
│   ├── DTO/                  # Request/response DTOs, grouped by feature
│   └── Entities/               # Domain entities (Hotel, Room, Booking, Review, Amenity, User...)
├── Services/                 # Business logic implementations
│   └── Interfaces/            # Service interfaces (for DI)
├── Program.cs                 # App startup, DI, auth, CORS, Swagger, seeding
├── appsettings.json            # Configuration (connection string, JWT settings)
└── HotelBookingProject0.csproj
```
 
---
 
## 🗃️ Data Model
 
The core entities and their relationships:
 
- **User** *(extends `IdentityUser`)* → has one `UserProfile`, many `Bookings`, many `Reviews`
- **Hotel** → many `Rooms`, `HotelImages`, `Reviews`, `Amenities`; has a computed `AverageReviewScore`
- **Room** → belongs to a `Hotel` and a `RoomType`; has many `Bookings`, `RoomImages`, `Amenities`
- **RoomType** → categorizes rooms (e.g. Single, Suite)
- **Booking** → links a `User` and a `Room`, with check-in/out dates, total price, and a `Status` (`Pending`, `Confirmed`, `CheckedIn`, `CheckedOut`, `Cancelled`)
- **Review** → linked to a `User` and a `Hotel`, with a rating, comment, and moderation `Status` (`Pending`, `Approved`, `Rejected`)
- **Amenity** → many-to-many with `Room`
- **HotelImage** / **RoomImage** → images tied to hotels/rooms, with a "primary image" flag
---
 
## 🚀 Getting Started
 
### Prerequisites
 
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- SQL Server (LocalDB works out of the box on Windows) or any accessible SQL Server instance
- (Optional) [Visual Studio 2022](https://visualstudio.microsoft.com/) or the `dotnet` CLI
### 1. Clone the repository
 
```bash
git clone https://github.com/<your-username>/HotelBookingProject0.git
cd HotelBookingProject0/HotelBookingProject0
```
 
### 2. Configure the database & secrets
 
Update `appsettings.json` (or better, use [user secrets](https://learn.microsoft.com/aspnet/core/security/app-secrets) for local dev) with your own values:
 
```json
{
  "ConnectionStrings": {
    "HotelApiDatabase": "Server=(localdb)\\MSSQLLocalDB;Database=HotelApiDb;Trusted_Connection=True;TrustServerCertificate=True;"
  },
  "Jwt": {
    "Issuer": "HotelApi",
    "Audience": "HotelApiClient",
    "Secret": "<a-long-random-secret-key>",
    "RefreshTokenTTLDays": 7
  }
}
```
 
> ⚠️ **Never commit real secrets.** Replace the JWT secret before deploying, and consider moving connection strings/secrets to environment variables or the .NET Secret Manager.
 
### 3. Apply database migrations
 
```bash
dotnet ef database update
```
 
This creates the `HotelApiDb` database and applies all migrations found in `Migrations/`.
 
### 4. Run the API
 
```bash
dotnet run
```
 
By default the API runs at:
 
- `https://localhost:7296` (HTTPS)
- `http://localhost:5244` (HTTP)
Swagger UI opens automatically at `/swagger`, where you can explore and test every endpoint (including authorizing with a JWT bearer token).
 
### 5. Default admin account
 
On first run, the app auto-seeds an admin account:
 
- **Email:** `ADMINelenekoberidze@gmail.com`
- **Password:** `Admin123#`
> ⚠️ Change this password (and remove the hardcoded seed credentials) before deploying anywhere public.
 
---
 
## 🔌 API Endpoints
 
All routes are prefixed with `/api/{Controller}`. Endpoints marked 🔒 require authentication (and specific roles where noted).
 
### Auth (`/api/Auth`)
| Method | Endpoint      | Description               |
|--------|----------------|-----------------------------|
| POST   | `/register`    | Register a new customer     |
| POST   | `/login`       | Log in, receive JWT + refresh token |
| POST   | `/logout`      | Log out                     |
| POST   | `/refresh`     | Exchange a refresh token for a new JWT |
| POST   | `/revoke`      | Revoke a refresh token       |
 
### Hotels (`/api/Hotel`)
| Method | Endpoint                      | Description                    |
|--------|---------------------------------|-----------------------------------|
| GET    | `/GetAllHotels`                 | Paginated list of all hotels       |
| GET    | `/GetHotelBy{id}`               | Get a hotel by ID                  |
| GET    | `/GetHotelsByCity/{city}`       | Get hotels in a given city         |
| GET    | `/GetCities`                    | List all distinct hotel cities     |
 
### Rooms (`/api/Room`)
| Method | Endpoint          | Description               |
|--------|---------------------|------------------------------|
| GET    | `/GetAll`            | Filterable room listing      |
| GET    | `/GetBy{id}`         | Get a room by ID             |
| GET    | `/GetRoomTypes`      | List all room types          |
 
### Room Types (`/api/RoomType`)
CRUD endpoints (`GET`, `GET/{id}`, `POST` 🔒Admin, `PUT/{id}` 🔒Admin, `DELETE/{id}` 🔒Admin)
 
### Bookings (`/api/Booking`) 🔒
| Method | Endpoint                          | Role       | Description                    |
|--------|--------------------------------------|-------------|------------------------------------|
| POST   | `/CreateBooking`                     | Customer    | Create a new booking                |
| GET    | `/GetCurrentUserBookings`            | Customer    | List the current user's bookings    |
| GET    | `/GetCurrentUserBookingBy{bookingId}`| Customer    | Get one of the current user's bookings |
| PATCH  | `/CancelBookingBy{bookingId}`        | Customer    | Cancel a booking                    |
| GET    | `/AdminGetAllBookings`               | Admin       | List all bookings                   |
| GET    | `/AdminGetBookingsBy{status}`        | Admin       | Filter all bookings by status       |
 
### Reviews (`/api/Review`)
| Method | Endpoint                              | Role       | Description                    |
|--------|------------------------------------------|-------------|------------------------------------|
| GET    | `/GetHotelReviewsBy{hotelId}`            | Public      | Get approved reviews for a hotel    |
| POST   | `/CreateReview`                          | 🔒 Customer | Submit a review                     |
| GET    | `/CurrentUsersReview`                    | 🔒 Customer | Get the current user's reviews      |
| DELETE | `/DeleteReviewBy{reviewId}`              | 🔒 Customer | Delete the current user's review    |
| GET    | `/AdminGetAllReviews`                    | 🔒 Admin    | List all reviews                    |
| GET    | `/AdminGetPendingReviews`                | 🔒 Admin    | List reviews pending moderation     |
| PATCH  | `/AdminUpdateReviewStatusBy{reviewId}`   | 🔒 Admin    | Approve or reject a review          |
 
### Amenities (`/api/Amenity`)
CRUD endpoints (`GET/GetAll`, `GET/GetBy{id}`, `POST/Create` 🔒Admin, `PUT/Update{id}` 🔒Admin, `DELETE/DeleteBy{id}` 🔒Admin)
 
### Images (`/api/HotelImage`, `/api/RoomImage`)
Get by hotel/room (public), add/delete/set-primary (🔒 Admin)
 
### User (`/api/User`, `/api/UserProfile`) 🔒
Get the current user's account info and profile; update the profile.
 
> 📌 Full request/response schemas are available live via **Swagger UI** at `/swagger` once the app is running.
 
---
 
## 🌐 CORS
 
CORS is pre-configured (`AllowAngular` policy) to accept requests from:
- `http://localhost:4200` / `https://localhost:4200`
- `http://localhost:62300` / `https://localhost:62300`
- `http://localhost:62990` / `https://localhost:62990`
Update the allowed origins in `Program.cs` if your frontend runs elsewhere.
 
---
 
## 🗄️ Database Migrations
 
To add a new migration after changing the models:
 
```bash
dotnet ef migrations add <MigrationName>
dotnet ef database update
```
 
---
 
## 🤝 Contributing
 
Contributions are welcome!
 
1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request
---
 
## 📄 License
 
This project is available under the MIT License. Feel free to use it for learning or as a starting point for your own projects.
 
---
 
<p align="center">Made with ❤️ using ASP.NET Core</p>
 
