
using Carry_In.View.Home;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Linq;

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

        private ICollection<Tuple<Type, Page>> _CachedPages = new Collection<Tuple<Type, Page>>();

        void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as View.Home.Components.MenuItem;
            if (item != null)
            {
                

                var nextPageType = item.TargetType;
                if ( nextPageType != CurrentDetailPageType)
                {
                    CurrentDetailPageType = nextPageType;

                    var nextPage = _CachedPages.Where(typeAndPage => typeAndPage.Item1 == item.TargetType)
                                           .Select(typeAndPage => typeAndPage.Item2)
                                           .FirstOrDefault() ??
                                           ((Func<Page>)(() =>
                                           {
                                               var newPage = new HomeNavigationPage((Page)Activator.CreateInstance(item.TargetType))
                                               {
                                                   Title = item.Title
                                               };
                                               _CachedPages.Add(new Tuple<Type, Page>(newPage.GetType(), newPage));
                                               return newPage;
                                           }))();

                    

                    App.Navigation = nextPage.Navigation;

                    Detail = nextPage;    
                }

                masterPage.MenuList.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}
