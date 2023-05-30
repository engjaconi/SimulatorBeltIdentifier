namespace ServerBeltIdentifier.Models
{
    public class BeltIdentifierController : Belt
    {
        public bool StopClick;
        public EPieceType PieceType;

        public BeltIdentifierController()
        {
            JourneyTime = 1;
            Interval = 1;
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

                if (NonMetallic)
                {
                    NonMetallic = false;
                    QuantityNonMetallic--;
                    if (!Transparent && !Metallic && (QuantityNonMetallic > 0))
                    {
                        QuantityNonMetallic--;
                    }
                }
            } 
            else
            {
                Barrier1 = false;
                Barrier2 = false;
                Barrier3 = false;
                PhotoSensor = false;
                Capacitive = true;
                Inductive = true;
            }

            IsError = false;
            IsBusy = false;
            MotorOn = false;
            WriteOpc();
        }

        public void AddPieceManual(EPieceType pieceType)
        {
            if (!MotorOn || IsError) return;

            if(IsModule1)
            {
                if (Transparent || Metallic || NonMetallic)
                {
                    IsError = true;
                    MotorOn = false;
                }

                IsBusy = true;

                switch (pieceType)
                {
                    case EPieceType.Transparent:
                        Transparent = true;
                        QuantityTransparent++;
                        TaskTransparent();
                        break;
                    case EPieceType.Metallic:
                        Metallic = true;
                        QuantityMetallic++;
                        TaskMetallic();
                        break;
                    case EPieceType.NonMetallic:
                        NonMetallic = true;
                        QuantityNonMetallic++;
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
                PieceType = pieceType;

                switch (pieceType)
                {
                    case EPieceType.Transparent:
                        TaskTransparent();
                        break;
                    case EPieceType.Metallic:
                        TaskMetallic();
                        break;
                    case EPieceType.NonMetallic:
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
                    AddPieceManual(EPieceType.Transparent);
                }
                else if (option >= 3 && option < 5)
                {
                    AddPieceManual(EPieceType.Metallic);
                }
                else if (option >= 5 && option < 7)
                {
                    AddPieceManual(EPieceType.NonMetallic);
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
                    Thread.Sleep((int)JourneyTime * 1000);
                    if (IsError || StopClick) return;
                    Transparent = false;
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
                        Barrier1 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }

                    if (!IsError && !StopClick)
                    {
                        Barrier1 = false;
                        Barrier2 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }

                    if (!IsError && !StopClick)
                    {
                        Barrier2 = false;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }

                    if (!IsError && !StopClick)
                    {
                        Capacitive = false;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }

                    if (!IsError && !StopClick)
                    {
                        Capacitive = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }

                    if (!IsError && !StopClick)
                    {
                        Barrier3 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }

                    if (!IsError && !StopClick)
                    {
                        Barrier3 = false;
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
                    Thread.Sleep((int)JourneyTime * 1000);
                    if (IsError || StopClick) return;
                    Metallic = false;
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
                        Barrier1 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Barrier1 = false;
                        Barrier2 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Barrier2 = false;
                        PhotoSensor = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        PhotoSensor = false;
                        Capacitive = false;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Capacitive = true;
                        Inductive = false;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Inductive = true;
                        Barrier3 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Barrier3 = false;
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
                    Thread.Sleep((int)JourneyTime * 1000);
                    if (IsError || StopClick) return;
                    NonMetallic = false;
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
                        Barrier1 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Barrier1 = false;
                        Barrier2 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Barrier2 = false;
                        PhotoSensor = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        PhotoSensor = false;
                        Capacitive = false;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Capacitive = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Barrier3 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && !StopClick)
                    {
                        Barrier3 = false;
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

            Transparent = NodeManager.Belt.Module1.Transparent.Input.Value;
            Metallic = NodeManager.Belt.Module1.Metallic.Input.Value;
            NonMetallic = NodeManager.Belt.Module1.NonMetallic.Input.Value;
            QuantityTransparent = NodeManager.Belt.Module1.QuantityTransparent.Input.Value;
            QuantityMetallic = NodeManager.Belt.Module1.QuantityMetallic.Input.Value;
            QuantityNonMetallic = NodeManager.Belt.Module1.QuantityNonMetallic.Input.Value;

            Barrier1 = NodeManager.Belt.Module2.Barrier1.Output.Value;
            Barrier2 = NodeManager.Belt.Module2.Barrier2.Output.Value;
            Barrier3 = NodeManager.Belt.Module2.Barrier3.Output.Value;
            PhotoSensor = NodeManager.Belt.Module2.PhotoSensor.Output.Value;
            Capacitive = NodeManager.Belt.Module2.Capacitive.Output.Value;
            Inductive = NodeManager.Belt.Module2.Inductive.Output.Value;
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

            NodeManager.Belt.Module1.Transparent.Input.Value = Transparent;
            NodeManager.Belt.Module1.Metallic.Input.Value = Metallic;
            NodeManager.Belt.Module1.NonMetallic.Input.Value = NonMetallic;
            NodeManager.Belt.Module1.QuantityTransparent.Input.Value = QuantityTransparent;
            NodeManager.Belt.Module1.QuantityMetallic.Input.Value = QuantityMetallic;
            NodeManager.Belt.Module1.QuantityNonMetallic.Input.Value = QuantityNonMetallic;

            NodeManager.Belt.Module2.Barrier1.Output.Value = Barrier1;
            NodeManager.Belt.Module2.Barrier2.Output.Value = Barrier2;
            NodeManager.Belt.Module2.Barrier3.Output.Value = Barrier3;
            NodeManager.Belt.Module2.PhotoSensor.Output.Value = PhotoSensor;
            NodeManager.Belt.Module2.Capacitive.Output.Value = Capacitive;
            NodeManager.Belt.Module2.Inductive.Output.Value = Inductive;
            
            NodeManager.Belt.ClearChangeMasks(NodeManager.Context, true);
        }
    }
}
