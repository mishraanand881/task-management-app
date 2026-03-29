using System;
using Microsoft.EntityFrameworkCore;
using Task_Management_App.Data;
using Task_Management_App.TaskIServices;
using Task_Management_App.TaskServices;

var builder = WebApplication.CreateBuilder(args);

// ? Add DbContext (IMPORTANT)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ? Add Service
builder.Services.AddScoped<ITaskService, TaskService>();

// ? Add Controllers
builder.Services.AddControllers();

// ? Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ? CORS (Angular connect ke liye)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        policy => policy.AllowAnyOrigin()
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});

var app = builder.Build();

// ? Swagger UI
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ? Enable CORS
app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();