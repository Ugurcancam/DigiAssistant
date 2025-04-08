using System.Reflection;
using DigiAssistant.Core.Repositories;
using DigiAssistant.Core.Services;
using DigiAssistant.Core.UnitOfWork;
using DigiAssistant.Repository;
using DigiAssistant.Repository.Repositories;
using DigiAssistant.Repository.UnitOfWork;
using DigiAssistant.Service.Mapping;
using DigiAssistant.Service.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));

// AutoMapper
builder.Services.AddAutoMapper(typeof(MapProfile));

//Database Context
builder.Services.AddDbContext<AppDbContext>
(
    x =>
    {
        x.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer"),option =>
        {
            option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext))!.GetName().Name);
        });
    }
);

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

app.Run();
