using Microsoft.AspNetCore.Identity;
using TravelMapTurkey.Core.EntityBase;

namespace TravelMapTurkey.Entity.Entities
{
    public class AppUser : IdentityUser<int>, IEntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Biography { get; set; }
        public ICollection<City> Cities { get; set; } = new List<City>();
    }
}
