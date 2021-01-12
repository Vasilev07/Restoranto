using Resturanto.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Resturanto.Services
{
    public class RestaurantData : IRestaurantData
    {
        private readonly Restoranto db;

        public RestaurantData(Restoranto db)
        {
            this.db = db;
        }

        public void Add(Restaurant restaurant)
        {
            db.Restaurants.Add(restaurant);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var restaurant = db.Restaurants.Find(id);
            db.Restaurants.Remove(restaurant);
            db.SaveChanges();
        }

        public Restaurant Get(int id)
        {
            return db.Restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return from r in db.Restaurants
                   orderby r.Name
                   select r;
        }

        public int GetTablesForRestaurant(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Restaurant restaurant)
        {
            var r = Get(restaurant.Id);

            r.Name = restaurant.Name;
            r.Cuisine = restaurant.Cuisine;

            db.SaveChanges();
        }
    }
}