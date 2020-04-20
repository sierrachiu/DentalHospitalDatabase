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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DentalHospitalDatabase
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

        private void btnDentalCheck_Click(object sender, RoutedEventArgs e)
        {
            Dental denCheckIn = new Dental();
            denCheckIn.Show();
            this.Close();
        }

        private void btnMedicalCheck_Click(object sender, RoutedEventArgs e)
        {
            Medical medCheckIn = new Medical();
            medCheckIn.Show();
            this.Close();
        }

        private void btnNewPatient_Click(object sender, RoutedEventArgs e)
        {
            New_Patient newPatCreate = new New_Patient();
            newPatCreate.Show();
            this.Close();
        }

        private void BtnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Login_Screen login = new Login_Screen();
            login.Show();
            this.Close();
        }

        /*
         * Probably don't need this button on this screen**************************************************
         * 
         * private void btnNewPatient_Click(object sender, RoutedEventArgs e)
        {
            New_Patient new_PatientCheckin = new New_Patient();
            new_PatientCheckin.Show();
            this.Close();
        }*/
    }
}
