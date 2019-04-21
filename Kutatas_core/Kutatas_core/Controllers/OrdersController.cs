﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kutatas_core.Data;
using Kutatas_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kutatas_core.Controllers
{
    public class OrdersController : Controller
    {
        private ApplicationDbContext dbContext;

        public OrdersController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        
        /// <summary>
        /// id alapján megkeresi a rendelést és teljesítettnek veszi a rendelést
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        #region Kiszállítás visszaigazolása
        [HttpPost]
        public ActionResult OrderValidation(int id)
        {
            try
            {
                var result = dbContext.Orders.Where(x=>x.Id == id).FirstOrDefault<Orders>();
                result.Performed = true;
                result.PerformedDate = DateTime.Now;

                using (dbContext)
                {
                    var customers = dbContext.Set<Orders>();
                    customers.Update(result);
                    dbContext.SaveChanges();
                }
                return new JsonResult(new { Success = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new { Success = false });
            }
        }
        #endregion

        /// <summary>
        /// Paraméterek alapján történő Insertálás adatbázisba
        /// </summary>
        /// <param name="food"></param>
        /// <param name="orderer"></param>
        /// <param name="allPrice"></param>
        /// <returns></returns>
        #region Menti a felhasználó rendelését az adatbázisba
        [HttpPost]
        public ActionResult InsertOrder(Food food, User orderer, int allPrice)
        {
            try
            {
                Orders order = new Orders();
                order.OrderedFood = food;
                order.Orderer = orderer;
                order.Performed = false;
                order.OrderDate = DateTime.Now;

                using (dbContext)
                {
                        var customers = dbContext.Set<Orders>();
                        customers.Add(order);
                        dbContext.SaveChanges();
                    
                }
                return new JsonResult(new { Succeed = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new { Succeed = false });
            }
        }
        #endregion


        /// <summary>
        /// Visszaadja egy JSON-ben az összes aktív és inaktív rendelést
        /// </summary>
        /// <returns></returns>
        #region Az összes rendelést listázza
        [HttpPost]
        public ActionResult SelectAllOrders()
        {
            try
            {
                var result = dbContext.Orders;
                return new JsonResult(result);
            }
            catch (Exception e)
            {
                return new JsonResult(new { Success = false });
            }
        }
        #endregion

        /// <summary>
        /// Minden olyan rendelést visszaad amit még nem teljesítettek
        /// </summary>
        /// <returns></returns>
        #region Az összes aktív rendelést visszaadja
        [HttpPost]
        public ActionResult SelectActiveOrders()
        {
            try
            {
                var result = dbContext.Orders;
                List<Orders> activeOrders = new List<Orders>();
                foreach(Orders x in result)
                {
                    if(x.Performed == true)
                    {
                        activeOrders.Add(x);
                    }
                }
                return new JsonResult(activeOrders);
            }
            catch (Exception e)
            {
                return new JsonResult(new { Success = false });
            }
        }
        #endregion

        /// <summary>
        /// Minden olyan rendelést visszaad amit már teljesítettek
        /// </summary>
        /// <returns></returns>
        #region Az összes inaktív rendelést visszaadja
        [HttpPost]
        public ActionResult SelectInactiveOrders()
        {
            try
            {
                var result = dbContext.Orders;
                List<Orders> inactiveOrders = new List<Orders>();
                foreach (Orders x in result)
                {
                    if (x.Performed == false)
                    {
                        inactiveOrders.Add(x);
                    }
                }
                return new JsonResult(inactiveOrders);
            }
            catch (Exception e)
            {
                return new JsonResult(new { Success = false });
            }
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }
    }
}