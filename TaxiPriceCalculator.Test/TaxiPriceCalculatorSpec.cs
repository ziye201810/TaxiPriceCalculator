using Moq;
using Xunit;
using Xunit.Sdk;

namespace TaxiPriceCalculator.Test
{
    public class TaxiPriceCalculatorSpec
    {
        private readonly TaxiPriceCalculator _taxiPriceCalculator;
        private readonly Mock<ISpeedMonitorProvider>  _mockMonitorProvider;

        public TaxiPriceCalculatorSpec()
        {
            _mockMonitorProvider=new Mock<ISpeedMonitorProvider>();
            _taxiPriceCalculator = new TaxiPriceCalculator(_mockMonitorProvider.Object);
            _mockMonitorProvider.Setup(x => x.GetCompensationMinutes()).Returns(0);
        }


        [Fact]
        public void should_return_fee_when_computing_given_distance_is_not_int_and_price()
        {
            var distance = 10.1;

            var fee = _taxiPriceCalculator.Cost(distance);
            Assert.Equal(13, fee);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        void should_return_zero_when_distance_is_minus_or_zero(int distance)
        {
            var fee = _taxiPriceCalculator.Cost(distance);
            Assert.Equal(0, fee);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(1.1)]
        void should_return_fee_when_distance_in_starting_distance(double distance)
        {
            var cost = _taxiPriceCalculator.Cost(distance);
            Assert.Equal(3, cost);
        }

        [Fact]
        void should_add_additional_oil_fee_when_distance_bigger_than_starting_distance()
        {
            var cost = _taxiPriceCalculator.Cost(6);
            Assert.Equal(8, cost);
        }

        [Fact]
        void should_return_correct_fee_when_has_2_minutes_compensation()
        {
            _mockMonitorProvider.Setup(x => x.GetCompensationMinutes()).Returns(2);

            var cost = _taxiPriceCalculator.Cost(6);
            Assert.Equal(10, cost);
        }
    }
}