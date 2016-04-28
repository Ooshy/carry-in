using Carry_In.Data;
using Carry_In.Home;
using Carry_In.Login;
using Xamarin.Forms;

namespace Carry_In
{
	public partial class App : Application
    {
        public static INavigation Navigation;
        private static Page _home;
        public static Page Home
        {
            get
            {
                return _home ?? (_home = new Home.HomePage(new Carry_In.Home.HomeViewModel()));
            }
        }

        static CarryInDatabase database;
        public static CarryInDatabase Database
        {
            get
            {
                database = database ?? new CarryInDatabase();
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            InitializeLoginPage();

            InitializeHomePage();
        }

        private void InitializeLoginPage()
        {
            var home = new HomePage(new HomeViewModel());
            var navigation = new NavigationPage(home)
            {
                BackgroundColor = (Color)Application.Current.Resources["icons"],
                BarBackgroundColor = (Color)Application.Current.Resources["icons"],
                BarTextColor = (Color)Application.Current.Resources["primary"],
                Title = "Menu",
            };

            Navigation = navigation.Navigation;
            MainPage = navigation;
        }

        private static void InitializeHomePage()
        {

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
