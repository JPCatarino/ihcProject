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
using System.Windows.Shapes;

namespace ihcProject.Pages
{
    public partial class MapDetails2 : Window
    {
        public UserTemplate cUserData { get; set; }
        public MapDetails2()
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().FirstOrDefault();
            cUserData = PlayerWindow.cUserData;
            DataContext = cUserData;
            InitializeComponent();
        }
    }
}
