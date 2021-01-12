using Resturanto.Services;
using Resturanto.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Resturanto.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly IReservationData db;

        public ReservationsController(IReservationData db)
        {
            this.db = db;
        }

        // GET: Reservations
        public ActionResult Index()
        {
            var reservations = db.GetAll();

            var viewModel = new ReservationsViewModel();

            List<ReservationsViewModel> list = new List<ReservationsViewModel>();

            foreach (var item in reservations)
            {
                viewModel.Reservations.Id = item.Id;
                viewModel.Reservations.ReservationName = item.ReservationName;
                viewModel.Reservations.ReservationNumber = item.ReservationNumber;
                viewModel.Reservations.ReservationTime = item.ReservationTime;
                viewModel.TableId = item.TableId;
                viewModel.RestaurantName = item.Table.Restaurant.Name;

                list.Add(viewModel);
            }


            IEnumerable<ReservationsViewModel> viewEnumerable = list;

            return View(viewEnumerable);
        }

        // GET: Reservations/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Reservations/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Reservations/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reservations/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Reservations/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Reservations/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Reservations/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
