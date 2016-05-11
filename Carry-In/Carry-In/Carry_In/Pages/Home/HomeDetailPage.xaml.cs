﻿
using Carry_In.Home;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using Carry_In.Pages.Receipt.Models;
using Carry_In.Restaurant;
using Carry_In.Components.Login;

namespace Carry_In.Pages.Home
{
    public partial class HomeDetailPage : ContentPage
    {

        public HomeViewModel ViewModel { get; set; }
        public HomeDetailPage()
        {
            BindingContext = this;
            InitializeComponent();
            
            if (!App.LoggedIn)
                ToolbarItems.Add(new LoginToolbarItem());

            
            RecentPlacesListView.ItemSelected += OnRecentPlaceSelected;
            InitializeRecents();

        }

        class RecentsListItemWithImage : RestaurantItem
        {
            public ImageSource Source { get; set; }
        }
        private void InitializeRecents()
        {

            RecentPlacesListView.ItemsSource = new RestaurantItem[]
            {
                new RecentsListItemWithImage()
                {
                    Title = "Aladin's Poundhouse",
                    Description = "A fine establishment",
                    AvailableTimes = new string[] { "10:00 PM" },
                    Distance = 10,
                    Expensiveness = 100.0,
                    Icon = "",
                    Source = ImageSource.FromUri(new Uri("http://deliciousliving.com/site-files/deliciousliving.com/files/uploads/2013/04/Food%2520samples_0.jpg")),
                    NumberOfReviews = 10,
                    AverageReview = 5
                },
                new RecentsListItemWithImage()
                {
                    Title = "Tyrone's Venture",
                    Description = "A not so fine establishment",
                    AvailableTimes = new string[] { "1:00 AM" },
                    Distance = 1,
                    Expensiveness = 10.0,
                    Icon = "",
                    Source = ImageSource.FromUri(new Uri("http://deliciousliving.com/site-files/deliciousliving.com/files/uploads/2013/04/Food%2520samples_0.jpg")),
                    NumberOfReviews = 100,
                    AverageReview = 2
                },
                new RecentsListItemWithImage()
                {
                    Title = "Tyrone's Venture",
                    Description = "A not so fine establishment",
                    AvailableTimes = new string[] { "1:00 AM" },
                    Distance = 1,
                    Expensiveness = 10.0,
                    Icon = "",
                    Source = ImageSource.FromUri(new Uri("http://deliciousliving.com/site-files/deliciousliving.com/files/uploads/2013/04/Food%2520samples_0.jpg")),
                    NumberOfReviews = 100,
                    AverageReview = 2
                },
                new RecentsListItemWithImage()
                {
                    Title = "Tyrone's Venture",
                    Description = "A not so fine establishment",
                    AvailableTimes = new string[] { "1:00 AM" },
                    Distance = 1,
                    Expensiveness = 10.0,
                    Icon = "",
                    Source = ImageSource.FromUri(new Uri("http://deliciousliving.com/site-files/deliciousliving.com/files/uploads/2013/04/Food%2520samples_0.jpg")),
                    NumberOfReviews = 100,
                    AverageReview = 2
                },
                new RecentsListItemWithImage()
                {
                    Title = "Tyrone's Venture",
                    Description = "A not so fine establishment",
                    AvailableTimes = new string[] { "1:00 AM" },
                    Distance = 1,
                    Expensiveness = 10.0,
                    Icon = "",
                    Source = ImageSource.FromUri(new Uri("http://deliciousliving.com/site-files/deliciousliving.com/files/uploads/2013/04/Food%2520samples_0.jpg")),
                    NumberOfReviews = 100,
                    AverageReview = 2
                }
            };
        }

        async void OnRecentPlaceSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (RecentPlacesListView.SelectedItem != null)
            {
                var menuItem = e.SelectedItem as RestaurantItem;

                if (menuItem == null)
                    return;

                RecentPlacesListView.SelectedItem = null;

                var page = new RestaurantPage();

                await App.Navigation.PushAsync(page);
            }
        }

    }
}
