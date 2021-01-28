using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using NavigationForms.CustomRenders;
using NavigationForms.iOS.CustomRenders;
using CoreAnimation;
using Foundation;

[assembly: ExportRenderer(typeof(DemoLabelRender), typeof(DemoLabelRenderIOS))]
namespace NavigationForms.iOS.CustomRenders
{
    public class DemoLabelRenderIOS : LabelRenderer
    {
        public DemoLabelRenderIOS() { }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.LayoutMargins = UIEdgeInsets.FromString("3.0,8.0,3.0,5.0");
                Control.Font = UIFont.FromName("Papyrus", 20f);
                Control.TextColor = UIColor.Magenta;
                Control.TextAlignment = UITextAlignment.Center;
                Control.BackgroundColor = UIColor.Black;
            }
        }
    }
}
