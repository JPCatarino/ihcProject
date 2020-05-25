using MahApps.Metro.Controls;
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
using System.Web;
using ihcProject.Pages;
using ihcProject.Classes;

namespace ihcProject.Controls
{
    /// <summary>
    /// Interaction logic for PlayerHamMenu.xaml
    /// </summary>
    public partial class PlayerHamMenu : UserControl
    {
        public PlayerHamMenu()
        {
            InitializeComponent();
        }

        public void goToProfilePage()
        {
            this.HamburgueMenuControl.SelectedIndex = 1;
            this.navFrame.Navigate(new Uri("../Pages/ProfilePage.xaml", UriKind.Relative));
        }

        public void goToComparePage(UserTemplate rv)
        {
            this.navFrame.Navigate(new ComparePage(rv));
        }

        public void goToRivalProfilePage(string rvname) {
            this.navFrame.Navigate(new ProfilePage(rvname));
        }

        private void HamburgerMenu_ItemClick(object sender, MahApps.Metro.Controls.ItemClickEventArgs e)
        {
            HamburgerMenuIconItem hmi = e.ClickedItem as HamburgerMenuIconItem;
            this.navFrame.Navigate(new Uri(hmi.Tag.ToString(), UriKind.Relative));
            this.HamburgueMenuControl.IsPaneOpen = false;
        }
    }
}
