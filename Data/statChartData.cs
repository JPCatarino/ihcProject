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
    static class statChartData
    {
        static public Func<ChartPoint, string> PointLabel { get; set; }


        static public Func<double, string> yFormatter { get; set; }
        static public SeriesCollection seriesCollection { get; set; }
        static public SeriesCollection seriesCollection2 { get; set; }
        static public SeriesCollection seriesCollection3 { get; set; }
        static public SeriesCollection seriesCollection4 { get; set; }
        static public string[] labelsX { get; set; }
        static public string[] labelsRankY { get; set; }


    }
}
