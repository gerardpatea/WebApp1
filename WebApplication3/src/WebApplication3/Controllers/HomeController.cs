using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApplication3.Models;
using WebApplication3.Services;
using WebApplication3.ViewModels;
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private IResturantService _restaurantService;
        private IGreeter _greetingService;

        public HomeController(IResturantService restaurantService, IGreeter greetingService)
        {
            _restaurantService = restaurantService;
            _greetingService = greetingService;
        }

        public IActionResult Index()
        {
            var viewModel = new HomePageViewModel
            {
                Restaurants = _restaurantService.Get(),
                Greeting = _greetingService.GetGreeting()
            };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            var r = new Restaurant
            {
                Name = model.Name,
                Type = model.Type
            };

            _restaurantService.Add(r);

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            try
            {
                var model = _restaurantService.Get()
                    .ToList()[id];
                return View(model);
            }
            catch (ArgumentOutOfRangeException)
            {
                return RedirectToAction("Index");
            }
        }

    }
}
