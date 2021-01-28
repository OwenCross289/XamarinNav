using System;
using NavigationForms.Helper;
using NavigationForms.Interfaces;

namespace NavigationForms.ViewModels
{
    public class CustomRenderViewModel : OnPropertyChangedImplementation, INavigatable
    {
        public int RedValue
        {
            get { return redValue; }
            set
            {
                redValue = value;
                OnPropertyChanged();
            }
        }
        private int redValue;

        public int GreenValue
        {
            get { return greenValue; }
            set
            {
                greenValue = value;
                OnPropertyChanged();
            }
        }
        private int greenValue;

        public int BlueValue
        {
            get { return blueValue; }
            set
            {
                blueValue = value;
                OnPropertyChanged();
            }
        }
        private int blueValue;

        public CustomRenderViewModel()
        {
            RedValue = 20;
            GreenValue = 40;
            BlueValue = 120;
        }

        public void OnNavigateAway()
        {
            // throw new NotImplementedException();
        }

        public void OnNavigateTo()
        {
            //throw new NotImplementedException();
        }
    }
}
