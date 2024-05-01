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
    /// Interaction logic for changePassOwner.xaml
    /// </summary>
    public partial class changePassOwner : Window
    {
        public changePassOwner()
        {
            InitializeComponent();
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            logInOwner objlogInOwner = new logInOwner();
            this.Visibility = Visibility.Hidden;
            objlogInOwner.Show();
        }
    }
}
