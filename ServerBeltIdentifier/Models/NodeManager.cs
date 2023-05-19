using BeltIdentifier;
using BeltIdentifierServer;
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

            // define um namespace para o modelo de tipo e um nome para nós criados dinamicamente.
            string[] namespaceUrls = new string[2];
            namespaceUrls[0] = global::BeltIdentifier.Namespaces.BeltIdentifier;
            namespaceUrls[1] = global::BeltIdentifier.Namespaces.BeltIdentifier + "/Istance";
            SetNamespaces(namespaceUrls);

            // obtém a configuração para o gerenciador de nós.
            Configuration = configuration.ParseExtension<ServerConfiguration>();

            // Usar padrões adequados, se não houver configuração.
            Configuration ??= new ServerConfiguration();
        }

        protected override NodeStateCollection LoadPredefinedNodes(ISystemContext context)
        {
            NodeStateCollection predefinedNodes = new();
            predefinedNodes.LoadFromBinaryResource(context, Config.PathPredefinedNodes,
                typeof(NodeManager).GetTypeInfo().Assembly, true);

            return predefinedNodes;
        }

        public override void CreateAddressSpace(IDictionary<NodeId, IList<IReference>> externalReference)
        {
            lock (Lock)
            {
                LoadPredefinedNodes(SystemContext, externalReference);

                // localiza o nó Belt Identifier 1 não tipado que foi criado quando o modelo foi carregado.
                BaseObjectState passiveNode = (BaseObjectState)FindPredefinedNode(new NodeId(global::BeltIdentifier.Objects.BeltServer
                    , NamespaceIndexes[0]), typeof(BaseObjectState));

                // converte o nó sem tipo em um nó tipado que pode ser manipulado dentro do servidor.
                Belt = new BeltState(null);
                Context = SystemContext;
                Belt.Create(SystemContext, passiveNode);

                // substitui os nós predefinidos sem tipo por suas versões fortemente tipadas.
                AddPredefinedNode(SystemContext, Belt);

                Belt.StartProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStartProcess);
                Belt.StopProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnStopProcess);
                Belt.ResetProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnResetProcess);
                Belt.AddTransparentPieceProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnAddTransparentPieceProcess);
                Belt.AddMetallicPieceProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnAddMetallicPieceProcess);
                Belt.AddNonMetallicPieceProcess.OnCallMethod = new GenericMethodCalledEventHandler(OnAddNonMetallicPieceProcess);

                InitializeVariableValues();
            }
        }

        private ServiceResult OnStartProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            ServerForm.BeltIdentifier.Start();
            return ServiceResult.Good;
        }

        private ServiceResult OnStopProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            ServerForm.BeltIdentifier.Stop();
            return ServiceResult.Good;
        }

        private ServiceResult OnResetProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            ServerForm.BeltIdentifier.Reset();
            return ServiceResult.Good;
        }

        private ServiceResult OnAddTransparentPieceProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            if (!ServerForm.BeltIdentifier.IsAuto)
                ServerForm.BeltIdentifier.AddPieceManual(EPieceType.Transparent);
            return ServiceResult.Good;
        }

        private ServiceResult OnAddMetallicPieceProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            if (!ServerForm.BeltIdentifier.IsAuto)
                ServerForm.BeltIdentifier.AddPieceManual(EPieceType.Metallic);
            return ServiceResult.Good;
        }
        
        private ServiceResult OnAddNonMetallicPieceProcess(ISystemContext context, MethodState method, IList<object> inputArguments, IList<object> outputArguments)
        {
            if (!ServerForm.BeltIdentifier.IsAuto)
                ServerForm.BeltIdentifier.AddPieceManual(EPieceType.NonMetallic);
            return ServiceResult.Good;
        }
        
        private static void InitializeVariableValues()
        {
            Belt.IsModule1.Input.Value = true;
            Belt.IsAuto.Input.Value = false;
            Belt.IsError.Input.Value = false;
            Belt.IsBusy.Input.Value = false;
            Belt.Motor.Status.Value = false;
            Belt.Motor.Interval.Value = 1;
            Belt.Motor.JourneyTime.Value = 1;

            Belt.Module1.Transparent.Input.Value = false;
            Belt.Module1.Metallic.Input.Value = false;
            Belt.Module1.NonMetallic.Input.Value = false;
            Belt.Module1.QuantityTransparent.Input.Value = 0;
            Belt.Module1.QuantityMetallic.Input.Value = 0;
            Belt.Module1.QuantityNonMetallic.Input.Value = 0;
   
            Belt.Module2.Barrier1.Output.Value = false;
            Belt.Module2.Barrier2.Output.Value = false;
            Belt.Module2.Barrier3.Output.Value = false;
            Belt.Module2.PhotoSensor.Output.Value = false;
            Belt.Module2.Inductive.Output.Value = true;
            Belt.Module2.Capacitive.Output.Value = true;
        }
    }
}
