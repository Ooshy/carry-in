
using Xamarin.Forms;

namespace Carry_In.Pages.Home
{
	public partial class HomeNavigationPage : NavigationPage
    {
		public HomeNavigationPage () : base()
		{
            InitializeComponent();
        }

        public HomeNavigationPage(Page page) : base(page)
        {
            InitializeComponent();
        }
	}
}
