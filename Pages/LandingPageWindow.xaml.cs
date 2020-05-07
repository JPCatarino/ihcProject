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
using MahApps.Metro.Controls;

namespace ihcProject
{
    /// <summary>
    /// Interaction logic for LandingPageWindow.xaml
    /// </summary>
    public partial class LandingPageWindow : MetroWindow {
        public LandingPageWindow()
        {
            InitializeComponent();
        }

        private void b_login_Click(object sender, RoutedEventArgs e)
        {
            // TODO Add redirection to login form
        }

        private void b_register_Click(object sender, RoutedEventArgs e)
        {
            // Todo Add redirection to register form
        }
    }
}
