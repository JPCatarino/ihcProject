﻿using System;
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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        bool userHasBeenClicked = false;
        bool passHasBeenClicked = false; 
        public LoginPage()
        {
            InitializeComponent();
        }

        private void tb_username_GotFocus(object sender, RoutedEventArgs e)
        {
            if (!userHasBeenClicked) {
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

        private void b_login_Click(object sender, RoutedEventArgs e)
        {
            // TODO : CHECK CREDENTIALS
            // TODO : READ WHAT TYPE OF THE USER IS THE PERSON LOGIN IN
            // TODO : NAVIGATE TO PROPER PAGE AFTER.
            /**
             * Kinda cheating here
             * Getting the current executing main window and revert it to original state
             * Then we hide the main window and open the new login window
             */
            var mainWindow = Application.Current.Windows.OfType<MainWindow>().FirstOrDefault();
            mainWindow.hideBackButton();
            NavigationService.GoBack();
            PlayerWindow n_window = new PlayerWindow();
            n_window.Show();
            mainWindow.Hide();
        }
    }
}
