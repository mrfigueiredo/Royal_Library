# Royal Library

This project is a web application built using ASP.NET Core for the backend, React for the frontend and MSSQL for the database. The entire application will be containerized using Docker for easy deployment and management soon.

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Node.js](https://nodejs.org/)
- [npm](https://www.npmjs.com/) or [Yarn](https://yarnpkg.com/)
- [MSSQL](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)

### Installing

1. Clone the repository:
   

```
git clone https://github.com/mrfigueiredo/Royal_Library.git
```

### Database setup

1. Create an MSSQL Server using the Client or running with Docker.
2. Create a new database following the assessment instructions.

### Backend Setup

#### Connect your database

1. After creating the database, get the url, port, user and password.
2. Open the appsettings.Development.json or appsettings.json ( depending on which env you are running)
3. Change the ConnectionString.DefaultConnection property with your database info as follow:
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "ConnectionStrings": {
    "DefaultConnection": "Server=tcp:<YHOUR_DATABASE_URL>;Database=<YOUR_DATABASE_NAME>;User ID=<YOUR_USER>;Password=<YOUR_PASSWORD>;TrustServerCertificate=True"
  }
}
```

#### Running the project

1. Open the prompt from your OS
```
cd <project_directory_root>.Royal_Library_Matheus_Figueiredo.Server
```
3. Restore dependencies
```
dotnet restore
```
3. Build the project
```
dotnet build
```
4. Run the project
```
dotnet run
```
Now let it running.

### Frontent Seupt

1. Open the prompt from your OS
```
cd <project_directory_root>.Royal_Library_Matheus_Figueiredo.client
```
2. Install dependencies
```
npm install 
```
or 
```
yarn
```
3. Run the project
```
npm run dev
```
or
```
yarn run dev
```
Now you can access the Application Page on your browser [http://localhost:5173/](http://localhost:5173/)
