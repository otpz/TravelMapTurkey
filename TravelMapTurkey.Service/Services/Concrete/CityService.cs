using AutoMapper;
using TravelMapTurkey.Data.UnitOfWorks;
using TravelMapTurkey.Entity.Entities;
using TravelMapTurkey.Entity.ViewModel.Cities;
using TravelMapTurkey.Service.Services.Abstraction;

namespace TravelMapTurkey.Service.Services.Concrete
{
    public class CityService : ICityService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public CityService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<List<CityViewModel>> GetAllCitiesWithCityReviewNonDeletedAsync()
        {
            var cities = await unitOfWork.GetRepository<City>().GetAllAsync(x=>!x.IsDeleted, u => u.User, r=>r.CityReview);
            var map = mapper.Map<List<CityViewModel>>(cities);
            return map;
        }
    }
}
