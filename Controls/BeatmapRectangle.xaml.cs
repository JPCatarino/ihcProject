using ControlzEx.Standard;
using System;
using System.Collections.Generic;
using System.Globalization;
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
    /// Interaction logic for BeatmapRectangle.xaml
    /// </summary>
    public partial class BeatmapRectangle : UserControl
    {
        public BeatmapRectangle()
        {
            InitializeComponent();
        }

        public Uri rankIcon {
            get { return (Uri)GetValue(rankIconProperty); }
            set { SetValue(rankIconProperty, value); }
        }

        public Uri beatmapImage
        {
            get { return (Uri)GetValue(beatmapImageProperty); }
            set { SetValue(beatmapImageProperty, value); }
        }

        public String beatmapName
        {
            get { return (string)GetValue(beatmapNameProperty); }
            set { SetValue(beatmapNameProperty, value); }
        }

        public Uri gameModeIcon
        {
            get { return (Uri)GetValue(gameModeIconProperty); }
            set { SetValue(gameModeIconProperty, value); }
        }

        public int beatmapPercentage
        {
            get { return (int)GetValue(beatmapPercentageProperty); }
            set { SetValue(beatmapPercentageProperty, value); }
        }

        public int beatmapPP
        {
            get { return (int)GetValue(beatmapPPProperty); }
            set { SetValue(beatmapPPProperty, value); }
        }

        public static DependencyProperty beatmapImageProperty = DependencyProperty.Register("beatmapImage", typeof(Uri), typeof(BeatmapRectangle));
        public static DependencyProperty rankIconProperty = DependencyProperty.Register("rankIcon", typeof(Uri), typeof(BeatmapRectangle));
        public static DependencyProperty beatmapNameProperty = DependencyProperty.Register("beatmapName", typeof(string), typeof(BeatmapRectangle));
        public static DependencyProperty gameModeIconProperty = DependencyProperty.Register("gameModeIcon", typeof(Uri), typeof(BeatmapRectangle));
        public static DependencyProperty beatmapPercentageProperty = DependencyProperty.Register("beatmapPercentage", typeof(int), typeof(BeatmapRectangle));
        public static DependencyProperty beatmapPPProperty = DependencyProperty.Register("beatmapPP", typeof(int), typeof(BeatmapRectangle));
    }

    public class NullToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return DependencyProperty.UnsetValue;
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Binding.DoNothing;
        }
    }

    public class ValueTooltipConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Console.WriteLine(value);
            if (value is string)
            {
                string m = value.ToString().Split(new string[] { "mode-", "." }, StringSplitOptions.None)[1];
                if (m == "osu") {
                    return "Standard";
                }
                return m.First().ToString().ToUpper() + String.Join("", m.Skip(1));
            }
            if (value is Uri) {
                Uri aux = (Uri)value;
                string m = aux.ToString().Split(new string[] { "mode-", "." }, StringSplitOptions.None)[1];
                if (m == "osu")
                {
                    return "Standard";
                }
                return m.First().ToString().ToUpper() + String.Join("", m.Skip(1));
            }
            return Binding.DoNothing;
        }

        public object ConvertBack(object valye, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }

}
