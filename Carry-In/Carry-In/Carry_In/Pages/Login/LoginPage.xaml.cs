

using Carry_In.Pages.Login.Commands;


using System.Windows.Input;
using Xamarin.Forms;

namespace Carry_In.Login
{
    public partial class LoginPage : ContentPage
    {
        public LoginViewModel LoginViewModel { get; set; }

        public LoginPage(LoginViewModel loginViewModel)
        {
            LoginViewModel = loginViewModel;

            Setup();
        }

        private ICommand _loginCommand { get; set; }
        public ICommand Login
        {
            get
            {
                return _loginCommand ?? new LoginCommand(this);
            }
            set {}
        }

        
        private ICommand _registerCommand { get; set; }
        public ICommand Register
        {
            get
            {
                return _registerCommand ?? new RegisterCommand(this);
            }
            set {}
        }

        private void Setup()
        {
            
            BindingContext = LoginViewModel.Model;

            InitializeComponent();

            LoginElement.BindingContext = this;
            LoginElement.Command = Login;
            
            RegisterElement.BindingContext = this;
            RegisterElement.Command = Register;
        }
    }
}