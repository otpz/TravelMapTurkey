using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TravelMapTurkey.Data.UnitOfWorks;
using TravelMapTurkey.Entity.Entities;
using TravelMapTurkey.Entity.ViewModel.Cities;
using TravelMapTurkey.Service.Extensions;
using TravelMapTurkey.Service.Helpers.Images;
using TravelMapTurkey.Service.Services.Abstraction;

namespace TravelMapTurkey.Service.Services.Concrete
{
    public class CityService : ICityService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IImageHelper imageHelper;
        private readonly ClaimsPrincipal _user;

        public CityService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor, IImageHelper imageHelper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.imageHelper = imageHelper;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task<int> CreateOrUpdateCityWithReviewAndImageAsync(CityAddViewModel cityAddViewModel)
        {
            int userIdentification = _user.GetLoggedInUserId();

            string userEmail = _user.GetLoggedInUserEmail();
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

                if (cityAddViewModel.Photo != null)
                {
                    var imageUpload = await imageHelper.Upload($"{cityAddViewModel.CityName}-{cityAddViewModel.Review[0]}-{cityAddViewModel.Type}", cityAddViewModel.Photo);
                    Image image = new(imageUpload.FullName, cityAddViewModel.Photo.ContentType, cityReview.Id);
                    await unitOfWork.GetRepository<Image>().AddAsync(image);
                    await unitOfWork.SaveAsync();
                }
            } else
            {
                var existCityReview = await unitOfWork.GetRepository<CityReview>().GetAsync(x => x.Id == existCity.CityReview.Id, null);
                existCity.UserId = cityAddViewModel.UserId;
                existCity.CityName = cityAddViewModel.CityName;
                existCity.CityReview.Review = cityAddViewModel.Review;

                if (cityAddViewModel.Photo != null)
                {
                    imageHelper.Delete(existCity.CityReview.Image.FileName);

                    var imageUpload = await imageHelper.Upload($"{cityAddViewModel.CityName}-{cityAddViewModel.Review[0]}-{cityAddViewModel.Type}", cityAddViewModel.Photo);
                    Image image = new(imageUpload.FullName, cityAddViewModel.Photo.ContentType, existCity.CityReview.Id);
                    await unitOfWork.GetRepository<Image>().AddAsync(image);
                    await unitOfWork.SaveAsync();
                    existCity.CityReview.Image.Id = image.Id;
                }
                else
                {
                    existCity.CityReview.Image = existCity.CityReview.Image;
                }

                existCity.Type = cityAddViewModel.Type;
                var cityMap = mapper.Map<City>(existCity); 
                await unitOfWork.GetRepository<City>().UpdateAsync(cityMap);
                await unitOfWork.SaveAsync();
            }
            return userIdentification;
        }

        public async Task<List<City>> GetAllCitiesByUserIdAsync(int userId)
        {
            var cities = await unitOfWork.GetRepository<City>().GetAllAsync(x => x.UserId == userId, include: x => x.Include(c => c.CityReview).ThenInclude(r => r.Image), null);
            return cities;
        }
    }
}
