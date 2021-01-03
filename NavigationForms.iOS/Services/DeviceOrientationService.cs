using NavigationForms.iOS.Services;
using NavigationForms.Services;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeviceOrientationService))]
namespace NavigationForms.iOS.Services
{
    public class DeviceOrientationService : IDeviceOrientationService
    {
        public DeviceOrientation GetOrientation()
        {
            UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;
            DeviceOrientation toReturn = DeviceOrientation.Undefined;
            if (orientation.IsLandscape())
            {
                toReturn = DeviceOrientation.Landscape;
            }
            if (orientation.IsPortrait())
            {
                toReturn = DeviceOrientation.Portrait;
            }

            return toReturn;
        }
    }
}
