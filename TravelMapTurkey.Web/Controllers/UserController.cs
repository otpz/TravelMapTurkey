using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TravelMapTurkey.Entity.ViewModel.Cities;
using TravelMapTurkey.Entity.ViewModel.Users;
using TravelMapTurkey.Service.Extensions;
using TravelMapTurkey.Service.Services.Abstraction;

namespace TravelMapTurkey.Web.Controllers
{
    //[Authorize]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly ICityService cityService;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly IMapper mapper;
        private readonly ClaimsPrincipal _user;

        public UserController(IUserService userService, ICityService cityService, IHttpContextAccessor httpContextAccessor, IMapper mapper)
        {
            this.userService = userService;
            this.cityService = cityService;
            this.httpContextAccessor = httpContextAccessor;
            this.mapper = mapper;
            _user = httpContextAccessor.HttpContext.User;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("User/Profile/{userId?}")]
        public async Task<IActionResult> Profile(int userId)
        {
            int loggedInUserId = 0;

            if (_user.Identity.IsAuthenticated)
            {
                loggedInUserId = _user.GetLoggedInUserId();
            }

            var user = await userService.GetUserProfileByIdAsync(userId);

            if (user == null)
            {
                return RedirectToAction("Error", "Home");
            }

            user.IsOwnProfile = loggedInUserId == userId;

            return View(user);
        }

        [HttpPost]
        [Route("User/Profile/{userId?}")]
        public async Task<IActionResult> Profile(CityAddViewModel cityAddViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Bilgileri tamamlayınız");
            }

            int userId = await cityService.CreateCityWithReviewAndImageAsync(cityAddViewModel);
            var user = await userService.GetUserProfileByIdAsync(userId);

            if (user == null)
            {
                return RedirectToAction("Error", "Home");
            }
            ModelState.Clear();
            return RedirectToAction("Profile", "User", userId);
        }

        [HttpGet]
        [Route("User/Settings/{userId?}")]
        public async Task<IActionResult> Settings(int userId)
        {
            int loggedInUserId = 0;

            if (_user.Identity.IsAuthenticated)
            {
                loggedInUserId = _user.GetLoggedInUserId();
            }

            if (loggedInUserId == userId)
            {
                var user = await userService.GetUserProfileByIdAsync(userId);
                var userUpdateMap = mapper.Map<UserUpdateViewModel>(user);
                return View(userUpdateMap);
            } else
            {
                return RedirectToAction("Error", "Home");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateViewModel userUpdateViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Bilgileri tamamlayınız");
            }
            await userService.UpdateUserSettingsAsync(userUpdateViewModel);
            int userId = userUpdateViewModel.Id;
            return RedirectToAction("Settings", "User", new {userId = userId});
        }
    }
}
