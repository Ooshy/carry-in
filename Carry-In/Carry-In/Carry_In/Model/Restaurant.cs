
using System.Collections.Generic;

namespace Carry_In.Models
{
    public enum FoodStyle
    {
        Greek,
        Italian,
        French,
        Japanese,
        Korean,
        American
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public Location Location { get; set; }
        public FoodStyle FoodStyle { get; set; }
        public string IconUri { get; set; }
        public string IconCacheUri { get; set;}
        public string PhoneNumber { get; set; }

        public double AverageReview { get; set; }
        public double Distance { get; set; }
        public IList<string> AvailableTimes { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfReviews { get; set; }
        public string Genre { get; set; }
        public double Expensiveness { get; set; }
    }
}
