using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using System.Security.Claims;
using TravelMapTurkey.Data.UnitOfWorks;
using TravelMapTurkey.Entity.Entities;
using TravelMapTurkey.Entity.ViewModel.Users;
using TravelMapTurkey.Service.Services.Abstraction;

namespace TravelMapTurkey.Service.Services.Concrete
{
    public class AuthService : IAuthService
    {
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<AppRole> roleManager;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly SignInManager<AppUser> signInManager;
        private readonly ClaimsPrincipal _user;

        public AuthService(IMapper mapper, IUnitOfWork unitOfWork, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager, IHttpContextAccessor httpContextAccessor, SignInManager<AppUser> signInManager)
        {
            this.mapper = mapper;
            this.unitOfWork = unitOfWork;
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.httpContextAccessor = httpContextAccessor;
            this.signInManager = signInManager;
            _user = httpContextAccessor.HttpContext.User;
        }

        public async Task<string> RegisterUserAsync(UserRegisterViewModel userRegisterViewModel)
        {
            var userMap = mapper.Map<AppUser>(userRegisterViewModel);
            userMap.UserName = userRegisterViewModel.Email;
            var result = await userManager.CreateAsync(userMap, string.IsNullOrEmpty(userRegisterViewModel.Password) ? "" : userRegisterViewModel.Password); // identity result 

            if (result.Succeeded)
            {
                var findRole = await roleManager.FindByIdAsync("2");
                await userManager.AddToRoleAsync(userMap, findRole.ToString());
                return "ok";
            }
            else
            {
                return "notok";
            }
        }

        public async Task<string> LoginUserAsync(UserLoginViewModel userLoginViewModel)
        {
            var user = await userManager.FindByEmailAsync(userLoginViewModel.Email);

            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user, userLoginViewModel.Password, true, false);
                if (result.Succeeded)
                {
                    return "ok";
                }
                else
                {
                    return "notok";
                }
            }
            else
            {
                return "notfound";
            }
        }

        public async Task LogoutUserAsync()
        {
            await signInManager.SignOutAsync();
        }
    }
}
