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

namespace DentalHospitalDatabase
{
    /// <summary>
    /// Interaction logic for Login_Screen.xaml
    /// </summary>
    public partial class Login_Screen : Window
    {
        public Login_Screen()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtUNInput.Clear();
            txtPWInput.Clear();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtUNInput.Text == "" || txtPWInput.Text == "")
            {
                MessageBox.Show("Please enter your Username and Password to continue");
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }

        private void TxtUNInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtLabelUser.Visibility = Visibility.Visible;
            if (txtUNInput.Text.Length > 0)
            {
                txtLabelUser.Visibility = Visibility.Hidden;
            }
        }

        private void TxtPassInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtLabelPass.Visibility = Visibility.Visible;
            if (txtPWInput.Text.Length > 0)
            {
                txtLabelPass.Visibility = Visibility.Hidden;
            }
        }

        private void WinLogin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            grid1.Focus();
        }
    }
}
