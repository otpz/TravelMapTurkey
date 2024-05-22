using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TravelMapTurkey.Data.Context;
using TravelMapTurkey.Data.Repositories.Abstractions;
using TravelMapTurkey.Data.Repositories.Concretes;
using TravelMapTurkey.Data.UnitOfWorks;

namespace TravelMapTurkey.Data.Extension
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
