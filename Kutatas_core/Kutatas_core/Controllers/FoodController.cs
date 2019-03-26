using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Kutatas_core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Kutatas_core.Controllers
{
    public class FoodController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        /// <summary>
        /// Eltárolja adatbázisba a feltölteni kívánt kajákat
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        #region Kaja mentése adatbázisba
        public void InsertFood(string name, int price)
        {
            try
            {
                Food newFood = new Food();
                newFood.Price = price;
                newFood.FoodName = name;

                // insert
                using (context)
                {
                    var customers = context.Set<Food>();
                    customers.Add(newFood);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {

            }
        }
        #endregion


        /// <summary>
        /// Képet ment az adatbázisba
        /// Átalakítást végez hogy a fájl menthető legyen
        /// </summary>
        /// <param name="food"></param>
        /// <param name="Image"></param>
        /// <returns></returns> 
        #region Kép konvertálás és mentés adatbáziba
        public async Task<IActionResult> SaveFileFromDataBase(Food food, IFormFile Image)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (Image != null)
                    {
                        if (Image.Length > 0)
                        //Convert Image to byte and save to database
                        {
                            byte[] p1 = null;
                            using (var fs1 = Image.OpenReadStream())
                            using (var ms1 = new MemoryStream())
                            {
                                fs1.CopyTo(ms1);
                                p1 = ms1.ToArray();
                            }
                            food.Image = p1;
                        }
                    }

                    context.Add(Image);
                    await context.SaveChangesAsync();

                    return View();
                }

            }
            catch (Exception e)
            {

            }
            return null;
        }
        #endregion

        /// <summary>
        /// Visszaadja az adatbázisból az összes ételt amit mentettek
        /// Listázás miatt kell
        /// </summary>
        /// <returns></returns>
        #region Az összes ételt kilistázza
        [HttpPost]
        public ActionResult SelectAllFood()
        {
            try
            {
                var result = context.Food;
                return new JsonResult(result);
            }
            catch (Exception e)
            {
                return new JsonResult(new { Success = false });
            }
        }
        #endregion


    }
}