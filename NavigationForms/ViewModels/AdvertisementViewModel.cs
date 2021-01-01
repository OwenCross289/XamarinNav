using System;
using NavigationForms.Helper;
using NavigationForms.Interfaces;

namespace NavigationForms.ViewModels
{
    public class AdvertisementViewModel : OnPropertyChangedImplementation, INavigatable
    {
        public string Text
        {
            get { return text; }
            set
            {
                OnPropertyChanged();
            }
        }

        public string Title { get; } = "Advertsing";

        public AdvertisementViewModel()
        {
        }

        public void OnNavigateAway()
        {
            
        }

        public void OnNavigateTo()
        {
            
        }

        private string text = "ADVERTS!";
    }
}
