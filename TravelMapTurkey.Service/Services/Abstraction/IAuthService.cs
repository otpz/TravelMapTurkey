using Microsoft.AspNetCore.Identity;
using TravelMapTurkey.Entity.ViewModel.Users;

namespace TravelMapTurkey.Service.Services.Abstraction
{
    public interface IAuthService
    {
        Task<string> RegisterUserAsync(UserRegisterViewModel userRegisterViewModel);
        Task<string> LoginUserAsync(UserLoginViewModel userLoginViewModel);
        Task LogoutUserAsync();
    }
}
