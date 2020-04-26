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

            AppDataGrid.Opacity = 0.0;
            PatientDataGrid.Opacity = 0.0;
            DocDataGrid.Opacity = 0.0;
            BillingDataGrid.Opacity = 0.0;

        }

        private void btnPatients_Click(object sender, RoutedEventArgs e)
        {
            PatientDataGrid.Opacity = 100.0;
            AppDataGrid.Opacity = 0.0;
            DocDataGrid.Opacity = 0.0;
            BillingDataGrid.Opacity = 0.0;
        }

        private void btnApp_Click(object sender, RoutedEventArgs e)
        {
            PatientDataGrid.Opacity = 0.0;
            AppDataGrid.Opacity = 100.0;
            DocDataGrid.Opacity = 0.0;
            BillingDataGrid.Opacity = 0.0;
        }

        private void btnDoctors_Click(object sender, RoutedEventArgs e)
        {
            PatientDataGrid.Opacity = 0.0;
            AppDataGrid.Opacity = 0.0;
            DocDataGrid.Opacity = 100.0;
            BillingDataGrid.Opacity = 0.0;
        }

        private void btnBilling_Click(object sender, RoutedEventArgs e)
        {
            PatientDataGrid.Opacity = 0.0;
            AppDataGrid.Opacity = 0.0;
            DocDataGrid.Opacity = 0.0;
            BillingDataGrid.Opacity = 100.0;
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            Login_Screen login_Screen = new Login_Screen();
            login_Screen.Show();
            this.Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            DentalHospitalDatabase.dbHospitalDataSet dbHospitalDataSet = ((DentalHospitalDatabase.dbHospitalDataSet)(this.FindResource("dbHospitalDataSet")));
            // Load data into the table patient. You can modify this code as needed.
            DentalHospitalDatabase.dbHospitalDataSetTableAdapters.patientTableAdapter dbHospitalDataSetpatientTableAdapter = new DentalHospitalDatabase.dbHospitalDataSetTableAdapters.patientTableAdapter();
            dbHospitalDataSetpatientTableAdapter.Fill(dbHospitalDataSet.patient);
            System.Windows.Data.CollectionViewSource patientViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("patientViewSource")));
            patientViewSource.View.MoveCurrentToFirst();
            DentalHospitalDatabase.dbHospitalDataSet1 dbHospitalDataSet1 = ((DentalHospitalDatabase.dbHospitalDataSet1)(this.FindResource("dbHospitalDataSet1")));
            // Load data into the table scheduling. You can modify this code as needed.
            DentalHospitalDatabase.dbHospitalDataSet1TableAdapters.schedulingTableAdapter dbHospitalDataSet1schedulingTableAdapter = new DentalHospitalDatabase.dbHospitalDataSet1TableAdapters.schedulingTableAdapter();
            dbHospitalDataSet1schedulingTableAdapter.Fill(dbHospitalDataSet1.scheduling);
            System.Windows.Data.CollectionViewSource schedulingViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("schedulingViewSource")));
            schedulingViewSource.View.MoveCurrentToFirst();
            DentalHospitalDatabase.dbHospitalDataSet2 dbHospitalDataSet2 = ((DentalHospitalDatabase.dbHospitalDataSet2)(this.FindResource("dbHospitalDataSet2")));
            // Load data into the table scheduling. You can modify this code as needed.
            DentalHospitalDatabase.dbHospitalDataSet2TableAdapters.schedulingTableAdapter dbHospitalDataSet2schedulingTableAdapter = new DentalHospitalDatabase.dbHospitalDataSet2TableAdapters.schedulingTableAdapter();
            dbHospitalDataSet2schedulingTableAdapter.Fill(dbHospitalDataSet2.scheduling);
            System.Windows.Data.CollectionViewSource schedulingViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("schedulingViewSource1")));
            schedulingViewSource1.View.MoveCurrentToFirst();
            // Load data into the table doctor. You can modify this code as needed.
            DentalHospitalDatabase.dbHospitalDataSet2TableAdapters.doctorTableAdapter dbHospitalDataSet2doctorTableAdapter = new DentalHospitalDatabase.dbHospitalDataSet2TableAdapters.doctorTableAdapter();
            dbHospitalDataSet2doctorTableAdapter.Fill(dbHospitalDataSet2.doctor);
            System.Windows.Data.CollectionViewSource doctorViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("doctorViewSource")));
            doctorViewSource.View.MoveCurrentToFirst();
            DentalHospitalDatabase.dbHospitalDataSet3 dbHospitalDataSet3 = ((DentalHospitalDatabase.dbHospitalDataSet3)(this.FindResource("dbHospitalDataSet3")));
            // Load data into the table billing. You can modify this code as needed.
            DentalHospitalDatabase.dbHospitalDataSet3TableAdapters.billingTableAdapter dbHospitalDataSet3billingTableAdapter = new DentalHospitalDatabase.dbHospitalDataSet3TableAdapters.billingTableAdapter();
            dbHospitalDataSet3billingTableAdapter.Fill(dbHospitalDataSet3.billing);
            System.Windows.Data.CollectionViewSource billingViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("billingViewSource")));
            billingViewSource.View.MoveCurrentToFirst();
            // Load data into the table doctor. You can modify this code as needed.
            DentalHospitalDatabase.dbHospitalDataSet3TableAdapters.doctorTableAdapter dbHospitalDataSet3doctorTableAdapter = new DentalHospitalDatabase.dbHospitalDataSet3TableAdapters.doctorTableAdapter();
            dbHospitalDataSet3doctorTableAdapter.Fill(dbHospitalDataSet3.doctor);
            System.Windows.Data.CollectionViewSource doctorViewSource1 = ((System.Windows.Data.CollectionViewSource)(this.FindResource("doctorViewSource1")));
            doctorViewSource1.View.MoveCurrentToFirst();
        }
    }
}
