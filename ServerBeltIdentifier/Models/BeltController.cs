namespace ServerBeltIdentifier.Models
{
    public partial class Belt
    {
        public uint JourneyTime;
        public uint Interval;
        public EPieceType PieceType;

        #region Instância da Esteira - Padrão de Projeto Singleton
        private static Belt _instance;

        private Belt()
        {
            JourneyTime = 1;
            Interval = 2;
            ReadOpc();
        }

        public static Belt GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Belt();
            }
            return _instance;
        }
        #endregion

        public void Start()
        {
            if (IsError) return;
           
            MotorOn = true;
            Started = true;
            WriteOpc();
        }

        public void Stop()
        {
            if (IsError) return;

            MotorOn = false;
            Started = false;
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
                    TransparentQuantity--;
                    if (!Metallic && !NonMetallic && (TransparentQuantity > 0))
                    {
                        TransparentQuantity--;
                    }
                }

                if (Metallic)
                {
                    Metallic = false;
                    MetallicQuantity--;
                    if (!Transparent && !NonMetallic && (MetallicQuantity > 0))
                    {
                        MetallicQuantity--;
                    }
                }

                if (NonMetallic)
                {
                    NonMetallic = false;
                    NonMetallicQuantity--;
                    if (!Transparent && !Metallic && (NonMetallicQuantity > 0))
                    {
                        NonMetallicQuantity--;
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
            Reseted = false;
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
                        TransparentQuantity++;
                        TaskTransparent();
                        break;
                    case EPieceType.Metallic:
                        Metallic = true;
                        MetallicQuantity++;
                        TaskMetallic();
                        break;
                    case EPieceType.NonMetallic:
                        NonMetallic = true;
                        NonMetallicQuantity++;
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
                    if (IsError || !Started) return;
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
                    if (!IsError && Started)
                    {
                        Barrier1 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }

                    if (!IsError && Started)
                    {
                        Barrier1 = false;
                        Barrier2 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }

                    if (!IsError && Started)
                    {
                        Barrier2 = false;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }

                    if (!IsError && Started)
                    {
                        Capacitive = false;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }

                    if (!IsError && Started)
                    {
                        Capacitive = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }

                    if (!IsError && Started)
                    {
                        Barrier3 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }

                    if (!IsError && Started)
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
                    if (IsError || !Started) return;
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
                    if (!IsError && Started)
                    {
                        Barrier1 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && Started)
                    {
                        Barrier1 = false;
                        Barrier2 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && Started)
                    {
                        Barrier2 = false;
                        PhotoSensor = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && Started)
                    {
                        PhotoSensor = false;
                        Capacitive = false;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && Started)
                    {
                        Capacitive = true;
                        Inductive = false;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && Started)
                    {
                        Inductive = true;
                        Barrier3 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && Started)
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
                    if (IsError || !Started) return;
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
                    if (!IsError && Started)
                    {
                        Barrier1 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && Started)
                    {
                        Barrier1 = false;
                        Barrier2 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && Started)
                    {
                        Barrier2 = false;
                        PhotoSensor = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && Started)
                    {
                        PhotoSensor = false;
                        Capacitive = false;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && Started)
                    {
                        Capacitive = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && Started)
                    {
                        Barrier3 = true;
                        WriteOpc();
                        Thread.Sleep(((int)JourneyTime / 6) * 1000);
                    }
                    if (!IsError && Started)
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
            Started = NodeManager.Belt.StartButton.Started.Value;
            Reseted = NodeManager.Belt.ResetButton.Reseted.Value;
            MotorOn = NodeManager.Belt.Motor.MotorOn.Value;
            IsBusy = NodeManager.Belt.IsBusy.IsBusyOn.Value;
            IsError = NodeManager.Belt.IsError.IsErrorOn.Value;
            IsModule1 = NodeManager.Belt.IsModule1.IsModule1On.Value;
            IsAuto = NodeManager.Belt.IsAuto.IsAutoOn.Value;

            Transparent = NodeManager.Belt.Module1.Transparent.IsTransparent.Value;
            Metallic = NodeManager.Belt.Module1.Metallic.IsMetallic.Value;
            NonMetallic = NodeManager.Belt.Module1.NonMetallic.IsNonMetallic.Value;
            TransparentQuantity = NodeManager.Belt.Module1.TransparentQuantity.TransparentQty.Value;
            MetallicQuantity = NodeManager.Belt.Module1.MetallicQuantity.MetallicQty.Value;
            NonMetallicQuantity = NodeManager.Belt.Module1.NonMetallicQuantity.NonMetallicQty.Value;

            Barrier1 = NodeManager.Belt.Module2.Barrier1.Barrier1On.Value;
            Barrier2 = NodeManager.Belt.Module2.Barrier2.Barrier2On.Value;
            Barrier3 = NodeManager.Belt.Module2.Barrier3.Barrier3On.Value;
            PhotoSensor = NodeManager.Belt.Module2.PhotoSensor.PhotoSensorOn.Value;
            Capacitive = NodeManager.Belt.Module2.Capacitive.CapacitiveOn.Value;
            Inductive = NodeManager.Belt.Module2.Inductive.InductiveOn.Value;

            if (Started == true && MotorOn == false && !IsError)
            {
                Start();
            } else if(Started == false && MotorOn == true && !IsError) { 
                Stop();
            } else if (Started == true && IsError)
            {
                Started = false;
            }

            if(Reseted == true && IsError == true)
            {
                Reset();
            } else if (Reseted == true && IsError == false)
            {
                Reseted = false;
            }
        }

        public void WriteOpc()
        {
            NodeManager.Belt.StartButton.Started.Value = Started;
            NodeManager.Belt.ResetButton.Reseted.Value = Reseted;
            NodeManager.Belt.Motor.MotorOn.Value = MotorOn;
            NodeManager.Belt.IsBusy.IsBusyOn.Value = IsBusy;
            NodeManager.Belt.IsError.IsErrorOn.Value = IsError;
            NodeManager.Belt.IsModule1.IsModule1On.Value = IsModule1;
            NodeManager.Belt.IsAuto.IsAutoOn.Value = IsAuto;

            NodeManager.Belt.Module1.Transparent.IsTransparent.Value = Transparent;
            NodeManager.Belt.Module1.Metallic.IsMetallic.Value = Metallic;
            NodeManager.Belt.Module1.NonMetallic.IsNonMetallic.Value = NonMetallic;
            NodeManager.Belt.Module1.TransparentQuantity.TransparentQty.Value = TransparentQuantity;
            NodeManager.Belt.Module1.MetallicQuantity.MetallicQty.Value = MetallicQuantity;
            NodeManager.Belt.Module1.NonMetallicQuantity.NonMetallicQty.Value = NonMetallicQuantity;

            NodeManager.Belt.Module2.Barrier1.Barrier1On.Value = Barrier1;
            NodeManager.Belt.Module2.Barrier2.Barrier2On.Value = Barrier2;
            NodeManager.Belt.Module2.Barrier3.Barrier3On.Value = Barrier3;
            NodeManager.Belt.Module2.PhotoSensor.PhotoSensorOn.Value = PhotoSensor;
            NodeManager.Belt.Module2.Capacitive.CapacitiveOn.Value = Capacitive;
            NodeManager.Belt.Module2.Inductive.InductiveOn.Value = Inductive;
            
            NodeManager.Belt.ClearChangeMasks(NodeManager.Context, true);
        }
    }
}
