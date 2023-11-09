namespace TestBank
{
    internal class BankFake
    {
        public double EndingBalance { get; set; }
        public int NumberOfChecks { get; set; }

        public BankFake(double endingBalance, int numberOfChecks)
        {
            EndingBalance = endingBalance;
            NumberOfChecks = numberOfChecks;
        }

        public double CalculateServiceFees()
        {
            double serviceFees = 10;

            if (EndingBalance < 400)
            {
                serviceFees += 15; 
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
