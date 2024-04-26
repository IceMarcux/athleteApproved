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
    /// Interaction logic for USER_Rental.xaml
    /// </summary>
    public partial class USER_Rental : Window
    {
        public USER_Rental()
        {
            InitializeComponent();
        }


        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void gcashBtn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void cashBtn_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void confirmBtn_Click(object sender, RoutedEventArgs e)
        {
            if (gcashBtn.IsChecked == true) {
                GCASH_PAYMENT objGCASH_PAYMENT = new GCASH_PAYMENT();
                this.Visibility = Visibility.Hidden;
                objGCASH_PAYMENT.Show();
            } else
            {
                admin_Approval objadmin_Approval = new admin_Approval();
                this.Visibility = Visibility.Hidden;
                objadmin_Approval.Show();
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            rent_A_gym objrent_A_gym = new rent_A_gym();
            this.Visibility = Visibility.Hidden;
            objrent_A_gym.Show();
        }

        private void backButton_Click_1(object sender, RoutedEventArgs e)
        {
            rent_A_gym objrent_A_gym = new rent_A_gym();
            this.Visibility = Visibility.Hidden;
            objrent_A_gym.Show();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
