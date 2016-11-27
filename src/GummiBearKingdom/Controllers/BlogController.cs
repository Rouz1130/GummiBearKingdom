using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace GummiBearKingdom.Controllers
{
    public class BlogController : Controller
    {
        private GummiBearKingdomContext db = new GummiBearKingdomContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Blog blog)
        {
            db.Blog.Add(blog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
