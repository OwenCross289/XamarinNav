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

      public MainViewModel()
      {
          CurrentView = Factory.CreateNotepadVM();
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

      public void SettingsNavigate()
      {
         CurrentView.OnNavigateAway();
         CurrentView = Factory.CreateSettingsVM();
         CurrentView.OnNavigateTo();
      }

        public void HomeNavigate()
      {
         CurrentView.OnNavigateAway();
         CurrentView = Factory.CreateNotepadVM();
         CurrentView.OnNavigateTo();
      }

      public void VisualiserNavigate()
      {
         CurrentView.OnNavigateAway();
         CurrentView = Factory.CreateDataVisualiserVM();
         CurrentView.OnNavigateTo();
      }

      private INavigatable currentView;
   }
}
