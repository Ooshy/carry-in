using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Carry_In.Login.Commands
{
    public class LoginCommand : ICommand
    {
        public LoginViewModel LoginViewModel { get; set; }

        private bool CanLogIn { get; set; }

        public LoginCommand(LoginViewModel loginViewModel)
        {
            LoginViewModel = loginViewModel;
            CanLogIn = true;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            // if already logged in, return false
            // else return true
            return CanLogIn; //TODO change this
        }

        public void Execute(object parameter)
        {
            LoginViewModel.Login(this, EventArgs.Empty);
        }
    }
}
