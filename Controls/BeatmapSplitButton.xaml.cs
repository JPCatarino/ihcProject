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

namespace ihcProject.Controls
{
    /// <summary>
    /// Interaction logic for BeatmapSplitButton.xaml
    /// </summary>
    public partial class BeatmapSplitButton : UserControl
    {
        public BeatmapSplitButton()
        {
            InitializeComponent();
        }

        public void setIndex(int i) {
            cb_main.SelectedIndex = i;
        }

        public int getIndex() {
            return cb_main.SelectedIndex;
        }
    }
}
