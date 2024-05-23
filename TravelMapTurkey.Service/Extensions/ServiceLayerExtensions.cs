using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
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

            services.AddAutoMapper(assembly);

            return services;
        }
    }
}
