using System.Collections.Generic;

namespace TaxiPriceCalculator
{
    public interface ISpeedMonitorProvider
    {
        List<SpeedLogRecord> getSpeedLog();
        int GetCompensationMinutes();
    }
}