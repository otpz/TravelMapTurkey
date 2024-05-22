using TravelMapTurkey.Data.UnitOfWorks;
using TravelMapTurkey.Entity.Entities;
using TravelMapTurkey.Entity.ViewModel.Cities;
using TravelMapTurkey.Service.Services.Abstraction;

namespace TravelMapTurkey.Service.Services.Concrete
{
    public class CityService : ICityService
    {
        private readonly IUnitOfWork unitOfWork;

        public CityService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public async Task<List<City>> GetAllCitiesWithCityReviewNonDeletedAsync()
        {
            var cities = await unitOfWork.GetRepository<City>().GetAllAsync(x=>!x.IsDeleted, u => u.User, r=>r.CityReview);
            return cities;
        }


    }
}
