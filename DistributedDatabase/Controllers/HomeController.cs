using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DistributedDatabase.Models;
using System;

namespace DistributedDatabase.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult CharacterForm() => View();
        
        [HttpPost]
        public IActionResult CharacterForm(string login, string password)
        {
            string authData = $"Login: {login}   Password: {password}";
            return Content(authData);
        }

        public IActionResult Error() => 
            View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
