using Opc.Ua;
using Opc.Ua.Configuration;
using Opc.Ua.Server;
using ServerBeltIdentifier.Models;

namespace BeltIdentifierServer
{
    public partial class ServerForm : Form
    {
        public static BeltIdentifierController BeltIdentifier;

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

            BeltIdentifier = new ServerBeltIdentifier.Models.BeltIdentifierController();
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus)
            {
                BeltIdentifier.IsModule1 = true;
            }
            else
            {
                BeltIdentifier.IsModule1 = false;
            }
            BeltIdentifier.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus)
            {
                BeltIdentifier.IsModule1 = true;
            }
            else
            {
                BeltIdentifier.IsModule1 = false;
            }
            BeltIdentifier.Stop();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            if (tpModule1.CanFocus && BeltIdentifier.IsError)
            {
                BeltIdentifier.IsModule1 = true;
                BeltIdentifier.Reset();
            }
            else if (tpModule2.CanFocus && BeltIdentifier.IsError)
            {
                BeltIdentifier.IsModule1 = false;
                BeltIdentifier.Reset();
            }
        }

        private void BtnAddPiece_Click(object sender, EventArgs e)
        {
            EPieceType pieceType = rbTransparent.Checked ? EPieceType.Transparent : rbMetallic.Checked ? EPieceType.Metallic : EPieceType.NonMetallic;

            if (tpModule1.CanFocus)
            {
                BeltIdentifier.IsModule1 = true;
            }
            else
            {
                BeltIdentifier.IsModule1 = false;
            }

            if (rbManual.Checked)
            {
                BeltIdentifier.AddPieceManual(pieceType);
            }
            else
            {
                BeltIdentifier.AddPieceAuto();
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
            if (BeltIdentifier.MotorOn)
            {
                btnStop.Enabled = true;
                btnStart.Enabled = false;
            }
            else
            {
                btnStop.Enabled = false;
                btnStart.Enabled = true;
            }

            if (BeltIdentifier.IsError)
            {
                btnReset.Enabled = true;
                btnStart.Enabled = false;
            }
            else
            {
                btnReset.Enabled = false;
            }

            if (BeltIdentifier.IsAuto)
            {
                rbAutomatic.Checked = true;
            }
            else
            {
                rbManual.Checked = true;
            }

            if (rbManual.Checked
                && !(BeltIdentifier.IsError)
                && (BeltIdentifier.MotorOn))
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
                BeltIdentifier.IsAuto = true;
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
                BeltIdentifier.IsAuto = false;
            }

            if (BeltIdentifier.IsModule1)
            {
                tbcModules.SelectedIndex = 0;
            }
            else
            {
                tbcModules.SelectedIndex = 1;
            }
        }

        private void UpdateIndicators()
        {
            pMotorStatus.BackgroundImage = BeltIdentifier.MotorOn ?
                ServerBeltIdentifier.Properties.Resources.green_led_on :
                ServerBeltIdentifier.Properties.Resources.green_led_off;
            pBusyStatus.BackgroundImage = BeltIdentifier.IsBusy ?
                ServerBeltIdentifier.Properties.Resources.green_led_on :
                ServerBeltIdentifier.Properties.Resources.green_led_off;
            pErrorStatus.BackgroundImage = BeltIdentifier.IsError ?
                ServerBeltIdentifier.Properties.Resources.red_led_on :
                ServerBeltIdentifier.Properties.Resources.red_led_off;

            if (tpModule1.CanFocus)
            {
                pTransparent.BackgroundImage = BeltIdentifier.Transparent ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pMetallic.BackgroundImage = BeltIdentifier.Metallic ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pNonMetallic.BackgroundImage = BeltIdentifier.NonMetallic ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                tbQuantityTransparent.Text = BeltIdentifier.QuantityTransparent.ToString();
                tbQuantityMetallic.Text = BeltIdentifier.QuantityMetallic.ToString();
                tbQuantityNonMetallic.Text = BeltIdentifier.QuantityNonMetallic.ToString();
            }
            else
            {
                pBarrier1.BackgroundImage = BeltIdentifier.Barrier1 ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pBarrier2.BackgroundImage = BeltIdentifier.Barrier2 ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pBarrier3.BackgroundImage = BeltIdentifier.Barrier3 ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                pPhotoSensor.BackgroundImage = BeltIdentifier.PhotoSensor ?
                    ServerBeltIdentifier.Properties.Resources.green_led_on :
                    ServerBeltIdentifier.Properties.Resources.green_led_off;
                /* 
                 * Lógica abaixo diferente, devido os sensores capacitivos e 
                 * indutivos serem normalmente fechados (NF).
                */
                pCapacitive.BackgroundImage = BeltIdentifier.Capacitive ?
                    ServerBeltIdentifier.Properties.Resources.green_led_off :
                    ServerBeltIdentifier.Properties.Resources.green_led_on;
                pInductive.BackgroundImage = BeltIdentifier.Inductive ?
                    ServerBeltIdentifier.Properties.Resources.green_led_off :
                    ServerBeltIdentifier.Properties.Resources.green_led_on;

                if (BeltIdentifier.IsAuto && !BeltIdentifier.IsModule1 && BeltIdentifier.MotorOn)
                {
                    switch (BeltIdentifier.PieceType)
                    {
                        case EPieceType.Transparent:
                            rbTransparent.Checked = true;
                            break;
                        case EPieceType.Metallic:
                            rbMetallic.Checked = true;
                            break;
                        case EPieceType.NonMetallic:
                            rbNonMetallic.Checked = true;
                            break;
                        default:
                            rbTransparent.Checked = false;
                            rbMetallic.Checked = false;
                            rbNonMetallic.Checked = false;
                            break;
                    }
                }
                else if (BeltIdentifier.IsAuto && !BeltIdentifier.IsModule1)
                {
                    rbTransparent.Checked = false;
                    rbMetallic.Checked = false;
                    rbNonMetallic.Checked = false;
                }
            }
        }

        private void UpadateControls()
        {
            tbInterval.Text = BeltIdentifier.Interval.ToString();
            tbJourneyTime.Text = BeltIdentifier.JourneyTime.ToString();
        }

        private void TimerUpdateForm_Tick(object sender, EventArgs e)
        {
            BeltIdentifier.ReadOpc();
            UpdateForm();
            BeltIdentifier.WriteOpc();
        }

        private void TimerMotor_Tick(object sender, EventArgs e)
        {
            if (rbAutomatic.Checked && BeltIdentifier.MotorOn && !BeltIdentifier.IsError)
            {
                timerAuto.Interval = (int)BeltIdentifier.Interval * 1000; // Para segundos.
                BeltIdentifier.AddPieceAuto();
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
                uint journey = Convert.ToUInt32(tbJourneyTime.Text);
                if (journey <= 0) throw new Exception();

                BeltIdentifier.JourneyTime = journey;
                BeltIdentifier.WriteOpc();
            }
            catch (Exception)
            {
                tbJourneyTime.Text = BeltIdentifier.JourneyTime.ToString();
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
                uint interval = Convert.ToUInt32(tbInterval.Text);
                if (interval <= 0) throw new Exception();
                BeltIdentifier.Interval = interval;
                BeltIdentifier.WriteOpc();
            }
            catch
            {
                tbInterval.Text = BeltIdentifier.Interval.ToString();
                MessageBox.Show("O valor informado é inválido, digite um número inteiro! Valor antigo restaurado.");
            }
            finally
            {
                timerUpdateForm.Enabled = true;
            }
        }

        private void RbManual_Enter(object sender, EventArgs e)
        {
            BeltIdentifier.IsAuto = false;
            BeltIdentifier.WriteOpc();
        }

        private void RbAutomatic_Enter(object sender, EventArgs e)
        {
            BeltIdentifier.IsAuto = true;
            BeltIdentifier.WriteOpc();
        }

        private void TbcModules_Selected(object sender, TabControlEventArgs e)
        {
            if (tpModule1.CanFocus)
            {
                BeltIdentifier.IsModule1 = false;
                BeltIdentifier.WriteOpc();
                UpdateForm();
            }
            else
            {
                BeltIdentifier.IsModule1 = true;
                BeltIdentifier.WriteOpc();
                UpdateForm();
            }
        }
    }
}