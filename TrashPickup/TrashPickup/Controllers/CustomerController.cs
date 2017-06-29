using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickup.Models;

namespace TrashPickup.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            Customer customer = new Customer() { customerName = "Lil Timmy" };

            return View(customer);
        }
    }
}