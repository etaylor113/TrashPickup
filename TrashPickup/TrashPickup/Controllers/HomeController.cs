﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickup.Models;

namespace TrashPickup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return CheckRedirect();
            }

            return View();
        }
        private ActionResult CheckRedirect()
        {
            var roll = GetRole();

            if (roll == "Admin")
            {
                return RedirectToAction("Index", "Admin");
            }
            else if (roll == "Customer")
            {
                return RedirectToAction("Index", "Customer");
            }
            else if (roll == "Employee")
            {
                return RedirectToAction("Index", "Worker");
            }

            return View();
        }
        public string GetRole()
        {

            string role = null;
            if (User.Identity.IsAuthenticated)
            {
                ApplicationDbContext context = new ApplicationDbContext();
                var user = User.Identity;
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
                var s = UserManager.GetRoles(user.GetUserId());
                role = s[0].ToString();
            }
            return role;

        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
