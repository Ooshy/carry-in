using Carry_In.Commands;
using Carry_In.Login;
using Carry_In.Services.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Carry_In.Components
{
    public partial class LoginRedirectButton : ToolbarItem
    {
        //private LoginService _LoginService => BindingContext as LoginService;
        private LoginPage _LoginPage { get { return new LoginPage(); } }

        public LoginRedirectButton()
        {
            BindingContext = this;

            OnLogin = new RelayCommandAsync<object>(LoginRedirect);

            InitializeComponent();
        }

        public RelayCommandAsync<object> OnLogin
        {
            get { return (RelayCommandAsync<object>)GetValue(OnLoginBinding); }
            set { SetValue(OnLoginBinding, value); }
        }

        // Using a DependencyProperty as the backing store for OnLogin.  This enables animation, styling, binding, etc...
        public static readonly BindableProperty OnLoginBinding =
            BindableProperty.Create("OnLogin", typeof(RelayCommand<object>), typeof(ToolbarItem), defaultValue: null);

        public async Task LoginRedirect(object doNothing)
        {
            await App.Navigation.PushModalAsync(_LoginPage);
        }

        public bool CanLogin(LoginService loginService)
        {
            return !loginService.LoggedIn;
        }
    }
}
