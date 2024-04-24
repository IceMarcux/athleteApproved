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
using System.Windows.Shapes;

namespace athleteApproved
{
    /// <summary>
    /// Interaction logic for rent_A_gym.xaml
    /// </summary>
    public partial class rent_A_gym : Window
    {
        public rent_A_gym()
        {
            InitializeComponent();
        }


        private void reviewBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rentBtn_Click(object sender, RoutedEventArgs e)
        {
            USER_Rental objUSER_Rental = new USER_Rental();
            this.Visibility = Visibility.Hidden;
            objUSER_Rental.Show();
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            logInUser objlogInUser = new logInUser();
            this.Visibility = Visibility.Hidden;
            objlogInUser.Show();
        }
    }
}
