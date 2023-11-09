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
    /// Interaction logic for populationPredition.xaml
    /// </summary>
    public partial class populationPredition : Window
    {
        public populationPredition()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (!int.TryParse(populSize.Text, out int populationSize) || populationSize < 2)
            {
                MessageBox.Show("Invalid population size. Please enter a number greater than or equal to 2.");
                return;
            }

            if (!double.TryParse(IncRat.Text, out double increaseRate) || increaseRate < 0)
            {
                MessageBox.Show("Invalid daily population increase rate. Please enter a non-negative number.");
                return;
            }

            if (!int.TryParse(comboBoxOne.Text, out int noofdays) || noofdays < 1)
            {
                MessageBox.Show("Invalid number of days. Please enter a number greater than or equal to 1.");
                return;
            }



            int daysPop = populationSize;
            for (int i = 1; i <= noofdays; i++)
            {
                double increasePopulation = (daysPop * increaseRate)/100;
                daysPop = (int)(daysPop + increasePopulation);
                MessageBox.Show("Day no: " + i + " & predicted population: " + daysPop);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        this.Close();
        }
    }
}
