using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DistributedDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights.Extensibility.Implementation;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.Features.Authentication;
using Microsoft.EntityFrameworkCore;

namespace DistributedDatabase.Controllers
{
    public class FormController : Controller
    {   
        [HttpGet]
        [Authorize]
        public IActionResult UserForm() => View();
        
        [HttpGet]
        [Authorize]
        public IActionResult CharacterForm() => View();
        
        [HttpPost]
        public IActionResult UserForm(string login, string password, string email, string dateOfBirth, string country)
        {
            string authData = $"Login: {login}   Password: {password} Email: {email}  DateOfBirth : {dateOfBirth} Country: {country}";
            return Content(authData);
        }
        
        [HttpPost]
        public IActionResult CharacterForm(string name, string sex, string skin, string height, string weight, string @class, string race)
        {
            return Content("Name: " + name);
        }

        [HttpGet]
        public IActionResult AuthForm()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AuthForm(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var context = new ApplicationContext();
                User user = await context.Users.FirstOrDefaultAsync(us =>
                    us.Login == model.Login && us.Password == model.Password);

                if (user != null)
                {
                    await Authenticate(model.Login);
                    return RedirectToAction("Characters", "Visualization");
                }
                ModelState.AddModelError("", "Некорректные логин/пароль.");
            }

            return View(model);
        }
        
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("AuthForm", "Form");
        }

        public IActionResult Error() => 
            View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        
        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
