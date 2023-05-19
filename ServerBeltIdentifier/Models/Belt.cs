namespace ServerBeltIdentifier.Models
{
    public class Belt
    {
        public bool MotorOn;
        public uint JourneyTime;
        public uint Interval;
        public bool IsBusy;
        public bool IsError;
        public bool IsModule1;
        public bool IsAuto;
        // Módulo 1
        public bool Transparent { get; set;  }
        public bool Metallic { get; set; }
        public bool NonMetallic { get; set; }
        public uint QuantityTransparent { get; set; }
        public uint QuantityMetallic { get; set; }
        public uint QuantityNonMetallic { get; set; }
        // Módulo 2
        public bool Barrier1 { get; set; }
        public bool Barrier2 { get; set; }
        public bool Barrier3 { get; set; }
        public bool PhotoSensor { get; set; }
        public bool Capacitive { get; set; }
        public bool Inductive { get; set; }
    }
}
