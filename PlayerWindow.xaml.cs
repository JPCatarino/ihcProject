using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ihcProject.Classes;
using MahApps.Metro.Controls;
using Newtonsoft.Json;

namespace ihcProject
{
    /// <summary>
    /// Interaction logic for PlayerWindow.xaml
    /// </summary>
    public partial class PlayerWindow : MetroWindow
    {
        public UserTemplate cUserData; 
        public PlayerWindow()
        {
            InitializeComponent();
        }

        public PlayerWindow(UserTemplate cUserData)
        {
            this.cUserData = cUserData;
            this.DataContext = cUserData;
            InitializeComponent();
        }

        private void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.Show();
        }

        private void dpi_profile_Click(object sender, RoutedEventArgs e)
        {
            hmb_player.goToProfilePage();
        }
    }
}
