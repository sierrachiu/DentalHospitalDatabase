﻿using System;
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
    /// Interaction logic for Payment.xaml
    /// </summary>
    public partial class Payment : Window
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void btnReturnHome_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btnCompleteInfo_Click(object sender, RoutedEventArgs e)
        {
            if (txtCSN.Text == "" || txtAmount.Text == "" || txtCSN.Text.Length != 9 ||  Convert.ToInt32(txtAmount.Text) < 0 )
            {
                MessageBox.Show("Amount or CSN is incorrect. PLease try again.");
            }
            else
            {
                MessageBox.Show("Thank you for your payment.");
                txtAmount.Clear();
                txtCSN.Clear();
            }
            /*MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();*/
        }
    }
}
