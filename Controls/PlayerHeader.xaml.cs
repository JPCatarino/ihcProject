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

        public UserTemplate cUserData
        { get { return GetValue(cUserDataProperty) as UserTemplate; }
          set { SetValue(cUserDataProperty, value); } }

        public static DependencyProperty cUserDataProperty = DependencyProperty.Register("cUserData", typeof(UserTemplate), typeof(PlayerHeader));


        public PlayerHeader()
        {
            InitializeComponent();
        }
    }
}
