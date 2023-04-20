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

            // set one namespace for the type model and one names for dynamically created nodes.
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = BeltIdentifier.Namespaces.BeltIdentifier;
            namespaceUrls[1] = BeltIdentifier.Namespaces.BeltIdentifier + "/Istance";
            SetNamespaces(namespaceUrls);

            // get the configuration for the node manager.
            m_configuration = configuration.ParseExtension<ServerBeltIdentifierConfiguration>();

            // use suitable defaults if no configuration exists.
            m_configuration ??= new ServerBeltIdentifierConfiguration();
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

                // find the untyped Identifier Belt 1 node that was created when the model was loaded.
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(BeltIdentifier.Objects.BeltServer
                    , NamespaceIndexes[0]), typeof(BaseObjectState));

                // convert the untyped node to a typed node that can be manipulated within the server.
                m_beltIdentifier1 = new BeltState(null);
                m_beltIdentifier1.Create(SystemContext, passiveNode);

                // replaces the untyped predefined nodes with their strongly typed versions.
                AddPredefinedNode(SystemContext, m_beltIdentifier1);

                
                m_beltIdentifier1.StartProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStartProcess);
                m_beltIdentifier1.StopProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStopProcess);
                

                m_simulationTimer = new System.Threading.Timer(DoSimulation, null, 1000, 1000);
            }
        }

        public void DoSimulation(object state)
        {
            m_beltIdentifier1.BeltIdentifier1.BeltIdentifierOpticalBarrierStart.Output.Value = 95.2;
        }

        private ServiceResult OnStartProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            m_beltIdentifier1.BeltIdentifier1.BeltIdentifierMotor.Speed.Value = 55.3;
            return ServiceResult.Good;
        }

        private ServiceResult OnStopProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            return ServiceResult.Good;
        }

        private readonly ServerBeltIdentifierConfiguration m_configuration;
        private static BeltState m_beltIdentifier1;
        private System.Threading.Timer m_simulationTimer;
    }
}
