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

namespace athleteApproved
{
    /// <summary>
    /// Interaction logic for USER_FEEDBACK.xaml
    /// </summary>
    public partial class USER_FEEDBACK : Window
    {
        public USER_FEEDBACK()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            rent_A_gym objrent_A_gym = new rent_A_gym();
            this.Visibility = Visibility.Hidden;
            objrent_A_gym.Show();
        }
    }
}
