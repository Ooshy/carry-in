using Carry_In.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Carry_In.View.Restaurant.FoodTabs
{
    public partial class FoodPage : ContentPage
    {
        public RestaurantViewModel FoodViewModel => BindingContext as RestaurantViewModel;

        public FoodType FoodType { get; set; }

        private bool refreshOverdue = true;
        public void RefreshFoods()
        {
            if (refreshOverdue) {
                FoodList.ItemsSource = FoodViewModel.Foods(FoodType);
                refreshOverdue = false;
            }
        }

        public FoodPage ()
		{
            InitializeComponent();
        }
	}
}
