using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kutatas_core.Models;



namespace Kutatas_core.Controllers
{
    public class AdminController: Controller
    {
        public IActionResult Admin()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
        public IActionResult Upload()
        {
            return View();
        }
    }
}
