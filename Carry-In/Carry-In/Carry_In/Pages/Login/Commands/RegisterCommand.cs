using Carry_In.Login;
using System;
using System.Windows.Input;

namespace Carry_In.Pages.Login.Commands
{
    public class RegisterCommand : ICommand
    {
        private LoginViewModel LoginViewModel { get; set; }
        public RegisterCommand(LoginViewModel loginViewModel)
        {
            LoginViewModel = loginViewModel;
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

        public void Execute(object parameter)
        {
            //LoginViewModel.Login("test", "test");
        }
    }
}
