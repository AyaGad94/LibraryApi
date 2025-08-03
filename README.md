# LibraryApi

An ASP.NET Core Web API for managing a simple digital library system.  
This project follows clean architecture principles and applies the **Repository Design Pattern** with **Unit of Work** for better separation of concerns and data access management.

## 📚 Features

- Manage books with full CRUD operations
- Each book includes title, author, price, and category
- Repository Pattern + Unit of Work applied for scalability and testability
- SQL Server integration using Entity Framework Core
- AutoMapper support for clean DTO mapping

## 🧱 Project Structure

- **Controllers/** – Expose API endpoints for interacting with the system
- **Models/** – Entity classes like `Book`
- **DTOs/** – Input/output data transfer objects
- **Services/** – Business logic using repositories
- **Repositories/** – Encapsulate database access logic
- **Interfaces/** – Define abstractions for repositories and Unit of Work
- **Data/** – Contains `AppDbContext` and migration management
- **Profiles/** – AutoMapper profile configuration

## 🧠 Design Patterns Used

- **Repository Pattern**
- **Unit of Work Pattern**
- **Service Layer**
- **AutoMapper** for DTO mapping

## 🛠️ Tech Stack

- ASP.NET Core Web API (.NET 6+)
- Entity Framework Core
- SQL Server (SSMS)
- AutoMapper
- Visual Studio 2022

## 🚀 Getting Started

### 1. Clone the Repository
```bash
git clone https://github.com/YourUsername/LibraryApi.git
cd LibraryApi
