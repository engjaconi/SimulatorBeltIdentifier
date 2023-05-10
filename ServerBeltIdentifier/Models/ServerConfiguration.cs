using BeltIdentifier;
using System.Runtime.Serialization;

namespace ServerBeltIdentifier.Models
{
    [DataContract(Namespace = Namespaces.BeltIdentifier)]
    public class ServerConfiguration
    {
        public ServerConfiguration()
        {
            Initialize();
        }

        [OnDeserializing()]
        private static void Initialize(StreamingContext context)
        {
            Initialize();
        }

        private static void Initialize() { }
    }
}
