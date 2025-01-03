using CB.Persistence.Context;
using CB.Application.Services;
using CB.Application.Container;
using CB.Application.Interfaces;
using CB.Persistence.Repositories;
using CB.Application.Features.Repository;
using CB.Application.Interfaces.CarInterfaces;
using CB.Application.Interfaces.BlogInterfaces;
using CB.Persistence.Repositories.CarRepository;
using CB.Persistence.Repositories.BlogRepositories;
using CB.Application.Interfaces.TagCloudInterfaces;
using CB.Application.Interfaces.RentACarInterfaces;
using CB.Application.Interfaces.CarPricingInterfaces;
using CB.Application.Interfaces.StaticticsInterfaces;
using CB.Application.Interfaces.CarFeatureInterfaces;
using CB.Persistence.Repositories.CommentRepositories;
using CB.Persistence.Repositories.TagCloudRepositories;
using CB.Persistence.Repositories.RentACarRepositories;
using CB.Persistence.Repositories.CarPricingRepositories;
using CB.Persistence.Repositories.StaticticsRepositories;
using CB.Persistence.Repositories.CarFeatureRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<CarBookContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepository));
builder.Services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
builder.Services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
builder.Services.AddScoped(typeof(IRentACarRepository), typeof(RentACarRepository));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(CommentRepository<>));
builder.Services.AddScoped(typeof(ICarPricingRepository), typeof(CarPricingRepository));
builder.Services.AddScoped<IStaticticsRepository, StaticticsRepository>();
builder.Services.AddScoped<ICarFeatureRepository, CarFeatureRepository>();

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
