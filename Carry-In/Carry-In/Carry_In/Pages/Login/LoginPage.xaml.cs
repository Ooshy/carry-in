using Carry_In.Login.Commands;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Carry_In.Login
{
    public partial class LoginPage : ContentPage
    {
        public LoginViewModel ViewModel { get; set; }
        
        public LoginPage(LoginViewModel viewModel)
        {
            ViewModel = viewModel;


            Setup();
        }

        private ICommand LoginCommand { get; set; }
        public ICommand Login
        {
            get
            {
                return LoginCommand ?? new LoginCommand(ViewModel);
            }
        }

        private void Setup()
        {
            BindingContext = ViewModel;
            InitializeComponent();
        }
    }
}