using System.Text;
using FluentValidation;
using CB.Application.Tools;
using CB.Persistence.Context;
using CB.Application.Services;
using CB.Application.Container;
using CB.Application.Interfaces;
using CB.Persistence.Repositories;
using FluentValidation.AspNetCore;
using Microsoft.IdentityModel.Tokens;
using CB.Application.Features.Repository;
using CB.Application.Interfaces.CarInterfaces;
using CB.Application.Interfaces.BlogInterfaces;
using CB.Persistence.Repositories.CarRepository;
using CB.Application.Interfaces.ReviewInterfaces;
using CB.Application.Interfaces.AppUserInterfaces;
using CB.Application.Interfaces.AppRoleInterfaces;
using CB.Persistence.Repositories.BlogRepositories;
using CB.Application.Interfaces.TagCloudInterfaces;
using CB.Application.Interfaces.RentACarInterfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using CB.Application.Interfaces.CarPricingInterfaces;
using CB.Application.Interfaces.StaticticsInterfaces;
using CB.Application.Interfaces.CarFeatureInterfaces;
using CB.Persistence.Repositories.ReviewRepositories;
using CB.Persistence.Repositories.CommentRepositories;
using CB.Persistence.Repositories.AppUserRepositories;
using CB.Persistence.Repositories.AppRoleRepositories;
using CB.Persistence.Repositories.TagCloudRepositories;
using CB.Persistence.Repositories.RentACarRepositories;
using CB.Persistence.Repositories.CarPricingRepositories;
using CB.Persistence.Repositories.StaticticsRepositories;
using CB.Persistence.Repositories.CarFeatureRepositories;
using CB.Application.Interfaces.CarDescriptionInterfaces;
using CB.Persistence.Repositories.CarDescriptionRepositories;
using CB.Application.Features.Mediator.Commands.ReviewCommands;
using CB.WebApi.Hubs;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
// Add services to the container.

// Registiration
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
builder.Services.AddScoped(typeof(IAppUserRepository), typeof(AppUserRepository));
builder.Services.AddScoped(typeof(IAppRoleRepository), typeof(AppRoleRepository));

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    });
});
builder.Services.AddSignalR();

// For CQRS
builder.Services.ContainerDependecies();

// For Mediator
builder.Services.AddApplicationService(builder.Configuration);

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<CreateReviewCommand>();
builder.Services.AddValidatorsFromAssemblyContaining<UpdateReviewCommand>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new TokenValidationParameters
    {
        ValidAudience = JwtTokenDefaults.ValidAudience,
        ValidIssuer = JwtTokenDefaults.ValidIssuer,
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)),
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true
    };
});

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

app.UseCors("CorsPolicy");

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapHub<CarHub>("/carhub");

app.Run();
