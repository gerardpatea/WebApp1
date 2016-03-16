using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Display(Name = "Restaurant Name")]
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        public FoodType Type { get; set; }
    }
}
