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
            cbServerUrl.Items.Clear();

            foreach (EndpointDescription endpoint in _server.GetEndpoints())
            {
                if (cbServerUrl.FindStringExact(endpoint.EndpointUrl) == -1)
                {
                    cbServerUrl.Items.Add(endpoint.EndpointUrl);
                }
            }

            if (cbServerUrl.Items.Count > 0)
            {
                cbServerUrl.SelectedIndex = 0;
            }

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            //this.textBox1.Text = NodeManager._Belt.Module1.Motor.Speed.Value.ToString();
            this.pMotorStatus.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_on;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            this.pMotorStatus.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
        }

        private void ServerUrlComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.textBox1.Text = NodeManager._Belt.Module2.Motor.Speed.Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tpModule1_Click(object sender, EventArgs e)
        {

        }
    }
}