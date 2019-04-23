# ASP.NET Core 2.2 Tutorial

[Reference](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-2.2&tabs=visual-studio-code)

## Creating Web API with ASP.NET Core MVC

### API Structure

| API                   | Description               | Request    | Response             |
| --------------------- | ------------------------- | ---------- | -------------------- |
| GET /api/todo         | Get all to-do items.      | None       | Array of to-do items |
| GET /api/todo/{id}    | Get an item by ID         | None       | To-do item           |
| POST /api/todo        | Add a new item            | To-do item | To-do item           |
| PUT /api/todo/{id}    | Update and existing item. | To-do item | To-do item           |
| DELETE /api/todo/{id} | Delete an item            | None       | None                 |

*Schematic Diagram*:

![Schematic Diagram](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api/_static/architecture.png?view=aspnetcore-2.2)

## Create Web Project

```powershell
dotnet new webapi -o ToDoApi
code -r ToDoApi
```

## Test API

Project template creates a `values` API. Call `GET` method to test app.

## Add Model class

*Model*: Set of classes that represent the data the app manages.

`Id`: Property functioning as the unique key in a relational database.

`Models`: Folder used by convention.

## Add databse context

*Database context*: Main class that coordinates Entity Framework functionality for data model.

Create by deriving from `Microsoft.EntityFrameworkCore.DbContext` class.

## Register database context

For ASP.NET Core, services like DB context must be registered with the [dependency injection (DI)](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.2) container. The container provides the service to controllers.

- Remove unused `using` declarations
- Add database context to DI container
- Specify database context used (in-memory database)

## Add a controller

- Define API controller class without methods
- Decoreate class with `[ApiController]`