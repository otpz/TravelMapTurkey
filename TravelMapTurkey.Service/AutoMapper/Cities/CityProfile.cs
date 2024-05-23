using AutoMapper;
using TravelMapTurkey.Entity.Entities;
using TravelMapTurkey.Entity.ViewModel.Cities;

namespace TravelMapTurkey.Service.AutoMapper.Cities
{
    public class CityProfile: Profile
    {
        public CityProfile()
        {
            CreateMap<City, CityViewModel>().ReverseMap();
        }
    }
}
