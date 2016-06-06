using Carry_In.Login;
using Carry_In.Register;
using System;
using System.Windows.Input;

namespace Carry_In.View.Login.Commands
{
    public class RegisterCommand : ICommand
    {
        private LoginPage RegisterViewModel { get; set; }
        public RegisterCommand(LoginPage loginViewModel)
        {
            RegisterViewModel = loginViewModel;
            CanRegister = true;
        }
        private bool CanRegister { get; set; }

        
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // if already logged in, return false
            // else return true
            return CanRegister; //TODO change this
        }

        public async void Execute(object parameter)
        {
            await App.Navigation.PushAsync(new RegisterPage { BindingContext = new RegisterViewModel() });
        }
    }
}
