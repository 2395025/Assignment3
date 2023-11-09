using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class BankChargesClass
    {
        public double EndingBalance { get; set; }
        public int NumberOfChecks { get; set; }

        public BankChargesClass(double endingBalance, int numberOfChecks)
        {
            EndingBalance = endingBalance;
            NumberOfChecks = numberOfChecks;
        }

        public double CalculateServiceFees()
        {
            double serviceFees = 10; // Base monthly fee

            if (EndingBalance < 400)
            {
                serviceFees += 15; // Extra fee for low balance
            }

            if (NumberOfChecks < 20)
            {
                serviceFees += NumberOfChecks * 0.10;
            }
            else if (NumberOfChecks >= 20 && NumberOfChecks < 40)
            {
                serviceFees += NumberOfChecks * 0.08;
            }
            else if (NumberOfChecks >= 40 && NumberOfChecks < 60)
            {
                serviceFees += NumberOfChecks * 0.06;
            }
            else
            {
                serviceFees += NumberOfChecks * 0.10;
            }

            return serviceFees;
        }
    }
}