using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GummiBearKingdom.Controllers
{
    public class AdminController : Controller
    {
        // GET: /<controller>/
        private GummiBearKingdomContext db = new GummiBearKingdomContext();
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult EditProduct(int id)
        {
            var thisItem = db.Products.FirstOrDefault(products => products.ProductsId == id);
            return View(thisItem);
        }

        [HttpPost]
        public IActionResult EditProduct(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteProduct(int id)
        {
            var Product = db.Products.FirstOrDefault(product => product.ProductsId == id);
            return View(Product);
        }

        [HttpPost, ActionName("DeleteProduct")]
        public IActionResult DeleteConfirmed(int id)
        {
            var Product = db.Products.FirstOrDefault(product => product.ProductsId == id);
            db.Products.Remove(Product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
