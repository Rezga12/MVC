using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projkt.Controllers
{
    public class DeleteController : Controller
    {
        // GET: Delete
        public ActionResult Company(int id)
        {
            var context = new RMSEntities3();
            var query = from st in context.Companies
                        where st.Id == id
                        select st;

            return View(query.First());
        }

        [HttpPost]
        public ActionResult CompanyDelete(FormCollection collection)
        {

            int id = Int32.Parse(collection.Get("id"));

            var context = new RMSEntities3();
            //context.Remove(context.Companies.Single(a => a.Id == id));
            context.Companies.Remove(context.Companies.Single(a => a.Id == id));
            context.SaveChanges();


            return View("~/Views/Home/Index.cshtml", context.Companies.ToList());
        }

        public ActionResult Product(int id)
        {
            var context = new RMSEntities3();
            var query = from st in context.GeneralProducts
                        where st.Id == id
                        select st;

            return View(query.First());
        }

        [HttpPost]
        public ActionResult ProductDelete(FormCollection collection)
        {

            int id = Int32.Parse(collection.Get("id"));

            var context = new RMSEntities3();
            //context.Remove(context.Companies.Single(a => a.Id == id));
            context.GeneralProducts.Remove(context.GeneralProducts.Single(a => a.Id == id));
            context.SaveChanges();


            return View("~/Views/Home/DisplayProducts.cshtml", context.GeneralProducts.ToList());
        }

        public ActionResult Order(int id)
        {
            var context = new RMSEntities3();
            var query = from st in context.Orders
                        where st.Id == id
                        select st;

            return View(query.First());
        }

        [HttpPost]
        public ActionResult OrderDelete(FormCollection collection)
        {

            int id = Int32.Parse(collection.Get("id"));

            var context = new RMSEntities3();
            //context.Remove(context.Companies.Single(a => a.Id == id));
            context.Orders.Remove(context.Orders.Single(a => a.Id == id));
            context.SaveChanges();


            return View("~/Views/Order/Index.cshtml", context.Orders.ToList());
        }
    }
}