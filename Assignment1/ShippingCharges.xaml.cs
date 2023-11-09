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
    /// Interaction logic for ShippingCharges.xaml
    /// </summary>
    public partial class ShippingCharges : Window
    {
        public ShippingCharges()
        {
            InitializeComponent();
        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtWeight.Text, out double weight) &&
                double.TryParse(txtDistance.Text, out double distance))
            {
                ShippingCalculator calculator = new ShippingCalculator();
                double shippingCharges = calculator.CalculateShippingCharges(weight, distance);

                MessageBox.Show($"Shipping Charges: ${shippingCharges:F2}");
               
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
