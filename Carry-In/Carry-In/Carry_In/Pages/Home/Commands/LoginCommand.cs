using Carry_In.Home;
using Carry_In.Login;
using System;
using System.Windows.Input;

namespace Carry_In.Pages.Home.Commands
{
    public class LoginCommand : ICommand
    {
        public HomeDetailPage HomePage { get; set; }

        private bool CanLogIn { get; set; }

        public LoginCommand(HomeDetailPage homePage)
        {
            HomePage = homePage;
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
            await App.Navigation.PushAsync(new LoginPage(new LoginViewModel()));   
        }
    }
}
