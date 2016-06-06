using Carry_In.Services.Login;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Carry_In.Home
{
    public class HomeViewModel
    {
        public LoginService LoginService { get; }
        public HomeViewModel(LoginService loginService = null)
        {
            LoginService = loginService;
        }

        // Select Restaurant

        // Search For Restaurants

    }
}
