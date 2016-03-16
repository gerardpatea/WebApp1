using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public enum FoodType
    {
        Chinese,
        Italian,
        French
    }


    public class Restaurant
    {
        public int Id { get; set; }

        [Display(Name="Restaurant Name")]
        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name="Cuisine Type")]
        [Required]
        public FoodType Type { get; set; }
    }
}
