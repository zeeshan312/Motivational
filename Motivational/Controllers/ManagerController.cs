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
        public ActionResult s()
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

        public ActionResult Index(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));

        }

        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year + "/" + month);
        }

        public ActionResult Random()
        {
            var acca = new Accounts() { Employees = "Finance manager" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer =1" },
                new Customer {Name = "Customer =2" }
            };

            var ViewModels = new ViewModels.RandomAccountsViewModels
            {
                //   Accounts = new acca; 
                Customer = customers
            };

            ViewData["Accounts"] = acca;
            return View(ViewModels);
        }
        
    }
    
}