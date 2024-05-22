using TravelMapTurkey.Entity.Entities;

namespace TravelMapTurkey.Entity.ViewModel.Cities
{
    public class CityViewModel
    {
        public string CityName { get; set; }
        public AppUser User { get; set; }
        public CityReview CityReview { get; set; }
        public string Type { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
