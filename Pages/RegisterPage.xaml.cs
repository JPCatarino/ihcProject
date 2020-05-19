using ihcProject.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        bool userHasBeenClicked = false;
        bool passHasBeenClicked = false;
        bool apiHasBeenClicked = false;
        String Role; 

        // Role check is implemented with strings, not the best solution.
        public RegisterPage(String Role)
        {
            this.Role = Role;
            InitializeComponent();
            RegRole = this.Role + " Register";
            if (Role == "Fan")
            {
                this.sp_api.Visibility = System.Windows.Visibility.Collapsed;
                this.bd_api.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        public string RegRole {
            get { return (string)GetValue(RegRoleProperty); }
            set { SetValue(RegRoleProperty, value); }
        }

        public static readonly DependencyProperty RegRoleProperty = DependencyProperty.Register("RegRole", typeof(string), typeof(RegisterPage), new PropertyMetadata(null));

        private void tb_username_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!userHasBeenClicked)
            {
                TextBox tb_u = sender as TextBox;
                tb_u.Text = String.Empty;
                userHasBeenClicked = true;
            }
        }

        private void pb_password_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!passHasBeenClicked)
            {
                PasswordBox pb_p = sender as PasswordBox;
                pb_p.Password = String.Empty;
                passHasBeenClicked = true;
            }
        }

        private void tb_username_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb_u = sender as TextBox;
            if (tb_u.Text == String.Empty)
            {
                tb_u.Text = "Username";
                userHasBeenClicked = false;
            }
        }

        private void pb_password_LostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox pb_p = sender as PasswordBox;
            if (pb_p.Password == String.Empty)
            {
                pb_p.Password = "Password";
                passHasBeenClicked = false;
            }
        }

        private void b_register_Click(object sender, RoutedEventArgs e)
        {
            UserGenerator newUser = new UserGenerator(tb_username.Text, pb_password.Password, Role);
            newUser.generate();
            string dir = Directory.GetCurrentDirectory() + "\\Data\\users.json";
            List<UserTemplate> allUsers;
            Console.WriteLine(dir);
            using (var streamReader = new StreamReader(dir))
            using (JsonReader reader = new JsonTextReader(streamReader))
            {
                JsonSerializer serializer = new JsonSerializer();
                allUsers = serializer.Deserialize<List<UserTemplate>>(reader);
            }
            allUsers.Add(newUser.getUser());
            string json = JsonConvert.SerializeObject(allUsers, Formatting.Indented);
            Console.WriteLine(json);
            // Write to resource and to file on PC, ON RELEASE DELETE SYSTEM.IO LINE
            using (var streamWriter = new StreamWriter(dir))
            {
                streamWriter.Write(json);
            }
            System.IO.File.WriteAllText(System.AppDomain.CurrentDomain.BaseDirectory + "../../Data/users.json", json);
        }

        private void tb_api_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!apiHasBeenClicked)
            {
                TextBox tb_api = sender as TextBox;
                tb_api.Text = String.Empty;
                apiHasBeenClicked = true;
            }
        }

        private void tb_api_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox tb_api = sender as TextBox;
            if (tb_api.Text == String.Empty)
            {
                tb_api.Text = "API key";
                apiHasBeenClicked = false;
            }
        }
    }
}
