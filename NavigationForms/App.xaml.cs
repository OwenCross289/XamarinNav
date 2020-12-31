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
            var view = new MainView
            {
                BindingContext = x
            };
            MainPage = new NavigationPage(view)
            { 
                BarBackgroundColor = Color.FromHex("#fd7b38"),
                BarTextColor = Color.White
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
