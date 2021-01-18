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
            int pointCount = 5;
            double[] ys1 = RandomDataSet(pointCount);
            double[] ys2 = RandomDataSet(pointCount);

            // create a series of bars and populate them with data
            var seriesA = new OxyPlot.Series.ColumnSeries()
            {
                Title = "Series A",
                StrokeColor = OxyColors.Black,
                FillColor = OxyColors.Red,
                StrokeThickness = 1
            };

            var seriesB = new OxyPlot.Series.ColumnSeries()
            {
                Title = "Series B",
                StrokeColor = OxyColors.Black,
                FillColor = OxyColors.Blue,
                StrokeThickness = 1
            };

            for (int i = 0; i < pointCount; i++)
            {
                seriesA.Items.Add(new OxyPlot.Series.ColumnItem(ys1[i], i));
                seriesB.Items.Add(new OxyPlot.Series.ColumnItem(ys2[i], i));
            }

            // create a model and add the bars into it
            var plotModel = new PlotModel
            {
                Title = "Bar Graph (Column Series)"
            };
            plotModel.Axes.Add(new OxyPlot.Axes.CategoryAxis());
            plotModel.Series.Add(seriesA);
            plotModel.Series.Add(seriesB);

            Model = plotModel;

        }

        public void OnNavigateAway()
        {

        }

        public void OnNavigateTo()
        {

        }

        private double[] RandomDataSet(int points = 5, double start = 100, double mult = 50)
        {
            // return an array of difting random numbers
            double[] values = new double[points];
            values[0] = start;
            for (int i = 1; i < points; i++)
                values[i] = values[i - 1] + (rand.NextDouble() - .5) * mult;
            return values;
        }

        private Random rand = new Random(0);
        private PlotModel model;
        private string text = "Graphs go here";
    }
}

