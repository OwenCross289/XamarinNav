using NavigationForms.ViewModels;

namespace NavigationForms.Model
{
    /// <summary>
    /// Infact not a factory 
    /// </summary>
    public class TestingGroundFactory
    {
        private NotepadViewModel Notepad { get; set; }

        private DataVisualiserViewModel DataVisualiser { get; set; }

        private SettingsViewModel Settings { get; set; }

        private AdvertisementViewModel Advertisement { get; set; }

        private DependencyServicesDemoViewModel DependencyServices { get; set; }

        public string Title { get; set; }

        public TestingGroundFactory()
        {
        }

        public NotepadViewModel CreateNotepadVM()
        {
            if (Notepad == null)
            {
                Notepad = new NotepadViewModel();
            }

            Title = "Notepad";

            return Notepad;
        }

        public DependencyServicesDemoViewModel GetDependencyServicesVM()
        {
            if (DependencyServices == null)
            {
                DependencyServices = new DependencyServicesDemoViewModel();
            }

            Title = "Dependency Services";

            return DependencyServices;
        }


        public DataVisualiserViewModel CreateDataVisualiserVM()
        {
            if (DataVisualiser == null)
            {
                DataVisualiser = new DataVisualiserViewModel();
            }
            Title = "Data Visualiser";

            return DataVisualiser;
        }

        public SettingsViewModel CreateSettingsVM()
        {
            if (Settings == null)
            {
                Settings = new SettingsViewModel();
            }
            Title = "Settings";

            return Settings;
        }

        public AdvertisementViewModel GetAdvertisementVM()
        {
            if (Advertisement == null)
            {
                Advertisement = new AdvertisementViewModel();
            }
            Title = "Adveertising";

            return Advertisement;
        }
    }
}
