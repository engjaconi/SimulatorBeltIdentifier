using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using ServerBeltIdentifier.Models;

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

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = NodeManager._Belt.Module1.Motor.Speed.Value.ToString();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            NodeManager._Belt.Module2.Motor.Speed.Value = 4;
            MessageBox.Show("ok");
        }

        private void ServerUrlComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.textBox1.Text = NodeManager._Belt.Module2.Motor.Speed.Value.ToString();
        }
    }
}