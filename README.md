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

