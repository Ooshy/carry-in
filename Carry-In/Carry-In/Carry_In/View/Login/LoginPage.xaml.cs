

using Carry_In.View.Login.Commands;


using System.Windows.Input;
using Xamarin.Forms;

namespace Carry_In.Login
{
    public partial class LoginPage : ContentPage
    {
        public LoginViewModel LoginViewModel => BindingContext as LoginViewModel;

        public LoginPage()
        {
            InitializeComponent();

            Setup();
        }

        private ICommand _loginCommand;
        public ICommand Login => _loginCommand ?? (_loginCommand = new LoginCommand(this));


        private ICommand _registerCommand;
        public ICommand Register => _registerCommand ?? (_registerCommand = new RegisterCommand(this));

        private void Setup()
        {       
            LoginElement.BindingContext = this;
            LoginElement.Command = Login;
            
            RegisterElement.BindingContext = this;
            RegisterElement.Command = Register;
        }
    }
}