using Resturanto.Models;
using System.Collections.Generic;

namespace Resturanto.Services
{
    public interface ITables
    {
        void Add(Table table);
        IEnumerable<Table> GetAll();
        /*ICollection<TableData> GetTablesForRestaurant(int id);*/
    }
}
