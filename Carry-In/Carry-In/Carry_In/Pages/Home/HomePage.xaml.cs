
using Xamarin.Forms;

namespace Carry_In.Home
{
    public partial class HomePage : ContentPage
	{
        public HomeViewModel ViewModel { get; set; }
        public HomePage (HomeViewModel homeViewModel, SearchViewModel searchViewModel)
		{
            ViewModel = homeViewModel;

            Setup();
		}

        private void Setup()
        {
            InitializeComponent();
        }
    }
}
