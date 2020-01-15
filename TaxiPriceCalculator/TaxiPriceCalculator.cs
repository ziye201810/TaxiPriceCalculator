using System;

namespace TaxiPriceCalculator
{
    public class TaxiPriceCalculator
    {
        private readonly ISpeedMonitorProvider _monitorProvider;
        private readonly int _startingDistance = 2;
        private readonly int _startingPrice = 3;
        private readonly int _additionalOilFee = 1;
        private int _chockingMinutes = 0;

        public TaxiPriceCalculator(ISpeedMonitorProvider monitorProvider)
        {
            _monitorProvider = monitorProvider;
        }

        public int Cost(double distance)
        {
            SetCompensationMinutes();
            
            if (distance <= 0) return 0;
            return distance <= _startingDistance
                ? _startingPrice
                : _startingPrice + (int) Math.Ceiling(distance - _startingDistance) + _additionalOilFee +
                  _chockingMinutes;
        }

        private void SetCompensationMinutes()
        {
            _chockingMinutes = _monitorProvider.GetCompensationMinutes();
        }
    }
}