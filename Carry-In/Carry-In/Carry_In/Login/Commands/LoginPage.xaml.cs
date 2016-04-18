using System;
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

        private void Setup()
        {
            BindingContext = ViewModel;
            InitializeComponent();
        }
    }
}