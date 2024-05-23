using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TravelMapTurkey.Service.Services.Abstraction;
using TravelMapTurkey.Web.Models;

namespace TravelMapTurkey.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICityService cityService;

        public HomeController(ILogger<HomeController> logger, ICityService cityService)
        {
            _logger = logger;
            this.cityService = cityService;
        }

        public async Task<IActionResult> Index()
        {
            var cities = await cityService.GetAllCitiesWithCityReviewNonDeletedAsync();
            return View(cities);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
