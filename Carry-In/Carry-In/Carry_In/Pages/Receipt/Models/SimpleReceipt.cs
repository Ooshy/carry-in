

using System.Collections.Generic;

namespace Carry_In.Pages.Receipt.Models
{
    public class RestaurantItem
    {
        public string Icon { get; set; }
        public double AverageReview { get; set; }
        public double Distance { get; set; }
        
        public IList<string> AvailableTimes { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfReviews { get; set; }

        public double Expensiveness { get; set; }
    }    
}
