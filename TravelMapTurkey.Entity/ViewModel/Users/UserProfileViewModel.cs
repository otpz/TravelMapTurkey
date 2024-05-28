using TravelMapTurkey.Entity.Entities;
using TravelMapTurkey.Entity.ViewModel.Cities;

namespace TravelMapTurkey.Entity.ViewModel.Users
{
    public class UserProfileViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Biography { get; set; }
        public bool IsOwnProfile { get; set; }
        public Image Image { get; set; }
        public IList<City> Cities { get; set; }
    }
}
