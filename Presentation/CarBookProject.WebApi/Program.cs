using FluentValidation;
using CB.Persistence.Context;
using CB.Application.Services;
using CB.Application.Container;
using CB.Application.Interfaces;
using CB.Persistence.Repositories;
using FluentValidation.AspNetCore;
using CB.Application.Features.Repository;
using CB.Application.Interfaces.CarInterfaces;
using CB.Application.Interfaces.BlogInterfaces;
using CB.Persistence.Repositories.CarRepository;
using CB.Application.Interfaces.ReviewInterfaces;
using CB.Persistence.Repositories.BlogRepositories;
using CB.Application.Interfaces.TagCloudInterfaces;
using CB.Application.Interfaces.RentACarInterfaces;
using CB.Application.Interfaces.CarPricingInterfaces;
using CB.Application.Interfaces.StaticticsInterfaces;
using CB.Application.Interfaces.CarFeatureInterfaces;
using CB.Persistence.Repositories.ReviewRepositories;
using CB.Persistence.Repositories.CommentRepositories;
using CB.Persistence.Repositories.TagCloudRepositories;
using CB.Persistence.Repositories.RentACarRepositories;
using CB.Persistence.Repositories.CarPricingRepositories;
using CB.Persistence.Repositories.StaticticsRepositories;
using CB.Persistence.Repositories.CarFeatureRepositories;
using CB.Application.Interfaces.CarDescriptionInterfaces;
using CB.Persistence.Repositories.CarDescriptionRepositories;
using CB.Application.Features.Mediator.Commands.ReviewCommands;

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
builder.Services.AddScoped(typeof(IStaticticsRepository), typeof(StaticticsRepository));
builder.Services.AddScoped(typeof(ICarFeatureRepository), typeof(CarFeatureRepository));
builder.Services.AddScoped(typeof(ICarDescriptionRepository), typeof(CarDescriptionRepository));
builder.Services.AddScoped(typeof(IReviewRepository), typeof(ReviewRepository));

// For CQRS
builder.Services.ContainerDependecies();

// For Mediator
builder.Services.AddApplicationService(builder.Configuration);

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<CreateReviewCommand>();
builder.Services.AddValidatorsFromAssemblyContaining<UpdateReviewCommand>();

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
