using ihcProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;

namespace ihcProject.Data
{
    public class statChartsData
    {
        static SeriesCollection seriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "PP",
                    Values = new ChartValues<double>{8254, 8912, 9510, 9984, 10116, 10598, 10920, 11034, 11473, 11927, 12142, 12448},
                    PointGeometry=DefaultGeometries.Circle,
                }
            };

        static SeriesCollection seriesCollection2 = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Rank",
                    Values = new ChartValues<double>{1182, 1021, 1094, 953, 724, 904, 742, 701, 689, 634, 611, 598},
                    PointGeometry=DefaultGeometries.Circle,
                    Stroke = Brushes.Red,
                },
            };

        static SeriesCollection seriesCollection3 = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Plays",
                    Values = new ChartValues<double>{1452, 1261, 3126, 3162, 2156, 1351, 2909, 1003, 927, 589, 1250, 3156},
                    PointGeometry=DefaultGeometries.Square,
                    Stroke = Brushes.Green,
                },
            };

        static public string[] labelsX = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        static public string[] labelsRankY = new string[] { "1200", "1100", "1000", "900", "800", "700", "600", "500" };

        private static void pieChart_dataClick(object sender, ChartPoint chartPoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartPoint.ChartView;

            foreach (PieSeries pieSeries in chart.Series)
            {
                pieSeries.PushOut = 0;
            }

            var series = (PieSeries)chartPoint.SeriesView;
            series.PushOut = 8;
        }
    }
}
