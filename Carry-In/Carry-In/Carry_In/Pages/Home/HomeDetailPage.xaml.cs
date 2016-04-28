
using Carry_In.Home;
using Carry_In.Pages.Home.Commands;
using System.Windows.Input;
using Xamarin.Forms;

namespace Carry_In.Pages.Home
{
    public partial class HomeDetailPage : ContentPage
	{

        public HomeViewModel ViewModel { get; set; }
        public HomeDetailPage ()
		{
            BindingContext = this;
			InitializeComponent ();

            LoginElement.Command = Login;
        }

        

        private ICommand _loginCommand { get; set; }
        public ICommand Login
        {
            get
            {
                return _loginCommand ?? new LoginCommand(this);
            }
            set { }
        }
    }
}
