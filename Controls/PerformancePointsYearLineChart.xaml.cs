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

namespace ihcProject.Controls
{
    /// <summary>
    /// Interaction logic for PerformancePointsYearLineChart.xaml
    /// </summary>
    public partial class PerformancePointsYearLineChart : UserControl
    {
        public PerformancePointsYearLineChart()
        {
            InitializeComponent();
            Random ran = new Random();
            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Performance Points (pp)",
                    Values = new ChartValues<double> { ran.Next(20000), ran.Next(20000), ran.Next(20000), ran.Next(20000), ran.Next(20000), ran.Next(20000), ran.Next(20000), ran.Next(20000), ran.Next(20000), ran.Next(20000), ran.Next(20000), ran.Next(20000) },
                    Fill = System.Windows.Media.Brushes.WhiteSmoke,
                }
            };

            Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Set", "Out", "Nov", "Dec"};
            YFormatter = value => value.ToString("");
            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
    }
}
