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
    /// Interaction logic for ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        //List<ComboBox> selectedComboBox;
        public ProfilePage()
        {
            InitializeComponent();
        }

        private void b_perf_Click(object sender, RoutedEventArgs e)
        {
            cb1.IsEnabled = true;
            cb2.IsEnabled = true;
            cb3.IsEnabled = true;
            cb4.IsEnabled = true;
            r_cb1.Visibility = Visibility.Collapsed;
            r_cb2.Visibility = Visibility.Collapsed;
            r_cb3.Visibility = Visibility.Collapsed;
            r_cb4.Visibility = Visibility.Collapsed;
            b_perf_cancel.Visibility = Visibility.Visible;
            b_perf_save.Visibility = Visibility.Visible;
            b_perf_clean.Visibility = Visibility.Visible;
        }

        private void b_perf_save_Click(object sender, RoutedEventArgs e)
        {
            disablePerfConf();
            //selectedComboBox.Clear();

        }

        private void b_perf_cancel_Click(object sender, RoutedEventArgs e)
        {
            //selectedComboBox.ForEach(delegate(ComboBox cb){
            //    cb.SelectedItem = -1;
            //});
            disablePerfConf();
            //selectedComboBox.Clear();

        }

        private void disablePerfConf() {
            cb1.IsEnabled = false;
            cb2.IsEnabled = false;
            cb3.IsEnabled = false;
            cb4.IsEnabled = false;
            r_cb1.Visibility = Visibility.Visible;
            r_cb2.Visibility = Visibility.Visible;
            r_cb3.Visibility = Visibility.Visible;
            r_cb4.Visibility = Visibility.Visible;
            b_perf_cancel.Visibility = Visibility.Collapsed;
            b_perf_save.Visibility = Visibility.Collapsed;
            b_perf_clean.Visibility = Visibility.Collapsed;
        }

        private void cb_GotFocus(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("got focus");
        }
    }
}
