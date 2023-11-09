using NUnit.Framework;


namespace TestShipping
{
    public class Tests
    {
        [Test]
        public void CalculateShippingCharges_WeightLessThanOrEqualTo2AndDistanceLessThanOrEqualTo500_ReturnsExpectedResult()
        {
            // Arrange
            double weight = 2.0;
            double distance = 400.0;
            double expectedShippingCharges = 1.10;

            ShippingFake shippingFake = new ShippingFake();

            // Act
            double actualShippingCharges = shippingFake.CalculateShippingCharges(weight, distance);

            // Assert
            Assert.AreEqual(expectedShippingCharges, actualShippingCharges, 0.01);
        }

        [Test]
        public void CalculateShippingCharges_WeightBetween2And6AndDistanceGreaterThan500_ReturnsExpectedResult()
        {
            // Arrange
            double weight = 4.0;
            double distance = 800.0;
            double expectedShippingCharges = 4.40;

            ShippingFake shippingFake = new ShippingFake();

            // Act
            double actualShippingCharges = shippingFake.CalculateShippingCharges(weight, distance);

            // Assert
            Assert.AreEqual(expectedShippingCharges, actualShippingCharges, 0.01);
        }

        [Test]
        public void CalculateShippingCharges_WeightGreaterThan10AndDistanceGreaterThan500_ReturnsExpectedResult()
        {
            // Arrange
            double weight = 12.0;
            double distance = 1000.0;
            double expectedShippingCharges = 9.60;

            ShippingFake shippingFake = new ShippingFake();

            // Act
            double actualShippingCharges = shippingFake.CalculateShippingCharges(weight, distance);

            // Assert
            Assert.AreEqual(expectedShippingCharges, actualShippingCharges, 0.01);
        }
    }
}