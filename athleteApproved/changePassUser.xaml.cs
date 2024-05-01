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
    /// Interaction logic for changePassUser.xaml
    /// </summary>
    public partial class changePassUser : Window
    {
        public changePassUser()
        {
            InitializeComponent();
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            logInUser objlogInUser = new logInUser();
            this.Visibility = Visibility.Hidden;
            objlogInUser.Show();
        }
    }
}
