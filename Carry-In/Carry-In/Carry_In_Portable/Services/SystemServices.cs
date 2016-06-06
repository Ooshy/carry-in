using Carry_In.Services.Presentation;
using Carry_In.Services.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carry_In.Services.Authentication;

namespace Carry_In.Services
{
    public class SystemServices
    {
        public PresentationService PresentationService { get; }
        public LoginService LoginService { get; }
        public AuthenticationService AuthenticationService { get; }

        public SystemServices(PresentationService presentationService = null, LoginService loginService = null, AuthenticationService authenticationService = null)
        {
            PresentationService = presentationService;
            LoginService = loginService;
            AuthenticationService = authenticationService;
        }
    }
}
