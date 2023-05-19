using Newtonsoft.Json.Linq;
using Opc.Ua;
using Opc.Ua.Client;

namespace ClientBeltIdentifier.Models
{
    internal class BeltIdentifier : Belt
    {
        private readonly Session session;
        public EPieceType PieceType { get; set; }

        public BeltIdentifier(Session session)
        {
            this.session = session;
            ReadOpc();
        }

        public void Start()
        {
            session.Call("ns=2;i=345", "ns=2;i=460");
        }

        public void Stop()
        {
            session.Call("ns=2;i=345", "ns=2;i=461");
        }

        public void Reset()
        {
            session.Call("ns=2;i=345", "ns=2;i=462");
        }

        public void AddPieceManual(EPieceType pieceType)
        {
            if (pieceType == EPieceType.Transparent)
            {
                session.Call("ns=2;i=345", "ns=2;i=1165");
            } else if (pieceType == EPieceType.Metallic)
            {
                session.Call("ns=2;i=345", "ns=2;i=1166");
            } else
            {
                session.Call("ns=2;i=345", "ns=2;i=1167");
            }
        }

        public void ReadOpc()
        {
            Interval = Convert.ToUInt32(session.ReadValue("ns=2;i=1145").ToString());
            JourneyTime = Convert.ToUInt32(session.ReadValue("ns=2;i=1139").ToString());
            MotorOn = Convert.ToBoolean(session.ReadValue("ns=2;i=1151").ToString());
            IsBusy = Convert.ToBoolean(session.ReadValue("ns=2;i=1205").ToString());
            IsError = Convert.ToBoolean(session.ReadValue("ns=2;i=1198").ToString());
            IsModule1 = Convert.ToBoolean(session.ReadValue("ns=2;i=1118").ToString());
            IsAuto = Convert.ToBoolean(session.ReadValue("ns=2;i=1111").ToString());

            Transparent = Convert.ToBoolean(session.ReadValue("ns=2;i=958").ToString());
            Metallic = Convert.ToBoolean(session.ReadValue("ns=2;i=362").ToString());
            NonMetallic = Convert.ToBoolean(session.ReadValue("ns=2;i=369").ToString());
            QuantityTransparent = Convert.ToUInt32(session.ReadValue("ns=2;i=965").ToString());
            QuantityMetallic = Convert.ToUInt32(session.ReadValue("ns=2;i=383").ToString());
            QuantityNonMetallic = Convert.ToUInt32(session.ReadValue("ns=2;i=390").ToString());
        
            Barrier1 = Convert.ToBoolean(session.ReadValue("ns=2;i=405").ToString());
            Barrier2 = Convert.ToBoolean(session.ReadValue("ns=2;i=412").ToString());
            Barrier3 = Convert.ToBoolean(session.ReadValue("ns=2;i=419").ToString());
            PhotoSensor = Convert.ToBoolean(session.ReadValue("ns=2;i=426").ToString());
            Capacitive = Convert.ToBoolean(session.ReadValue("ns=2;i=433").ToString());
            Inductive = Convert.ToBoolean(session.ReadValue("ns=2;i=440").ToString());
        }
    }
}
