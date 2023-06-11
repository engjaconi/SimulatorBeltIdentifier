using Opc.Ua;
using Opc.Ua.Client;

namespace ClientBeltIdentifier.Models
{
    public partial class Belt
    {
        private Session Session;
        public EPieceType PieceType;

        #region Instância da Esteira - Padrão de Projeto Singleton
        private static Belt _instance;

        private Belt(Session session)
        {
            this.Session = session;
            ReadOpc();
        }

        public static Belt GetInstance(Session session)
        {
            if (_instance == null)
            {
                _instance = new Belt(session);
            }

            _instance.Session = session;
            return _instance;
        }
        #endregion

        public void Start()
        {
            if (Started) { return; }
            WriteOpc("ns=2;i=235", true);
        }

        public void Stop()
        {
            if (!Started) { return; }
            WriteOpc("ns=2;i=235", false);
        }

        public void Reset()
        {
            WriteOpc("ns=2;i=239", true);
        }

        public void ReadOpc()
        {
            if (!Session.Connected) { return; }
            Started = Convert.ToBoolean(Session.ReadValue("ns=2;i=235").ToString());
            Reseted = Convert.ToBoolean(Session.ReadValue("ns=2;i=239").ToString());
            MotorOn = Convert.ToBoolean(Session.ReadValue("ns=2;i=259").ToString());
            IsBusy = Convert.ToBoolean(Session.ReadValue("ns=2;i=255").ToString());
            IsError = Convert.ToBoolean(Session.ReadValue("ns=2;i=251").ToString());
            IsModule1 = Convert.ToBoolean(Session.ReadValue("ns=2;i=247").ToString());
            IsAuto = Convert.ToBoolean(Session.ReadValue("ns=2;i=243").ToString());

            Transparent = Convert.ToBoolean(Session.ReadValue("ns=2;i=264").ToString());
            Metallic = Convert.ToBoolean(Session.ReadValue("ns=2;i=268").ToString());
            NonMetallic = Convert.ToBoolean(Session.ReadValue("ns=2;i=272").ToString());
            TransparentQuantity = Convert.ToUInt32(Session.ReadValue("ns=2;i=382").ToString());
            MetallicQuantity = Convert.ToUInt32(Session.ReadValue("ns=2;i=389").ToString());
            NonMetallicQuantity = Convert.ToUInt32(Session.ReadValue("ns=2;i=396").ToString());
        
            Barrier1 = Convert.ToBoolean(Session.ReadValue("ns=2;i=298").ToString());
            Barrier2 = Convert.ToBoolean(Session.ReadValue("ns=2;i=302").ToString());
            Barrier3 = Convert.ToBoolean(Session.ReadValue("ns=2;i=306").ToString());
            PhotoSensor = Convert.ToBoolean(Session.ReadValue("ns=2;i=310").ToString());
            Capacitive = Convert.ToBoolean(Session.ReadValue("ns=2;i=314").ToString());
            Inductive = Convert.ToBoolean(Session.ReadValue("ns=2;i=318").ToString());
        }

        private void WriteOpc(string node, bool value)
        {
            try
            {
                WriteValue valueToWrite = new WriteValue();

                valueToWrite.NodeId = node;
                valueToWrite.Value.WrappedValue = value;
                valueToWrite.AttributeId = Attributes.Value;
                valueToWrite.Value.StatusCode = StatusCodes.Good;
                valueToWrite.Value.ServerTimestamp = DateTime.MinValue;
                valueToWrite.Value.SourceTimestamp = DateTime.MinValue;

                WriteValueCollection valuesToWrite = new WriteValueCollection();
                valuesToWrite.Add(valueToWrite);

                StatusCodeCollection results = null;
                DiagnosticInfoCollection diagnosticInfos = null;

                Session.Write(
                    null,
                    valuesToWrite,
                    out results,
                    out diagnosticInfos);

                ClientBase.ValidateResponse(results, valuesToWrite);
                ClientBase.ValidateDiagnosticInfos(diagnosticInfos, valuesToWrite);

                if (StatusCode.IsBad(results[0]))
                {
                    throw new ServiceResultException(results[0]);
                }
            }
            catch
            {
                MessageBox.Show("Falha ao enviar o comando para o servidor, tente novamente!");
            }
        }
    }
}
