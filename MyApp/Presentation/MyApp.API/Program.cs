using Microsoft.EntityFrameworkCore;
using MyApp.Application.Services;
using MyApp.Core.Interfaces;
using MyApp.Infrastructure.Data;
using MyApp.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configure EF Core to use SQL Server
builder.Services.AddDbContext<CustomerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register dependencies
//builder.Services.AddScoped<ICustomerRepository, InMemoryCustomerRepository>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<CustomerService>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
