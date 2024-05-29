using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
using System.Reflection;
using TravelMapTurkey.Service.FluentValidations;
using TravelMapTurkey.Service.Helpers.Images;
using TravelMapTurkey.Service.Services.Abstraction;
using TravelMapTurkey.Service.Services.Concrete;

namespace TravelMapTurkey.Service.Extensions
{
    public static class ServiceLayerExtensions 
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<ICityService, CityService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IImageHelper, ImageHelper>();

            services.AddAutoMapper(assembly);

            services.AddControllersWithViews().AddFluentValidation(opt =>
            {
                opt.RegisterValidatorsFromAssemblyContaining<UserValidator>();
                opt.DisableDataAnnotationsValidation = true;
                opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
            });
            return services;
        }
    }
}
