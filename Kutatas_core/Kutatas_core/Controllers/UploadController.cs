﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace Kutatas_core.Controllers
{
    public class UploadController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
