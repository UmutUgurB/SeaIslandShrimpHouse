using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaIsland.EntityLayer.Entities
{
    public class Meal
    {
        public int MealID { get; set; }
        public string MealName { get; set;} 
        public string MealDescription { get; set;}
        public string ImageUrl { get; set;}
        public decimal Price { get; set;}
        public bool IsMealActive { get; set; }
    }
}
