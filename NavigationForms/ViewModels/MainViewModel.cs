using System.Windows.Input;
using NavigationForms.Helper;
using NavigationForms.Interfaces;
using NavigationForms.Model;
using Xamarin.Forms;

namespace NavigationForms.ViewModels
{
    public class MainViewModel : OnPropertyChangedImplementation
    {
        private TestingGroundFactory NotFactory { get; set; } = new TestingGroundFactory();

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
            CurrentView = NotFactory.CreateNotepadVM();
            CurrentView.OnNavigateTo();
            CurrentViewTitle = "Notepad";
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

        public ICommand NavigateToDependencyServicesDemo
        {
            get { return new Command(() => DependencyServicesDemoNavigate()); }
        }

        public void DependencyServicesDemoNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = NotFactory.GetDependencyServicesVM();
            CurrentViewTitle = "Dependency Service";
            CurrentView.OnNavigateTo();
        }

        public void SettingsNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = NotFactory.CreateSettingsVM();
            CurrentViewTitle = "Settings";
            CurrentView.OnNavigateTo();
        }

        public void HomeNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = NotFactory.CreateNotepadVM();
            CurrentViewTitle = "Notepad";
            CurrentView.OnNavigateTo();
        }

        public void VisualiserNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = NotFactory.CreateDataVisualiserVM();
            CurrentViewTitle = "Visualiser";
            CurrentView.OnNavigateTo();
        }

        public void AdvertisementNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = NotFactory.GetAdvertisementVM();
            CurrentViewTitle = "Advertising";
            CurrentView.OnNavigateTo();
        }

        private INavigatable currentView;
        private string currentViewTitle;
    }
}
