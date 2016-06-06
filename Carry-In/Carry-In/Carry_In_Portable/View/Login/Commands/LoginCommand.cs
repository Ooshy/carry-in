using Carry_In.Login;
using Carry_In.View.Home;
using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace Carry_In.View.Login.Commands
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
                await App.Navigation.PopAsync();

                var currentPage = App.Navigation.NavigationStack[App.Navigation.NavigationStack.Count - 1];

                var refreshed = (currentPage as Refreshable)?.RefreshScreen() ?? 
                                ((currentPage as TabbedPage)?.CurrentPage as Refreshable)?.RefreshScreen() ??
                                ((currentPage as MasterDetailPage)?.Detail as Refreshable)?.RefreshScreen();
            }
            else
            {
                await LoginPage.DisplayAlert("Error", "Invalid username or password.", "Ok");
            }
        }
    }
}
