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
            pwbInput.Clear();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            if (txtUNInput.Text == "" || pwbInput.Password.Length == 0)
            {
                MessageBox.Show("Please enter your Username and Password to continue");
            }
            else if (txtUNInput.Text == "doctor")
            {
                Doctor doctor = new Doctor();
                doctor.Show();
                this.Close();
            }
            else if (txtUNInput.Text == "username")
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else if (txtUNInput.Text != "username" || txtUNInput.Text != "doctor")
            {
                MessageBox.Show("Incorrect Username or Password");
            }
        }

        private void TxtUNInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtLabelUser.Visibility = Visibility.Visible;
            txtUNInput.Background = Brushes.Transparent;
            if (txtUNInput.Text.Length > 0)
            {
                txtLabelUser.Visibility = Visibility.Hidden;
                txtUNInput.Background = Brushes.White;
            }
        }

        private void pwbInput_PasswordChanged(object sender, RoutedEventArgs e)
        {
            txtLabelPass.Visibility = Visibility.Visible;
            pwbInput.Background = Brushes.Transparent;
            if (pwbInput.Password.Length > 0)
            {
                txtLabelPass.Visibility = Visibility.Hidden;
                pwbInput.Background = Brushes.White;
            }
        }

        private void WinLogin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            grid1.Focus();
        }
    }
}
