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
using MahApps.Metro.IconPacks;
using MaterialDesignThemes.Wpf;

namespace ihcProject
{
    /// <summary>
    /// Interaction logic for LandingPageWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b_login_Click(object sender, RoutedEventArgs e)
        {
            this.navFrame.NavigationService.Navigate(new Pages.LoginPage());
            showBackButton();
        }

        private void b_register_Click(object sender, RoutedEventArgs e)
        {
            this.navFrame.NavigationService.Navigate(new Pages.RoleChoicePage());
            showBackButton();
        }

        private void b_back_Click(object sender, RoutedEventArgs e)
        {
            this.navFrame.NavigationService.GoBack();
            if (!navFrame.NavigationService.CanGoBack)
                hideBackButton();
        }

        public void showBackButton() {
            Console.WriteLine("Back button now visible");
            this.b_login.Visibility = System.Windows.Visibility.Collapsed;
            this.b_register.Visibility = System.Windows.Visibility.Collapsed;
            this.b_back.Visibility = System.Windows.Visibility.Visible;
        }

        public void hideBackButton()
        {
            Console.WriteLine("Back button now hidden");
            this.b_login.Visibility = System.Windows.Visibility.Visible;
            this.b_register.Visibility = System.Windows.Visibility.Visible;
            this.b_back.Visibility = System.Windows.Visibility.Collapsed;
        }


    }
}
