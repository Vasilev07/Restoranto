using Resturanto.Services;
using System.Web.Mvc;

namespace Resturanto.Controllers
{
    public class HomeController : Controller
    {
        IRestaurantData db;

        public HomeController(IRestaurantData db)
        {
            this.db = db;
        }

        public ActionResult Index()
        {
            var model = db.GetAll();

            return View(model);
        }
    }
}