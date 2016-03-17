using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class CreateViewModel
    {
        public IEnumerable<string> FoodTypes { get; set; }
        public Restaurant Restaurant { get; set; }
    }
}
