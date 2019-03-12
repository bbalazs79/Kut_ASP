﻿using System;
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

        public void InsertUser(string firstName, string lastName, string email, string phoneNumber, string password, string city,string address)
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

                // insert
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
            }catch(Exception e)
            {

            }
        }

        public User SelectUser(string email)
        {
            try
            {
                User user = context.User.Where(x => x.Email == email).FirstOrDefault<User>();
                return user;
            }catch(Exception e)
            {}
            return null;
        }
    }
}