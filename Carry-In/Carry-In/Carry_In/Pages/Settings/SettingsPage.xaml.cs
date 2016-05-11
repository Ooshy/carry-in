﻿using Carry_In.Components.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Carry_In.Pages.Settings
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();

            if (!App.LoggedIn)
                ToolbarItems.Add(new LoginToolbarItem());
        }
	}
}
