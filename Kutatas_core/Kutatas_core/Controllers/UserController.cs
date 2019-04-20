using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kutatas_core.IoC;
using Kutatas_core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Kutatas_core.Data;
using Microsoft.AspNetCore.Authorization;

namespace Kutatas_core.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        private readonly ApplicationDbContext dbContext;

        // Dependency Injection-t használ az app: a konstruktor paraméterben megkapja a példányokat (nem kell velük foglalkoznunk)
        public UserController(UserManager<User> userManager, SignInManager<User> signInManager, ApplicationDbContext dbContext)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.dbContext = dbContext;
        }

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
        // AllowAnonymous: ha az osztály [Authorize]-zal van ellátva, de szeretnénk, hogy éppen ehhez a metódushoz ne kelljen authentikálni, akkor ezzel meg lehet oldani
        [AllowAnonymous]
        public async Task<IActionResult> RegisterUser(string firstName, string lastName, string email, string phoneNumber, string password, string city, string address)
        {
            var user = new User {
                UserName = email,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber,
                City = city,
                Address = address
            };

            var result = await this.userManager.CreateAsync(user, password);
            if(result.Succeeded)
            {
                // Alapértelmezetten a "Normal" szerepkört kapja a user
                await this.userManager.AddToRoleAsync(user, "Normal");
                await this.signInManager.SignInAsync(user, isPersistent: false);
                return this.LocalRedirect("/Home");
            }

            return this.LocalRedirect("/Home/Registration");
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        /*#region visszaad egy felhasználót email cím alapján
        [HttpPost]
        public ActionResult SelectUser(string email)
        {
            try
            {
                var result = dbContext.User.Where(x => x.Email == email).FirstOrDefault<User>();
                if (result.Email == null || result.Email == String.Empty)
                    return new JsonResult(new { Success = false });
                return new JsonResult(result);
            }
            catch (Exception e)
            {
                return new JsonResult(new { Success = false });
            }
        }
        #endregion*/


        // Kikommenteltem a hibák miatt, elég sok minden változott

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
        /*#region Módosítja bizonyos rekordok tartalmát
        [HttpPost]
        public ActionResult UpdateUser(string firstName, string lastName, string email, string phoneNumber, string password, string city, string address)
        {
            if (Authenticate(this.Request.Headers["Authentication"]) == null)
            {
                this.Response.StatusCode = 401;
                return new JsonResult(new { Success = false });
            }
            try
            {

                var result = dbContext.User.Where(x => x.Email == email).FirstOrDefault<User>();
                if (result.Email == null || result.Email == String.Empty)
                    return new JsonResult(new { Success = false });

                result.FirstName = firstName;
                result.LastName = lastName;
                result.Email = email;
                result.PhoneNumber = phoneNumber;
                //result.Password = password;
                result.City = city;
                result.Address = address;

                using (dbContext)
                {
                    if (firstName != null && lastName != null && email != null && password != null)
                    {
                        var customers = dbContext.Set<User>();
                        customers.Update(result);
                        dbContext.SaveChanges();
                    }
                }
                return new JsonResult(new { Succeed = true });
            }
            catch (Exception e)
            {
                return new JsonResult(new { Succeed = false });
            }
        }
        #endregion*/

        [HttpPost]
        // AllowAnonymous: ha az osztály [Authorize]-zal van ellátva, de szeretnénk, hogy éppen ehhez a metódushoz ne kelljen authentikálni, akkor ezzel meg lehet oldani
        [AllowAnonymous]
        public async Task<IActionResult> Login(string email, string password)
        {
            var result = await signInManager.PasswordSignInAsync(email, password, false, lockoutOnFailure: true);
            if (result.Succeeded)
            {
                Response.StatusCode = 200;
                return this.Redirect("/Home");
            }

            return this.Redirect("/Home/Login");
        }

        [HttpGet]
        // Az Authorize attribútumnak paraméterben meg lehet adni, hogy milyen szerepkörre van szükség
        [Authorize(Roles = "Admin")]
        public IActionResult Test()
        {
            return new JsonResult(new { Success = true });
        }

        // Majd ehhez csináljatok gombot
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await this.signInManager.SignOutAsync();
            return this.Redirect("/Home/Login");
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}