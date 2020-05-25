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

namespace ihcProject.Controls
{
    /// <summary>
    /// Interaction logic for PlayerHeader.xaml
    /// </summary>
    public partial class PlayerHeader : UserControl
    {

        public string userName
        {
            get { return GetValue(userNameProperty) as string; }
            set { SetValue(userNameProperty, value); }
        }

        public int globalRank
        {
            get { return (int) GetValue(globalRankProperty); }
            set { SetValue(globalRankProperty, value); }
        }

        public string countryName
        {
            get { return GetValue(countryNameProperty) as string; }
            set { SetValue(countryNameProperty, value); }
        }

        public int countryRank
        {
            get { return (int)GetValue(countryRankProperty); }
            set { SetValue(countryRankProperty, value); }
        }

        public int star
        {
            get { return (int)GetValue(starProperty); }
            set { SetValue(starProperty, value); }
        }

        public string avgBtt
        {
            get { return GetValue(avgBttProperty) as string; }
            set { SetValue(avgBttProperty, value); }
        }

        public int avgBPM
        {
            get { return (int)GetValue(avgBPMProperty); }
            set { SetValue(avgBPMProperty, value); }
        }

        public int cs
        {
            get { return (int)GetValue(csProperty); }
            set { SetValue(csProperty, value); }
        }

        public int ar
        {
            get { return (int)GetValue(arProperty); }
            set { SetValue(arProperty, value); }
        }

        public int od
        {
            get { return (int)GetValue(odProperty); }
            set { SetValue(odProperty, value); }
        }

        public int hp
        {
            get { return (int)GetValue(csProperty); }
            set { SetValue(hpProperty, value); }
        }

        public static DependencyProperty userNameProperty = DependencyProperty.Register("userName", typeof(string), typeof(PlayerHeader));
        public static DependencyProperty globalRankProperty = DependencyProperty.Register("globalRank", typeof(int), typeof(PlayerHeader));
        public static DependencyProperty countryNameProperty = DependencyProperty.Register("countryName", typeof(string), typeof(PlayerHeader));
        public static DependencyProperty countryRankProperty = DependencyProperty.Register("countryRank", typeof(int), typeof(PlayerHeader));
        public static DependencyProperty starProperty = DependencyProperty.Register("star", typeof(int), typeof(PlayerHeader));
        public static DependencyProperty avgBttProperty = DependencyProperty.Register("avgBtt", typeof(string), typeof(PlayerHeader));
        public static DependencyProperty avgBPMProperty = DependencyProperty.Register("avgBPM", typeof(int), typeof(PlayerHeader));
        public static DependencyProperty csProperty = DependencyProperty.Register("cs", typeof(int), typeof(PlayerHeader));
        public static DependencyProperty arProperty = DependencyProperty.Register("ar", typeof(int), typeof(PlayerHeader));
        public static DependencyProperty odProperty = DependencyProperty.Register("od", typeof(int), typeof(PlayerHeader));
        public static DependencyProperty hpProperty = DependencyProperty.Register("hp", typeof(int), typeof(PlayerHeader));



        public PlayerHeader()
        {
            Console.WriteLine(userName);
            InitializeComponent();
        }
    }
}
