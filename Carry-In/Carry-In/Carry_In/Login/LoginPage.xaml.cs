using System;
using Xamarin.Forms;

namespace Carry_In.Login
{
    public partial class LoginPage : ContentPage
    {
        public string MainText { get; set; }
        public LoginPage()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            MainText = "Initial Text";
        }
    }
}