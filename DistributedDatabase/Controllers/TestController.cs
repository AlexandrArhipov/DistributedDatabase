using Microsoft.AspNetCore.Mvc;

namespace DistributedDatabase.Controllers
{
    public class TestController : Controller
    {
        [HttpGet]
        public IActionResult TelerikTest() => View();
        /*
        [HttpGet]
        public IActionResult ShowDatabase()
        {
            using (var context = new ApplicationContext())
            {
                /*context.Characters.Add(new Character());
                context.SaveChanges();
                string result = "";
                foreach (var character in context.Characters)
                {
                    result += character?.Name + "\n";
                }
                return Content(result);
            }
        }*/

    }
}