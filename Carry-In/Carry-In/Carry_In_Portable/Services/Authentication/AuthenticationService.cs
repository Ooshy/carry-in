using Carry_In.View.Login.Models;

namespace Carry_In.Services.Authentication
{
    public interface AuthenticationService
    {
        bool Authenticate(LoginModel loginModel);
    }
}
