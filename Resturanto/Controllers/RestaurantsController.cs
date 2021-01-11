using Resturanto.ViewModels;
using Resturanto.Services;
using System;
using System.Web.Mvc;
using Resturanto.Models;

namespace Resturanto.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantData db;
        private readonly TableController tableController;
        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
            tableController = DependencyResolver.Current.GetService<TableController>();
        }
        
        [HttpGet]
        public ActionResult Index()
        {
            var model = db.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var model = db.Get(id);

            var viewModel = new ViewModels.Restaurant();
            viewModel.Cuisine = model.Cuisine;
            viewModel.Name = model.Name;
            viewModel.Tables = tableController.GetTablesForRestaurant(id);

            if (model == null)
            {
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(ViewModels.Restaurant restaurant)
        {
            if (String.IsNullOrEmpty(restaurant.Name))
            {
                ModelState.AddModelError(nameof(restaurant.Name), "The name is required");
            }

            Models.Restaurant restaurantToSave = new Models.Restaurant();
            restaurantToSave.Cuisine = restaurant.Cuisine;
            restaurantToSave.Name = restaurant.Name;

            if (ModelState.IsValid)
            {
                for (int i = 0; i < restaurant.Tables; i++)
                {
                    Table table = new Table();
                    table.Reserved = false;
                    restaurantToSave.Tables.Add(table);
                }
                db.Add(restaurantToSave);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var model = db.Get(id);

            if (model == null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Models.Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                db.Update(restaurant);
                return RedirectToAction("Details", new { id = restaurant.Id });
            }

            return View(restaurant);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var model = db.Get(id);

            if(model == null)
            {
                return View("NotFound");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, FormCollection formCollection)
        {
            db.Delete(id);

            return RedirectToAction("Index");
        }
    }
}