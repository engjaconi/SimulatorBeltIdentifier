using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using ServerBeltIdentifier.Models;

namespace BeltIdentifierServer
{
    public partial class ServerForm : Form
    {
        public static BeltModule1 beltModule1 = new();
        public static BeltModule2 beltModule2 = new();

        public ServerForm()
        {
            InitializeComponent();
        }

        public ServerForm(ApplicationInstance application)
        {
            InitializeComponent();

            StandardServer server = application.Server as StandardServer;

            // Insere a URL na caixa de texto.
            cbServerUrl.Items.Clear();

            foreach (EndpointDescription endpoint in server.GetEndpoints())
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

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus)
            {
                beltModule1.Start();
            }
            else
            {
                beltModule2.Start();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus)
            {
                beltModule1.Stop();
            }
            else
            {
                beltModule2.Stop();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus && beltModule1.Error)
            {
                beltModule1.Reset();
            }
            else if (tpModule2.CanFocus && beltModule2.Error)
            {
                beltModule2.Reset();
            }
        }

        private void BtnAddPiece_Click(object sender, EventArgs e)
        {
            string pieceType = rbTransparent.Checked ? "Transparent" : rbMetallic.Checked ? "Metallic" : "NonMetallic";
            int speedMotor = rbSpeed1.Checked ? 1 : rbSpeed2.Checked ? 2 : rbSpeed3.Checked ? 3 : 4;

            if (tpModule1.CanFocus)
            {
                if (rbManual.Checked)
                {
                    beltModule1.AddPieceManual(pieceType, speedMotor);
                }
                else
                {
                    beltModule1.AddPieceAuto(speedMotor);
                }
            }
            else
            {
                if (rbManual.Checked)
                {
                    beltModule2.AddPieceManual(pieceType, speedMotor);
                }
                else
                {
                    beltModule2.AddPieceAuto(speedMotor);
                }
            }
        }

        private void UpdateForm()
        {
            UpdateButtons();
            UpdateIndicators();
        }

        private void UpdateButtons()
        {
            if (beltModule1.MotorOn || beltModule2.MotorOn)
            {
                btnStop.Enabled = true;
                btnStart.Enabled = false;
            }
            else
            {
                btnStop.Enabled = false;
                btnStart.Enabled = true;
            }

            if (beltModule1.Error || beltModule2.Error)
            {
                btnReset.Enabled = true;
                btnStart.Enabled = false;
            }
            else
            {
                btnReset.Enabled = false;
            }

            if (rbManual.Checked
                && !(beltModule1.Error || beltModule2.Error)
                && (beltModule1.MotorOn || beltModule2.MotorOn))
            {
                btnAddPiece.Enabled = true;
            }
            else
            {
                btnAddPiece.Enabled = false;
            }

            if (rbAutomatic.Checked)
            {
                rbTransparent.Enabled = false;
                rbMetallic.Enabled = false;
                rbNonMetallic.Enabled = false;
                rbTransparent.Checked = false;
                rbMetallic.Checked = false;
                rbNonMetallic.Checked = false;
            }
            else
            {
                rbTransparent.Enabled = true;
                rbMetallic.Enabled = true;
                rbNonMetallic.Enabled = true;
                if (!(rbTransparent.Checked || rbMetallic.Checked || rbNonMetallic.Checked))
                {
                    rbTransparent.Checked = true;
                }
            }
        }

        private void UpdateIndicators()
        {
            if (tpModule1.CanFocus)
            {
                pMotorStatus.BackgroundImage = beltModule1.MotorOn ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pBusyStatus.BackgroundImage = beltModule1.Busy ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pErrorStatus.BackgroundImage = beltModule1.Error ?
                    ServerBeltIdentifier.Properties.Resources.red_led_on :
                    ServerBeltIdentifier.Properties.Resources.red_led_off;
                pTransparent.BackgroundImage = beltModule1.Transparent ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pMetallic.BackgroundImage = beltModule1.Metallic ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pNonMetallic.BackgroundImage = beltModule1.NonMetallic ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                tbQuantityTransparent.Text = beltModule1.QuantityTransparent.ToString();
                tbQuantityMetallic.Text = beltModule1.QuantityMetallic.ToString();
                tbQuantityNonMetallic.Text = beltModule1.QuantityNonMetallic.ToString();
            }
            else
            {
                pMotorStatus.BackgroundImage = beltModule2.MotorOn ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pBusyStatus.BackgroundImage = beltModule2.Busy ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pErrorStatus.BackgroundImage = beltModule2.Error ?
                    ServerBeltIdentifier.Properties.Resources.red_led_on :
                    ServerBeltIdentifier.Properties.Resources.red_led_off;
                pBarrier1.BackgroundImage = beltModule2.Barrier1 ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pBarrier2.BackgroundImage = beltModule2.Barrier2 ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pBarrier3.BackgroundImage = beltModule2.Barrier3 ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pPhotoSensor.BackgroundImage = beltModule2.PhotoSensor ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                /* 
                 * Lógica abaixo diferente, devido os sensores capacitivos e 
                 * indutivos serem normalmente fechados (NF).
                */
                pCapacitive.BackgroundImage = beltModule2.Capacitive ?
                    ServerBeltIdentifier.Properties.Resources.green_led_off :
                    ServerBeltIdentifier.Properties.Resources.green_led_on;
                pInductive.BackgroundImage = beltModule2.Inductive ?
                    ServerBeltIdentifier.Properties.Resources.green_led_off :
                    ServerBeltIdentifier.Properties.Resources.green_led_on;

                if (rbAutomatic.Checked && tpModule2.CanFocus)
                {
                    switch (beltModule2.PieceType)
                    {
                        case "Transparent":
                            rbTransparent.Checked = true;
                            break;
                        case "Metallic":
                            rbMetallic.Checked = true;
                            break;
                        case "NonMetallic":
                            rbNonMetallic.Checked = true;
                            break;
                        default:
                            rbTransparent.Checked = false;
                            rbMetallic.Checked = false;
                            rbNonMetallic.Checked = false;
                            break;
                    }
                }
            }
        }

        private void TimerUpdateForm_Tick(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus)
            {
                beltModule1.ReadOpc();
            }
            else
            {
                beltModule2.ReadOpc();
            }

            UpdateForm();
        }

        private void TimerModule1_Tick(object sender, EventArgs e)
        {
            if (rbAutomatic.Checked && beltModule1.MotorOn && !beltModule1.Error && tpModule1.CanFocus)
            {
                int speedMotor = rbSpeed1.Checked ? 1 : rbSpeed2.Checked ? 2 : rbSpeed3.Checked ? 3 : 4;
                timerAutoModule1.Interval = (speedMotor * 1000) + 1000; // Intervalo entre cada peça será de 1s.
                beltModule1.AddPieceAuto(speedMotor);
            }
        }

        private void TimerAutoModule2_Tick(object sender, EventArgs e)
        {
            if (rbAutomatic.Checked && beltModule2.MotorOn && !beltModule2.Error && tpModule2.CanFocus)
            {
                int speedMotor = rbSpeed1.Checked ? 1 : rbSpeed2.Checked ? 2 : rbSpeed3.Checked ? 3 : 4;
                timerAutoModule2.Interval = (speedMotor * 6000) + 1000; // Intervalo entre cada sensor será de 1s.

                beltModule2.AddPieceAuto(speedMotor);
            }
        }
    }
}