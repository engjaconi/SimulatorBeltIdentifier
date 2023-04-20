using BeltIdentifier;
using System.Runtime.Serialization;

namespace ServerBeltIdentifier.Models
{
    [DataContract(Namespace = Namespaces.BeltIdentifier)]
    public class ServerBeltIdentifierConfiguration
    {
        public ServerBeltIdentifierConfiguration() 
        {
            Initialize();
        }

        /// <summary>
        /// Initializes the object during deserialization.
        /// </summary>
        [OnDeserializing()]
        private static void Initialize(StreamingContext context) 
        {
            Initialize();
        }

        /// <summary>
        /// Sets private members to default values.
        /// </summary>
        private static void Initialize() {}
    }
}
