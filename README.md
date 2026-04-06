 Student Management System 
 
📌 Description

This project is a Student Management System developed using ASP.NET Core Web API.
It provides APIs to perform CRUD operations on student data with secure access using JWT authentication.

🚀 Functionality

* Perform CRUD operations (Add, View, Update, Delete students)
* Secure endpoints using JWT authentication
* Handle errors using global exception middleware
* Test APIs using Swagger

🧱 Architecture

The project follows layered architecture:
* Controller → Handles API requests
* Service → Business logic
* Repository → Database operations

🛠️ Technologies

* ASP.NET Core Web API
* Entity Framework Core(Code First Approach)
* SQL Server
* JWT Authentication
* Swagger

⚙️ How to Run

1. Open the project in Visual Studio 2022
2. Update connection string in `appsettings.json`
3. Run migration:
   * Add-Migration InitialCreate
   * Update-Database
4. Run the project (F5)

🔐 How to Access APIs

1. Call: POST `/api/auth/login`
2. Copy the token
3. Click 🔒 Authorize in Swagger
4. Enter:
   Bearer {YOUR_TOKEN}

📡 APIs
* GET /api/student
* POST /api/student
* PUT /api/student
* DELETE /api/student/{id}

Author: 
Nidhi Pokale
