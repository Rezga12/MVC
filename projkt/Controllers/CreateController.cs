using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projkt.Controllers
{
    public class CreateController : Controller
    {
        // GET: Create
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.a = "a";
            return View();
        }

        

        public ActionResult Company()
        {

            ViewBag.title = "Create";

            return View();
        }

        [HttpPost]
        public ActionResult CompanyCreated(projkt.Company comp)
        {   
            RMSEntities3 db = new RMSEntities3();
            comp.register_date = DateTime.Now;
            comp.avg_rating = 0;
            db.Companies.Add(comp);
            if (comp.logo_url == null)
            {
                comp.logo_url = "https://i.vimeocdn.com/portrait/1274237_300x300";
            }

            ViewBag.title = "Created";
            ViewBag.a = comp.Name;
            db.SaveChanges();
            return View("Index");

        }

        public ActionResult GeneralProduct()
        {

            ViewBag.title = "Create";

            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(projkt.GeneralProduct prd)
        {

            ViewBag.title = "Create Product";

            RMSEntities3 db = new RMSEntities3();
            db.GeneralProducts.Add(prd);
            db.SaveChanges();

            return View("Index");
        }

        
        public ActionResult Menu(int id)
        {
            ViewBag.id = id;
            RMSEntities3 context = new RMSEntities3();
            var query = from st in context.GeneralProducts
                        select st;

            return View(query.ToList<projkt.GeneralProduct>());
        }

        [HttpPost]
        public ActionResult CreateMenu(FormCollection collection)
        {
            int id = Int32.Parse(collection.Get("-id"));

            RMSEntities3 context = new RMSEntities3();
            var menuItems = context.Menus.Where(menu => menu.company_id == id).ToList();

            foreach (var item in menuItems)
            {
                context.Menus.Remove(item);
            }
            

            foreach (var item in collection.Keys)
            {
                if(item.ToString().IndexOf("-") == -1)
                {
                    string name = item.ToString();
                    string duration = collection.Get(name + "-duration");
                    string price = collection.Get(name + "-price");
                    string type = collection.Get(name + "-type");

                    context.Menus.Add(new Menu
                    {   
                        Price = Int32.Parse(price),
                        category = type,
                        cook_duration = Int32.Parse(duration),
                        company_id = id,
                       global_code = Int32.Parse(collection.Get(name))
                    });
                    context.SaveChanges();

                }
            }

            return View("Index");
        }
    }
}