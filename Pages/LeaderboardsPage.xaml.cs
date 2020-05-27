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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;


namespace ihcProject.Pages
{
    /// <summary>
    /// Interaction logic for LeaderboardsPage.xaml
    /// </summary>
    public partial class LeaderboardsPage : Page
    {
        //UserTemplate User;
        ObservableCollection<User> users;
        ObservableCollection<User> country;


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
                StringBuilder builder = new StringBuilder();

                //string name = "";
                char ch;
                for (int j = 0; j <= len; j++)
                {
                    ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rand.NextDouble() + 65)));
                    builder.Append(ch);
                }
                //UserGenerator u = new UserGenerator(name, name, "fan");
                // u.generate();
                // UserTemplate user = u.getUser();

                User user = new User();
                user.username = builder.ToString();
                user.rank = i+1;
                user.accuracy = rand.Next(90,100);
                user.performance = rand.Next(40000, 48000);
                user.rankedScore = rand.Next(40000, 48000);
                user.ss = rand.Next(100, 5800);
                user.s = rand.Next(100, 5000);
                user.a = rand.Next(100, 5000);


                UserRanking.Items.Add(user);

                users.Append(user);
            }
            return users;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            User user = (User)UserRanking.SelectedItem;

            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault();
            PlayerWindow.hmb_player.goToRivalProfilePage(user.username, user.rank);

        }
        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User user = (User)UserRanking.SelectedItem; //Datagrid bound with ProductItem 
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault();
            PlayerWindow.hmb_player.goToRivalProfilePage(user.username, user.rank);
        }

        private async void BtnGlobal_Click(object sender, RoutedEventArgs e)
        {

        }
        private async void BtnYou_Click(object sender, RoutedEventArgs e)
        {
            var metroWindow = (Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault() as MetroWindow);
            await metroWindow.ShowMessageAsync("Not Implemented", "This functionality is not yet implemented. We're sorry!", MessageDialogStyle.Affirmative);
        }
        private async void BtnCountry_Click(object sender, RoutedEventArgs e)
        {
            var metroWindow = (Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault() as MetroWindow);
            await metroWindow.ShowMessageAsync("Not Implemented", "This functionality is not yet implemented. We're sorry!", MessageDialogStyle.Affirmative);
        }
        private async void Search_Click(object sender, RoutedEventArgs e)
        {
            var metroWindow = (Application.Current.Windows.OfType<PlayerWindow>().LastOrDefault() as MetroWindow);
            await metroWindow.ShowMessageAsync("Not Implemented", "This functionality is not yet implemented. We're sorry!", MessageDialogStyle.Affirmative);
        }
        public class User
        {
            public int rank { get; set; }
            public string username{ get; set; }
            public int accuracy { get; set; }
            public int performance { get; set; }
            public int rankedScore { get; set; }
            public int ss { get; set; }
            public int s { get; set; }
            public int a { get; set; }
        }
    }
}
