
using Carry_In.Home;
using Xamarin.Forms;
using System;
using Carry_In.View.Home;
using Carry_In.Components.Login;
using System.Collections.Generic;
using Carry_In.View.Restaurant;
using Carry_In.View.Restaurant.FoodTabs;

namespace Carry_In.View.Home
{
    public partial class RecentlyVisitedPage : ContentPage, Refreshable
    {
        public HomeViewModel ViewModel => BindingContext as HomeViewModel;
        public RecentlyVisitedPage()
        {
            BindingContext = this;

            InitializeComponent();

            RefreshScreen();
    
            RecentPlacesListView.ItemSelected += OnRecentPlaceSelected;
            InitializeRecents();

        }

        private class RecentsListItemWithImage : Model.Restaurant
        {
            public ImageSource Source { get; set; }
        }
        private void InitializeRecents()
        {

            RecentPlacesListView.ItemsSource = new Model.Restaurant[]
            {
                new RecentsListItemWithImage()
                {
                    Id = 1,
                    Title = "Aladin's Poundhouse",
                    Description = "A fine establishment",
                    AvailableTimes = new string[] { "10:00 PM" },
                    Distance = 10,
                    Expensiveness = 100.0,
                    Source = ImageSource.FromUri(new Uri("http://deliciousliving.com/site-files/deliciousliving.com/files/uploads/2013/04/Food%2520samples_0.jpg")),
                    NumberOfReviews = 10,
                    AverageReview = 5
                },
                new RecentsListItemWithImage()
                {
                    Id = 2,
                    Title = "Tyrone's Venture",
                    Description = "A not so fine establishment",
                    AvailableTimes = new string[] { "1:00 AM" },
                    Distance = 4,
                    Expensiveness = 10.0,
                    Source = ImageSource.FromUri(new Uri("http://www.freedigitalphotos.net/images/category-images/131.jpg")),
                    NumberOfReviews = 100,
                    AverageReview = 2
                },
                new RecentsListItemWithImage()
                {
                    Id = 3,
                    Title = "Burger Joint",
                    Description = "Fast Food Yo",
                    AvailableTimes = new string[] { "1:00 AM" },
                    Distance = 3,
                    Expensiveness = 2,
                    Source = ImageSource.FromUri(new Uri("https://pbs.twimg.com/profile_images/561232141753651200/Tl5uHcMk.jpeg")),
                    NumberOfReviews = 900,
                    AverageReview = 2
                },
                new RecentsListItemWithImage()
                {
                    Id = 4,
                    Title = "Bagel's Palace",
                    Description = "We sell a lot of stuff!",
                    AvailableTimes = new string[] { "1:00 AM" },
                    Distance = 1,
                    Expensiveness = 5.0,
                    Source = ImageSource.FromUri(new Uri("http://a.abcnews.go.com/images/Business/GTY_banned_foods_jef_130626_16x9_608.jpg")),
                    NumberOfReviews = 500,
                    AverageReview = 2
                },
                new RecentsListItemWithImage()
                {
                    Id = 5,
                    Title = "Doughnut Shop",
                    Description = "Get your donuts!",
                    AvailableTimes = new string[] { "1:00 AM" },
                    Distance = 7,
                    Expensiveness = 10.0,            
                    Source = ImageSource.FromUri(new Uri("http://assets.eatingwell.com/sites/default/files/imagecache/standard/doughnut_pink_310.jpg")),
                    NumberOfReviews = 100,
                    AverageReview = 2
                }
            };
        }

        private IDictionary<long, RestaurantPage> restaurants = new Dictionary<long, Restaurant.RestaurantPage>();
        
        async void OnRecentPlaceSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (RecentPlacesListView.SelectedItem != null)
            {
                var theRestaurant = e.SelectedItem as Model.Restaurant;

                if (theRestaurant == null)
                    return;

                RecentPlacesListView.SelectedItem = null;

                await App.Navigation.PushAsync(
                    restaurants.ContainsKey(theRestaurant.Id) ?
                    restaurants[theRestaurant.Id] :
                    (restaurants[theRestaurant.Id] = (new RestaurantPage { BindingContext = new RestaurantViewModel(theRestaurant), Title = theRestaurant.Title }).Initialize()));
            }
        }

        public bool? RefreshScreen()
        {            
            //if (!App.LoggedIn)
            //    if (!ToolbarItems.Contains(LoginRedirectButton))
            //        ToolbarItems.Add(LoginRedirectButton);
            
            //else
            //    if (ToolbarItems.Contains(LoginRedirectButton))
            //        ToolbarItems.Remove(LoginRedirectButton);

            return null;
        }
    }
}
