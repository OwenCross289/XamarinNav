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

        private string text = "Notepad!!!";
    }
}

