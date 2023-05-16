using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ServerBeltIdentifier.Models
{
    public class Belt
    {
        public bool MotorOn;
        public int JourneyTime = 1;
        public int Interval = 1;
        public bool IsBusy;
        public bool IsError;
        public bool IsModule1;
        public bool IsAuto;
        public bool StopClick;
        public Module1 Module1;
        public Module2 Module2;

        public Belt()
        {
            Module1 = new Module1();
            Module2 = new Module2();
            ReadOpc();
        }

        public void Start()
        {
            if (IsError) return;
           
            StopClick = false;
            MotorOn = true;
            WriteOpc();
        }

        public void Stop()
        {
            if (IsError) return;

            MotorOn = false;
            StopClick = true;
            WriteOpc();
        }

        public void Reset()
        {
            if (!IsError) return;

            if(IsModule1)
            {
                if (Module1.Transparent)
                {
                    Module1.Transparent = false;
                    Module1.QuantityTransparent--;
                    if (!Module1.Metallic && !Module1.NonMetallic && (Module1.QuantityTransparent > 0))
                    {
                        Module1.QuantityTransparent--;
                    }
                }

                if (Module1.Metallic)
                {
                    Module1.Metallic = false;
                    Module1.QuantityMetallic--;
                    if (!Module1.Transparent && !Module1.NonMetallic && (Module1.QuantityMetallic > 0))
                    {
                        Module1.QuantityMetallic--;
                    }
                }

                if (Module1.NonMetallic)
                {
                    Module1.NonMetallic = false;
                    Module1.QuantityNonMetallic--;
                    if (!Module1.Transparent && !Module1.Metallic && (Module1.QuantityNonMetallic > 0))
                    {
                        Module1.QuantityNonMetallic--;
                    }
                }
            } 
            else
            {
                Module2.Barrier1 = false;
                Module2.Barrier2 = false;
                Module2.Barrier3 = false;
                Module2.PhotoSensor = false;
                Module2.Capacitive = true;
                Module2.Inductive = true;
            }

            IsError = false;
            IsBusy = false;
            MotorOn = false;
            WriteOpc();
        }

        public void AddPieceManual(string pieceType)
        {
            if (!MotorOn || IsError) return;

            if(IsModule1)
            {
                if (Module1.Transparent || Module1.Metallic || Module1.NonMetallic)
                {
                    IsError = true;
                    MotorOn = false;
                }

                IsBusy = true;

                switch (pieceType)
                {
                    case "Transparent":
                        Module1.Transparent = true;
                        Module1.QuantityTransparent++;
                        TaskTransparent();
                        break;
                    case "Metallic":
                        Module1.Metallic = true;
                        Module1.QuantityMetallic++;
                        TaskMetallic();
                        break;
                    case "NonMetallic":
                        Module1.NonMetallic = true;
                        Module1.QuantityNonMetallic++;
                        TaskNonMetallic();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if (IsBusy)
                {
                    IsError = true;
                    MotorOn = false;
                    WriteOpc();
                    return;
                }

                IsBusy = true;
                Module2.PieceType = pieceType;

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
            }
            WriteOpc();
        }

        public void AddPieceAuto()
        {
            Task t = new(() =>
            {
                Random probability = new();
                int option = probability.Next(1, 8);

                if (option > 0 && option < 3)
                {
                    AddPieceManual("Transparent");
                }
                else if (option >= 3 && option < 5)
                {
                    AddPieceManual("Metallic");
                }
                else if (option >= 5 && option < 7)
                {
                    AddPieceManual("NonMetallic");
                }
                else
                {
                    IsError = true;
                    MotorOn = false;
                }
                WriteOpc();
            });
            t.Start();
        }

        private void TaskTransparent()
        {
            if(IsModule1)
            {
                Task tTransparent = new(() => {
                    Thread.Sleep(JourneyTime * 1000);
                    if (IsError) return;
                    Module1.Transparent = false;
                    IsBusy = false;
                    WriteOpc();
                });
                tTransparent.Start();
            }
            else
            {
                Task tTransparent = new(() =>
                {
                    if (!IsError && !StopClick)
                    {
                        Module2.Barrier1 = true;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }

                    if (!IsError && !StopClick)
                    {
                        Module2.Barrier1 = false;
                        Module2.Barrier2 = true;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }

                    if (!IsError && !StopClick)
                    {
                        Module2.Barrier2 = false;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }

                    if (!IsError && !StopClick)
                    {
                        Module2.Capacitive = false;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }

                    if (!IsError && !StopClick)
                    {
                        Module2.Capacitive = true;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }

                    if (!IsError && !StopClick)
                    {
                        Module2.Barrier3 = true;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }

                    if (!IsError && !StopClick)
                    {
                        Module2.Barrier3 = false;
                        IsBusy = false;
                        WriteOpc();
                    }
                });
                tTransparent.Start();
            }
        }

        private void TaskMetallic()
        {
            if(IsModule1)
            {
                Task tMetallic = new(() => {
                    Thread.Sleep(JourneyTime * 1000);
                    if (IsError) return;
                    Module1.Metallic = false;
                    IsBusy = false;
                    WriteOpc();
                });
                tMetallic.Start();
            }
            else
            {
                Task tMetallic = new(() =>
                {
                    if (!IsError && !StopClick)
                    {
                        Module2.Barrier1 = true;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Module2.Barrier1 = false;
                        Module2.Barrier2 = true;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Module2.Barrier2 = false;
                        Module2.PhotoSensor = true;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Module2.PhotoSensor = false;
                        Module2.Capacitive = false;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Module2.Capacitive = true;
                        Module2.Inductive = false;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Module2.Inductive = true;
                        Module2.Barrier3 = true;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Module2.Barrier3 = false;
                        IsBusy = false;
                        WriteOpc();
                    }
                });
                tMetallic.Start();
            }
        }

        private void TaskNonMetallic()
        {
            if(IsModule1)
            {
                Task tNonMetallic = new(() => {
                    Thread.Sleep(JourneyTime * 1000);
                    if (IsError) return;
                    Module1.NonMetallic = false;
                    IsBusy = false;
                    WriteOpc();
                });
                tNonMetallic.Start();
            }
            else
            {
                Task tNonMetallic = new(() =>
                {
                    if (!IsError && !StopClick)
                    {
                        Module2.Barrier1 = true;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Module2.Barrier1 = false;
                        Module2.Barrier2 = true;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Module2.Barrier2 = false;
                        Module2.PhotoSensor = true;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Module2.PhotoSensor = false;
                        Module2.Capacitive = false;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Module2.Capacitive = true;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Module2.Barrier3 = true;
                        WriteOpc();
                        Thread.Sleep((JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Module2.Barrier3 = false;
                        IsBusy = false;
                        WriteOpc();
                    }
                });
                tNonMetallic.Start();
            }
        }
                       
        public void ReadOpc()
        {
            MotorOn = NodeManager.Belt.Motor.Status.Value;
            JourneyTime = NodeManager.Belt.Motor.JourneyTime.Value >= 1 ? NodeManager.Belt.Motor.JourneyTime.Value : JourneyTime;
            IsBusy = NodeManager.Belt.IsBusy.Input.Value;
            IsError = NodeManager.Belt.IsError.Input.Value;
            IsModule1 = NodeManager.Belt.IsModule1.Input.Value;
            IsAuto = NodeManager.Belt.IsAuto.Input.Value;

            Module1.Transparent = NodeManager.Belt.Module1.Transparent.Input.Value;
            Module1.Metallic = NodeManager.Belt.Module1.Metallic.Input.Value;
            Module1.NonMetallic = NodeManager.Belt.Module1.NonMetallic.Input.Value;
            Module1.QuantityTransparent = NodeManager.Belt.Module1.QuantityTransparent.Input.Value;
            Module1.QuantityMetallic = NodeManager.Belt.Module1.QuantityMetallic.Input.Value;
            Module1.QuantityNonMetallic = NodeManager.Belt.Module1.QuantityNonMetallic.Input.Value;

            Module2.Barrier1 = NodeManager.Belt.Module2.Barrier1.Output.Value;
            Module2.Barrier2 = NodeManager.Belt.Module2.Barrier2.Output.Value;
            Module2.Barrier3 = NodeManager.Belt.Module2.Barrier3.Output.Value;
            Module2.PhotoSensor = NodeManager.Belt.Module2.PhotoSensor.Output.Value;
            Module2.Capacitive = NodeManager.Belt.Module2.Capacitive.Output.Value;
            Module2.Inductive = NodeManager.Belt.Module2.Inductive.Output.Value;
            if (IsAuto)
            {
                // Variável disponível apenas para controle Automático.
                Interval = NodeManager.Belt.Motor.Interval.Value >= 1 ? NodeManager.Belt.Motor.Interval.Value : Interval;
                WriteOpc();
            }
            // Voltando ao valor antigo, caso o cliente OPC tente passar um valor inválido.
            if (NodeManager.Belt.Motor.JourneyTime.Value >= 1 || NodeManager.Belt.Motor.Interval.Value >= 1)
            {
                WriteOpc();
            }
        }

        public void WriteOpc()
        {
            NodeManager.Belt.Motor.Status.Value = MotorOn;
            NodeManager.Belt.Motor.JourneyTime.Value = JourneyTime;
            NodeManager.Belt.Motor.Interval.Value = Interval;
            NodeManager.Belt.IsBusy.Input.Value = IsBusy;
            NodeManager.Belt.IsError.Input.Value = IsError;
            NodeManager.Belt.IsModule1.Input.Value = IsModule1;
            NodeManager.Belt.IsAuto.Input.Value = IsAuto;

            NodeManager.Belt.Module1.Transparent.Input.Value = Module1.Transparent;
            NodeManager.Belt.Module1.Metallic.Input.Value = Module1.Metallic;
            NodeManager.Belt.Module1.NonMetallic.Input.Value = Module1.NonMetallic;
            NodeManager.Belt.Module1.QuantityTransparent.Input.Value = Module1.QuantityTransparent;
            NodeManager.Belt.Module1.QuantityMetallic.Input.Value = Module1.QuantityMetallic;
            NodeManager.Belt.Module1.QuantityNonMetallic.Input.Value = Module1.QuantityNonMetallic;

            NodeManager.Belt.Module2.Barrier1.Output.Value = Module2.Barrier1;
            NodeManager.Belt.Module2.Barrier2.Output.Value = Module2.Barrier2;
            NodeManager.Belt.Module2.Barrier3.Output.Value = Module2.Barrier3;
            NodeManager.Belt.Module2.PhotoSensor.Output.Value = Module2.PhotoSensor;
            NodeManager.Belt.Module2.Capacitive.Output.Value = Module2.Capacitive;
            NodeManager.Belt.Module2.Inductive.Output.Value = Module2.Inductive;
            
            NodeManager.Belt.ClearChangeMasks(NodeManager.Context, true);
        }
    }
}
