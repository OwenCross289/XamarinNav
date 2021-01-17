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

        public TestingGroundFactory() { }

        public NotepadViewModel GetNotepadVM()
        {
            if (Notepad == null)
            {
                Notepad = new NotepadViewModel();
            }

            return Notepad;
        }

        public DependencyServicesDemoViewModel GetDependencyServicesVM()
        {
            if (DependencyServices == null)
            {
                DependencyServices = new DependencyServicesDemoViewModel();
            }

            return DependencyServices;
        }

        public DataVisualiserViewModel GetDataVisulizerVM()
        {
            if (DataVisualiser == null)
            {
                DataVisualiser = new DataVisualiserViewModel();
            }

            return DataVisualiser;
        }

        public SettingsViewModel GetSettingsVM()
        {
            if (Settings == null)
            {
                Settings = new SettingsViewModel();
            }

            return Settings;
        }

        public AdvertisementViewModel GetAdvertisementVM()
        {
            if (Advertisement == null)
            {
                Advertisement = new AdvertisementViewModel();
            }

            return Advertisement;
        }
    }
}
