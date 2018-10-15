using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace projkt.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index()
        {
            var context = new RMSEntities3();


            return View(context.Orders.ToList());
        }
        [HttpPost]
        public ActionResult Make(FormCollection collection)
        {   
            

            var id = int.Parse(collection.Get("company_id"));
            collection.Remove("company_id");

            var context = new RMSEntities3();
            var totalPrice = 0;

            var orderList = new List<OrderMeal>();

            foreach (var key in collection.Keys)
            {
                int foodId = int.Parse((string)key);
                var food = context.Menus.Where(fd => fd.global_code == foodId && fd.company_id == id).First();
                var quantity = int.Parse(collection.Get((string)key));

                totalPrice += food.Price * quantity;

                orderList.Add(new OrderMeal
                {
                    product_id = food.Id,
                    quantity = quantity,
                   
                });
            }

            var order = new Order
            {
                Date = DateTime.Now,
                company_id = id,
                total_amount = totalPrice,
                Rating = 0,
            };
            context.Orders.Add(order);

            context.SaveChanges();
            var orderId = order.Id;



            foreach (var orderMeal in orderList)
            {
                if (orderMeal.quantity > 0)
                {
                    orderMeal.order_id = orderId;
                    context.OrderMeals.Add(orderMeal);
                }
                
            }


            context.SaveChanges();

            return View(collection);
        }


        public ActionResult Details(int id)
        {
            var modelList = new List<Models.OrderDetails>();

            var context = new RMSEntities3();
            var total = 0;
            var mealList = context.OrderMeals.Where(order => order.order_id == id).ToList();

            foreach (var meal in mealList)
            {
                var product = context.Menus.Where(menu => menu.Id == meal.product_id).First();
                var productName = context.GeneralProducts.Where(prd => prd.Id == product.global_code).First().Name;

                var detail = new Models.OrderDetails
                {
                    Name = productName,
                    Price = product.Price,
                    Quantity = meal.quantity,
                };

                modelList.Add(detail);
                total += detail.Price * detail.Quantity;
            }

            ViewBag.total = total;
            return View(modelList);
        }

    }
}