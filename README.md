# .NET 8 Web API with Entity Framework 8

## Overview
This repository contains a .NET 8 Web API project that demonstrates building a Web API from scratch using Entity Framework 8 for data management. It includes implementation of the CRUD operations for a `FrontMan` model and uses the Repository Pattern with Dependency Injection for clean architecture.

## Features
- **Web API Creation**: Starting from setting up a new Web API project.
- **Model Definition**: Adding a new `FrontMan` model.
- **CRUD Operations**: Implementing Create, Read, Update, and Delete functionalities.
- **Testing with Swagger**: Using Swagger UI to test API methods.
- **Repository Pattern**: Organizing code using the Repository Pattern.
- **Dependency Injection**: Implementing Dependency Injection to manage services.
- **Entity Framework Integration**:
  - Configuring Entity Framework (EF8) with SQL Server.
  - Running Code-First Migrations.
  - Using DbContext for data operations.

## Tools & Technologies
- .NET 8
- Entity Framework 8 (EF8)
- SQL Server Express
- SQL Server Management Studio (SSMS)
- Swagger UI for API testing

## Getting Started
To get started with this project:
1. Clone the repository.
2. Ensure you have SQL Server Express installed and running.
3. Install the required NuGet packages for EF8.
4. Update the connection string in `appsettings.json` to match your SQL Server setup.
5. Run the application and navigate to `https://localhost:<port>/swagger` to view and test the API endpoints.

## Key Operations
- **GET**: Fetch all FrontMan or a single hero by ID.
- **POST**: Add a new FrontMan.
- **PUT**: Update an existing FrontMan.
- **DELETE**: Remove a FrontMan.

## Running Migrations
To set up and update the database schema:
This will apply the initial schema to your SQL Server database based on the defined DbContext and DbSet.
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
