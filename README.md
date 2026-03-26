🎬 MovieApp API
A production-ready RESTful API for a movies & series streaming platform, built with ASP.NET Core 8 following Clean Architecture principles.

🚀 Tech Stack
LayerTechnologyBackendASP.NET Core 8 Web APIArchitectureClean ArchitectureDatabasePostgreSQL (Railway)ORMEntity Framework Core 8AuthJWT Bearer TokensFile StorageAWS S3ValidationFluentValidationMappingAutoMapperDocsSwagger / OpenAPILoggingSerilog

📁 Project Structure
MovieApp/
├── MovieApp.Domain/         # Entities, Interfaces, Enums, Exceptions
├── MovieApp.Application/    # DTOs, Services, Validators, Mappings
├── MovieApp.Infrastructure/ # DbContext, Repositories, JWT, S3
└── MovieApp.API/            # Controllers, Middleware, Program.cs

✨ Features

🎥 Movies & Series — Full CRUD with details, players, trailers
📺 Seasons & Episodes — Multi-language episode players
⭐ Reviews & Ratings — User reviews for movies and series
📋 WishList & Library — Personal collections per user
🕐 Watching History — Track what users have watched
🔐 Auth — Register, Login with JWT tokens
🌍 Countries, Actors, Genres, Languages — Full lookup management
🛡️ Role-based Access — User / Admin roles
☁️ File Uploads — Poster & image uploads via AWS S3


⚙️ Getting Started
Prerequisites

.NET 8 SDK
PostgreSQL or Railway
AWS S3 bucket (for file uploads)

1. Clone the repository
bashgit clone https://github.com/yourusername/MovieApp.git
cd MovieApp
2. Configure environment variables
Update appsettings.Development.json:
json{
  "ConnectionStrings": {
    "DefaultConnection": "Host=...;Database=movieapp;Username=...;Password=..."
  },
  "JwtSettings": {
    "SecretKey": "your-secret-key",
    "Issuer": "MovieApp",
    "Audience": "MovieAppUsers",
    "ExpirationDays": 7
  },
  "AWS": {
    "BucketName": "your-bucket",
    "AccessKey": "...",
    "SecretKey": "...",
    "Region": "us-east-1"
  }
}
3. Apply migrations
bashdotnet ef database update --project MovieApp.Infrastructure --startup-project MovieApp.API
4. Run the project
bashdotnet run --project MovieApp.API
5. Open Swagger
https://localhost:5001/swagger

🗄️ Database Schema
Main entities and relationships:

User → UserDetail, WishList, Library, Reviews
Movie → MovieDetail, MoviePlayer, Actors, Genres, Countries
Series → SeriesDetail, SeriesTrailer, Seasons → Episodes → EpisodePlayers
WishList / Library → can contain both Movies and Series
WatchingHistory → tracks Movies, Series, Episodes per user


📦 NuGet Packages
Npgsql.EntityFrameworkCore.PostgreSQL
Microsoft.AspNetCore.Authentication.JwtBearer
AutoMapper
FluentValidation.AspNetCore
AWSSDK.S3
BCrypt.Net-Next
Serilog.AspNetCore
Swashbuckle.AspNetCore

🚢 Deployment
This API is deployed on Railway with a PostgreSQL database.
Production URL: https://your-app.railway.app