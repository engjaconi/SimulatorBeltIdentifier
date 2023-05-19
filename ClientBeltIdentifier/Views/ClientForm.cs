using ClientBeltIdentifier.Models;
using Opc.Ua;
using Opc.Ua.Client;
using Opc.Ua.Configuration;

namespace ClientBeltIdentifier
{
    public partial class ClientForm : Form
    {
        private readonly ApplicationInstance? Application;
        private Session? Session;
        private BeltIdentifier? BeltIdentifier;

        public ClientForm() { }

        public ClientForm(ApplicationInstance application)
        {
            Application = application;
            InitializeComponent();
        }

        private void BtnConect_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedEndpoint = CoreClientUtils.SelectEndpoint(tbServerUrl.Text, useSecurity: true);
                Session = Session.Create(Application.ApplicationConfiguration, new ConfiguredEndpoint(null, selectedEndpoint, EndpointConfiguration.Create(Application.ApplicationConfiguration)), false, "", 60000, null, null).GetAwaiter().GetResult();
                BeltIdentifier = new(Session);

                btnStart.Enabled = true;
                timerUpdateForm.Enabled = true;
                timerAuto.Enabled = true;
            }
            catch
            {
                tbServerUrl.Focus();
                MessageBox.Show("Url informada não é válida ou o servidor está desligado!");
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
            EPieceType pieceType = 
                rbTransparent.Checked ? EPieceType.Transparent : rbMetallic.Checked ? EPieceType.Metallic : EPieceType.NonMetallic;

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
                ClientBeltIdentifier.Properties.Resources.green_led_on :
                ClientBeltIdentifier.Properties.Resources.green_led_off;
            pBusyStatus.BackgroundImage = BeltIdentifier.IsBusy ?
                ClientBeltIdentifier.Properties.Resources.green_led_on :
                ClientBeltIdentifier.Properties.Resources.green_led_off;
            pErrorStatus.BackgroundImage = BeltIdentifier.IsError ?
                ClientBeltIdentifier.Properties.Resources.red_led_on :
                ClientBeltIdentifier.Properties.Resources.red_led_off;

            if (tpModule1.CanFocus)
            {
                pTransparent.BackgroundImage = BeltIdentifier.Transparent ?
                    ClientBeltIdentifier.Properties.Resources.green_led_on :
                    ClientBeltIdentifier.Properties.Resources.green_led_off;
                pMetallic.BackgroundImage = BeltIdentifier.Metallic ?
                    ClientBeltIdentifier.Properties.Resources.green_led_on :
                    ClientBeltIdentifier.Properties.Resources.green_led_off;
                pNonMetallic.BackgroundImage = BeltIdentifier.NonMetallic ?
                    ClientBeltIdentifier.Properties.Resources.green_led_on :
                    ClientBeltIdentifier.Properties.Resources.green_led_off;
                tbQuantityTransparent.Text = BeltIdentifier.QuantityTransparent.ToString();
                tbQuantityMetallic.Text = BeltIdentifier.QuantityMetallic.ToString();
                tbQuantityNonMetallic.Text = BeltIdentifier.QuantityNonMetallic.ToString();
            }
            else
            {
                pBarrier1.BackgroundImage = BeltIdentifier.Barrier1 ?
                    ClientBeltIdentifier.Properties.Resources.green_led_on :
                    ClientBeltIdentifier.Properties.Resources.green_led_off;
                pBarrier2.BackgroundImage = BeltIdentifier.Barrier2 ?
                    ClientBeltIdentifier.Properties.Resources.green_led_on :
                    ClientBeltIdentifier.Properties.Resources.green_led_off;
                pBarrier3.BackgroundImage = BeltIdentifier.Barrier3 ?
                    ClientBeltIdentifier.Properties.Resources.green_led_on :
                    ClientBeltIdentifier.Properties.Resources.green_led_off;
                pPhotoSensor.BackgroundImage = BeltIdentifier.PhotoSensor ?
                    ClientBeltIdentifier.Properties.Resources.green_led_on :
                    ClientBeltIdentifier.Properties.Resources.green_led_off;
                /* 
                 * Lógica abaixo diferente, devido os sensores capacitivos e 
                 * indutivos serem normalmente fechados (NF).
                */
                pCapacitive.BackgroundImage = BeltIdentifier.Capacitive ?
                    ClientBeltIdentifier.Properties.Resources.green_led_off :
                    ClientBeltIdentifier.Properties.Resources.green_led_on;
                pInductive.BackgroundImage = BeltIdentifier.Inductive ?
                    ClientBeltIdentifier.Properties.Resources.green_led_off :
                    ClientBeltIdentifier.Properties.Resources.green_led_on;

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
            //BeltIdentifier.WriteOpc();
        }

        private void TimerMotor_Tick(object sender, EventArgs e)
        {
            if (rbAutomatic.Checked && BeltIdentifier.MotorOn && !BeltIdentifier.IsError)
            {
                timerAuto.Interval = (int)BeltIdentifier.Interval * 1000; // Para segundos.
                //BeltIdentifier.AddPieceAuto();
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
                //BeltIdentifier.WriteOpc();
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
                //BeltIdentifier.WriteOpc();
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
            //BeltIdentifier.WriteOpc();
        }

        private void RbAutomatic_Enter(object sender, EventArgs e)
        {
            BeltIdentifier.IsAuto = true;
            // BeltIdentifier.WriteOpc();
        }

        private void TbcModules_Selected(object sender, TabControlEventArgs e)
        {
            if (tpModule1.CanFocus)
            {
                BeltIdentifier.IsModule1 = false;
                //BeltIdentifier.WriteOpc();
                UpdateForm();
            }
            else
            {
                BeltIdentifier.IsModule1 = true;
                // BeltIdentifier.WriteOpc();
                UpdateForm();
            }
        }
    }
}