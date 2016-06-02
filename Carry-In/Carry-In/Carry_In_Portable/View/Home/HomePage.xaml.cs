
using Carry_In.Pages.Home;
using System;
using Xamarin.Forms;

namespace Carry_In.Home
{
    public partial class HomePage : MasterDetailPage
	{
        public Type CurrentDetailPageType { get; set; }
        public HomeViewModel ViewModel => BindingContext as HomeViewModel;
        public HomePage ()
		{
            InitializeComponent();

            Setup();
		}

        private void Setup()
        {
            masterPage.MenuList.ItemSelected += OnMenuItemSelected;

            
            var detailPage = new HomeNavigationPage(new HomeTabbedPage()) { Title = "Home" };
            CurrentDetailPageType = detailPage.GetType();

            App.Navigation = detailPage.Navigation;

            Detail = detailPage;
        }

        void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Pages.Home.MenuItem;
            if (item != null)
            {
                var nextPage = (Page)Activator.CreateInstance(item.TargetType);
                var nextPageType = nextPage.GetType();
                if ( nextPageType != CurrentDetailPageType)
                {
                    CurrentDetailPageType = nextPageType;
                    nextPage = new HomeNavigationPage(nextPage) { Title = nextPage.Title };
                    App.Navigation = nextPage.Navigation;

                    Detail = nextPage;    
                }

                masterPage.MenuList.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
