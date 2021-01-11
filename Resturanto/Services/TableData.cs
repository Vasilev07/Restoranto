using Resturanto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resturanto.Services
{
    public class TableData : ITables
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

        /*public ICollection<TableData> GetTablesForRestaurant(int id)
        {
            return from t in db.Table
                   where t.;
        }*/
    }
}