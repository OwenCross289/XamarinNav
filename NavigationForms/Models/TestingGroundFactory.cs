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

        public string Title { get; set; }

        public TestingGroundFactory()
        {
        }

        public NotepadViewModel CreateNotepadVM()
        {
            if(Notepad == null)
            {
                Notepad = new NotepadViewModel();
            }

            Title = Notepad.Title;

            return Notepad;
        }

        public DataVisualiserViewModel CreateDataVisualiserVM()
        {
            if (DataVisualiser == null)
            {
                DataVisualiser = new DataVisualiserViewModel();
            }
            Title = DataVisualiser.Title;

            return DataVisualiser;
        }

        public SettingsViewModel CreateSettingsVM()
        {
            if (Settings == null)
            {
                Settings = new SettingsViewModel();
            }
            Title = Settings.Title;

            return Settings;
        }

        public AdvertisementViewModel GetAdvertisementVM()
        {
            if (Advertisement == null)
            {
                Advertisement = new AdvertisementViewModel();
            }
            Title = Advertisement.Title;

            return Advertisement;
        }
    }
}
