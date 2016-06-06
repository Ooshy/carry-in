using Carry_In.Home;

using Carry_In.View.Login.Models;
using Carry_In.Services.Presentation;
using Carry_In.Services.Login;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Carry_In.Services.Data.User;

namespace Carry_In.Login
{
    public class LoginViewModel
    {
        private UserDataService _UserDataService { get; }
        private LoginService _LoginService { get; }
        private PresentationService _PresentationService { get; }
        public LoginViewModel(LoginService loginService, PresentationService presentationService, UserDataService userDataService)
        {
            if ((_LoginService = loginService) == null)
                throw new ArgumentNullException("Login Service is null.");
            if ((_UserDataService = userDataService) == null)
                throw new ArgumentNullException("User Data Service is null.");
            if ((_PresentationService = presentationService) == null)
                throw new ArgumentNullException("Presentation Service is null.");
        }

        public LoginModel _Model { get; } = new LoginModel();

        public async Task<bool> Login()
        {
            return await _LoginService.LoginAsync(_Model);
        }
    }
}
