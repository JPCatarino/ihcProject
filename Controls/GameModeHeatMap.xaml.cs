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
using LiveCharts.Defaults;

namespace ihcProject.Controls
{
    /// <summary>
    /// Interaction logic for GameModeHeatMap.xaml
    /// </summary>
    public partial class GameModeHeatMap : UserControl
    {
        public GameModeHeatMap()
        {
            var r = new Random();

            Values = new ChartValues<HeatPoint>
            {
                //X means Game Mode
                //Y is the day
 
                //"Standard"
                new HeatPoint(0, 0, r.Next(0, 101)),
                new HeatPoint(0, 1, r.Next(0, 101)),
                new HeatPoint(0, 2, r.Next(0, 101)),
                new HeatPoint(0, 3, r.Next(0, 101)),
                new HeatPoint(0, 4, r.Next(0, 101)),
                new HeatPoint(0, 5, r.Next(0, 101)),
                new HeatPoint(0, 6, r.Next(0, 101)),
 
                //"Taiko"
                new HeatPoint(1, 0, r.Next(0, 101)),
                new HeatPoint(1, 1, r.Next(0, 101)),
                new HeatPoint(1, 2, r.Next(0, 101)),
                new HeatPoint(1, 3, r.Next(0, 101)),
                new HeatPoint(1, 4, r.Next(0, 101)),
                new HeatPoint(1, 5, r.Next(0, 101)),
                new HeatPoint(1, 6, r.Next(0, 101)),
 
                //"Mania"
                new HeatPoint(2, 0, r.Next(0, 101)),
                new HeatPoint(2, 1, r.Next(0, 101)),
                new HeatPoint(2, 2, r.Next(0, 101)),
                new HeatPoint(2, 3, r.Next(0, 101)),
                new HeatPoint(2, 4, r.Next(0, 101)),
                new HeatPoint(2, 5, r.Next(0, 101)),
                new HeatPoint(2, 6, r.Next(0, 101)),
 
                //"Catch The Beat"
                new HeatPoint(3, 0, r.Next(0, 101)),
                new HeatPoint(3, 1, r.Next(0, 101)),
                new HeatPoint(3, 2, r.Next(0, 101)),
                new HeatPoint(3, 3, r.Next(0, 101)),
                new HeatPoint(3, 4, r.Next(0, 101)),
                new HeatPoint(3, 5, r.Next(0, 101)),
                new HeatPoint(3, 6, r.Next(0, 101)),

            };

            Days = new[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            GameModes = new[]
            {
                "Standard",
                "Taiko",
                "Mania",
                "Catch The Beat"
            };

            DataContext = this;

            InitializeComponent();

        }
        public ChartValues<HeatPoint> Values { get; set; }
        public string[] Days { get; set; }
        public string[] GameModes { get; set; }

    }
}
