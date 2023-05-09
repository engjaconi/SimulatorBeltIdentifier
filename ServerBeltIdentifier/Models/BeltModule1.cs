using Opc.Ua;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBeltIdentifier.Models
{
    public class BeltModule1 : Belt
    {
        public bool Opaque { get; private set;  }
        public bool Metallic { get; private set; }
        public bool NonMetallic { get; private set; }
        public int QuantityOpaque { get; private set; }
        public int QuantityMetallic { get; private set; }
        public int QuantityNonMetallic { get; private set; }

        public BeltModule1()
        {
            ReadOpc();
        }

        public void Start()
        {
            if (Error) return;

            MotorOn = true;
            WriteOpc();
        }
        public void Stop()
        {
            if (Error) return;

            MotorOn = false;
            WriteOpc();
        }
        public void Reset()
        {
            if (!Error) return;

            if (Opaque)
            {
                Opaque = false;
                QuantityOpaque--;
                if (!Metallic && !NonMetallic)
                {
                    QuantityOpaque--;
                }
            }
            
            if (Metallic)
            {
                Metallic = false;
                QuantityMetallic--;
                if (!Opaque && !NonMetallic)
                {
                    QuantityMetallic--;
                }
            } 

            if (NonMetallic){
                NonMetallic = false;
                QuantityNonMetallic--;
                if (!Opaque && !Metallic)
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
            if(Opaque || Metallic || NonMetallic)
            {
                Error = true;
                MotorOn = false;
            }

            MotorSpeed = speedMotor;
            Busy = true;

            switch(pieceType)
            {
                case "Opaque":
                    Opaque = true;
                    QuantityOpaque++;
                    TaskOpaque();
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
                    AddPieceManual("Opaque", speedMotor);
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
        private void TaskOpaque()
        {
            Task tOpaque = new(() => {
                Thread.Sleep(MotorSpeed * 1000);
                if (Error) return;
                Opaque = false;
                Busy = false;
                WriteOpc();
            });
            tOpaque.Start();
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
            Opaque = NodeManager._Belt.Module1.Opaque.Input.Value;
            Metallic = NodeManager._Belt.Module1.Metallic.Input.Value;
            NonMetallic = NodeManager._Belt.Module1.NonMetallic.Input.Value;
            QuantityOpaque = NodeManager._Belt.Module1.QuantityOpaque.Input.Value;
            QuantityMetallic = NodeManager._Belt.Module1.QuantityMetallic.Input.Value;
            QuantityNonMetallic = NodeManager._Belt.Module1.QuantityNonMetallic.Input.Value;
            MotorSpeed = NodeManager._Belt.Module1.Motor.Speed.Value;
            Busy = NodeManager._Belt.Module1.Busy.Input.Value;
            Error = NodeManager._Belt.Module1.Error.Input.Value;
            MotorOn = NodeManager._Belt.Module1.Motor.Status.Value;
        }
        public void WriteOpc()
        {
            NodeManager._Belt.Module1.Opaque.Input.Value = Opaque;
            NodeManager._Belt.Module1.Metallic.Input.Value = Metallic;
            NodeManager._Belt.Module1.NonMetallic.Input.Value = NonMetallic;
            NodeManager._Belt.Module1.QuantityOpaque.Input.Value = QuantityOpaque;
            NodeManager._Belt.Module1.QuantityMetallic.Input.Value = QuantityMetallic;
            NodeManager._Belt.Module1.QuantityNonMetallic.Input.Value = QuantityNonMetallic;
            NodeManager._Belt.Module1.Motor.Speed.Value = MotorSpeed;
            NodeManager._Belt.Module1.Busy.Input.Value = Busy;
            NodeManager._Belt.Module1.Error.Input.Value = Error;
            NodeManager._Belt.Module1.Motor.Status.Value = MotorOn;
        }
    }
}
