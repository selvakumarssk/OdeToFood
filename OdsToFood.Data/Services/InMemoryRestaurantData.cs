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
                new Restaurant(){ Id=2,Name="Mango Grove",Cuisine=CuisineType.French}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(x => x.Name);
        }
    }
}
