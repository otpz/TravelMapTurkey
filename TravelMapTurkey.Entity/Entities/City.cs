using TravelMapTurkey.Core.EntityBase;

namespace TravelMapTurkey.Entity.Entities
{
    public class City : EntityBase
    {
        public City(){}
        public City(string cityName, int userId, string type)
        {
            CityName = cityName;
            UserId = userId;
            Type = type;
        }
        public string CityName { get; set; }
        public int UserId { get; set; }
        public AppUser User { get; set; }
        public CityReview CityReview { get; set; }
        public string Type { get; set; }
    }
}
