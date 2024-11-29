using CB.Persistence.Context;
using CB.Application.Services;
using CB.Application.Container;
using CB.Application.Interfaces;
using CB.Persistence.Repositories;
using CB.Application.Interfaces.CarInterfaces;
using CB.Application.Interfaces.BlogInterfaces;
using CB.Persistence.Repositories.CarRepository;
using CB.Persistence.Repositories.BlogRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<CarBookContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
builder.Services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));

// For CQRS
builder.Services.ContainerDependecies();

// For Mediator
builder.Services.AddApplicationService(builder.Configuration);

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
