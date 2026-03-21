using EcommerceAdmin.Core.Entities;
using EcommerceAdmin.Core.Interfaces;
using EcommerceAdmin.Infrastructure.Data;
using EcommerceAdmin.Infrastructure.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StackExchange.Redis;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Task 1.1: Configure Entity Framework Core for SQL Server (Identity & User Management)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServerConnection")));

builder.Services.AddIdentity<SuperAdmin, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Task 1.2: Configure Npgsql / EF Core for PostgreSQL (Product Catalog)
builder.Services.AddDbContext<CatalogDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgresConnection")));

// Task 1.3: Set up StackExchange.Redis for distributed caching
var redisConnection = builder.Configuration.GetConnectionString("RedisConnection");
builder.Services.AddSingleton<IConnectionMultiplexer>(ConnectionMultiplexer.Connect(redisConnection!));
builder.Services.AddScoped<ICacheService, RedisCacheService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

// Health Check Endpoint
app.MapGet("/health", () => Results.Ok(new { Status = "Healthy", Databases = "Pending" }))
   .WithName("HealthCheck")
   .WithOpenApi();

app.Run();
