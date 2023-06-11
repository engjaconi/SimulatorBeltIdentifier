namespace ClientBeltIdentifier.Models
{
    public partial class Belt
    {
        public bool Started;
        public bool Reseted;
        public bool MotorOn;
        public bool IsBusy;
        public bool IsError;
        public bool IsModule1;
        public bool IsAuto;

        #region Propriedades do Módulo 1
        public bool Transparent;
        public bool Metallic;
        public bool NonMetallic;
        public uint TransparentQuantity;
        public uint MetallicQuantity;
        public uint NonMetallicQuantity;
        #endregion

        #region Propriedades do Módulo 2
        public bool Barrier1;
        public bool Barrier2;
        public bool Barrier3;
        public bool PhotoSensor;
        public bool Capacitive;
        public bool Inductive;
        #endregion
    }
}
