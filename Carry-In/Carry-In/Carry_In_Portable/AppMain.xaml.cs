﻿using Carry_In.Home;
using Xamarin.Forms;

namespace Carry_In
{
	public partial class App : Application
    {
        public static INavigation Navigation;

        private static MasterDetailPage _home;
        public static MasterDetailPage Home => _home ?? (_home = new HomePage { BindingContext = new HomeViewModel() });

        public static bool LoggedIn { get; internal set; }

        public App()
        {
            InitializeComponent();

            InitializeHomePage();
        }

        private void InitializeHomePage()
        {
            LoggedIn = false;

            //MainPage = Home;
            MainPage = new FoodList();
            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            // check if logged in
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}