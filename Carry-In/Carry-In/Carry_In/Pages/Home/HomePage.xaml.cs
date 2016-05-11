
using Carry_In.Pages.Home;
using System;
using Xamarin.Forms;

namespace Carry_In.Home
{
    public partial class HomePage : MasterDetailPage
	{
        public Type CurrentDetailPage { get; set; }
        public HomeViewModel ViewModel { get; set; }
        public HomePage (HomeViewModel homeViewModel)
		{
            ViewModel = homeViewModel;
            
            Setup();
		}

        private void Setup()
        {
            InitializeComponent();

            masterPage.MenuList.ItemSelected += OnMenuItemSelected;

            
            var detail = new HomeNavigationPage(new HomeDetailPage());
            CurrentDetailPage = detail.GetType();

            App.Navigation = detail.Navigation;

            Detail = detail;
        }

        void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Pages.Home.MenuItem;
            if (item != null)
            {
                var nextPage = (Page)Activator.CreateInstance(item.TargetType);
                var nextPageType = nextPage.GetType();
                if ( nextPageType != CurrentDetailPage)
                {
                    CurrentDetailPage = nextPageType;
                    nextPage = new HomeNavigationPage(nextPage);
                    App.Navigation = nextPage.Navigation;

                    Detail = nextPage;    
                }

                masterPage.MenuList.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
