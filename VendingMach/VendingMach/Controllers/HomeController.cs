using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VendingMach.Models;
using System.Data;
using System.Data.Entity;

namespace VendingMach.Controllers
{
    public class HomeController : Controller
    {
        private VendingContext db = new VendingContext();
        public ActionResult Index()
        {
            return View(); 
        }

        // Get: Home/ListProducts
        // Получить список всех имеющихся товаров
        public ActionResult ListProducts()
        {
            var selectitem = db.Beverages.Where(a => a.Count > 0).ToList();
            if (selectitem.Count <= 0)
            {
                return null;
            }
            ViewBag.Balance = 0;
            return View(selectitem);
        }

        // Post: Home/ListProducts/
        [HttpPost]
        public ActionResult ListProducts(int id, int balance, decimal price)
        {
            // Если баланс больше цены, то совершается покупка продукта
            // db.Count - 1
            if (balance >= price)
            {
                var buy = db.Beverages.FirstOrDefault(a => a.Id == id);
                buy.Count -= 1;
                db.Entry(buy).State = EntityState.Modified;
                db.SaveChanges();
                ViewBag.Balance = balance-price;
            }
            else
            {
                ViewBag.Balance = balance;
            }
            var selectitem = db.Beverages.Where(a => a.Count > 0).ToList();
            if (selectitem.Count <= 0)
            {
                return null;
            }

            return View(selectitem);
        }

    }
}