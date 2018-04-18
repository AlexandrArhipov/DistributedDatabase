using System;
using Microsoft.AspNetCore.Mvc;
using DistributedDatabase.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Word = Microsoft.Office.Interop.Word;

namespace DistributedDatabase.Controllers
{
    public class VisualizationController : Controller
    {
        private readonly IHostingEnvironment _appEnvironment;

        
        public VisualizationController(IHostingEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        
        [HttpGet]
        [Authorize]
        public IActionResult Characters()
        {
            var context = new ApplicationContext();
            ViewData["Races"] = context.Races;
            ViewData["Classes"] = context.Classes;
            return View(context.Characters);
        }

        [HttpGet]
        [Authorize]
        public IActionResult Users() => 
            View(new ApplicationContext().Users);
        
        [Authorize]
        public FileResult ExoprtToWord()
        {
            // Создаём объект документа
            Word.Document doc = null;

            // Создаём объект приложения
            Word.Application app = new Word.Application();
            // Путь до шаблона документа
            string source = _appEnvironment.WebRootPath + @"/templates/chec.doc";
            // Открываем
            doc = app.Documents.Open(source);
            doc.Activate();

            // Добавляем информацию
            // wBookmarks содержит все закладки
            Word.Bookmarks wBookmarks = doc.Bookmarks;
            Word.Range wRange;
            int i = 0;
            string[] data = { DateTime.Now.ToShortDateString(), User.Identity.Name};
            foreach (Word.Bookmark mark in wBookmarks)
            {

                wRange = mark.Range;
                wRange.Text = data[i];
                i++;
            }
            
            // Закрываем документ
            doc.Close();
            doc = null;

            byte[] fileBytes = System.IO.File.ReadAllBytes(source);
            string fileName = "chec.doc";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }
    }
}
