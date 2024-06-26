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
    /// Interaction logic for logInOwner.xaml
    /// </summary>
    public partial class logInOwner : Window
    {
        public logInOwner()
        {
            InitializeComponent();
        }


        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWindow.Show();
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            ownerDb objownerDb = new ownerDb();
            this.Visibility = Visibility.Hidden;
            objownerDb.Show();
        }

        private void forgotBtn_Click(object sender, RoutedEventArgs e)
        {
            changePassOwner objchangePassOwner = new changePassOwner();
            this.Visibility = Visibility.Hidden;
            objchangePassOwner.Show();
        }
    }
}
