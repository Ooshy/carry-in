using Carry_In.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Carry_In.Pages.Restaurant.FoodTabs
{
	public partial class AppetizersPage : ContentPage
	{
        public IList<FoodItem> Appetizers { get; set; }
        public AppetizersPage () : this(null)
		{
            
		}

        public AppetizersPage(Carry_In.Models.Restaurant restaurant)
        {
            this.BindingContext = this;

            Appetizers = new List<FoodItem>()
            {
                new FoodItem { Description="Shaniqua served with eggs", Name="Tyrone's Castle", Ingredients="Bagels, Waffles" , Price=20.00m},
                new FoodItem { Description="Shaniqua served with fries", Name="Fry Waffle", Ingredients= "Fries, Waffles", Price=15.00m}
            };

            InitializeComponent();
        }
	}
}
