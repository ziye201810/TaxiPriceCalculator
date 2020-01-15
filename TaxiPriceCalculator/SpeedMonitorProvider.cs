using System;
using System.Collections.Generic;

namespace TaxiPriceCalculator
{
    
    public class SpeedMonitorProvider : ISpeedMonitorProvider
    {
        public List<SpeedLogRecord> getSpeedLog()
        {
            var  startTime = DateTime.Now;
            var result = new List<SpeedLogRecord>
            {
                new SpeedLogRecord
                {
                    time = startTime,
                    minutesCount = 1,
                    speedPerHour = 30,
                    distance = 0
                },
                new SpeedLogRecord
                {
                    time = startTime.AddMinutes(1),
                    minutesCount = 2,
                    speedPerHour = 40,
                    distance = 2
                }
            };
            return result;
        }

        public int GetCompensationMinutes()
        {
            return (new Random(1)).Next(10);
        }
    }
}