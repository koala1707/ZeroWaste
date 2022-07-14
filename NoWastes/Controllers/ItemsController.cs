using NoWasteFoods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NoWasteFoods.ViewModels;

namespace NoWasteFoods.Controllers
{
    public class ItemsController : Controller
    {
        public ActionResult Index()
        {
            var items = GetItems();
            return View(items);
        }

        public ActionResult Details(int id)
        {
            var item = GetItems().SingleOrDefault(i => i.Id == id);

            if (item == null)
                return HttpNotFound();

            return View(item);
        }

        private IEnumerable<Items> GetItems()
        {
            return new List<Items>
            {
                new Items { Id=1, ItemName="Carrot"},
                new Items {Id=2, ItemName="Spinach"}
            };
        }

        // GET: items/try
        public ActionResult Try()
        {
            var vegetable = new Categories() { CategoryName = "Vegetable" };
            var itemList = new List<Items>
            {
                new Items { ItemName = "Carrot", Expired = "25/07/2022", Storage="Fridge", Amount=2},
                new Items { ItemName = "Broccoli", Expired = "13/07/2022", Storage="Fridge", Amount=1 },
                new Items { ItemName = "Spinach", Expired = "16/07/2022", Storage="Fridge", Amount=1},
            };

            var viewModel = new FoodStorageViewModel
            {
                Category = vegetable,
                ItemList = itemList
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        // In RouteConfig.cs (routes.MapMvcAttributeRoutes())
        [Route("items/expired/{day:regex(\\d{2})}/{month:regex(\\d{2}):range(1,12)}/{year:regex(\\d{4})}")]
        public ActionResult ByExpiredDate(int year, int month, int day)
        {
            return Content(day + "/" + month + "/" + year);
        }

    }
}