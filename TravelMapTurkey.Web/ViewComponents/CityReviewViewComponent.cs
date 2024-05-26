using Microsoft.AspNetCore.Mvc;

namespace TravelMapTurkey.Web.ViewComponents
{
    public class CityReviewViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
