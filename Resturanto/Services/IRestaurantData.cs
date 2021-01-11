using System.Collections.Generic;
using Resturanto.Models;

namespace Resturanto.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        void Add(Restaurant restaurant);
        void Update(Restaurant restaurant);
        void Delete(int id);
        int GetTablesForRestaurant(int id);
    }
}
