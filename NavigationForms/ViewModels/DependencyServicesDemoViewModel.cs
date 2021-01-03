using System;
using System.Windows.Input;
using NavigationForms.Helper;
using NavigationForms.Interfaces;
using NavigationForms.Services;
using Xamarin.Forms;

namespace NavigationForms.ViewModels
{
    public class DependencyServicesDemoViewModel : OnPropertyChangedImplementation, INavigatable
    {
        public string DeviceOrientationS
        {
            get { return deviceOrientationS; }
            set
            {
                deviceOrientationS = value;
                OnPropertyChanged();
            }
        }

        public DependencyServicesDemoViewModel()
        {
            DeviceOrientationS = DependencyService.Get<IDeviceOrientationService>().GetOrientation().ToString();
        }

        public ICommand GetDeviceOrientationCommand
        {
            get { return new Command(() => GetDeviceOrientation()); }
        }

        private void GetDeviceOrientation()
        {
            DeviceOrientationS = DependencyService.Get<IDeviceOrientationService>().GetOrientation().ToString();
        }

        public void OnNavigateTo()
        {

        }

        public void OnNavigateAway()
        {

        }

        private string deviceOrientationS;
    }
}
