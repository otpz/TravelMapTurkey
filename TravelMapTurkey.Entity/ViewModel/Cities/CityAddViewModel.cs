using Microsoft.AspNetCore.Http;
using TravelMapTurkey.Entity.Entities;

namespace TravelMapTurkey.Entity.ViewModel.Cities
{
    public class CityAddViewModel
    {
        public int UserId { get; set; }
        public string CityName { get; set; }
        public string Type { get; set; }
        public string Review { get; set; }  
        public Image Image { get; set; }
        public IFormFile? Photo { get; set; }
    }
}
