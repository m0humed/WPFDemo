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
using System.Windows.Shapes;

namespace Demo
{
    /// <summary>
    /// Interaction logic for ControlTemplate.xaml
    /// </summary>
    public partial class ControlTemplate : Window
    {
        public ControlTemplate()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("صلي علي النبي");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" طب ما تصلي علي النبي كمان مره ");

        }
    }
}
