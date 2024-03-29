
using Android.App;
using Carry_In.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using static Carry_In.Droid.Resource;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(RootNavigationRenderer))]

namespace Carry_In.Droid
{
    public class RootNavigationRenderer : NavigationRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<NavigationPage> e)
        {
            base.OnElementChanged(e);

            RemoveAppIconFromActionBar();
        }

        void RemoveAppIconFromActionBar()
        {
            // http://stackoverflow.com/questions/14606294/remove-icon-logo-from-action-bar-on-android
            var actionBar = ((Activity)Context).ActionBar;
            
            actionBar.Title = "Home";
            actionBar.SetDisplayShowTitleEnabled(true);
            actionBar.DisplayOptions |= ActionBarDisplayOptions.HomeAsUp;
            actionBar.SetIcon(Drawable.menu_icon);
        }
    }
}