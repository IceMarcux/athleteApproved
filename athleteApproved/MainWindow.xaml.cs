using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace athleteApproved
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            signup objsignup = new signup();
            this.Visibility = Visibility.Hidden;
            objsignup.Show();
        }


        private void ownerClick_Click(object sender, RoutedEventArgs e)
        {
            logInOwner objlogInOwner = new logInOwner();
            this.Visibility = Visibility.Hidden;
            objlogInOwner.Show();
        }

        private void userClick_Click(object sender, RoutedEventArgs e)
        {
            logInUser objlogInUser = new logInUser();
            this.Visibility = Visibility.Hidden;
            objlogInUser.Show();
        }
    }
}