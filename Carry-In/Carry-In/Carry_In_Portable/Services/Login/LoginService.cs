
using Carry_In.View.Login.Models;
using System.Threading.Tasks;

namespace Carry_In.Services.Login
{
    public interface LoginService
    {
        bool Login(LoginModel loginModel);
        bool Logout();
        Task<bool> LogoutAsync();
        Task<bool> LoginAsync(LoginModel loginModel);
        bool LoggedIn { get; }
    }
}
