using System;
using NavigationForms.Helper;
using NavigationForms.Interfaces;

namespace NavigationForms.ViewModels
{
    public class CustomRenderViewModel : OnPropertyChangedImplementation, INavigatable
    {
        public CustomRenderViewModel()
        {
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
