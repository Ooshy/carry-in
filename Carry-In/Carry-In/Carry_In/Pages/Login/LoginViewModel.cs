using Carry_In.Home;
using System;
using Xamarin.Forms;

namespace Carry_In.Login
{
    public class LoginViewModel
    {
        private NavigationPage Navigation { get; set; }
        public LoginViewModel(NavigationPage navigation)
        {
            Navigation = navigation;
        }

        public void Login(object sender, EventArgs args)
        {
            // Verify Credentials
            // If Successful, Login

            // Else, Return Error / Home Page

            // For Now, Let's Just Advance To The Home Page
            Navigation?.PushAsync(new HomePage(new HomeViewModel(Navigation), new SearchViewModel(Navigation)));
        }
        

    }
}
