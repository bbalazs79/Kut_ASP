using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kutatas_core.Models;
using Kutatas_core.Data;
using Microsoft.AspNetCore.Authorization;

namespace Kutatas_core.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        
        public HomeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        // Ezekkel mindenképpen kezdjetek valamit (az is jobb, ha mindegyikhez külön View és Controller van)
        [Authorize(Roles = "Normal")]
        public IActionResult Cart()
        {
            return View();
        }
        
        public IActionResult Index()
        {
            return View(this.dbContext.Food.ToList());
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
