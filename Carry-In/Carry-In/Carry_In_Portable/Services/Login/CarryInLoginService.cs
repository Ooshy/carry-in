using Carry_In.Services.Authentication;
using Carry_In.View.Login.Models;
using System;
using System.Threading.Tasks;

namespace Carry_In.Services.Login
{
    public class CarryInLoginService : LoginService
    {
        public bool LoggedIn { get; private set; }

        public bool Login(LoginModel loginModel)
        {
            return (LoggedIn = _AuthenticationService.Authenticate(loginModel));
        }

        private readonly AuthenticationService _AuthenticationService;
        public CarryInLoginService(AuthenticationService authenticationService)
        {
            _AuthenticationService = authenticationService;
        }

        public async Task<bool> LoginAsync(LoginModel loginModel)
        {
            return Login(loginModel);
        }

        public bool Logout()
        {
            LoggedIn = false;

            return true;
        }

        public async Task<bool> LogoutAsync()
        {
            return Logout();
        }
    }
}
