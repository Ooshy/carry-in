using Carry_In.Register;
using System;
using System.Windows.Input;

namespace Carry_In.View.Register.Commands
{
    public class RegisterCommand : ICommand
    {
        private RegisterPage RegisterPage { get; set; }
        public RegisterCommand(RegisterPage registerPage)
        {
            RegisterPage = registerPage;
            CanRegister = true;
        }
        private bool CanRegister { get; set; }

        
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return CanRegister; //TODO change this
        }

        public async void Execute(object parameter)
        {
            var success = await RegisterPage.RegisterViewModel.Register();

            if (success)
            {
                await App.Navigation.PopAsync(false);
                await App.Navigation.PushAsync(App.Home);
                await RegisterPage.DisplayAlert("Success", "Welcome to Carry-in!", "Continue");
            }
            else
            {
                await RegisterPage.DisplayAlert("Error", "To be determined text.", "Try Again");
            }
            
        }
    }
}
