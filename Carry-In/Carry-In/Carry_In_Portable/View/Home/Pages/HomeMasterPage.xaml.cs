using Carry_In.Cart;
using Carry_In.Confirmation;
using Carry_In.View.Profile;
using Carry_In.View.Settings;
using Carry_In.Receipt;
using System;
using System.Collections.Generic;


using Xamarin.Forms;

namespace Carry_In.View.Home
{
	public partial class HomeMasterPage : ContentPage
	{
        public ListView MenuList { get { return _menuList; } }

        

        public HomeMasterPage () 
		{
			InitializeComponent ();

            var masterPageItems = new List<Components.MenuItem>();

            masterPageItems.Add(new Components.MenuItem
            {
                Title = "Home",
                IconSource = "home_icon.png",
                Detail = "",
                TargetType = typeof(HomeTabbedPage)
            });

            masterPageItems.Add(new Components.MenuItem
            {
                Title = "Cart",
                IconSource = "cart_icon.png",
                Detail = "Checkout",
                TargetType = typeof(CartPage)
            });

            masterPageItems.Add(new Components.MenuItem
            {
                Title = "Profile",
                Detail = "Update account information",
                IconSource = "user_icon.png",
                TargetType = typeof(ProfilePage)
            });


            masterPageItems.Add(new Components.MenuItem
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
