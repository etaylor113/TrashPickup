using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashPickup.Models;

namespace TrashPickup.Controllers
{
    public class WorkerController : Controller
    {
        // GET: Worker
        public ActionResult Index()
        {
            Worker worker = new Worker() { workerName = "Worker Joe" };
           
            return View(worker);
        }
    }
}