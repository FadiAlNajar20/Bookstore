# Bookstore Management Platform

## Overview
This project implements a **Bookstore Management Platform** using the MVC (Model-View-Controller) architecture in **ASP.NET Core**. It provides a basic system to manage books with CRUD (Create, Read, Update, Delete) functionality. Users can add, view, edit, and delete books, and optionally search feature to filter books by **title** or **author**.
### Key Features:
- Full MVC-based ASP.NET Core project.
- CRUD operations for managing books.
- Data management using **Entity Framework Core** with SQL Server as the database.
- Form validation for book creation and editing.
- Optional search feature for filtering books.

## Application Setup

1. **Create a New Project:**
   - Set up a new **ASP.NET Core MVC Web Application** for the Bookstore platform.
   
2. **Database Setup:**
   - Configure your database connection using **SQL Server**.
   - In `appsettings.json`, set the connection string to connect to your database.

3. **NuGet Packages:**
   From the NuGet Package Manager, add the following packages:
   ```bash
   Install-Package Microsoft.EntityFrameworkCore.SqlServer
   Install-Package Microsoft.EntityFrameworkCore.Tools
   Install-Package Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
   Install-Package Microsoft.EntityFrameworkCore.Design
   ```

## Tasks

### 1. Create the **Book Model**
   - Define the `Book` model with the following properties:
     - `Title` (string, required)
     - `Author` (string, required)
     - `Price` (decimal, range constraint)
     - `Genre` (string)
   - Apply validation attributes like `[Required]`, `[StringLength]`, and `[Range]` to ensure data validation.

### 2. Set Up the **Database Context**
   - Create a database context (e.g., `BookstoreContext`) to manage the `Book` model.
   - Register the database context in the application’s service configuration (`Startup.cs` or `Program.cs`).

### 3. Create the **BooksController**
   Implement a controller to handle CRUD operations for the `Book` model:
   - **Index**: Display a list of all books.
   - **Create**: Add new books to the list.
   - **Edit**: Update existing books.
   - **Delete**: Remove books from the system.
   - **Details**: View detailed information about a specific book.

### 4. Create the **Views**
   - Implement **Razor Views** for each action (Index, Create, Edit, Delete, Details).
   - For **Create** and **Edit** views, implement forms with validation using `asp-for` for model binding and validation error handling.
   - Ensure validation errors are displayed for invalid inputs or missing required fields.

### 5. Implement CRUD Operations
   - Use **Entity Framework Core** to implement CRUD operations.
   - Ensure data is stored persistently in the database.
