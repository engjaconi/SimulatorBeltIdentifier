using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;

namespace BeltIdentifierServer
{
    public partial class ServerForm : Form
    {
        private ApplicationInstance _application;
        private StandardServer _server;
        private Opc.Ua.ApplicationConfiguration _configuration;
        public ServerForm()
        {
            InitializeComponent();
        }

        public ServerForm(ApplicationInstance application)
        {
            InitializeComponent();

            _application = application;
            _server = application.Server as StandardServer;
            _configuration = application.ApplicationConfiguration;

            // Insere a URL na caixa de texto.
            ServerUrlComboBox.Items.Clear();

            foreach (EndpointDescription endpoint in _server.GetEndpoints())
            {
                if (ServerUrlComboBox.FindStringExact(endpoint.EndpointUrl) == -1)
                {
                    ServerUrlComboBox.Items.Add(endpoint.EndpointUrl);
                }
            }

            if (ServerUrlComboBox.Items.Count > 0)
            {
                ServerUrlComboBox.SelectedIndex = 0;
            }
        }
    }
}