using Carry_In.Home;

using Carry_In.Pages.Login.Models;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Carry_In.Login
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            Model = new LoginModel();
        }

        public LoginModel Model { get; set; }

        public async Task<bool> Login()
        {
            // Verify Credentials
            //var user = App.Database.GetUser(Model.Username, Model.Password);
            //// If Successful, Login
            //if (user != null)
            //    return true;

            // Else, Return Error / Home Page
            return false;
        }
    }
}
