using Carry_In.Login;
using Xamarin.Forms;

namespace Carry_In
{
    public class App : Application
	{
        public static INavigation Navigation;
		public App ()
		{
            var login = new LoginPage(new LoginViewModel());
            var navigation = new NavigationPage(login);
            Navigation = navigation.Navigation;
            MainPage = navigation;
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