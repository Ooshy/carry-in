
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Carry_In.Components.Login
{
	public class LoginToolbarItem : ToolbarItem
	{
		public LoginToolbarItem ()
		{
            Text = "Hello ContentView";
            Icon = "login_icon.png";
            Command = Login;
        }


        private ICommand _loginCommand { get; set; }
        public ICommand Login
        {
            get
            {
                return _loginCommand ?? new LoginCommand();
            }
            set { }
        }

    }
}
