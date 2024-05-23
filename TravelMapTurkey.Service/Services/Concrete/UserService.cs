using AutoMapper;
using Microsoft.AspNetCore.Http;
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
    }
}
