using Carry_In.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Carry_In.Pages.Restaurant
{
    public class FoodItemCell : TextCell
    {
        public FoodItemCell() : base()
        {
        }
        public FoodItem FoodItem { get; set; }
    }
}
