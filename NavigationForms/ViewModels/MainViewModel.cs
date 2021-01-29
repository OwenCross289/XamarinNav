using System.Windows.Input;
using NavigationForms.Helper;
using NavigationForms.Interfaces;
using NavigationForms.Model;
using Xamarin.Forms;

namespace NavigationForms.ViewModels
{
    public class MainViewModel : OnPropertyChangedImplementation
    {
        private TestingGroundFactory NotFactory { get; } = new TestingGroundFactory();

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
            CurrentView = NotFactory.GetNotepadVM();
            CurrentView.OnNavigateTo();
            CurrentViewTitle = "Lottie Animations";
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

        public ICommand NavigateToDataVisualizer
        {
            get { return new Command(() => DataVisualizerNavigate()); }
        }

        public ICommand NavigateToCustomRender
        {
            get { return new Command(() => CustomRenderNavigate()); }
        }

        public ICommand NavigateToMediaElement
        {
            get { return new Command(() => MediaElementNavigate()); }
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
            CurrentView = NotFactory.GetSettingsVM();
            CurrentViewTitle = "Settings";
            CurrentView.OnNavigateTo();
        }

        public void HomeNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = NotFactory.GetNotepadVM();
            CurrentViewTitle = "Lottie Animations";
            CurrentView.OnNavigateTo();
        }

        public void VisualiserNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = NotFactory.GetDataVisulizerVM();
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

        public void DataVisualizerNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = NotFactory.GetDataVisulizerVM();
            CurrentViewTitle = "Graphs";
            CurrentView.OnNavigateTo();
        }

        public void CustomRenderNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = NotFactory.GetCustomRenderVM();
            CurrentViewTitle = "Custom Render Demo";
            CurrentView.OnNavigateTo();
        }

        public void MediaElementNavigate()
        {
            CurrentView.OnNavigateAway();
            CurrentView = NotFactory.GetMediaElementVM();
            CurrentViewTitle = "Video Demo";
            CurrentView.OnNavigateTo();
        }

        private INavigatable currentView;
        private string currentViewTitle;
    }
}
