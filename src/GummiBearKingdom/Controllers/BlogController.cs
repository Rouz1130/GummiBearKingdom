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
        private BlogModel theView = new BlogModel();

        public IActionResult Index()
        {
            return View(db.Blog.ToList());
        }
        [HttpPost]
        public ActionResult Index(Blog blog)
        {
            db.Blog.Add(blog);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public class BlogModel
        {
            public IEnumerable<Blog> BlogList { get; set; }
            public Blog Blog { get; set; }
            private GummiBearKingdomContext db = new GummiBearKingdomContext();
            public BlogModel()
            {
                BlogList = db.Blog.ToList();
            }
        }
    }
}
