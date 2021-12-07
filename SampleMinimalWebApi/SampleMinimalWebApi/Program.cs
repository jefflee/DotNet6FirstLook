var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.MapGet("/", () => "Hello World!");
app.UseSwaggerUI();

app.Run();

//using Microsoft.AspNetCore.Mvc;
//using SampleMinimalWebApi.Model;

//var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddEndpointsApiExplorer();

//builder.Services.AddSwaggerGen();

//builder.Services.AddScoped<IToDoItemRepository, ToDoItemRepository>();

//var app = builder.Build();

//app.UseSwagger();

//app.MapGet("/api/todo/all", async ([FromServices] IToDoItemRepository repository) =>
//{
//   return repository.GetAll();
//});

//app.MapGet("/api/todo/{id}", async ([FromServices] IToDoItemRepository repository, int id) =>
//{
//    return repository.GetById(id);
//});

//app.MapPost("/api/todo", async ([FromServices] IToDoItemRepository repository, ToDoItem item) =>
//{
//    repository.CreateNewToDoItem(item);
//    return Results.Created($"/api/todo/{item.Id}", item);
//});

//app.UseSwaggerUI();

//app.Run();
