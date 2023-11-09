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

namespace Assignment1
{
    /// <summary>
    /// Interaction logic for BankCharges.xaml
    /// </summary>
    public partial class BankCharges : Window
    {
        public BankCharges()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtEndingBalance.Text, out double endingBalance) &&
                int.TryParse(txtNumberOfChecks.Text, out int numberOfChecks))
            {
                BankChargesClass bankCharges = new BankChargesClass(endingBalance, numberOfChecks);
                double serviceFees = bankCharges.CalculateServiceFees();

                MessageBox.Show($"Service Fees for the Month: ${serviceFees:F2}");
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
