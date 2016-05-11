using System;
using System.Collections.Generic;
using System.Text;

namespace Carry_In.Models
{
    public class FoodItem
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Ingredients { get; set; }
        public string IconUri { get; set; }
        public string IconCacheUri { get; set; }
    }
}
