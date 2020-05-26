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

namespace ihcProject.Pages
{
    public partial class UserStats : Page
    {
        public UserTemplate cUserData
        { get; set; }



        private void pieChart_dataClick(object sender, ChartPoint chartPoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartPoint.ChartView;

            foreach (PieSeries pieSeries in chart.Series)
            {
                pieSeries.PushOut = 0;
            }

            var series = (PieSeries)chartPoint.SeriesView;
            series.PushOut = 8;
        }

        

        public UserStats()
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().FirstOrDefault();
            cUserData = PlayerWindow.cUserData;
            DataContext = cUserData;

            InitializeComponent();
        }

        private void beatmapBtt_1_Click(object sender, RoutedEventArgs e)
        {
            MapDetails deiatilsWindow = new MapDetails();
            deiatilsWindow.ShowDialog();
        }

        private void beatmapBtt_2_Click(object sender, RoutedEventArgs e)
        {
            MapDetails2 deiatilsWindow = new MapDetails2();
            deiatilsWindow.ShowDialog();
        }

        private void beatmapBtt_3_Click(object sender, RoutedEventArgs e)
        {
            MapDetails3 deiatilsWindow = new MapDetails3();
            deiatilsWindow.ShowDialog();
        }
    }
}
