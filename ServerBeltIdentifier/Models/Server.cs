using Opc.Ua;
using Opc.Ua.Server;
using ServerBeltIdentifier.Models;

namespace BeltIdentifierServer.Models
{
    internal class Server : StandardServer
    {
        protected override MasterNodeManager CreateMasterNodeManager(IServerInternal server, Opc.Ua.ApplicationConfiguration configuration)
        {
            List<INodeManager> nodeManagers = new()
            {
                // Criando meu nó customizado.
                new NodeManager(server, configuration)
            };

            // Criando o nó gerenciador.
            return new MasterNodeManager(server, configuration, null, nodeManagers.ToArray());
        }

        protected override ServerProperties LoadServerProperties()
        {
            ServerProperties properties = new()
            {
                ManufacturerName = "UCL",
                ProductName = "BeltIdentifier Server",
                ProductUri = "http://opcfoundation.org/BeltIdentifier/InvormationModelServer/v1.0",
                SoftwareVersion = Utils.GetAssemblySoftwareVersion(),
                BuildNumber = Utils.GetAssemblyBuildNumber(),
                BuildDate = Utils.GetAssemblyTimestamp()
            };

            return properties;
        }
    }
}
