﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;



namespace GummiBearKingdom.Controllers
{
    public class BlogControllers : Controller
    {
        private GummiBearKingdomContext db = new GummiBearKingdomContext();

        public IActionResult Index()
        {
            return View(db.Blog.ToList());
        }
    }
}
