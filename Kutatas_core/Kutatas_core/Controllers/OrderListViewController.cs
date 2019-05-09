using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kutatas_core.Data;
using Microsoft.AspNetCore.Mvc;
using Kutatas_core.Models;

namespace Kutatas_core.Controllers
{
    public class OrderListViewController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public OrderListViewController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(this.dbContext.Orders.ToList());
        }
    }
}