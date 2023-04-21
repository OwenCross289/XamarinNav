using System;
using NavigationForms.Helper;
using NavigationForms.Interfaces;
using OxyPlot;

namespace NavigationForms.ViewModels
{
    public class DataVisualiserViewModel : OnPropertyChangedImplementation, INavigatable
    {
        public string Text
        {
            get { return text; }
            set
            {
                text = value;
                OnPropertyChanged();
            }
        }

        public PlotModel Model
        {
            get { return model; }
            set
            {
                model = value;
                OnPropertyChanged();
            }
        }


        public DataVisualiserViewModel()
        {

        }

        public void OnNavigateAway()
        {

        }

        public void OnNavigateTo()
        {

        }

        private double[] RandomDataSet(int points = 5, double start = 100, double mult = 50)
        {
            return new[] { 0.0, 0.1 };
        }

        private Random rand = new Random(0);
        private PlotModel model;
        private string text = "Graphs go here";
    }
}

