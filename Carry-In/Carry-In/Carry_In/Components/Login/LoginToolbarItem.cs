
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Carry_In.Components.Login
{
	public class LoginRedirectButton : ToolbarItem
	{
		public LoginRedirectButton ()
		{
            Text = "Hello ContentView";
            Icon = "login_icon.png";
            Command = Login;
        }


        private ICommand _loginCommand { get; set; }
        public ICommand Login => _loginCommand ?? (_loginCommand = new LoginCommand());
    }
}
