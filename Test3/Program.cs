using Microsoft.EntityFrameworkCore;
using Test3.Data;
using Test3.Interfaces;
using Test3.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserLogService, UserLogService>();
builder.Services.AddScoped<ISystemUserLogsCollection, SystemUserLogsCollection>();

builder.Services.AddScoped<IDbInitializer, DbInitializer>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<UserLogsDbContext>(options =>
    options.UseInMemoryDatabase("UserLogsDb"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

await ApplyMigrations();

await app.RunAsync();

async Task ApplyMigrations()
{
    using (var scope = app.Services.CreateScope())
    {
        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();

        await dbInitializer.InitializeAsync();
    }
}