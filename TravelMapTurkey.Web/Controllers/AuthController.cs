﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TravelMapTurkey.Entity.ViewModel.Users;
using TravelMapTurkey.Service.Services.Abstraction;

namespace TravelMapTurkey.Web.Controllers
{
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
                string result = await authService.LoginUserAsync(userLoginViewModel);

                if (result == "notfound")
                {
                    ModelState.AddModelError("", "Kullanıcı bulunamadı");
                    return View();
                } else if (result == "ok")
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