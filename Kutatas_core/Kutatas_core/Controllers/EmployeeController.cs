using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kutatas_core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kutatas_core.Controllers
{
    public class EmployeeController : Controller
    {

        private ApplicationDbContext context = new ApplicationDbContext();


        /// <summary>
        /// Menti a dolgozók bejelentkezési adatait az adatbázisba
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="password"></param>
        /// <param name="city"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        #region InsertEmployee
        [HttpPost]
        public ActionResult InsertEmployee(string firstName, string lastName, string email, string phoneNumber, string password, string city, string address)
        {
            try
            {
                Employee newEmployee = new Employee();
                newEmployee.FirstName = firstName;
                newEmployee.LastName = lastName;
                newEmployee.Email = email;
                newEmployee.Password = password;
                using (context)
                {
                    if (firstName != null && lastName != null && email != null && password != null)
                    {
                        Employee user = context.Employee.Where(x => x.Email == email).FirstOrDefault<Employee>();
                        var customers = context.Set<Employee>();
                        customers.Add(newEmployee);
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
        /// Visszaad egy dolgozót az adatbázisból az összes adataival együtt
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        #region SelectEmployee
        [HttpPost]
        public ActionResult SelectEmployee(string email)
        {
            try
            {
                var result = context.Employee.Where(x => x.Email == email).FirstOrDefault<Employee>();
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
    }
}