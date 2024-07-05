This repository contains a RESTful API built using ASP.NET Core. The API provides CRUD operations for managing products, demonstrating the code-first approach with Entity Framework Core, dependency injection, and repository patterns.

**Features**
RESTful API with CRUD operations for products.
Code-first approach using Entity Framework Core.
Repository pattern for data access.
Dependency injection for repository management.
Basic error handling and response status codes.

**Technologies Used**
ASP.NET Core
Entity Framework Core
SQL Server
Dependency Injection

**Project Structure**
Controllers: Contains the ProductsController which handles HTTP requests and responses.
Models: Contains the entity classes and context for the database.
Repository: Contains the repository interface and its implementation for data access.
Migrations: Contains database migrations for the code-first approach.

**Endpoints**
GET /api/products: Retrieve all products.
GET /api/products/{id}: Retrieve a product by ID.
POST /api/products: Create a new product.
PUT /api/products/{id}: Update an existing product.
DELETE /api/products/{id}: Delete a product by ID.

**Contributing**
Contributions are welcome! Please fork the repository and create a pull request with your changes. Ensure that your code follows the existing style and conventions.

**License**
This project is licensed under the MIT License. See the LICENSE file for more details.





