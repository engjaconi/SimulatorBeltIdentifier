using Opc.Ua;

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
                if (!Metallic && !NonMetallic && (QuantityTransparent > 0))
                {
                    QuantityTransparent--;
                }
            }
            
            if (Metallic)
            {
                Metallic = false;
                QuantityMetallic--;
                if (!Transparent && !NonMetallic && (QuantityMetallic > 0))
                {
                    QuantityMetallic--;
                }
            } 

            if (NonMetallic){
                NonMetallic = false;
                QuantityNonMetallic--;
                if (!Transparent && !Metallic && (QuantityNonMetallic > 0))
                {
                    QuantityNonMetallic--;
                }
            }

            Error = false;
            Busy = false;
            MotorOn = false;

            WriteOpc();
        }
        
        public void AddPieceManual(string pieceType)
        {
            if(Transparent || Metallic || NonMetallic)
            {
                Error = true;
                MotorOn = false;
            }

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
        
        public void AddPieceAuto() 
        {
            Task t = new (()=>
            {
                Random probability = new();
                int option = probability.Next(1, 8);

                if (option > 0 && option < 3)
                {
                    AddPieceManual("Transparent");
                } else if (option >= 3 && option < 5)
                {
                    AddPieceManual("Metallic");
                } else if (option >= 5 && option < 7)
                {
                    AddPieceManual("NonMetallic");
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
                Thread.Sleep(JourneyTime * 1000);
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
                Thread.Sleep(JourneyTime * 1000);
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
                Thread.Sleep(JourneyTime * 1000);
                if (Error) return;
                NonMetallic = false;
                Busy = false;
                WriteOpc();
            });
            tNonMetallic.Start();
        }
        
        public override void ReadOpc()
        {
            Transparent = NodeManager.Belt.Module1.Transparent.Input.Value;
            Metallic = NodeManager.Belt.Module1.Metallic.Input.Value;
            NonMetallic = NodeManager.Belt.Module1.NonMetallic.Input.Value;
            QuantityTransparent = NodeManager.Belt.Module1.QuantityTransparent.Input.Value;
            QuantityMetallic = NodeManager.Belt.Module1.QuantityMetallic.Input.Value;
            QuantityNonMetallic = NodeManager.Belt.Module1.QuantityNonMetallic.Input.Value;
            JourneyTime = NodeManager.Belt.Module1.Motor.JourneyTime.Value;
            Busy = NodeManager.Belt.Module1.Busy.Input.Value;
            Error = NodeManager.Belt.Module1.Error.Input.Value;
            MotorOn = NodeManager.Belt.Module1.Motor.Status.Value;
        }
        
        public override void WriteOpc()
        {
            NodeManager.Belt.Module1.Transparent.Input.Value = Transparent;
            NodeManager.Belt.Module1.Metallic.Input.Value = Metallic;
            NodeManager.Belt.Module1.NonMetallic.Input.Value = NonMetallic;
            NodeManager.Belt.Module1.QuantityTransparent.Input.Value = QuantityTransparent;
            NodeManager.Belt.Module1.QuantityMetallic.Input.Value = QuantityMetallic;
            NodeManager.Belt.Module1.QuantityNonMetallic.Input.Value = QuantityNonMetallic;
            NodeManager.Belt.Module1.Motor.JourneyTime.Value = JourneyTime;
            NodeManager.Belt.Module1.Busy.Input.Value = Busy;
            NodeManager.Belt.Module1.Error.Input.Value = Error;
            NodeManager.Belt.Module1.Motor.Status.Value = MotorOn;
            NodeManager.Belt.ClearChangeMasks(NodeManager.Context, true);
        }
    }
}
