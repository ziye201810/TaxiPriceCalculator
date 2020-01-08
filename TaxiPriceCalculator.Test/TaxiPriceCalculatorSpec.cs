using Xunit;

namespace TaxiPriceCalculator.Test
{
    public class TaxiPriceCalculatorSpec
    {
        [Fact]
        public void TestCost()
        {
            var taxiPriceCalculator = new TaxiPriceCalculator();

            Assert.Equal(0, taxiPriceCalculator.Cost());
        }
    }
}