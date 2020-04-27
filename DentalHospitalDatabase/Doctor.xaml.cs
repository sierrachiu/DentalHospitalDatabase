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
            BillingDataGrid.Opacity = 0;
            DocDataGrid.Opacity = 0;
            AppDataGrid.Opacity = 0;
        }

        private void btnPatient_Click(object sender, RoutedEventArgs e)
        {
            Panel.SetZIndex(PatientDataGrid, 3);
            Panel.SetZIndex(BillingDataGrid, 2);
            Panel.SetZIndex(DocDataGrid, 1);
            Panel.SetZIndex(AppDataGrid, 0);

            PatientDataGrid.Opacity = 1;
            BillingDataGrid.Opacity = 0;
            DocDataGrid.Opacity = 0;
            AppDataGrid.Opacity = 0;

        }

        private void btnBilling_Click(object sender, RoutedEventArgs e)
        {
            Panel.SetZIndex(PatientDataGrid, 2);
            Panel.SetZIndex(BillingDataGrid, 3);
            Panel.SetZIndex(DocDataGrid, 1);
            Panel.SetZIndex(AppDataGrid, 0);

            PatientDataGrid.Opacity = 0;
            BillingDataGrid.Opacity = 1;
            DocDataGrid.Opacity = 0;
            AppDataGrid.Opacity = 0;

        }

        private void btnDoctor_Click(object sender, RoutedEventArgs e)
        {
            Panel.SetZIndex(PatientDataGrid, 1);
            Panel.SetZIndex(BillingDataGrid, 2);
            Panel.SetZIndex(DocDataGrid, 3);
            Panel.SetZIndex(AppDataGrid, 0);

            PatientDataGrid.Opacity = 0;
            BillingDataGrid.Opacity = 0;
            DocDataGrid.Opacity = 1;
            AppDataGrid.Opacity = 0;
        }

        private void btnApp_Click(object sender, RoutedEventArgs e)
        {
            Panel.SetZIndex(PatientDataGrid, 0);
            Panel.SetZIndex(BillingDataGrid, 1);
            Panel.SetZIndex(DocDataGrid, 2);
            Panel.SetZIndex(AppDataGrid, 3);

            PatientDataGrid.Opacity = 0;
            BillingDataGrid.Opacity = 0;
            DocDataGrid.Opacity = 0;
            AppDataGrid.Opacity = 1;
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
            // Load data into the table billing. You can modify this code as needed.
            DentalHospitalDatabase.HospitalDataSetTableAdapters.billingTableAdapter hospitalDataSetbillingTableAdapter = new DentalHospitalDatabase.HospitalDataSetTableAdapters.billingTableAdapter();
            hospitalDataSetbillingTableAdapter.Fill(hospitalDataSet.billing);
            System.Windows.Data.CollectionViewSource billingViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("billingViewSource")));
            billingViewSource.View.MoveCurrentToFirst();
            // Load data into the table doctor. You can modify this code as needed.
            DentalHospitalDatabase.HospitalDataSetTableAdapters.doctorTableAdapter hospitalDataSetdoctorTableAdapter = new DentalHospitalDatabase.HospitalDataSetTableAdapters.doctorTableAdapter();
            hospitalDataSetdoctorTableAdapter.Fill(hospitalDataSet.doctor);
            System.Windows.Data.CollectionViewSource doctorViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("doctorViewSource")));
            doctorViewSource.View.MoveCurrentToFirst();
            // Load data into the table scheduling. You can modify this code as needed.
            DentalHospitalDatabase.HospitalDataSetTableAdapters.schedulingTableAdapter hospitalDataSetschedulingTableAdapter = new DentalHospitalDatabase.HospitalDataSetTableAdapters.schedulingTableAdapter();
            hospitalDataSetschedulingTableAdapter.Fill(hospitalDataSet.scheduling);
            System.Windows.Data.CollectionViewSource schedulingViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("schedulingViewSource")));
            schedulingViewSource.View.MoveCurrentToFirst();
        }
    }
}
