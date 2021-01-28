using System;
using NavigationForms.Helper;
using NavigationForms.Interfaces;

namespace NavigationForms.ViewModels
{
    public class NotepadViewModel : OnPropertyChangedImplementation, INavigatable
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

        public NotepadViewModel()
        {
        }

        public void OnNavigateAway()
        {

        }

        public void OnNavigateTo()
        {

        }

        private string text = "Animation View. " +
            "This page is showing off animations with lottie files a json format for displaying animations." +
            "These can be created from after effects files";
    }
}

