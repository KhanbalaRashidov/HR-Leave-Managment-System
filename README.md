# Techical Stack
- ASP.NET Core 6.0 (with .NET Core 6.0)
- ASP.NET WebApi Core
- ASP.NET Identity Core
- Entity Framework Core
- .NET Core Native DI
- AutoMapper
- FluentValidator
- MediatR
- Swagger UI
- MSSQL
- xUnit
- Moq


# Design Patterns
- Domain Driven Design
- Domain Events
- Domain Notification
- CQRS
- Repository & Generic Repository
- Inversion of Control / Dependency injection
- ORM
- Mediator


# How to run
- Visual Studio: `Just run`
- VSCode: `Just run`


# Testing
- Terminal: `dotnet test`

<!-- # Docker

```sh
docker build -t aspnetcore-docker-image .
docker run -it --rm -p 3000:80 --name aspnetcore-docker-container aspnetcore-docker-image
docker run -d -p 3000:80 --name aspnetcore-docker-container aspnetcore-docker-image
``` -->

- http://localhost:5000/

# Swagger (Dev env only)
- http://localhost:5000/swagger

# Health check (Staging & Prod env only)
- http://localhost:5000/hc-ui
- http://localhost:5000/hc-json