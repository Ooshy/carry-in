using Carry_In.Login;
using System;
using System.Windows.Input;

namespace Carry_In.Pages.Login.Commands
{
    public class LoginCommand : ICommand
    {
        public LoginPage LoginPage { get; set; }

        private bool CanLogIn { get; set; }

        public LoginCommand(LoginPage loginPage)
        {
            LoginPage = loginPage;
            CanLogIn = true;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // if already logged in, return false
            // else return true
            return CanLogIn; //TODO change this
        }

        public async void Execute(object parameter)
        {
            bool success = await LoginPage.LoginViewModel.Login();

            if (success)
            {
                App.LoggedIn = true;
                await App.Navigation.PopAsync();
            }
            else
            {
                await LoginPage.DisplayAlert("Error", "Invalid username or password.", "Ok");
            }
        }
    }
}
