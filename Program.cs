using Microsoft.EntityFrameworkCore;
using RestApi.Models;
using RestApi.Models.DataManager;
using RestApi.Models.Entities;
using RestApi.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//Application Db context
builder.Services.AddDbContext<ApplicationDbContext>(
    options=> options.UseSqlServer(builder.Configuration.GetConnectionString("default"))
    );

builder.Services.AddScoped<IDataRepository<Product> , ProductDataManager>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
