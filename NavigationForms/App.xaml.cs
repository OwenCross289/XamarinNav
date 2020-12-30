using NavigationForms.Views;
using NavigationForms.ViewModels;
using Xamarin.Forms;

namespace NavigationForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var x = new MainViewModel();
            MainPage = new MainView
            {
                BindingContext = x
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
