using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;
using System.Security.Claims;
using TravelMapTurkey.Entity.ViewModel.Cities;
using TravelMapTurkey.Service.Extensions;
using TravelMapTurkey.Service.Services.Abstraction;

namespace TravelMapTurkey.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly ICityService cityService;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ClaimsPrincipal _user;

        public UserController(IUserService userService, ICityService cityService, IHttpContextAccessor httpContextAccessor)
        {
            this.userService = userService;
            this.cityService = cityService;
            this.httpContextAccessor = httpContextAccessor;
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

            int loggedInUserId = _user.GetLoggedInUserId();

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
            return RedirectToAction("Profile", "User", userId) ;
        }
    }
}
