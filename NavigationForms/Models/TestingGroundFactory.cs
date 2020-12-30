using NavigationForms.ViewModels;

namespace NavigationForms.Model
{
   public class TestingGroundFactory
   {

      public TestingGroundFactory()
      {
      }

      public NotepadViewModel CreateNotepadVM()
      {
         return new NotepadViewModel();
      }

      public DataVisualiserViewModel CreateDataVisualiserVM()
      {
         return new DataVisualiserViewModel();
      }

      public SettingsViewModel CreateSettingsVM()
      {
         return new SettingsViewModel();
      }
   }
}
