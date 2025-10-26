using BugStore.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connctString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlite(connctString));
var app = builder.Build();



app.MapGet("/", () => "Hello World!");

app.Run();
