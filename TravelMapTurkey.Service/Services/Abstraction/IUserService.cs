using TravelMapTurkey.Entity.ViewModel.Users;

namespace TravelMapTurkey.Service.Services.Abstraction
{
    public interface IUserService
    {
        Task<UserViewModel> GetLoggedInUserProfileAsync();
        Task<UserProfileViewModel> GetUserByIdAsync(int userId);
        Task<UserProfileViewModel> GetUserProfileByIdAsync(int userId);
    }
}
