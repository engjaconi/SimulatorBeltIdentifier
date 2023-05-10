namespace ServerBeltIdentifier.Models
{
    public class BeltModule1 : Belt
    {
        public bool Transparent { get; private set;  }
        public bool Metallic { get; private set; }
        public bool NonMetallic { get; private set; }
        public int QuantityTransparent { get; private set; }
        public int QuantityMetallic { get; private set; }
        public int QuantityNonMetallic { get; private set; }

        public BeltModule1()
        {
            ReadOpc();
        }
        
        public void Reset()
        {
            if (!Error) return;

            if (Transparent)
            {
                Transparent = false;
                QuantityTransparent--;
                if (!Metallic && !NonMetallic)
                {
                    QuantityTransparent--;
                }
            }
            
            if (Metallic)
            {
                Metallic = false;
                QuantityMetallic--;
                if (!Transparent && !NonMetallic)
                {
                    QuantityMetallic--;
                }
            } 

            if (NonMetallic){
                NonMetallic = false;
                QuantityNonMetallic--;
                if (!Transparent && !Metallic)
                {
                    QuantityNonMetallic--;
                }
            }

            Error = false;
            Busy = false;
            MotorOn = false;

            WriteOpc();
        }
        
        public void AddPieceManual(string pieceType, int speedMotor)
        {
            if(Transparent || Metallic || NonMetallic)
            {
                Error = true;
                MotorOn = false;
            }

            MotorSpeed = speedMotor;
            Busy = true;

            switch(pieceType)
            {
                case "Transparent":
                    Transparent = true;
                    QuantityTransparent++;
                    TaskTransparent();
                    break;
                case "Metallic":
                    Metallic = true;
                    QuantityMetallic++;
                    TaskMetallic();
                    break;
                case "NonMetallic":
                    NonMetallic = true;
                    QuantityNonMetallic++;
                    TaskNonMetallic();
                    break;
                default:
                    break;
            }
            WriteOpc();
        }
        
        public void AddPieceAuto(int speedMotor) 
        {
            Task t = new (()=>
            {
                Random probability = new();
                int option = probability.Next(1, 8);

                if (option > 0 && option < 3)
                {
                    AddPieceManual("Transparent", speedMotor);
                } else if (option >= 3 && option < 5)
                {
                    AddPieceManual("Metallic", speedMotor);
                } else if (option >= 5 && option < 7)
                {
                    AddPieceManual("NonMetallic", speedMotor);
                } else
                {
                    Error = true;
                    MotorOn = false;
                }      
                WriteOpc();
            });
            t.Start();
        }
        
        private void TaskTransparent()
        {
            Task tTransparent = new(() => {
                Thread.Sleep(MotorSpeed * 1000);
                if (Error) return;
                Transparent = false;
                Busy = false;
                WriteOpc();
            });
            tTransparent.Start();
        }
        
        private void TaskMetallic()
        {
            Task tMetallic = new(() => {
                Thread.Sleep(MotorSpeed * 1000);
                if (Error) return;
                Metallic = false;
                Busy = false;
                WriteOpc();
            });
            tMetallic.Start();
        }
        
        private void TaskNonMetallic()
        {
            Task tNonMetallic = new(() => {
                Thread.Sleep(MotorSpeed * 1000);
                if (Error) return;
                NonMetallic = false;
                Busy = false;
                WriteOpc();
            });
            tNonMetallic.Start();
        }
        
        public void ReadOpc()
        {
            Transparent = NodeManager._Belt.Module1.Transparent.Input.Value;
            Metallic = NodeManager._Belt.Module1.Metallic.Input.Value;
            NonMetallic = NodeManager._Belt.Module1.NonMetallic.Input.Value;
            QuantityTransparent = NodeManager._Belt.Module1.QuantityTransparent.Input.Value;
            QuantityMetallic = NodeManager._Belt.Module1.QuantityMetallic.Input.Value;
            QuantityNonMetallic = NodeManager._Belt.Module1.QuantityNonMetallic.Input.Value;
            MotorSpeed = NodeManager._Belt.Module1.Motor.Speed.Value;
            Busy = NodeManager._Belt.Module1.Busy.Input.Value;
            Error = NodeManager._Belt.Module1.Error.Input.Value;
            MotorOn = NodeManager._Belt.Module1.Motor.Status.Value;
        }
        
        public override void WriteOpc()
        {
            NodeManager._Belt.Module1.Transparent.Input.Value = Transparent;
            NodeManager._Belt.Module1.Metallic.Input.Value = Metallic;
            NodeManager._Belt.Module1.NonMetallic.Input.Value = NonMetallic;
            NodeManager._Belt.Module1.QuantityTransparent.Input.Value = QuantityTransparent;
            NodeManager._Belt.Module1.QuantityMetallic.Input.Value = QuantityMetallic;
            NodeManager._Belt.Module1.QuantityNonMetallic.Input.Value = QuantityNonMetallic;
            NodeManager._Belt.Module1.Motor.Speed.Value = MotorSpeed;
            NodeManager._Belt.Module1.Busy.Input.Value = Busy;
            NodeManager._Belt.Module1.Error.Input.Value = Error;
            NodeManager._Belt.Module1.Motor.Status.Value = MotorOn;
        }
    }
}
