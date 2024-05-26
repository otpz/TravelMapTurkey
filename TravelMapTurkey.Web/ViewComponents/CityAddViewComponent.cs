using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TravelMapTurkey.Entity.ViewModel.Cities;
using TravelMapTurkey.Service.Services.Abstraction;

namespace TravelMapTurkey.Web.ViewComponents
{
    public class CityAddViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var model = new CityAddViewModel();
            return View(model);
        }
    }
}
