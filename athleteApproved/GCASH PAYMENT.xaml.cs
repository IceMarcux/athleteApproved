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
    /// Interaction logic for GCASH_PAYMENT.xaml
    /// </summary>
    public partial class GCASH_PAYMENT : Window
    {
        public GCASH_PAYMENT()
        {
            InitializeComponent();
        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            admin_Approval objadmin_Approval = new admin_Approval();
            this.Visibility = Visibility.Hidden;
            objadmin_Approval.Show();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            USER_Rental objUSER_Rental = new USER_Rental();
            this.Visibility = Visibility.Hidden;
            objUSER_Rental.Show();
        }
    }
}
