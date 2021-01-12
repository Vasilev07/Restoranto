using Resturanto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resturanto.Services
{
    public class TableData : ITablesData
    {
        private readonly Restoranto db;
        public TableData(Restoranto db)
        {
            this.db = db;
        }
        public void Add(Table table)
        {
            db.Table.Add(table);
            db.SaveChanges();
        }

        public IEnumerable<Table> GetAll()
        {
            return from t in db.Table
                   select t;
        }

        public Table GetById(int id)
        {
            return db.Table.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Table> GetTablesForRestaurant(int id)
        {
            return db.Table.Where(r => r.RestaurantId == id);
        }

        public void DeleteTableByRestaurantId(int id)
        {
            var data = db.Table.Where(t => t.RestaurantId == id).ToList();

            data.ForEach(t => DeleteTableById(t.Id));
        }

        public void DeleteTableById(int id)
        {
            var tableToRemove = GetById(id);

            db.Table.Remove(tableToRemove);
        }
    }
}