using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public string Name { get; set; }
        public FoodType Type { get; set; }
    }
}
