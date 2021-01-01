using System.Windows.Input;
using NavigationForms.Helper;
using NavigationForms.Interfaces;
using NavigationForms.Model;
using Xamarin.Forms;

namespace NavigationForms.ViewModels
{
   public class MainViewModel : OnPropertyChangedImplementation
   {
        private TestingGroundFactory Factory { get; set; } = new TestingGroundFactory();

        public INavigatable CurrentView
        {
            get { return currentView; }
            set
            {
                currentView = value;
                OnPropertyChanged();
            }
        }

        public string CurrentViewTitle
        {
            get { return currentViewTitle; }
            set
            {
                currentViewTitle = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            CurrentView = Factory.CreateNotepadVM();
            CurrentViewTitle = Factory.Title;
        }

        public ICommand NavigateToVisualiser
        {
            get { return new Command(() => VisualiserNavigate()); }
        }

        public ICommand NavigateToHome
        {
            get { return new Command(() => HomeNavigate()); }
        }

        public ICommand NavigateToSettings
        {
            get { return new Command(() => SettingsNavigate()); }
        }

        public ICommand NavigateToAdvertisement
        {
            get { return new Command(() => AdvertisementNavigate()); }
        }

        public void SettingsNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = Factory.CreateSettingsVM();
            CurrentViewTitle = Factory.Title;
            CurrentView.OnNavigateTo();
        }

        public void HomeNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = Factory.CreateNotepadVM();
            CurrentViewTitle = Factory.Title;
            CurrentView.OnNavigateTo();
        }

        public void VisualiserNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = Factory.CreateDataVisualiserVM();
            CurrentViewTitle = Factory.Title;
            CurrentView.OnNavigateTo();
        }

        public void AdvertisementNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = Factory.GetAdvertisementVM();
            CurrentViewTitle = Factory.Title;
            CurrentView.OnNavigateTo();
        }

        private INavigatable currentView;
        public string currentViewTitle = "";
   }
}
