using Microsoft.AspNetCore.Mvc;
using TravelMapTurkey.Service.Services.Abstraction;

namespace TravelMapTurkey.Web.ViewComponents
{
    public class UserHeaderViewComponent : ViewComponent
    {
        private readonly IUserService userService;

        public UserHeaderViewComponent(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await userService.GetLoggedInUserProfileAsync();
            return View(user);
        }
    }
}
