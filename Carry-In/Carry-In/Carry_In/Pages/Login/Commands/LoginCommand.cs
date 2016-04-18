using Carry_In.Home;
using Carry_In.Pages.Login.Models;
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

        public async void Execute(object parameter)
        {
            LoginModel model = new LoginModel();
            model.Username = "Test";
            model.Password = "Test";
            bool success = await LoginViewModel.Login(model);

            if (success)
            {
                await App.Navigation.PushAsync(
                    new HomePage(
                        new HomeViewModel(),
                        new SearchViewModel()
                        )
                        );
            }
            else
            {
                // error
            }
        }
    }
}
