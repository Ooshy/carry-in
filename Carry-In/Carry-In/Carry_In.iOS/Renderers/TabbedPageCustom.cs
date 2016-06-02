using Carry_In.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(TabbedPageCustom))]
namespace Carry_In.iOS.Renderers
{
    public class TabbedPageCustom : TabbedRenderer
    {
        public TabbedPageCustom()
        {
            
        }
    }
}
