using ihcProject.Classes;
using ihcProject.Controls;
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
        UserTemplate cUserData
        { get; set; }
        UserTemplate rivalUserData
        { get; set; }


        public static DependencyProperty rivalUserProperty = DependencyProperty.Register("rivalUser", typeof(String), typeof(ProfilePage));

        public ProfilePage()
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault();
            cUserData = PlayerWindow.cUserData;
            DataContext = cUserData;
            InitializeComponent();
        }

        public ProfilePage(string rvname)
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault();
            UserGenerator rivalGen = new UserGenerator(rvname, "...", "Player");
            cUserData = PlayerWindow.cUserData;
            rivalGen.generateRival();
            rivalUserData = rivalGen.getUser();
            DataContext = rivalUserData;
            Console.WriteLine(rvname);
            InitializeComponent();
            b_perf.Visibility = Visibility.Hidden;
            b_stat.Visibility = Visibility.Hidden;
            b_comp.Visibility = Visibility.Visible;
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
            cUserData.profile_choices.cb1_item = cb1.getIndex();
            cUserData.profile_choices.cb2_item = cb2.getIndex();
            cUserData.profile_choices.cb3_item = cb3.getIndex();
            cUserData.profile_choices.cb4_item = cb4.getIndex();
        }

        private void b_perf_cancel_Click(object sender, RoutedEventArgs e)
        {
            cb1.setIndex(cUserData.profile_choices.cb1_item);
            cb2.setIndex(cUserData.profile_choices.cb2_item);
            cb3.setIndex(cUserData.profile_choices.cb3_item);
            cb4.setIndex(cUserData.profile_choices.cb4_item);
            disablePerfConf();

        }

        private void b_perf_clean_Click(object sender, RoutedEventArgs e)
        {
            cb1.setIndex(0);
            cb2.setIndex(0);
            cb3.setIndex(0);
            cb4.setIndex(0);
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

        private void b_stat_Click(object sender, RoutedEventArgs e)
        {
            pss_main.showCombo();
            b_stat_cancel.Visibility = Visibility.Visible;
            b_stat_save.Visibility = Visibility.Visible;
            b_stat_clean.Visibility = Visibility.Visible;
        }

        private void b_stat_save_Click(object sender, RoutedEventArgs e)
        {
            disableStatConf();
            cUserData.profile_choices.pss_item = pss_main.getIndex();
        }

        private void b_stat_cancel_Click(object sender, RoutedEventArgs e)
        {
            disableStatConf();
            pss_main.setIndex(cUserData.profile_choices.pss_item);
        }

        private void b_stat_clean_Click(object sender, RoutedEventArgs e)
        {
            pss_main.setIndex(0);
        }

        private void disableStatConf()
        {
            pss_main.hideCombo();
            b_stat_cancel.Visibility = Visibility.Collapsed;
            b_stat_save.Visibility = Visibility.Collapsed;
            b_stat_clean.Visibility = Visibility.Collapsed;
        }

        private void cb1_Loaded(object sender, RoutedEventArgs e)
        {
            BeatmapSplitButton aux = (BeatmapSplitButton)sender;
            if (rivalUserData != null) {
                aux.setIndex(rivalUserData.profile_choices.cb1_item);
            }
            else aux.setIndex(cUserData.profile_choices.cb1_item);
        }

        private void cb2_Loaded(object sender, RoutedEventArgs e)
        {
            BeatmapSplitButton aux = (BeatmapSplitButton)sender;
            if (rivalUserData != null)
            {
                aux.setIndex(rivalUserData.profile_choices.cb2_item);
            }
            else aux.setIndex(cUserData.profile_choices.cb2_item);
        }

        private void cb3_Loaded(object sender, RoutedEventArgs e)
        {
            BeatmapSplitButton aux = (BeatmapSplitButton)sender;
            if (rivalUserData != null)
            {
                aux.setIndex(rivalUserData.profile_choices.cb3_item);
            }
            else aux.setIndex(cUserData.profile_choices.cb3_item);
        }

        private void cb4_Loaded(object sender, RoutedEventArgs e)
        {
            BeatmapSplitButton aux = (BeatmapSplitButton)sender;
            if (rivalUserData != null)
            {
                aux.setIndex(rivalUserData.profile_choices.cb4_item);
            }
            else aux.setIndex(cUserData.profile_choices.cb4_item);
        }

        private void pss_main_Loaded(object sender, RoutedEventArgs e)
        {
            ProfileStatShowcase aux = (ProfileStatShowcase)sender;
            if (rivalUserData != null)
            {
                aux.setIndex(rivalUserData.profile_choices.pss_item);
            }
            else aux.setIndex(cUserData.profile_choices.pss_item);
        }

        private void b_comp_Click(object sender, RoutedEventArgs e)
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault();
            PlayerWindow.hmb_player.goToComparePage();
        }
    }
}
