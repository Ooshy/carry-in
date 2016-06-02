
using Carry_In.Pages.Restaurant;
using Carry_In.Pages.Restaurant.FoodTabs;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Carry_In.Pages.Restaurant
{
    public partial class RestaurantPage : TabbedPage
    {
        private IList<FoodPage> FoodPages { get; set; }

        public RestaurantViewModel RestaurantViewModel => BindingContext as RestaurantViewModel;


        private bool _initialized = false;
        public RestaurantPage Initialize()
        {
            if (_initialized)
                return this;

            _initialized = true;

            InitializeClassMembers();

            InitializeComponent();

            foreach (var page in FoodPages)
            {
                Children.Add(page);
            }

            if (FoodPages.Count > 0)
                FoodPages[0].RefreshFoods();

            CurrentPageChanged += (object sender, EventArgs e) =>
            {
                var currentPage = CurrentPage as FoodPage;
                if (currentPage == null)
                    return;

                var index = Children.IndexOf(currentPage);

                RestaurantViewModel.CurrentFoodType = currentPage.FoodType;
                currentPage.RefreshFoods();
            };

            return this;
        }
        private void InitializeClassMembers()
        {
            FoodPages = new List<FoodPage>() {
                GetFoodPage(FoodType.Appetizers),
                GetFoodPage(FoodType.Entrees),
                GetFoodPage(FoodType.Beverages),
                GetFoodPage(FoodType.Desserts)
            };

        }

        private FoodPage GetFoodPage(FoodType foodType)
        {
            return new FoodPage() { Title = Enum.GetName(typeof(FoodType), foodType), BindingContext = RestaurantViewModel, FoodType = foodType };
        }

    }
}
