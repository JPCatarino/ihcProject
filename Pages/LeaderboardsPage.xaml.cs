using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using ihcProject.Classes;


namespace ihcProject.Pages
{
    /// <summary>
    /// Interaction logic for LeaderboardsPage.xaml
    /// </summary>
    public partial class LeaderboardsPage : Page
    {
        //UserTemplate User;
        ObservableCollection<User> users;

        public LeaderboardsPage()
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault();

            InitializeComponent();

            users = getUsers();

            //UserRanking.Items.Add(users);
        }
        public ObservableCollection<User> getUsers()
        {
            Random rand = new Random();
            ObservableCollection<User> users = new ObservableCollection<User>();

            for (int i = 0; i < 100; i++)
            {
                int len = rand.Next(3, 10);
                string name = "";
                for (int j = 0; j <= len; j++)
                {
                    int letter = rand.Next('a', 'z');
                    name.Append((char)letter);
                }
                //UserGenerator u = new UserGenerator(name, name, "fan");
                // u.generate();
                // UserTemplate user = u.getUser();

                User user = new User();
                user.username = name;
                user.rank = i;
                UserRanking.Items.Add(user);

                users.Append(user);
            }
            return users;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault();
            PlayerWindow.hmb_player.goToRivalProfilePage("Rival User");

        }
        private void BtnGlobal_Click(object sender, RoutedEventArgs e)
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault();
            PlayerWindow.hmb_player.goToRivalProfilePage("Rival User");

        }
        private void BtnYou_Click(object sender, RoutedEventArgs e)
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault();
            PlayerWindow.hmb_player.goToRivalProfilePage("Rival User");

        }
        private void BtnCountry_Click(object sender, RoutedEventArgs e)
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault();
            PlayerWindow.hmb_player.goToRivalProfilePage("Rival User");

        }
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault();
            PlayerWindow.hmb_player.goToRivalProfilePage("Rival User");

        }
        public class User
        {
            public int rank { get; set; }
            public string username{ get; set; }
            public string accuracy { get; set; }
            public string rerformance { get; set; }
            public string rankedScore { get; set; }
            public string ss { get; set; }
            public int s { get; set; }
            public int a { get; set; }
        }
    }
}
