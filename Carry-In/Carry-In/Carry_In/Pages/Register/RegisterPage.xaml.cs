
using Carry_In.Pages.Register.Commands;
using System.Windows.Input;
using Xamarin.Forms;

namespace Carry_In.Register
{
    public partial class RegisterPage : ContentPage
	{
        public RegisterViewModel RegisterViewModel { get; set; }
        public RegisterPage (RegisterViewModel registerViewModel)
        {
            RegisterViewModel = registerViewModel;
            Setup();
        }
        
        private void Setup()
        {
            BindingContext = RegisterViewModel.RegisterModel;

            InitializeComponent();

            RegisterElement.BindingContext = this;
            RegisterElement.Command = Register;
        }

        private ICommand _registerCommand { get; set; }
        public ICommand Register
        {
            get
            {
                return _registerCommand ?? new RegisterCommand(this);
            }
            set { }
        }
    }
}
