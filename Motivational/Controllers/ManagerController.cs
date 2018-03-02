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
            var admin   = new Accounts() { Company = "whinstone" };
            return View(admin);

        }

    }
    
}