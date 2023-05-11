using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using ServerBeltIdentifier.Models;

namespace BeltIdentifierServer
{
    public partial class ServerForm : Form
    {
        public static BeltModule1 BeltModule1 = new();
        public static BeltModule2 BeltModule2 = new();

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

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus)
            {
                BeltModule1.Start();
            }
            else
            {
                BeltModule2.Start();
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus)
            {
                BeltModule1.Stop();
            }
            else
            {
                BeltModule2.Stop();
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus && BeltModule1.Error)
            {
                BeltModule1.Reset();
            }
            else if (tpModule2.CanFocus && BeltModule2.Error)
            {
                BeltModule2.Reset();
            }
        }

        private void BtnAddPiece_Click(object sender, EventArgs e)
        {
            string pieceType = rbTransparent.Checked ? "Transparent" : rbMetallic.Checked ? "Metallic" : "NonMetallic";

            if (tpModule1.CanFocus)
            {
                if (rbManual.Checked)
                {
                    BeltModule1.AddPieceManual(pieceType);
                }
                else
                {
                    BeltModule1.AddPieceAuto();
                }
            }
            else
            {
                if (rbManual.Checked)
                {
                    BeltModule2.AddPieceManual(pieceType);
                }
                else
                {
                    BeltModule2.AddPieceAuto();
                }
            }
        }

        private void UpdateForm()
        {
            UpdateButtons();
            UpdateIndicators();
            UpadateControls();
        }

        private void UpdateButtons()
        {
            if (BeltModule1.MotorOn || BeltModule2.MotorOn)
            {
                btnStop.Enabled = true;
                btnStart.Enabled = false;
            }
            else
            {
                btnStop.Enabled = false;
                btnStart.Enabled = true;
            }

            if (BeltModule1.Error || BeltModule2.Error)
            {
                btnReset.Enabled = true;
                btnStart.Enabled = false;
            }
            else
            {
                btnReset.Enabled = false;
            }

            if (rbManual.Checked
                && !(BeltModule1.Error || BeltModule2.Error)
                && (BeltModule1.MotorOn || BeltModule2.MotorOn))
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
                tbInterval.Enabled = true;
            }
            else
            {
                rbTransparent.Enabled = true;
                rbMetallic.Enabled = true;
                rbNonMetallic.Enabled = true;
                tbInterval.Enabled = false;
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
                pMotorStatus.BackgroundImage = BeltModule1.MotorOn ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pBusyStatus.BackgroundImage = BeltModule1.Busy ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pErrorStatus.BackgroundImage = BeltModule1.Error ?
                    ServerBeltIdentifier.Properties.Resources.red_led_on :
                    ServerBeltIdentifier.Properties.Resources.red_led_off;
                pTransparent.BackgroundImage = BeltModule1.Transparent ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pMetallic.BackgroundImage = BeltModule1.Metallic ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pNonMetallic.BackgroundImage = BeltModule1.NonMetallic ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                tbQuantityTransparent.Text = BeltModule1.QuantityTransparent.ToString();
                tbQuantityMetallic.Text = BeltModule1.QuantityMetallic.ToString();
                tbQuantityNonMetallic.Text = BeltModule1.QuantityNonMetallic.ToString();
            }
            else
            {
                pMotorStatus.BackgroundImage = BeltModule2.MotorOn ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pBusyStatus.BackgroundImage = BeltModule2.Busy ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pErrorStatus.BackgroundImage = BeltModule2.Error ?
                    ServerBeltIdentifier.Properties.Resources.red_led_on :
                    ServerBeltIdentifier.Properties.Resources.red_led_off;
                pBarrier1.BackgroundImage = BeltModule2.Barrier1 ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pBarrier2.BackgroundImage = BeltModule2.Barrier2 ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pBarrier3.BackgroundImage = BeltModule2.Barrier3 ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pPhotoSensor.BackgroundImage = BeltModule2.PhotoSensor ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                /* 
                 * Lógica abaixo diferente, devido os sensores capacitivos e 
                 * indutivos serem normalmente fechados (NF).
                */
                pCapacitive.BackgroundImage = BeltModule2.Capacitive ?
                    ServerBeltIdentifier.Properties.Resources.green_led_off :
                    ServerBeltIdentifier.Properties.Resources.green_led_on;
                pInductive.BackgroundImage = BeltModule2.Inductive ?
                    ServerBeltIdentifier.Properties.Resources.green_led_off :
                    ServerBeltIdentifier.Properties.Resources.green_led_on;

                if (rbAutomatic.Checked && tpModule2.CanFocus)
                {
                    switch (BeltModule2.PieceType)
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

        private void UpadateControls()
        {
            if (tpModule1.CanFocus)
            {
                tbInterval.Text = BeltModule1.Interval.ToString();
                tbJourneyTime.Text = BeltModule1.JourneyTime.ToString();
            }
            else
            {
                tbInterval.Text = BeltModule2.Interval.ToString();
                tbJourneyTime.Text = BeltModule2.JourneyTime.ToString();
            }
        }

        private void TimerUpdateForm_Tick(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus)
            {
                BeltModule1.ReadOpc();
            }
            else
            {
                BeltModule2.ReadOpc();
            }
            UpdateForm();
        }

        private void TimerModule1_Tick(object sender, EventArgs e)
        {
            if (rbAutomatic.Checked && BeltModule1.MotorOn && !BeltModule1.Error && tpModule1.CanFocus)
            {
                timerAutoModule1.Interval = BeltModule1.Interval * 1000; // Para segundos.
                BeltModule1.AddPieceAuto();
            }
        }

        private void TimerAutoModule2_Tick(object sender, EventArgs e)
        {
            if (rbAutomatic.Checked && BeltModule2.MotorOn && !BeltModule2.Error && tpModule2.CanFocus)
            {
                timerAutoModule2.Interval = (BeltModule2.Interval * 1000) + 1000;
                BeltModule2.AddPieceAuto();
            }
        }

        private void TbJourneyTime_Enter(object sender, EventArgs e)
        {
            timerUpdateForm.Enabled = false;
        }

        private void TbInterval_Enter(object sender, EventArgs e)
        {
            timerUpdateForm.Enabled = false;
        }

        private void TbJourneyTime_Leave(object sender, EventArgs e)
        {
            try
            {
                int journey = Convert.ToInt16(tbJourneyTime.Text);
                if (journey <= 0) throw new Exception();

                BeltModule1.JourneyTime = journey;
                BeltModule2.JourneyTime = journey;
                BeltModule1.WriteOpc();
                BeltModule2.WriteOpc();
            }
            catch (Exception)
            {
                tbJourneyTime.Text = BeltModule1.JourneyTime.ToString();
                MessageBox.Show("O valor informado é inválido, digite um número inteiro maior que 0! Valor antigo restaurado.");
            }
            finally
            {
                timerUpdateForm.Enabled = true;
            }
        }

        private void TbInterval_Leave(object sender, EventArgs e)
        {
            try
            {
                int interval = Convert.ToInt16(tbInterval.Text);
                if (interval <= 0) throw new Exception();
                BeltModule1.Interval = interval;
                BeltModule2.Interval = interval;
            }
            catch
            {
                tbInterval.Text = BeltModule1.Interval.ToString();
                MessageBox.Show("O valor informado é inválido, digite um número inteiro! Valor antigo restaurado.");
            }
            finally
            {
                timerUpdateForm.Enabled = true;
            }
        }
    }
}