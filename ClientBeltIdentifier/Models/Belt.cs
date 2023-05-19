namespace ClientBeltIdentifier.Models
{
    internal abstract class Belt
    {
        public uint Interval { get; set; }
        public uint JourneyTime { get; set; }
        public bool MotorOn { get; set; }
        public bool IsBusy { get; set; }
        public bool IsError { get; set; }
        public bool IsModule1 { get; set; }
        public bool IsAuto { get; set; }
        // Módulo 1
        public bool Transparent { get; set; }
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
