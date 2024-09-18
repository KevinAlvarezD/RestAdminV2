# RestAdmin

<div style="text-align: center;">
    <img src="https://www.restadmin.co/images/restadmin.png" alt="Logo" width="200" style="display: block; margin: 0 auto;"/>
</div>


RestAdmin is a comprehensive billing system for restaurants. It is a web API created in C# and .NET, using Swagger for documentation. The system includes CRUD (Create, Read, Update, Delete) functionalities and specialized queries to the database.

![License](https://img.shields.io/badge/license-MIT-blue.svg) ![Version](https://img.shields.io/badge/version-1.0.0-blue.svg)

## Index

1. [Description](#description)
2. [Features](#features)
3. [Technologies](#technologies)
4. [Installation](#installation)
5. [Usage](#usage)
6. [Contribution](#contribution)
7. [License](#license)
8. [Credits](#credits)
9. [Contact](#contact)

## Description

RestAdmin is a billing solution for restaurants that allows you to manage orders, invoices, and customer data through a robust API. The system allows for CRUD operations and executes advanced queries on the database to obtain specific and useful information.

## Features

- **Complete CRUD:** Create, read, update, and delete records of orders, invoices, and customers.
- **Specialized Queries:** Execute advanced queries to obtain detailed information.
- **Swagger Documentation:** Interact with the API intuitively through Swagger UI.
- **Security and Control:** Access management and authorization to protect sensitive data.

## Technologies

- **Languages:** C#
- **Frameworks:** .NET Core
- **Documentation:** Swagger
- **Database:** MySQL
- **ORM:** Entity Framework Core

## Installation

### Prerequisites

- **.NET Core SDK:** Ensure that you have the .NET Core SDK (version 3.1 or higher) installed.
- **MySQL:** You must have MySQL installed and configured on your machine.

### Cloning the Repository

```bash
git clone https://github.com/your_user/restadmin.git
```

### Installing Dependencies

```bash
cd restadmin
dotnet restore
```

### Configuration

1. **Database:**
   - Create a database in MySQL and configure the connection string in `appsettings.json`.

2. **Migrations:**
   - Run the migrations to create the tables in the database:

   ```bash
   dotnet ef database update
   ```

### Running

To run the API locally:

```bash
dotnet run
```

The API will be available at `https://restadmin.azurewebsites.net/index.html`. You can access the official page at `www.restadmin.co`.

## Usage

To interact with the API, you can use tools like Postman or the integrated Swagger UI. Here’s an example of how to make a GET request to retrieve all orders:

```bash
curl -X GET "http://localhost:5000/api/orders"
```

## Contribution

If you would like to contribute to the project, please follow these steps:

1. **Fork the repository.**

2. **Create a branch for your feature:**

   ```bash
   git checkout -b feature/new-feature
   ```

3. **Make your changes and commit:**

   ```bash
   git commit -am 'Added new feature'
   ```

4. **Push the branch:**

   ```bash
   git push origin feature/new-feature
   ```

5. **Create a pull request on GitHub.**

### Code of Conduct

Please follow the established code of conduct to maintain a collaborative environment.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for more details.

## Credits

- **Authors:**
  - Kevin Alvarez Diaz
  - Luis Alejandro Londoño Valle
  - Alejandro Castrillon

- **Libraries or Resources:** Thanks to any libraries or resources used in the project.

## Contact

- **Kevin Alvarez Diaz:** [GitHub](https://github.com/KevinAlvarezD)
- **Luis Alejandro Londoño Valle:** [GitHub](https://github.com/AlejandroLondonoValle)
- **Alejandro Castrillon:** [GitHub](https://github.com/CODEALEJO)
