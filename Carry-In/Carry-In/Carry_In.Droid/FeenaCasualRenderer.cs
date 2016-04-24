using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Android.Graphics;
using Xamarin.Forms;
using Carry_In.Droid;
using Carry_In;

[assembly: ExportRenderer(typeof(Label), typeof(MyLabelRenderer))]
namespace Carry_In.Droid
{
        public class MyLabelRenderer : LabelRenderer
        {
            protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
            {
                base.OnElementChanged(e);
                var label = (TextView)Control; // for example
                Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "FeenaCasual.ttf");  // font name specified here
                label.Typeface = font;
            }
        }
    
}