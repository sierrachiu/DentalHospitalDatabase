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
    /// Interaction logic for New_Patient.xaml
    /// </summary>
    public partial class New_Patient : Window
    {
        public New_Patient()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)//new appointment for new patient
        {
            CreateAppt createAppt = new CreateAppt();
            createAppt.Show();
            this.Close();
        }

        private void btnReturn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}