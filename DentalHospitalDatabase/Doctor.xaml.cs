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
    /// Interaction logic for Doctor.xaml
    /// </summary>
    public partial class Doctor : Window
    {
        public Doctor()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBilling_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDoctor_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnApp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Login_Screen login_Screen = new Login_Screen();
            login_Screen.Show();
            this.Close();
        }
    }
}
