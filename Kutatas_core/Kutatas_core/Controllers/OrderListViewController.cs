using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kutatas_core.Data;
using Microsoft.AspNetCore.Mvc;
using Kutatas_core.Models;
using Microsoft.AspNetCore.Authorization;

namespace Kutatas_core.Controllers
{
    public class OrderListViewController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public OrderListViewController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View(this.dbContext.Orders.ToList());
        }
    }
}