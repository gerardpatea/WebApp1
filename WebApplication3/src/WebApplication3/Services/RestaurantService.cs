using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Services
{
    public interface IResturantService
    {
        IEnumerable<Restaurant> Get();
        void Add(Restaurant newRestaurant);

    }
    public class RestaurantService : IResturantService
    {
        private IList<Restaurant> _restaurants = new List<Restaurant>();

        public RestaurantService()
        {
            _restaurants.Add(new Restaurant
            {
                Name = "Gerards Restaurant",
                Type = FoodType.Chinese
            });
        }

        public void Add(Restaurant newRestaurant)
        {
            _restaurants.Add(newRestaurant);
        }

        public IEnumerable<Restaurant> Get()
        {
            return _restaurants;
        }
    }
}
