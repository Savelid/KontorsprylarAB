﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KAB.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Category(string id)
        {

            return View();
        }
        public IActionResult Product()
        {
            return View();
        }
    }
}
