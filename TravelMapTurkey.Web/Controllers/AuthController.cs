using AutoMapper;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TravelMapTurkey.Data.Configurations;
using TravelMapTurkey.Entity.Entities;
using TravelMapTurkey.Entity.ViewModel.Users;
using TravelMapTurkey.Service.Services.Abstraction;

namespace TravelMapTurkey.Web.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private readonly IAuthService authService;
        private readonly IValidator<AppUser> validator;
        private readonly IMapper mapper;
        private readonly IValidator<UserLoginViewModel> validator2;

        public AuthController(IAuthService authService, IValidator<AppUser> validator, IMapper mapper, IValidator<UserLoginViewModel> validator2)
        {
            this.authService = authService;
            this.validator = validator;
            this.mapper = mapper;
            this.validator2 = validator2;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterViewModel userRegisterViewModel)
        {
            var userMap = mapper.Map<AppUser>(userRegisterViewModel);

            var validationResult = await validator.ValidateAsync(userMap);

            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(this.ModelState);
                return View();
            }

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
            var validationResult = await validator2.ValidateAsync(userLoginViewModel);
            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(this.ModelState);
                return View();
            }

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
