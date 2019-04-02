﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kutatas_core.Models;

namespace Kutatas_core.Controllers
{
    public class HomeController : Controller
    {

        /// <summary>
        /// Admin cshtml 
        /// </summary>
        /// <returns></returns>
        
        public IActionResult Registration()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
