using System;
using System.Collections.Generic;
using System.Linq;
using Resturanto.Models;

namespace Resturanto.Services
{
    public class InMemomoryRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemomoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant{Id = 1, Name = "Joro Pizza", Cuisine = CuisineType.Indian },
                new Restaurant{Id = 2, Name = "Joro Pizza 2", Cuisine = CuisineType.Italian },
                new Restaurant{Id = 3, Name = "Joro Pizza 3", Cuisine = CuisineType.Mexican }
            };
        }

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(r => r.Id) + 1;
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(restaurants => restaurants.Name);
        }

        public void Update(Restaurant restaurant)
        {
            var existing = Get(restaurant.Id);

            if (existing != null)
            {
                existing.Name = restaurant.Name;
                existing.Cuisine = restaurant.Cuisine;
            }
        }
    }
}
