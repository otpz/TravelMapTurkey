using Microsoft.AspNetCore.Mvc;
using TravelMapTurkey.Service.Services.Abstraction;

namespace TravelMapTurkey.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
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
            if (userId == null || userId == 0)
            {
                return RedirectToAction("Error", "Home");
            }

            var user = await userService.GetUserByIdAsync(userId);
            return View(user);
        }
    }
}
