using Carry_In.Login;
using Xamarin.Forms;

namespace Carry_In
{
    public class App : Application
	{
		public App ()
		{
            var navigation = new NavigationPage();
            var login = new LoginPage(new LoginViewModel(navigation));
            MainPage = login;
		}

        protected override void OnStart()
        {
            // Handle when your app starts
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