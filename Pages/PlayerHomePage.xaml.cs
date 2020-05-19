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

namespace ihcProject.Pages
{
    /// <summary>
    /// Interaction logic for PlayerHomePage.xaml
    /// </summary>
    public partial class PlayerHomePage : Page
    {

        UserTemplate cUserData;
        public PlayerHomePage()
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().Last();
            cUserData = PlayerWindow.cUserData;
            DataContext = cUserData;
            InitializeComponent();
        }


    }

    public class ValueColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Console.WriteLine(value);
            if (value is int)
            {
                return (int)value < 0 ? new SolidColorBrush(Colors.Red) : new SolidColorBrush(Colors.Green);
            }
            return Binding.DoNothing;
        }

        public object ConvertBack(object valye, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
