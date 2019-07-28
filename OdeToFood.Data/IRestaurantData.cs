using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
    public class InMemoryResurantData : IRestaurantData
    {
        public List<Restaurant> restaurants;

        public InMemoryResurantData()
        {
            restaurants = new List<Restaurant>() {
                new Restaurant{Id=1,Name="Saravana Bhavan",Cuisine=CuisineType.SouthIndian,Location="BTM Layout"},
                new Restaurant{Id=2,Name="New Cafetria",Cuisine=CuisineType.NorthIndian,Location="BTM Layout"},
                new Restaurant{Id=3,Name="Burger King",Cuisine=CuisineType.Mexican,Location="HSR Layout"},
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(x => x.Name);
        }
    }
}
