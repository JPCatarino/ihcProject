﻿using ihcProject.Classes;
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
using MahApps.Metro.Controls;
using System.Windows.Shapes;

namespace ihcProject
{
    public partial class MapDetails : MetroWindow
    {
        public UserTemplate cUserData { get; set; }
        public MapDetails()
        {
            var PlayerWindow = Application.Current.Windows.OfType<PlayerWindow>().FirstOrDefault();
            cUserData = PlayerWindow.cUserData;
            DataContext = cUserData;

            InitializeComponent();
        }
    }
}
