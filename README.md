# CRM System - Fullstack ASP.NET Core Application

A complete CRM system built with ASP.NET Core MVC, featuring a three-tier architecture with robust inventory management, order processing, and responsive UI with dark/light mode support.

## Features:

- User Management: Create, edit, and delete user accounts.

- Order Processing: Create and manage customer orders with validation.

- Inventory Management: Comprehensive stock control system.

- Product Catalog: Manage products and their details.

- Warehouse Management: Track multiple warehouse locations.

- Stock Validation: Automatic stock validation during order processing.

- Responsive UI: Modern interface with Tailwind CSS.

- Dark/Light Mode: Toggle between themes with persistent settings.

- Unit Testing: Comprehensive test coverage for business logic.

- Three-Tier Architecture: Clean separation of concerns (UI, BLL, DAL).

- Entity Framework Core: Data access with migrations support.

## Prerequisites:

.NET 9.0 SDK or higher

SQL Server Express (LocalDB) or PostgreSQL

Visual Studio

2022 (optional) or VS Code

Node.js (for Tailwind CSS)

# Quick Start:

## Option 1: Using Local Setup

Clone the repository:

```
git clone  https://github.com/dirtysas/Webapp_v2
cd webapp
```

# Set up database connection:

- Update WebApp.Web/appsettings.json with your database connection string
## For LocalDB
```
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=WebAppDb;Trusted_Connection=True;"
}
```

# Run the application:
```
cd ../WebApp.Web
dotnet run
```
## Access the application:
- Open http://localhost:5000 in your browser

### Access Points
- Application: http://localhost:5000
- Database: SQL Server LocalDB

# Usage:

- Open http://localhost:5000 in your browser
- Navigate to different sections using the sidebar:
- Users: Manage customer accounts
- Orders: Process and track customer orders
- Products: Manage product catalog
- Warehouses: Manage warehouse locations
- Stocks: Monitor inventory levels
- Toggle dark/light theme using the theme button in the top right corner
- When creating orders, the system automatically validates stock availability

# Technologies Used:

## Frontend:

- ASP.NET Core MVC 9.0
- Razor Pages
- Tailwind CSS
- JavaScript
- HTML5/CSS3

## Backend:

- ASP.NET Core 9.0
- Entity Framework Core 9.0
- SQL Server (LocalDB) / PostgreSQL
- xUnit for unit testing
- Moq for mocking dependencies

# Architecture Principles
- Three-Tier Architecture: Clear separation between UI, business logic, and data access layers
- Dependency Injection: Comprehensive DI container configuration
- Repository Pattern: Abstraction of data access
-Unit of Work: Transaction management via DbContext
- SOLID Principles: Adherence to object-oriented design principles
-Strong Typization: Comprehensive C# types throughout the application


# Data Storage
## All data is stored in the configured database:

- Users table: Customer information
- Orders table: Order details
- Products table: Product catalog
- Warehouses table: Warehouse locations
- Stocks table: Inventory levels per product per warehouse

## Customization
### To customize the application:

- Modify Tailwind CSS configuration in _Layout.cshtml
- Extend entities in WebApp.DAL/Entities
- Add new services in WebApp.BLL/Services
- Create new views in WebApp.Web/Views

