using AutoMapper;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using TravelMapTurkey.Data.UnitOfWorks;
using TravelMapTurkey.Entity.Entities;
using TravelMapTurkey.Entity.ViewModel.Cities;
using TravelMapTurkey.Service.Extensions;
using TravelMapTurkey.Service.Services.Abstraction;

namespace TravelMapTurkey.Service.Services.Concrete
{
    public class CityService : ICityService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ClaimsPrincipal _user;

        public CityService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
        }
        public async Task<List<CityViewModel>> GetAllCitiesWithCityReviewNonDeletedAsync()
        {
            var cities = await unitOfWork.GetRepository<City>().GetAllAsync(x=>!x.IsDeleted, r=>r.CityReview);
            var map = mapper.Map<List<CityViewModel>>(cities);
            return map;
        }

        

        public async Task<int> CreateCityWithReviewAndImageAsync(CityAddViewModel cityAddViewModel)
        {
            int userIdentification = _user.GetLoggedInUserId();

            var allCities = await GetAllCitiesByUserIdAsync(userIdentification);

            var existCity = allCities.Find(x => x.CityName == cityAddViewModel.CityName);

            if (existCity == null)
            {
                City city = new(cityName: cityAddViewModel.CityName, userId: userIdentification, cityAddViewModel.Type);
                await unitOfWork.GetRepository<City>().AddAsync(city);
                await unitOfWork.SaveAsync();

                CityReview cityReview = new(review: cityAddViewModel.Review, cityId: city.Id);
                await unitOfWork.GetRepository<CityReview>().AddAsync(cityReview);
                await unitOfWork.SaveAsync();
            } else
            {
                var existCityReview = await unitOfWork.GetRepository<CityReview>().GetAsync(x => x.Id == existCity.CityReview.Id, null);
                
                
                existCity.UserId = cityAddViewModel.UserId;
                existCity.CityName = cityAddViewModel.CityName;
                existCity.CityReview.Review = cityAddViewModel.Review;
                existCity.Type = cityAddViewModel.Type;
                var cityMap = mapper.Map<City>(existCity); 
                await unitOfWork.GetRepository<City>().UpdateAsync(cityMap);
                await unitOfWork.SaveAsync();

            }
            
            return userIdentification;
        }

        public async Task<List<City>> GetAllCitiesByUserIdAsync(int userId)
        {
            var cities = await unitOfWork.GetRepository<City>().GetAllAsync(x => x.UserId == userId, c => c.CityReview);
            return cities;
        }
    }
}
