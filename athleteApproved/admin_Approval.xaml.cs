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
    /// Interaction logic for admin_Approval.xaml
    /// </summary>
    public partial class admin_Approval : Window
    {
        public admin_Approval()
        {
            InitializeComponent();
        }

        private void feedbackBtn_Click_1(object sender, RoutedEventArgs e)
        {
            USER_FEEDBACK objUSER_FEEDBACK = new USER_FEEDBACK();
            this.Visibility = Visibility.Hidden;
            objUSER_FEEDBACK.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
