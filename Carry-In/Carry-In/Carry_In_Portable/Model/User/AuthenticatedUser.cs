using Carry_In.Services.Authentication;
using Carry_In.Services.Login;
using Carry_In.View.Login.Models;
using System;

namespace Carry_In.Model.User
{
    public class AuthenticatedUser
    {
        private Exception AuthenticationFailedException { get { return new InvalidOperationException("User could not be authenticated."); } }

        private LoginModel _LoginModel;
        private User _User;
        public User User
        {
            get
            {
                if (!_AuthenticationService.Authenticate(_LoginModel))
                    throw AuthenticationFailedException;

                return null;
            }
        }

        private AuthenticationService _AuthenticationService { get; }
        public AuthenticatedUser(LoginModel loginModel, LoginService loginService)
        {

            //if (loginService.Login(loginModel))
            //{

            //}
            //_AuthenticationService = authenticationService;

            //if (_AuthenticationService.Authenticate(loginModel))
            //    throw AuthenticationFailedException;

            //_LoginModel = loginModel;
        }

        public bool ValidateUser(LoginModel loginModel, AuthenticationService authenticationService)
        {
            return authenticationService.Authenticate(loginModel);
        }
    }
}
