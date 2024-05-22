using TravelMapTurkey.Core.EntityBase;

namespace TravelMapTurkey.Entity.Entities
{
    public class CityReview : EntityBase
    {
        public CityReview(){}
        public CityReview(string review, int cityId)
        {
            Review = review;
            CityId = cityId;
        }
        public string Review { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public Image Image { get; set; }
    }
}
