﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using TravelMapTurkey.Data.UnitOfWorks;
using TravelMapTurkey.Entity.Entities;
using TravelMapTurkey.Entity.ViewModel.Users;
using TravelMapTurkey.Service.Extensions;
using TravelMapTurkey.Service.Services.Abstraction;

namespace TravelMapTurkey.Service.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ClaimsPrincipal _user;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task<UserViewModel> GetLoggedInUserProfileAsync()
        {
            var userId = _user.GetLoggedInUserId();
            var getUserProfile = await unitOfWork.GetRepository<AppUser>().GetByIdAsync(userId);
            var userViewModelMap = mapper.Map<UserViewModel>(getUserProfile);
            return userViewModelMap;
        }

        public async Task<UserProfileViewModel> GetUserByIdAsync(int userId)
        {
            var user = await unitOfWork.GetRepository<AppUser>().GetByIdAsync(userId);
            var userViewModelMap = mapper.Map<UserProfileViewModel>(user);
            return userViewModelMap;
        }

        public async Task<UserProfileViewModel> GetUserProfileByIdAsync(int userId)
        {
            var userById = await unitOfWork.GetRepository<AppUser>().GetByIdAsync(userId);
            if (userById == null)
                return null;

            var user = await unitOfWork.GetRepository<AppUser>().GetAsync(x => x.Id == userById.Id, include: x=>x.Include(c=>c.Cities).ThenInclude(r=>r.CityReview).ThenInclude(i=>i.Image));

            var userViewModelMap = mapper.Map<UserProfileViewModel>(user);
            return userViewModelMap;
        }

        public async Task UpdateUserSettingsAsync(UserUpdateViewModel userUpdateViewModel)
        {
            var user = await unitOfWork.GetRepository<AppUser>().GetAsync(x => x.Id == userUpdateViewModel.Id, null);

            user.Email = userUpdateViewModel.Email;
            user.FirstName = userUpdateViewModel.FirstName;
            user.LastName = userUpdateViewModel.LastName;
            user.Biography = userUpdateViewModel.Biography;

            await unitOfWork.GetRepository<AppUser>().UpdateAsync(user);
            await unitOfWork.SaveAsync();
        }

        public async Task<List<UserListViewModel>> GetAllUserWithCityAndImageAsync()
        {
            var users = await unitOfWork.GetRepository<AppUser>().GetAllAsync(null, include: x=>x.Include(c=>c.Cities).ThenInclude(r=>r.CityReview).ThenInclude(i=>i.Image), orderBy: r=>r.OrderByDescending(x => x.Cities.Count()));
            var userListMap = mapper.Map<List<UserListViewModel>>(users);
            return userListMap;
        }
    }
}
