using Carry_In.Home;
using Carry_In.Services;
using Carry_In.Services.Authentication;
using Carry_In.Services.Login;
using Xamarin.Forms;

namespace Carry_In
{
    public partial class App : Application
    {
        public static INavigation Navigation;

        private static MasterDetailPage _home;
        public static MasterDetailPage Home => _home ?? (_home = new HomePage { BindingContext = new HomeViewModel() });

        private AuthenticationService _AuthenticationService;
        private SystemServices _SystemServices { get; }

        public App()
        {
            InitializeComponent();

            _SystemServices = new SystemServices
            (
                authenticationService: (_AuthenticationService = null),
                presentationService: null,
                loginService: new CarryInLoginService(_AuthenticationService)
            );

            InitializeHomePage();
        }

        private void InitializeHomePage()
        {
            MainPage = Home;   
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
