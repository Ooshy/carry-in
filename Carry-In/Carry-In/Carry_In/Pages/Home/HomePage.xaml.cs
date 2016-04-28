
using Xamarin.Forms;

namespace Carry_In.Home
{
    public partial class HomePage : MasterDetailPage
	{
        public HomeViewModel ViewModel { get; set; }
        public HomePage (HomeViewModel homeViewModel)
		{
            ViewModel = homeViewModel;

            Setup();
		}

        private void Setup()
        {
            InitializeComponent();

            //this.Content = null;
        }
    }
}
