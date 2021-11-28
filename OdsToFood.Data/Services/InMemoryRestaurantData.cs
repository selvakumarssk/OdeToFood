using OdsToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdsToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant(){ Id=1,Name="Scott's Pizza",Cuisine=CuisineType.Italian},
                new Restaurant(){ Id=2,Name="Saravana Bhavanan",Cuisine=CuisineType.Indian},
                new Restaurant(){ Id=3,Name="Mango Grove",Cuisine=CuisineType.French}
            };
        }

        public void Add(Restaurant restaurant)
        {
            restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(r => r.Id) + 1;
        }

        public void Update(Restaurant restaurant)
        {
            var exisitingRestaurant = Get(restaurant.Id);
            exisitingRestaurant.Name=restaurant.Name;
            exisitingRestaurant.Cuisine = restaurant.Cuisine;
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(x => x.Name);
        }
    }
}
