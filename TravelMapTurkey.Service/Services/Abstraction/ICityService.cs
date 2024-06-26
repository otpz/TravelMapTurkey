﻿using TravelMapTurkey.Entity.Entities;
using TravelMapTurkey.Entity.ViewModel.Cities;

namespace TravelMapTurkey.Service.Services.Abstraction
{
    public interface ICityService
    {
        Task<int> CreateOrUpdateCityWithReviewAndImageAsync(CityAddViewModel cityAddViewModel);
    }
}
