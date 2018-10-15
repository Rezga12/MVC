using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projkt.Models;

namespace projkt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            RMSEntities3 context = new RMSEntities3();
            var query = from st in context.Companies
                        select st;
            
            return View(query.ToList<projkt.Company>());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

       

        public ActionResult Menu(int id)
        {
            var context = new RMSEntities3();
            var query = from st in context.Menus
                        where st.company_id == id
                        select st;

            var list = query.ToList<projkt.Menu>();
            var nameList = new List<KeyValuePair<string, projkt.Menu>>();
            foreach (var item in list)
            {
                var name = context.GeneralProducts.Where(q => q.Id == item.global_code).First().Name;
                nameList.Add(new KeyValuePair<string, Menu>(name,item));
            }
            ViewBag.Header = context.Companies.Where(q => q.Id == id).First().Name;
            return View(nameList);

        }


        

        

        public ActionResult DisplayProducts()
        {

            var context = new RMSEntities3();

            return View(context.GeneralProducts.ToList());
        }

    }
}