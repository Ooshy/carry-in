using Carry_In.Cart;
using Carry_In.Confirmation;
using Carry_In.Pages.Profile;
using Carry_In.Pages.Settings;
using Carry_In.Receipt;
using System;
using System.Collections.Generic;


using Xamarin.Forms;

namespace Carry_In.Pages.Home
{
	public partial class HomeMasterPage : ContentPage
	{
        public ListView MenuList { get { return _menuList; } }

        

        public HomeMasterPage () 
		{
			InitializeComponent ();

            var masterPageItems = new List<MenuItem>();

            masterPageItems.Add(new MenuItem
            {
                Title = "Home",
                IconSource = "home_icon.png",
                Detail = "",
                TargetType = typeof(HomeTabbedPage)
            });

            masterPageItems.Add(new MenuItem
            {
                Title = "Cart",
                IconSource = "cart_icon.png",
                Detail = "Checkout",
                TargetType = typeof(CartPage)
            });

            masterPageItems.Add(new MenuItem
            {
                Title = "Profile",
                Detail = "Update account information",
                IconSource = "user_icon.png",
                TargetType = typeof(ProfilePage)
            });


            masterPageItems.Add(new MenuItem
            {
                Title = "Settings",
                Detail = "Customize app settings",
                IconSource = "settings_icon.png",
                TargetType = typeof(SettingsPage)
            });


            _menuList.ItemsSource = masterPageItems;
        }
	}
}
