using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
 
        public BeltModule2()
        {
            ReadOpc();
        }

        public void Start()
        {
            if (Error)
            {
                return;
            }
            MotorOn = true;
            WriteOpc();
        }

        public void Stop()
        {
            MotorOn = false;
            WriteOpc();
        }

        public void Reset()
        {
            WriteOpc();
        }
        public void AddPieceManual(string pieceType, int speedMotor)
        {

        }
        public void AddPieceAuto(int speedMotor)
        {

        }
        public void ReadOpc()
        {
            Barrier1 = NodeManager._Belt.Module2.Barrier1.Output.Value;
            Barrier2 = NodeManager._Belt.Module2.Barrier2.Output.Value;
            Barrier3 = NodeManager._Belt.Module2.Barrier3.Output.Value;
            PhotoSensor = NodeManager._Belt.Module2.PhotoSensor.Output.Value;
            Capacitive = NodeManager._Belt.Module2.Capacitive.Output.Value;
            Inductive = NodeManager._Belt.Module2.Inductive.Output.Value;
            MotorSpeed = NodeManager._Belt.Module2.Motor.Speed.Value;
            Busy = NodeManager._Belt.Module2.Busy.Input.Value;
            Error = NodeManager._Belt.Module2.Error.Input.Value;
            MotorOn = NodeManager._Belt.Module2.Motor.Status.Value;
        }

        public void WriteOpc()
        {
            NodeManager._Belt.Module2.Barrier1.Output.Value = Barrier1;
            NodeManager._Belt.Module2.Barrier2.Output.Value = Barrier2;
            NodeManager._Belt.Module2.Barrier3.Output.Value = Barrier3;
            NodeManager._Belt.Module2.PhotoSensor.Output.Value = PhotoSensor;
            NodeManager._Belt.Module2.Capacitive.Output.Value = Capacitive;
            NodeManager._Belt.Module2.Inductive.Output.Value = Inductive;
            NodeManager._Belt.Module2.Motor.Speed.Value = MotorSpeed;
            NodeManager._Belt.Module2.Busy.Input.Value = Busy;
            NodeManager._Belt.Module2.Error.Input.Value = Error;
            NodeManager._Belt.Module2.Motor.Status.Value = MotorOn;
        }
    }
}
