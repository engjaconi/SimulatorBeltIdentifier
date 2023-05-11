namespace ServerBeltIdentifier.Models
{
    public class BeltModule2 : Belt
    {
        public bool Barrier1 { get; private set; }
        public bool Barrier2 { get; private set; }
        public bool Barrier3 { get; private set; }
        public bool PhotoSensor { get; private set; }
        public bool Capacitive { get; private set; }
        public bool Inductive { get; private set; }
        public string PieceType { get; private set; }

        public BeltModule2()
        {
            ReadOpc();
        }

        public void Reset()
        {
            if (!Error) return;

            Barrier1 = false;
            Barrier2 = false;
            Barrier3 = false;
            PhotoSensor = false;
            Capacitive = true;
            Inductive = true;
            Error = false;
            Busy = false;
            MotorOn = false;

            WriteOpc();
        }

        public void AddPieceManual(string pieceType, int speedMotor)
        {
            if (Busy)
            {
                Error = true;
                MotorOn = false;
                WriteOpc();
                return;
            }
            PieceType = pieceType;
            MotorSpeed = speedMotor;
            Busy = true;

            switch (pieceType)
            {
                case "Transparent":
                    TaskTransparent();
                    break;
                case "Metallic":
                    TaskMetallic();
                    break;
                case "NonMetallic":
                    TaskNonMetallic();
                    break;
                default:
                    break;
            }
            WriteOpc();
        }

        private void TaskTransparent()
        {
            Task tTransparent = new(() =>
            {
                if (!Error && !StopClick)
                {
                    Barrier1 = true;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }

                if (!Error && !StopClick)
                {
                    Barrier1 = false;
                    Barrier2 = true;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }

                if (!Error && !StopClick)
                {
                    Barrier2 = false;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }

                if (!Error && !StopClick)
                {
                    Capacitive = false;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }

                if (!Error && !StopClick)
                {
                    Capacitive = true;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }

                if (!Error && !StopClick)
                {
                    Barrier3 = true;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }

                if (!Error && !StopClick)
                {
                    Barrier3 = false;
                    Busy = false;
                    WriteOpc();
                }
            });
            tTransparent.Start();
        }

        private void TaskMetallic()
        {
            Task tMetallic = new(() =>
            {
                if (!Error && !StopClick)
                {
                    Barrier1 = true;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }
                if (!Error && !StopClick)
                {
                    Barrier1 = false;
                    Barrier2 = true;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }
                if (!Error && !StopClick)
                {
                    Barrier2 = false;
                    PhotoSensor = true;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }
                if (!Error && !StopClick)
                {
                    PhotoSensor = false;
                    Capacitive = false;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }
                if (!Error && !StopClick)
                {
                    Capacitive = true;
                    Inductive = false;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }
                if (!Error && !StopClick)
                {
                    Inductive = true;
                    Barrier3 = true;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }
                if (!Error && !StopClick)
                {
                    Barrier3 = false;
                    Busy = false;
                    WriteOpc();
                }
            });
            tMetallic.Start();
        }

        private void TaskNonMetallic()
        {
            Task tNonMetallic = new(() =>
            {
                if (!Error && !StopClick)
                {
                    Barrier1 = true;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }
                if (!Error && !StopClick)
                {
                    Barrier1 = false;
                    Barrier2 = true;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }
                if (!Error && !StopClick)
                {
                    Barrier2 = false;
                    PhotoSensor = true;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }
                if (!Error && !StopClick)
                {
                    PhotoSensor = false;
                    Capacitive = false;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }
                if (!Error && !StopClick)
                {
                    Capacitive = true;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }
                if (!Error && !StopClick)
                {
                    Barrier3 = true;
                    WriteOpc();
                    Thread.Sleep(MotorSpeed * 1000);
                }
                if (!Error && !StopClick)
                {
                    Barrier3 = false;
                    Busy = false;
                    WriteOpc();
                }
            });
            tNonMetallic.Start();
        }

        public void AddPieceAuto(int speedMotor)
        {
            Task t = new(() =>
            {
                Random probability = new();
                int option = probability.Next(1, 8);

                if (option > 0 && option < 3)
                {
                    AddPieceManual("Transparent", speedMotor);
                }
                else if (option >= 3 && option < 5)
                {
                    AddPieceManual("Metallic", speedMotor);
                }
                else if (option >= 5 && option < 7)
                {
                    AddPieceManual("NonMetallic", speedMotor);
                }
                else
                {
                    Error = true;
                    MotorOn = false;
                    WriteOpc();
                }
            });
            t.Start();
        }

        public void ReadOpc()
        {
            Barrier1 = NodeManager.Belt.Module2.Barrier1.Output.Value;
            Barrier2 = NodeManager.Belt.Module2.Barrier2.Output.Value;
            Barrier3 = NodeManager.Belt.Module2.Barrier3.Output.Value;
            PhotoSensor = NodeManager.Belt.Module2.PhotoSensor.Output.Value;
            Capacitive = NodeManager.Belt.Module2.Capacitive.Output.Value;
            Inductive = NodeManager.Belt.Module2.Inductive.Output.Value;
            MotorSpeed = NodeManager.Belt.Module2.Motor.Speed.Value;
            Busy = NodeManager.Belt.Module2.Busy.Input.Value;
            Error = NodeManager.Belt.Module2.Error.Input.Value;
            MotorOn = NodeManager.Belt.Module2.Motor.Status.Value;
        }

        public override void WriteOpc()
        {
            NodeManager.Belt.Module2.Barrier1.Output.Value = Barrier1;
            NodeManager.Belt.Module2.Barrier2.Output.Value = Barrier2;
            NodeManager.Belt.Module2.Barrier3.Output.Value = Barrier3;
            NodeManager.Belt.Module2.PhotoSensor.Output.Value = PhotoSensor;
            NodeManager.Belt.Module2.Capacitive.Output.Value = Capacitive;
            NodeManager.Belt.Module2.Inductive.Output.Value = Inductive;
            NodeManager.Belt.Module2.Motor.Speed.Value = MotorSpeed;
            NodeManager.Belt.Module2.Busy.Input.Value = Busy;
            NodeManager.Belt.Module2.Error.Input.Value = Error;
            NodeManager.Belt.Module2.Motor.Status.Value = MotorOn;
            NodeManager.Belt.ClearChangeMasks(NodeManager.Context, true);
        }
    }
}
