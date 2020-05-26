using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ihcProject.Data
{
    class CartesianGraphData
    {
        public SeriesCollection seriesCollection1
        {
            get 
            {
                return new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "PP",
                        Values = new ChartValues<double>{8254, 8912, 9510, 9984, 10116, 10598, 10920, 11034, 11473, 11927, 12142, 12448},
                        PointGeometry=DefaultGeometries.Circle,
                    }
                };
            }
        }

        public SeriesCollection seriesCollection2
        {
            get
            {
                return new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "Rank",
                        Values = new ChartValues<double>{1182, 1021, 1094, 953, 724, 904, 742, 701, 689, 634, 611, 598},
                        PointGeometry=DefaultGeometries.Circle,
                        Stroke = Brushes.Red,
                    }
                };
            }
        }

        public SeriesCollection seriesCollection3
        {
            get
            {
                return new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "Plays",
                        Values = new ChartValues<double>{1452, 1261, 3126, 3162, 2156, 1351, 2909, 1003, 927, 589, 1250, 3156},
                        PointGeometry=DefaultGeometries.Square,
                        Stroke = Brushes.Green,
                    }
                };
            }
        }

        public string[] labelsX
        {
            get
            {
                return new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            }
        }

        public string[] labelsRankY
        {
            get
            {
                return new string[] { "1200", "1100", "1000", "900", "800", "700", "600", "500" };
            }
        }
    }
}
