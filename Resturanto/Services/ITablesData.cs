using Resturanto.Models;
using System.Collections.Generic;

namespace Resturanto.Services
{
    public interface ITablesData
    {
        void Add(Table table);
        IEnumerable<Table> GetAll();
        IEnumerable<Table> GetTablesForRestaurant(int id);
        void DeleteTableByRestaurantId(int id);
    }
}
