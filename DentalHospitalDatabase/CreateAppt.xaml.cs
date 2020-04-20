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
    /// Interaction logic for CreateAppt.xaml
    /// </summary>
    public partial class CreateAppt : Window
    {
        public CreateAppt()
        {
            InitializeComponent();
        }

        /*
         * This button isnt needed I think
         * 
         * private void btnPayment_Click(object sender, RoutedEventArgs e)
        {
            Payment payment = new Payment();
            payment.Show();
            this.Close();
        }*/

        private void btnReturnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnCreateAppt_Click(object sender, RoutedEventArgs e)
        {
            if (txtFNameInput.Text == "" || txtLNameInput.Text == "" || dpAppDate.Text == "" || cmbAppTime.Text == "")
            {
                MessageBox.Show("Please complete the required fields");
            }
            else
            {
                MessageBox.Show("Your appointment has been scheduled.");
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }

            /*MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();*/
        }

        private void WinCreate_MouseDown(object sender, MouseButtonEventArgs e)
        {
            grid2.Focus();
        }
    }
}
