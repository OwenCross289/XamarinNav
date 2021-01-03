using System;
using NavigationForms.Helper;
using NavigationForms.Interfaces;

namespace NavigationForms.ViewModels
{
    public class DataVisualiserViewModel : OnPropertyChangedImplementation, INavigatable
    {
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged();
            }
        }

        public DataVisualiserViewModel()
        {
        }

        public void OnNavigateAway()
        {

        }

        public void OnNavigateTo()
        {

        }

        private string text = "";
    }
}

