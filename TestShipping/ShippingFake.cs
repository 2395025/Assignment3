namespace TestShipping
{
    internal class ShippingFake
    {
        public double CalculateShippingCharges(double weight, double distance)
        {
            double baseRate = 0;

            if (weight <= 2)
            {
                baseRate = 1.10;
            }
            else if (weight <= 6)
            {
                baseRate = 2.20;
            }
            else if (weight <= 10)
            {
                baseRate = 3.70;
            }
            else
            {
                baseRate = 4.80;
            }

            double shippingCharges = baseRate * (Math.Ceiling(distance / 500.0));
            return shippingCharges;
        }
    }
}