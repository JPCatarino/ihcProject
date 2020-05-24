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
using LiveCharts;
using ihcProject.Classes;
using MaterialDesignColors;

namespace ihcProject.Pages
{
    /// <summary>
    /// Interaction logic for ComparePage.xaml
    /// </summary>
    /// 
    public partial class ComparePage : Page
    {   
        UserTemplate cUserData;
        UserTemplate RivalUser;
        public ComparePage()
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault();
            cUserData = PlayerWindow.cUserData;
            RivalUser = PlayerWindow.cUserData;
            ChartValues<double> Avalues = new ChartValues<double> {10,11,12,13,14,15,16 };
            ChartValues<double> Bvalues = new ChartValues<double> {1,2,3,4,5,6,7 };
            InitializeComponent();
            //User Data definition
            String imgsrc = cUserData.avatar_url;
            UserName.Text= cUserData.username.ToString();
            UserRank.Text = cUserData.statistics.rank.global.ToString();
            UserPP.Text= cUserData.statistics.pp.ToString();
            UserLvl.Text = cUserData.statistics.level.current.ToString();
            UserPlayCnt.Text = cUserData.statistics.play_count.ToString();
            UserTScore.Text = cUserData.statistics.total_score.ToString();
            UserAccuracy.Text= cUserData.statistics.hit_accuracy.ToString();
            //Compare Data Definition
            String CompareimgSrc = RivalUser.avatar_url;
            CompareName.Text = RivalUser.username.ToString();
            CompareRank.Text = RivalUser.statistics.rank.global.ToString();
            ComparePP.Text = RivalUser.statistics.pp.ToString();
            CompareLvl.Text = RivalUser.statistics.level.current.ToString();
            ComparePlayCnt.Text = RivalUser.statistics.play_count.ToString();
            CompareTScore.Text = RivalUser.statistics.total_score.ToString();
            CompareAccuracy.Text = RivalUser.statistics.hit_accuracy.ToString();
            SeeComparison(cUserData,RivalUser);
            //Add Chart Values
            charta.Values = Avalues;
            chartb.Values = Bvalues;
        }
        public ChartValues<double> Avalues { get; set; }
        public ChartValues<double> Bvalues { get; set; }

        public void SeeComparison(UserTemplate user1, UserTemplate user2) {

            //FF90EE90
            var Conv = new System.Windows.Media.BrushConverter();
            var brush = (Brush)Conv.ConvertFromString("#FF90EE90");

            Statistics s1 = user1.statistics;
            Statistics s2 = user2.statistics;
            //if s1.rank.global > s2.rank.global{
            //    UserRank.Background = "LawnGreen";
            //        }
            //Level Compare
            if (s1.level.current > s2.level.current) { UserLvl.Background = brush; }
            else { if (s2.level.current > s1.level.current){ CompareLvl.Background = brush; } }
            //PP compare
            if (s1.pp > s2.pp) {UserPP.Background = brush;}
            else {if (s2.pp > s1.pp) { ComparePP.Background = brush; }}
            //score compare
            if (s1.total_score > s1.total_score) { UserTScore.Background = brush; }
            else { if (s2.total_score > s1.total_score) { CompareTScore.Background = brush; } }
            //Accuracy Compare
            if (s1.hit_accuracy > s2.hit_accuracy) { UserAccuracy.Background = brush; }
            else { if (s2.hit_accuracy > s1.hit_accuracy) { CompareAccuracy.Background = brush; } }
            //Play Count Compare
            if (s1.play_count > -s2.play_count) { UserPlayCnt.Background = brush; }
            else { if (s2.play_count > s1.play_count) { ComparePlayCnt.Background = brush; } }


        }
    
    }
}
