using Microsoft.AspNetCore.Identity;

namespace TravelMapTurkey.Entity.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
