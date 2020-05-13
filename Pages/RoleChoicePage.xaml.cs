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
    /// Interaction logic for RoleChoicePage.xaml
    /// </summary>
    public partial class RoleChoicePage : Page
    {
        public RoleChoicePage()
        {
            InitializeComponent();
        }

        private void b_fan_Checked(object sender, RoutedEventArgs e)
        {
            this.b_select.IsEnabled = true;
        }

        private void b_player_Checked(object sender, RoutedEventArgs e)
        {
            this.b_select.IsEnabled = true;
        }
    }
}
