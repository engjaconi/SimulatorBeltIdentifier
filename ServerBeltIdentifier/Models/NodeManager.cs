using BeltIdentifier;
using Opc.Ua;
using Opc.Ua.Server;
using System.Reflection;

namespace ServerBeltIdentifier.Models
{
    internal class NodeManager : CustomNodeManager2
    {
        private readonly ServerConfiguration Configuration;
        public static BeltState Belt;
        public static SystemContext Context;

        public NodeManager(IServerInternal server, Opc.Ua.ApplicationConfiguration configuration) : base(server, configuration)
        {
            SystemContext.NodeIdFactory = this;

            // Define um namespace para o modelo de tipo e um nome para nós criados dinamicamente.
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = global::BeltIdentifier.Namespaces.BeltIdentifier;
            namespaceUrls[1] = global::BeltIdentifier.Namespaces.BeltIdentifier + "/Istance";
            SetNamespaces(namespaceUrls);

            // Obtém a configuração para o gerenciador de nós.
            Configuration = configuration.ParseExtension<ServerConfiguration>();

            // Usar padrões adequados, se não houver configuração.
            Configuration ??= new ServerConfiguration();
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new();
            predefinedNodes.LoadFromBinaryResource(context, "Models\\OpcComunication\\BeltIdentifier.PredefinedNodes.uanodes",
                typeof(NodeManager).GetTypeInfo().Assembly, true);

            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReference)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReference);

                // Localiza o nó Belt Identifier 1 não tipado que foi criado quando o modelo foi carregado.
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(global::BeltIdentifier.Objects.BeltServer
                    , NamespaceIndexes[0]), typeof(BaseObjectState));

                // Converte o nó sem tipo em um nó tipado que pode ser manipulado dentro do servidor.
                Belt = new BeltState(null);
                Context = SystemContext;
                Belt.Create(SystemContext, passiveNode);

                // Substitui os nós predefinidos sem tipo por suas versões fortemente tipadas.
                AddPredefinedNode(SystemContext, Belt);

                InitializeVariableValues();
            }
        }

        private static void InitializeVariableValues()
        {
            Belt.StartButton.Started.Value = false;
            Belt.ResetButton.Reseted.Value = false;
            Belt.IsModule1.IsModule1On.Value = true;
            Belt.IsAuto.IsAutoOn.Value = false;
            Belt.IsError.IsErrorOn.Value = false;
            Belt.IsBusy.IsBusyOn.Value = false;
            Belt.Motor.MotorOn.Value = false;

            Belt.Module1.Transparent.IsTransparent.Value = false;
            Belt.Module1.Metallic.IsMetallic.Value = false;
            Belt.Module1.NonMetallic.IsNonMetallic.Value = false;
            Belt.Module1.TransparentQuantity.TransparentQty.Value = 0;
            Belt.Module1.MetallicQuantity.MetallicQty.Value = 0;
            Belt.Module1.NonMetallicQuantity.NonMetallicQty.Value = 0;
   
            Belt.Module2.Barrier1.Barrier1On.Value = false;
            Belt.Module2.Barrier2.Barrier2On.Value = false;
            Belt.Module2.Barrier3.Barrier3On.Value = false;
            Belt.Module2.PhotoSensor.PhotoSensorOn.Value = false;
            Belt.Module2.Inductive.InductiveOn.Value = true;
            Belt.Module2.Capacitive.CapacitiveOn.Value = true;
        }
    }
}
