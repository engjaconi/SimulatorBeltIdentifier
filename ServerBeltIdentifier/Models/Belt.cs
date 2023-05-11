namespace ServerBeltIdentifier.Models
{
    public abstract class Belt
    {
        public int JourneyTime;
        public bool MotorOn;
        public bool Busy;
        public bool Error;
        public bool StopClick;
        public int Interval = 1;

        public void Start()
        {
            if (Error) return;

            StopClick = false;
            MotorOn = true;
            WriteOpc();
        }

        public void Stop()
        {
            if (Error) return;

            MotorOn = false;
            StopClick = true;
            WriteOpc();
        }

        public abstract void WriteOpc();
    }
}
