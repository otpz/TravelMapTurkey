using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;
using TravelMapTurkey.Entity.ViewModel.Users;
using TravelMapTurkey.Service.Extensions;
using TravelMapTurkey.Service.Services.Abstraction;

namespace TravelMapTurkey.Web.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterViewModel userRegisterViewModel)
        {
            string result = await authService.RegisterUserAsync(userRegisterViewModel);
            if (result == "ok")
            {
                return RedirectToAction("Login", "Auth");
            }
            else
            {
                ModelState.AddModelError("", "Bilgileri doğru giriniz");
                return View();
            }
        }

        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLoginViewModel)
        {
            
            if (ModelState.IsValid)
            {
                string results = await authService.LoginUserAsync(userLoginViewModel);
                if (results == "notfound")
                {
                    ModelState.AddModelError("", "Kullanıcı bulunamadı");
                    return View();
                } else if (results == "ok")
                {
                    return RedirectToAction("Index", "Home");
                } else
                {
                    ModelState.AddModelError("", "E-posta veya şifreniz yanlıştır.");
                    return View();
                }
            }
            else
                return View();
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await authService.LogoutUserAsync();
            return RedirectToAction("Index", "Home");
        }

        //[Authorize]
        //[HttpGet]
        //public async Task<IActionResult> AccessDenied()
        //{
        //    return View();
        //}



    }
}
