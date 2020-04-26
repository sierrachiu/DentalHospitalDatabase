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

            PatientDataGrid.Opacity = 0;
        }

        private void btnPatient_Click(object sender, RoutedEventArgs e)
        {
            PatientDataGrid.Opacity = 1;
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            DentalHospitalDatabase.HospitalDataSet hospitalDataSet = ((DentalHospitalDatabase.HospitalDataSet)(this.FindResource("hospitalDataSet")));
            // Load data into the table patient. You can modify this code as needed.
            DentalHospitalDatabase.HospitalDataSetTableAdapters.patientTableAdapter hospitalDataSetpatientTableAdapter = new DentalHospitalDatabase.HospitalDataSetTableAdapters.patientTableAdapter();
            hospitalDataSetpatientTableAdapter.Fill(hospitalDataSet.patient);
            System.Windows.Data.CollectionViewSource patientViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("patientViewSource")));
            patientViewSource.View.MoveCurrentToFirst();
        }
    }
}
