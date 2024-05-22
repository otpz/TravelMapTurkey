using TravelMapTurkey.Entity.Entities;

namespace TravelMapTurkey.Service.Services.Abstraction
{
    public interface ICityService
    {
        Task<List<City>> GetAllCitiesWithCityReviewNonDeletedAsync();
    }
}
