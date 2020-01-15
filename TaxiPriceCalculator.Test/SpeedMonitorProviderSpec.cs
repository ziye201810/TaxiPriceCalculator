using System.Linq;
using Xunit;

namespace TaxiPriceCalculator.Test
{
    public class SpeedMonitorProviderSpec
    {
        private readonly SpeedMonitorProvider _monitor;

        public SpeedMonitorProviderSpec()
        {
            _monitor = new SpeedMonitorProvider();
        }

        [Fact]
        void should_return_speed_log_when_get_logs()
        {
            var result = _monitor.getSpeedLog();
            var first = result.FirstOrDefault();
            
            Assert.NotNull(first.time);
            Assert.NotNull(first.speedPerHour);
        }
        
        [Fact]
        void should_return_int_when_get_compensation_minutes()
        {
            var result = _monitor.GetCompensationMinutes();
            Assert.IsType<int>(result);
        }
    }
}