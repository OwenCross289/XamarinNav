using System;
using NavigationForms.Helper;
using NavigationForms.Interfaces;

namespace NavigationForms.ViewModels
{
    public class SettingsViewModel :  OnPropertyChangedImplementation, INavigatable
    {
        public string Text
        {
            get { return text; }
            set
            {
                OnPropertyChanged();
            }
        }

        public string Title { get; } = "Settings";

        public SettingsViewModel()
        {
        }

        public void OnNavigateAway()
        {
           
        }

        public void OnNavigateTo()
        {
            
        }

        private string text = "Settings Page. Can modify the content view to go here.";
    }
}

