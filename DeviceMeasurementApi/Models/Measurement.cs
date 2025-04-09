using System;

namespace DeviceMeasurementApi.Models
{
    public class Measurement
    {
        public int Id { get; set; }

        public DateTime Timestamp { get; set; }

        public double Value { get; set; }

    }
}
