using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BstCatagoriesController : Controller
    {
        // GET: BstCatagories
        public ActionResult BstIndex()
        {
            BstBookStore bstDb = new BstBookStore();
            var bstCategories = bstDb.BstCategories.ToList();
            return View(bstCategories);
        }
    }
}