using TravelMapTurkey.Entity.ViewModel.Users;

namespace TravelMapTurkey.Service.Services.Abstraction
{
    public interface IUserService
    {
        Task<UserViewModel> GetLoggedInUserProfileAsync();
        Task<UserViewModel> GetUserByIdAsync(int userId);
    }
}
