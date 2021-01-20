using System;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using Android.Content;
using NavigationForms.CustomRenders;
using NavigationForms.Droid.CustomRenders;
using Android.Graphics;

[assembly: ExportRenderer(typeof(DemoLabelRender), typeof(DemoLabelRenderDroid))]
namespace NavigationForms.Droid.CustomRenders
{
    public class DemoLabelRenderDroid : LabelRenderer
    {
        public DemoLabelRenderDroid(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Black);
                Control.Gravity = Android.Views.GravityFlags.Center;
                Control.SetTextColor(Android.Graphics.Color.Magenta);
                var papyrus = Typeface.CreateFromAsset(Context.Assets, "fonts/papyrus.ttf");
                Control.SetTypeface(papyrus, TypefaceStyle.Normal);
            }
        }
    }
}
