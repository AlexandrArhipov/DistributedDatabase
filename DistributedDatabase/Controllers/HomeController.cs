using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DistributedDatabase.Models;
using System;
using System.Linq;

namespace DistributedDatabase.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult CharacterForm()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureCreated();
                var users = db.user.ToList();
                Console.WriteLine("Список объектов:");
                foreach (var u in users)
                {
                    Console.WriteLine($"{u.Login};{u.Password};{u.Country};{u.Date_Of_Birth};{u.Email}");
                }
            }
            return Ok();
            //return View();
        }
        
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
