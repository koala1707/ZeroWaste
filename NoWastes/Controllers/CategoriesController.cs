using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NoWasteFoods.Models;

namespace NoWasteFoods.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            var categories = GetCategories();
            return View(categories);
        }

        private IEnumerable<Categories> GetCategories()
        {
            return new List<Categories>
            {
            new Categories { Id=1, CategoryName = "Vegetable" },
            new Categories { Id=2, CategoryName = "Meat" }
             };
        }
    }
}