using Carry_In.Data;
using Carry_In.Home;
using Carry_In.Pages.Home;
using Xamarin.Forms;

namespace Carry_In
{
	public partial class App : Application
    {
        public static INavigation Navigation;

        private static MasterDetailPage _home;
        public static MasterDetailPage Home
        {
            get
            {
                return _home ?? (_home = new HomePage(new HomeViewModel()));
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

        public static bool LoggedIn { get; internal set; }

        public App()
        {
            InitializeComponent();

            InitializeHomePage();
        }

        private void InitializeHomePage()
        {
            _home = new HomePage(new HomeViewModel());

            LoggedIn = false;

            MainPage = _home;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            // check if logged in
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
