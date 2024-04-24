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
    /// Interaction logic for logInUser.xaml
    /// </summary>
    public partial class logInUser : Window
    {
        public logInUser()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWindow.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            rent_A_gym objrent_A_gym = new rent_A_gym();
            this.Visibility = Visibility.Hidden;
            objrent_A_gym.Show();
        }
    }
}
