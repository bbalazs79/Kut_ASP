using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Kutatas_core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using Microsoft.AspNetCore.Authorization;
using Kutatas_core.Data;

namespace Kutatas_core.Controllers
{
    public class FoodController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        /// <summary>
        /// Eltárolja adatbázisba a feltölteni kívánt kajákat
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        #region Kaja mentése adatbázisba
        public void InsertFood(string name, string description, int price)
        {
            try
            {
                Food newFood = new Food();
                newFood.Price = price;
                newFood.Name = name;
                newFood.Description = description;

                // insert
                using (dbContext)
                {
                    var customers = dbContext.Set<Food>();
                    customers.Add(newFood);
                    dbContext.SaveChanges();
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
        //#region Kép konvertálás és mentés adatbáziba
        //public async Task<IActionResult> SaveFileFromDataBase(Food food, IFormFile Image)
        //{
        //    try
        //    {
        //        if (ModelState.IsValid)
        //        {
        //            if (Image != null)
        //            {
        //                if (Image.Length > 0)
        //                //Convert Image to byte and save to database
        //                {
        //                    byte[] p1 = null;
        //                    using (var fs1 = Image.OpenReadStream())
        //                    using (var ms1 = new MemoryStream())
        //                    {
        //                        fs1.CopyTo(ms1);
        //                        p1 = ms1.ToArray();
        //                    }
        //                    food.Image = p1;
        //                }
        //            }

        //            dbContext.Add(Image);
        //            await dbContext.SaveChangesAsync();

        //            return View();
        //        }

        //    }
        //    catch (Exception e)
        //    {

        //    }
        //    return null;
        //}
        //#endregion
        
        public FoodController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return this.View(this.dbContext.Food.ToList());
        }


    }
}