using TravelMapTurkey.Core.EntityBase;

namespace TravelMapTurkey.Entity.Entities
{
    public class Image : EntityBase
    {
        public Image(){}
        public Image(string fileName, string fileType, int cityReviewId)
        {
            FileName = fileName;
            FileType = fileType;
            CityReviewId = cityReviewId;
        }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public int CityReviewId { get; set; }
        public CityReview CityReview { get; set; }
    }
}
