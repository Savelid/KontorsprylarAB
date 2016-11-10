using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KAB.Models.Entities;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace KAB.Controllers
{
    public class ProductController : Controller
    {
        KABdbcontext context;

        public ProductController(KABdbcontext context)
        {
            this.context = context;
        }

        public IActionResult Category(string id)
        {
            var categoryVM = context.GetCategory(id);
            return View(categoryVM);
        }
        public IActionResult Product(int id)
        {
            var productVM = context.GetProduct(id);
            return View(productVM);
        }
    }
}
