
using Carry_In.Pages.Register.Commands;
using System.Windows.Input;
using Xamarin.Forms;

namespace Carry_In.Register
{
    public partial class RegisterPage : ContentPage
	{
        public RegisterViewModel RegisterViewModel => BindingContext as RegisterViewModel;
        public RegisterPage ()
        {
            InitializeComponent();

            SetupRegisterButton();
        }
        
        private void SetupRegisterButton()
        {
            RegisterElement.BindingContext = this;
            RegisterElement.Command = Register;
        }

        private ICommand _registerCommand;
        public ICommand Register =>  _registerCommand ?? (_registerCommand = new RegisterCommand(this));
    }
}
