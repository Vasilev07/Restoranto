using Resturanto.Models;
using Resturanto.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Resturanto.Controllers
{
    public class TableController : Controller
    {
        private readonly ITablesData db;
        public TableController(ITablesData db)
        {
            this.db = db;
        }

        public int GetTablesForRestaurant(int id)
        {
            return db.GetTablesForRestaurant(id).Count();
        }
        
        public void DeleteTableByRestaurantId(int id)
        {
            db.DeleteTableByRestaurantId(id);
        }
    }
}
