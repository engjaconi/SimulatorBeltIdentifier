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
        public static BeltModule1 _beltModule1 = new();
        public static BeltModule2 _beltModule2 = new();
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

        private void ServerForm_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void ServerUrlComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus)
            {
                _beltModule1.Start();
            }
            else
            {
                _beltModule2.Start();
            }
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus)
            {
                _beltModule1.Stop();
            }
            else
            {
                _beltModule2.Stop();
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus && _beltModule1.Error)
            {
                _beltModule1.Reset();
            }
            else if (tpModule2.CanFocus && _beltModule2.Error)
            {
                _beltModule2.Reset();
            }
        }
        private void btnAddPiece_Click(object sender, EventArgs e)
        {
            string pieceType = rbOpaque.Checked ? "Opaque" : rbMetallic.Checked ? "Metallic" : "NonMetallic";
            int speedMotor = rbSpeed1.Checked ? 1 : rbSpeed2.Checked ? 2 : rbSpeed3.Checked ? 3 : 4;

            if (tpModule1.CanFocus)
            {
                if (rbManual.Checked)
                {
                    _beltModule1.AddPieceManual(pieceType, speedMotor);
                }
                else
                {
                    _beltModule1.AddPieceAuto(speedMotor);
                }
            }
            else
            {
                if (rbManual.Checked)
                {
                    _beltModule2.AddPieceManual(pieceType, speedMotor);
                }
                else
                {
                    _beltModule2.AddPieceAuto(speedMotor);
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus)
            {
                _beltModule1.ReadOpc();
            }
            else
            {
                _beltModule2.ReadOpc();
            }

            UpdateForm();
        }
        private void UpdateForm()
        {
            UpdateButtons();
            UpdateIndicators();
        }
        private void UpdateButtons()
        {
            if (_beltModule1.MotorOn || _beltModule2.MotorOn)
            {
                btnStop.Enabled = true;
                btnStart.Enabled = false;
            }
            else
            {
                btnStop.Enabled = false;
                btnStart.Enabled = true;
            }

            if (_beltModule1.Error || _beltModule2.Error)
            {
                btnReset.Enabled = true;
                btnStart.Enabled = false;
            }
            else
            {
                btnReset.Enabled = false;
            }

            if (rbManual.Checked
                && !(_beltModule1.Error || _beltModule2.Error)
                && (_beltModule1.MotorOn || _beltModule2.MotorOn))
            {
                btnAddPiece.Enabled = true;
            }
            else
            {
                btnAddPiece.Enabled = false;
            }

            if (rbAutomatic.Checked)
            {
                rbOpaque.Enabled = false;
                rbMetallic.Enabled = false;
                rbNonMetallic.Enabled = false;
                rbOpaque.Checked = false;
            }
            else
            {
                rbOpaque.Enabled = true;
                rbMetallic.Enabled = true;
                rbNonMetallic.Enabled = true;
                if (!(rbOpaque.Checked || rbMetallic.Checked || rbNonMetallic.Checked))
                {
                    rbOpaque.Checked = true;
                }
            }
        }
        private void UpdateIndicators()
        {
            if (tpModule1.CanFocus)
            {
                pMotorStatus.BackgroundImage = _beltModule1.MotorOn ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pBusyStatus.BackgroundImage = _beltModule1.Busy ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pErrorStatus.BackgroundImage = _beltModule1.Error ?
                    ServerBeltIdentifier.Properties.Resources.red_led_on :
                    ServerBeltIdentifier.Properties.Resources.red_led_off;
                pOpaque.BackgroundImage = _beltModule1.Opaque ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pMetallic.BackgroundImage = _beltModule1.Metallic ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pNonMetallic.BackgroundImage = _beltModule1.NonMetallic ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                tbQuantityOpaque.Text = _beltModule1.QuantityOpaque.ToString();
                tbQuantityMetallic.Text = _beltModule1.QuantityMetallic.ToString();
                tbQuantityNonMetallic.Text = _beltModule1.QuantityNonMetallic.ToString();
            }
            else
            {
                pMotorStatus.BackgroundImage = _beltModule2.MotorOn ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pBusyStatus.BackgroundImage = _beltModule2.Busy ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pErrorStatus.BackgroundImage = _beltModule2.Error ?
                    ServerBeltIdentifier.Properties.Resources.red_led_on :
                    ServerBeltIdentifier.Properties.Resources.red_led_off;
                pBarrier1.BackgroundImage = _beltModule2.Barrier1 ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pBarrier2.BackgroundImage = _beltModule2.Barrier2 ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pBarrier3.BackgroundImage = _beltModule2.Barrier3 ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pPhotoSensor.BackgroundImage = _beltModule2.PhotoSensor ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                /* 
                 * Lógica abaixo diferente, devido os sensores capacitivos e 
                 * indutivos serem normalmente fechados (NF).
                */
                pCapacitive.BackgroundImage = _beltModule2.Capacitive ?
                    ServerBeltIdentifier.Properties.Resources.green_led_off :
                    ServerBeltIdentifier.Properties.Resources.green_led_on;
                pInductive.BackgroundImage = _beltModule2.Inductive ?
                    ServerBeltIdentifier.Properties.Resources.green_led_off :
                    ServerBeltIdentifier.Properties.Resources.green_led_on;
            }
        }
        private void timerAuto_Tick(object sender, EventArgs e)
        {
            if (rbAutomatic.Checked &&
                (_beltModule1.MotorOn || _beltModule2.MotorOn)
                && (!_beltModule1.Error && !_beltModule2.Error))
            {
                if (tpModule1.CanFocus)
                {
                    int speedMotor = rbSpeed1.Checked ? 1 : rbSpeed2.Checked ? 2 : rbSpeed3.Checked ? 3 : 4;
                    _beltModule1.AddPieceAuto(speedMotor);
                }
            }
        }
    }
}