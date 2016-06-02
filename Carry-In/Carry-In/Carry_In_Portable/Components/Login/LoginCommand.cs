using Carry_In.Home;
using Carry_In.Login;
using System;
using System.Windows.Input;

namespace Carry_In.Components.Login
{
    public class LoginCommand : ICommand
    {
        private bool CanLogIn { get; set; }

        public LoginCommand()
        {
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
            App.Home.IsPresented = false;
            await App.Navigation.PushAsync(new LoginPage { BindingContext = new LoginViewModel() });   
        }
    }
}
