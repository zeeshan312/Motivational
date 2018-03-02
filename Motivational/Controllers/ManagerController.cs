using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Motivational.Models;

namespace Motivational.Controllers
{
    public class ManagerController : Controller
    {
        //Get : Accounts/Ascending
        public ActionResult Ascending()
        {
            var admin = new Accounts() { Company = "whinstone" };
            //  return View(admin);
            //  return Content("software house!");
            // return HttpNotFound();
            // return new EmptyResult();
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }
        

        [HttpPost]
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }


    }
    
}