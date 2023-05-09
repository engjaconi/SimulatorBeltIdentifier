using BeltIdentifier;
using BeltIdentifierServer;
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
                _Belt = new BeltState(null);
                _Belt.Create(SystemContext, passiveNode);

                // substitui os nós predefinidos sem tipo por suas versões fortemente tipadas.
                AddPredefinedNode(SystemContext, _Belt);

                _Belt.StartModule1Process.OnCallMethod = new GenericMethodCalledEventHandler(OnStartModule1Process);
                _Belt.StopModule1Process.OnCallMethod = new GenericMethodCalledEventHandler(OnStopModule1Process);
                _Belt.ResetModule1Process.OnCallMethod = new GenericMethodCalledEventHandler(OnResetModule1Process);

                _Belt.StartModule2Process.OnCallMethod = new GenericMethodCalledEventHandler(OnStartModule2Process);
                _Belt.StopModule2Process.OnCallMethod = new GenericMethodCalledEventHandler(OnStopModule2Process);
                _Belt.ResetModule2Process.OnCallMethod = new GenericMethodCalledEventHandler(OnResetModule2Process);

                InitializeVariableValues();
            }
        }

        private ServiceResult OnStartModule1Process(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            ServerForm.beltModule1.Start();
            return ServiceResult.Good;
        }

        private ServiceResult OnStopModule1Process(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            ServerForm.beltModule1.Stop();
            return ServiceResult.Good;
        }

        private ServiceResult OnResetModule1Process(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            ServerForm.beltModule1.Reset();
            return ServiceResult.Good;
        }

        private ServiceResult OnStartModule2Process(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            ServerForm.beltModule2.Start();
            return ServiceResult.Good;
        }

        private ServiceResult OnStopModule2Process(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            ServerForm.beltModule2.Stop();
            return ServiceResult.Good;
        }

        private ServiceResult OnResetModule2Process(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            ServerForm.beltModule2.Reset();
            return ServiceResult.Good;
        }

        private void InitializeVariableValues()
        {
            _Belt.Module1.Transparent.Input.Value = false;
            _Belt.Module1.Metallic.Input.Value = false;
            _Belt.Module1.NonMetallic.Input.Value = false;
            _Belt.Module1.Error.Input.Value = false;
            _Belt.Module1.QuantityTransparent.Input.Value = 0;
            _Belt.Module1.QuantityMetallic.Input.Value = 0;
            _Belt.Module1.QuantityNonMetallic.Input.Value = 0;
            _Belt.Module1.Motor.Speed.Value = 1;
            _Belt.Module1.Motor.Status.Value = false;
            _Belt.Module1.Busy.Input.Value = false;

            _Belt.Module2.Barrier1.Output.Value = false;
            _Belt.Module2.Barrier2.Output.Value = false;
            _Belt.Module2.Barrier3.Output.Value = false;
            _Belt.Module2.PhotoSensor.Output.Value = false;
            _Belt.Module2.Inductive.Output.Value = true;
            _Belt.Module2.Capacitive.Output.Value = true;
            _Belt.Module2.Motor.Speed.Value = 0;
            _Belt.Module2.Motor.Status.Value = false;
            _Belt.Module2.Error.Input.Value = false;
            _Belt.Module2.Busy.Input.Value= false;
        }

        private readonly ServerConfiguration _configuration;
        public static BeltState _Belt;
    }
}
