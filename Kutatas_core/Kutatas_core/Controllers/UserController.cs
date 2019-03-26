using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kutatas_core.IoC;
using Kutatas_core.Models;
using Microsoft.AspNetCore.Mvc;


namespace Kutatas_core.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="password"></param>
        /// <param name="city"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        #region adatbázisba ment ez a metódus
        [HttpPost]
        public ActionResult InsertUser(string firstName, string lastName, string email, string phoneNumber, string password, string city, string address)
        {
            try
            {
                User newUser = new User();
                newUser.FirstName = firstName;
                newUser.LastName = lastName;
                newUser.Email = email;
                newUser.PhoneNumber = phoneNumber;
                newUser.Password = password;
                newUser.City = city;
                newUser.Address = address;

                using (context)
                {
                    if (firstName != null && lastName != null && email != null && password != null)
                    {
                        User user = context.User.Where(x => x.Email == email).FirstOrDefault<User>();
                        var customers = context.Set<User>();
                        customers.Add(newUser);
                        context.SaveChanges();
                    }
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
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        #region visszaad egy felhasználót email cím alapján
        [HttpPost]
        public ActionResult SelectUser(string email)
        {
            try
            {
                var result = context.User.Where(x => x.Email == email).FirstOrDefault<User>();
                if (result.Email == null || result.Email == String.Empty)
                    return new JsonResult(new { Success = false });
                return new JsonResult(result);
            }
            catch (Exception e)
            {
                return new JsonResult(new { Success = false });
            }
        }
        #endregion

        /// <summary>
        /// Update metódus 
        /// A felhasználók adatainak módosítására szolgál 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="password"></param>
        /// <param name="city"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        #region Módosítja bizonyos rekordok tartalmát
        [HttpPost]
        public ActionResult UpdateUser(string firstName, string lastName, string email, string phoneNumber, string password, string city, string address)
        {
            try
            {

                var result = context.User.Where(x => x.Email == email).FirstOrDefault<User>();
                    if (result.Email == null || result.Email == String.Empty)
                        return new JsonResult(new { Success = false });

                result.FirstName = firstName;
                result.LastName = lastName;
                result.Email = email;
                result.PhoneNumber = phoneNumber;
                result.Password = password;
                result.City = city;
                result.Address = address;

                using (context)
                {
                    if (firstName != null && lastName != null && email != null && password != null)
                    {
                        var customers = context.Set<User>();
                        customers.Update(result);
                        context.SaveChanges();
                    }
                }
                return new JsonResult(new { Succeed = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new { Succeed = false });
            }
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }

    }
}