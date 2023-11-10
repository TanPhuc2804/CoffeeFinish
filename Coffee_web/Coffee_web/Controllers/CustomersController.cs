using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Coffee_web.Models;

namespace CoffeeManager.Controllers
{
    public class CustomersController : Controller
    {
        CoffeeEntities db = new CoffeeEntities();
        // GET: Customers
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Customer cus)
        {
            try
            {

                db.Customers.Add(cus);
                db.SaveChanges();
                return RedirectToAction("Show", "ShoppingCart");
            }catch (Exception ex)
            {
                RedirectToAction("Show", "ShoppingCart");
            }

            return View();
        }
    }
}