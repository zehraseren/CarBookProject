using Microsoft.Extensions.DependencyInjection;
using CB.Application.Features.CQRS.Handlers.CarHandlers;
using CB.Application.Features.CQRS.Handlers.AboutHandlers;
using CB.Application.Features.CQRS.Handlers.BrandHandlers;
using CB.Application.Features.CQRS.Handlers.BannerHandlers;
using CB.Application.Features.CQRS.Handlers.ContactHandlers;
using CB.Application.Features.CQRS.Handlers.CategoryHandlers;

namespace CB.Application.Container
{
    public static class Extentions
    {
        public static void ContainerDependecies(this IServiceCollection services)
        {
            services.AddScoped<GetAboutQueryHandler>();
            services.AddScoped<GetAboutByIdQueryHandler>();
            services.AddScoped<CreateAboutCommandHandler>();
            services.AddScoped<RemoveAboutCommandHandler>();
            services.AddScoped<UpdateAboutCommandHandler>();

            services.AddScoped<GetBannerQueryHandler>();
            services.AddScoped<GetBannerByIdQueryHandler>();
            services.AddScoped<CreateBannerCommandHandler>();
            services.AddScoped<RemoveBannerCommandHandler>();
            services.AddScoped<UpdateBannerCommandHandler>();

            services.AddScoped<GetBrandQueryHandler>();
            services.AddScoped<GetBrandByIdQueryHandler>();
            services.AddScoped<CreateBrandCommandHandler>();
            services.AddScoped<RemoveBrandCommandHandler>();
            services.AddScoped<UpdateBrandCommandHandler>();

            services.AddScoped<GetCarQueryHandler>();
            services.AddScoped<GetCarByIdQueryHandler>();
            services.AddScoped<CreateCarCommandHandler>();
            services.AddScoped<RemoveCarCommandHandler>();
            services.AddScoped<UpdateCarCommandHandler>();
            services.AddScoped<GetCarWithBrandQueryHandler>();

            services.AddScoped<GetCategoryQueryHandler>();
            services.AddScoped<GetCategoryByIdQueryHandler>();
            services.AddScoped<CreateCategoryCommandHandler>();
            services.AddScoped<RemoveCategoryCommandHandler>();
            services.AddScoped<UpdateCategoryCommandHandler>();

            services.AddScoped<GetContactQueryHandler>();
            services.AddScoped<GetContactByIdQueryHandler>();
            services.AddScoped<CreateContactCommandHandler>();
            services.AddScoped<RemoveContactCommandHandler>();
            services.AddScoped<UpdateContactCommandHandler>();
        }
    }
}
