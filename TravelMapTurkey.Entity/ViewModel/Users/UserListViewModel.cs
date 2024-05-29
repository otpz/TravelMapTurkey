﻿using TravelMapTurkey.Entity.Entities;

namespace TravelMapTurkey.Entity.ViewModel.Users
{
    public class UserListViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
