namespace TestBank
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCalculateServiceFees()
        {
            // Arrange
            double endingBalance = 500;
            int numberOfChecks = 25; 
            BankFake bank = new BankFake(endingBalance, numberOfChecks);

            // Act
            double serviceFees = bank.CalculateServiceFees();

            // Assert
            double expectedServiceFees = 10;

            if (endingBalance < 400)
            {
                expectedServiceFees += 15; 
            }

            if (numberOfChecks < 20)
            {
                expectedServiceFees += numberOfChecks * 0.10;
            }
            else if (numberOfChecks >= 20 && numberOfChecks < 40)
            {
                expectedServiceFees += numberOfChecks * 0.08;
            }
            else if (numberOfChecks >= 40 && numberOfChecks < 60)
            {
                expectedServiceFees += numberOfChecks * 0.06;
            }
            else
            {
                expectedServiceFees += numberOfChecks * 0.10;
            }

            Assert.AreEqual(expectedServiceFees, serviceFees, 0.01); 
        }
    }
}




