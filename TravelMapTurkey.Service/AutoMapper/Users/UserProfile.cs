﻿using AutoMapper;
using TravelMapTurkey.Entity.Entities;
using TravelMapTurkey.Entity.ViewModel.Users;

namespace TravelMapTurkey.Service.AutoMapper.Users
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AppUser, UserRegisterViewModel>().ReverseMap();
            CreateMap<AppUser, UserLoginViewModel>().ReverseMap();
        }
    }
}