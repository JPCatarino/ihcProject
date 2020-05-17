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

        private void b_select_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)b_fan.IsChecked)
                NavigationService.Navigate(new RegisterPage("Fan"));
            else if ((bool)b_player.IsChecked)
                NavigationService.Navigate(new RegisterPage("Player"));
        }

        private void b_fan_MouseMove(object sender, MouseEventArgs e)
        {
            fan_tt.Placement = System.Windows.Controls.Primitives.PlacementMode.Relative;
            fan_tt.HorizontalOffset = e.GetPosition((IInputElement)sender).X + 16;
            fan_tt.VerticalOffset = e.GetPosition((IInputElement)sender).Y + 16;
        }

        private void b_player_MouseMove(object sender, MouseEventArgs e)
        {
            player_tt.Placement = System.Windows.Controls.Primitives.PlacementMode.Relative;
            player_tt.HorizontalOffset = e.GetPosition((IInputElement)sender).X + 16;
            player_tt.VerticalOffset = e.GetPosition((IInputElement)sender).Y + 16;
        }
    }
}
