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
            Sharpnado.Shades.Initializer.Initialize(loggerEnable: false);

            var mainViewModel = new MainViewModel();
            var view = new MainView
            {
                BindingContext = mainViewModel
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
