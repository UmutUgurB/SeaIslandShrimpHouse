﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeaIsland.EntityLayer.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; } 
        public bool IsCategoryActive { get; set; }
        public List<Meal> Meal { get; set; }

    }
}
