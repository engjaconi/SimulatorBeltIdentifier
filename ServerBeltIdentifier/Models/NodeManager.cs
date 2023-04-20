using BeltIdentifier;
using Opc.Ua;
using Opc.Ua.Server;
using System.Reflection;

namespace ServerBeltIdentifier.Models
{
    internal class NodeManager : CustomNodeManager2
    {
        public NodeManager(IServerInternal server, Opc.Ua.ApplicationConfiguration configuration) : base(server, configuration)
        {
            SystemContext.NodeIdFactory = this;

            // define um namespace para o modelo de tipo e um nome para nós criados dinamicamente.
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = BeltIdentifier.Namespaces.BeltIdentifier;
            namespaceUrls[1] = BeltIdentifier.Namespaces.BeltIdentifier + "/Istance";
            SetNamespaces(namespaceUrls);

            // obtém a configuração para o gerenciador de nós.
            _configuration = configuration.ParseExtension<ServerConfiguration>();

            // Usar padrões adequados, se não houver configuração.
            _configuration ??= new ServerConfiguration();
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new();
            predefinedNodes.LoadFromBinaryResource(context, "C:\\Users\\engja\\source\\repos\\SimulatorBeltIdentifier\\ServerBeltIdentifier\\Models\\OpcComunication\\BeltIdentifier.PredefinedNodes.uanodes",
                typeof(NodeManager).GetTypeInfo().Assembly, true);

            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReference)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReference);

                // localiza o nó Belt Identifier 1 não tipado que foi criado quando o modelo foi carregado.
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(BeltIdentifier.Objects.BeltServer
                    , NamespaceIndexes[0]), typeof(BaseObjectState));

                // converte o nó sem tipo em um nó tipado que pode ser manipulado dentro do servidor.
                _beltIdentifier1 = new BeltState(null);
                _beltIdentifier1.Create(SystemContext, passiveNode);

                // substitui os nós predefinidos sem tipo por suas versões fortemente tipadas.
                AddPredefinedNode(SystemContext, _beltIdentifier1);

                _beltIdentifier1.StartProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStartProcess);
                _beltIdentifier1.StopProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStopProcess);

                _simulationTimer = new System.Threading.Timer(DoSimulation, null, 1000, 1000);
            }
        }

        public void DoSimulation(object state)
        {
            _beltIdentifier1.BeltIdentifier1.BeltIdentifierOpticalBarrierStart.Output.Value = 95.2;
        }

        private ServiceResult OnStartProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            _beltIdentifier1.BeltIdentifier1.BeltIdentifierMotor.Speed.Value = 55.3;
            return ServiceResult.Good;
        }

        private ServiceResult OnStopProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            return ServiceResult.Good;
        }

        private readonly ServerConfiguration _configuration;
        private static BeltState _beltIdentifier1;
        private System.Threading.Timer _simulationTimer;
    }
}
