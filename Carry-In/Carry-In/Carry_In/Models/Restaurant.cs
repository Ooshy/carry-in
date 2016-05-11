using System;
using System.Collections.Generic;
using System.Text;

namespace Carry_In.Models
{
    public enum FoodStyle
    {

    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Location Location { get; set; }
        public FoodStyle FoodStyle { get; set; }
        public string IconUri { get; set; }
        public string IconCacheUri { get; set; }
        public string PhoneNumber { get; set; }
        public string AvailableTimes { get; set; }
    }
}
