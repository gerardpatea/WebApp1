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
        Restaurant Get(int id);
    }

    public class SqlServerRestaurantService : IResturantService
    {
        private RestaurantDbContext _context;

        public SqlServerRestaurantService(RestaurantDbContext context)
        {
            _context = context;
        }

        public void Add(Restaurant newRestaurant)
        {
            _context.Add(newRestaurant);
            _context.SaveChanges();
        }

        public IEnumerable<Restaurant> Get()
        {
            return _context.Restaurants;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(x => x.Id == id);
        }
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

        public Restaurant Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
