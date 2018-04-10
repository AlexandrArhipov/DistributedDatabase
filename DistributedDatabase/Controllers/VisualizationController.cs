﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DistributedDatabase.Models;

namespace DistributedDatabase.Controllers
{
    public class VisualizationController : Controller
    {
        [HttpGet]
        public IActionResult Characters()
        {
            var context = new ApplicationContext();
            ViewData["Races"] = context.Races;
            ViewData["Classes"] = context.Classes;
            return View(context.Characters);
        }

        [HttpGet]
        public IActionResult Users() => 
            View((new ApplicationContext()).Users);
    }
}
