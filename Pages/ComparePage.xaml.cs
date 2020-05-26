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
using LiveCharts.Wpf;

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
        public ComparePage(UserTemplate RivalUser)
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault();
            this.cUserData = PlayerWindow.cUserData;
            this.RivalUser = RivalUser;
            int seed1 = (cUserData.statistics.pp + cUserData.statistics.play_count) * 5781643;
            int seed2 = (RivalUser.statistics.pp + RivalUser.statistics.play_count) * 4542348;
            Random r1 = new Random(seed1);
            Random r2 = new Random(seed2);
            InitializeComponent();
            var ulen = cUserData.statistics.hit_accuracy.ToString().Length;
            var rlen = RivalUser.statistics.hit_accuracy.ToString().Length;
            //User Data definition
            //String imgsrc = cUserData.avatar_url;
            UserPic.Source = loadimage(cUserData.avatar_url);
            UserName.Text = cUserData.username.ToString();
            UserRank.Text = cUserData.statistics.rank.global.ToString();
            UserPP.Text = cUserData.statistics.pp.ToString();
            UserLvl.Text = cUserData.statistics.level.current.ToString();
            UserPlayCnt.Text = cUserData.statistics.play_count.ToString();
            UserTScore.Text = cUserData.statistics.total_score.ToString();
            if (ulen > 4) { UserAccuracy.Text = cUserData.statistics.hit_accuracy.ToString().Substring(0, 4) + "%"; }
            else { UserAccuracy.Text = cUserData.statistics.hit_accuracy.ToString() + "%"; }
            //Compare Data Definition
            //String CompareimgSrc = RivalUser.avatar_url;
            VSimg.Source = new BitmapImage(new Uri("pack://application:,,,/assets/images/icons/others/vs.png"));
            ComparePic.Source = loadimage(RivalUser.avatar_url);
            CompareName.Text = RivalUser.username.ToString();
            CompareRank.Text = RivalUser.statistics.rank.global.ToString();
            ComparePP.Text = RivalUser.statistics.pp.ToString();
            CompareLvl.Text = RivalUser.statistics.level.current.ToString();
            ComparePlayCnt.Text = RivalUser.statistics.play_count.ToString();
            CompareTScore.Text = RivalUser.statistics.total_score.ToString();
            CompareAccuracy.Text = RivalUser.statistics.hit_accuracy.ToString().Substring(0,4);
            if (rlen > 4) { CompareAccuracy.Text = RivalUser.statistics.hit_accuracy.ToString().Substring(0, 4) + "%"; }
            else { CompareAccuracy.Text = RivalUser.statistics.hit_accuracy.ToString() + "%"; }

            SeeComparison(cUserData,RivalUser);
            //Add Chart Values
            List<int> l1 = gen_dummy_data(cUserData.statistics.pp, r1, 100);
            List<int> l2 = gen_dummy_data(RivalUser.statistics.pp, r2, 100);
            if (l1.Count > l2.Count) { normalize_data_size(l2, l1.Count); }
            else { if (l2.Count > l1.Count) { normalize_data_size(l1, l2.Count); } }

            SeriesCollection sc = new SeriesCollection {
                new LineSeries
                {
                    Title = cUserData.username,
                    Values = list_to_chart(l1),
                    PointGeometry = DefaultGeometries.None,
                    LineSmoothness = 0
                },

                new LineSeries
                {
                    Title=RivalUser.username,
                    Values =  list_to_chart(l2),
                    PointGeometry = DefaultGeometries.None,
                    LineSmoothness = 0
                }
            };
            LChart.Series = sc;
        }
        public ChartValues<double> Avalues { get; set; }
        public ChartValues<double> Bvalues { get; set; }


        public BitmapImage loadimage(string path) 
        {
            return new BitmapImage(new Uri("pack://application:,,," + path.Substring(2)));
        }


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
            if (s1.play_count > s2.play_count) { UserPlayCnt.Background = brush; }
            else { if (s2.play_count > s1.play_count) { ComparePlayCnt.Background = brush; } }


        }

        // Generate a list of random sorted numbers to be used for the livechart comparison
        // I try to generate the most randomness possible, thorugh the usage of a very janky
        // algorithm(™) to simulate this randomness

        public List<int> gen_dummy_data(int max, Random _random, int num)
        {
            List<int> l = new List<int> { 0 };
            int start_date = _random.Next(0, num / 4);
            int data_size = num - start_date;


            //Generate rank progeression
            for (int i = 0; i < data_size; i++)
            {
                l.Add(_random.Next(1, max));
            }

            //Generates some bottlenecks in Variable progression
            int bottleneck_num = _random.Next(1, 10);
            for (int i = 0; i <= bottleneck_num; i++)
            {
                int rndpp = _random.Next(1, max);
                for (int j = 0; j < 10; j++)
                {
                    int offset = (int)(rndpp / 100);
                    int dummy = rndpp + _random.Next(offset * -1, offset);
                    l.Add(dummy);
                }
            }
            // Generate an inactive period
            for (int i = 0; i < start_date; i++) { l.Add(0); }
            // Sorts the list
            //Adds max value to list
            l.Add(max);
            //Converts list to chartvalues
            return l;
        }

        public List<int> normalize_data_size(List<int> l, int size)
        {
            Random r = new Random();
            int lsize = l.Count;
            int ninserts = size - lsize;
            for (int i = 0; i < ninserts; i++)
            {
                l.Add(r.Next(0, l[lsize - 1]));
            }
            return l;
        }

        public ChartValues<int> list_to_chart(List<int> l)
        {
            ChartValues<int> c = new ChartValues<int> { };
            l.Sort();
            foreach (int i in l) { c.Add(i); }
            return c;
        }



    }
}
