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

        public void InsertUser(string name, string password)
        {
            User newUser = new User();
            newUser.UserName = name;
            newUser.Password = password;

            // insert
            using (context)
            {
                var customers = context.Set<User>();
                customers.Add(newUser);
                context.SaveChanges();
            }
        }

        public User SelectUser(string userName)
        {
            User user = context.User.Where(x => x.UserName == userName).FirstOrDefault<User>();
            return user;
        }   
    }
}