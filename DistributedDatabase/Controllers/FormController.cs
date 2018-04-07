using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DistributedDatabase.Models;
using System;
using System.Linq;

namespace DistributedDatabase.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult ShowDatabase()
        {
            using (var context = new ApplicationContext())
            {
                string result = "";
                foreach (var character in context.Characters)
                {
                    result += character?.Name + " - " + context.Races.First(x => x.Id == character.RaceId).Name + "\n";
                }
                return Content(result);
            }
        }

        [HttpGet]
        public IActionResult UserForm() => View();
        
        [HttpGet]
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

        public IActionResult Error() => 
            View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
