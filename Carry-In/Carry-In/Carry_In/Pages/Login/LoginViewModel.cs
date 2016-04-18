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
        }

        
        public async Task<bool> Login(LoginModel model)
        {
            // Verify Credentials
            // If Successful, Login

            // Else, Return Error / Home Page

            // For Now, Let's Just Advance To The Home Page
            return true;
            
        }

        public async Task<bool> Login(RegisterModel model)
        {
            // Verify Credentials
            // If Successful, Login

            // Else, Return Error / Home Page

            // For Now, Let's Just Advance To The Home Page
            return true;
        }

    }
}
