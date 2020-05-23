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

namespace ihcProject.Controls
{
    /// <summary>
    /// Interaction logic for ProfileStatShowcase.xaml
    /// </summary>
    public partial class ProfileStatShowcase : UserControl
    {
        public ProfileStatShowcase()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (b_graph.Child != null) {
                b_graph.Child = null;
                b_graph.Style = null;
            }
            switch(cb_main.SelectedItem.ToString().Split(new string[] { ": "}, StringSplitOptions.None).Last().Trim())
            {
                case "None":
                    b_graph.Style = Resources["dashed_border"] as Style;
                    TextBlock text = new TextBlock();
                    text.Text = "No Stats Selected";
                    text.FontSize = 30;
                    text.Foreground = Brushes.WhiteSmoke;
                    text.VerticalAlignment = VerticalAlignment.Center;
                    text.HorizontalAlignment = HorizontalAlignment.Center;
                    b_graph.Child = text;
                    break;
                case "Performance Points Gain (Year)":
                    PerformancePointsYearLineChart pointsYearLineChart = new PerformancePointsYearLineChart();
                    b_graph.Child = pointsYearLineChart;
                    break;
                case "Game Mode Frequency (Week)":
                    GameModeHeatMap gameModeHeatMap = new GameModeHeatMap();
                    b_graph.Child = gameModeHeatMap;
                    break;
            }
        }

        public string getSelectedItem() {
            return cb_main.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last().Trim();
        }

        public void hideCombo()
        {
            cb_main.Visibility = Visibility.Hidden;
        }

        public void showCombo() {
            cb_main.Visibility = Visibility.Visible;
        }
    }
}
