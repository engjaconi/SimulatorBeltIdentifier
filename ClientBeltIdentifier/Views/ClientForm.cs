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
        private Belt BeltIdentifier;

        public ClientForm() { }

        public ClientForm(ApplicationInstance application)
        {
            Application = application;
            InitializeComponent();
        }

        private void BtnConect_Click(object sender, EventArgs e)
        {
            if (Session == null || !Session.Connected)
            {
                try
                {
                    var selectedEndpoint = CoreClientUtils.SelectEndpoint(tbServerUrl.Text, useSecurity: true);
                    Session = Session.Create(Application.ApplicationConfiguration, new ConfiguredEndpoint(null, selectedEndpoint, EndpointConfiguration.Create(Application.ApplicationConfiguration)), false, "", 60000, null, null).GetAwaiter().GetResult();
                    BeltIdentifier = Belt.GetInstance(Session);

                    btnStart.Enabled = true;
                    timerUpdateForm.Enabled = true;
                    btnConect.Text = "Desconectar";
                    btnConect.BackColor = Color.LightSalmon;
                }
                catch
                {
                    tbServerUrl.Focus();
                    MessageBox.Show("Url informada não é válida ou o servidor está desligado!");
                }
            }
            else
            {
                btnConect.Text = "Conectar";
                btnConect.BackColor = Color.LightGreen;
                btnStart.Enabled = false;
                btnStop.Enabled = false;
                btnReset.Enabled = false;
                timerUpdateForm.Enabled = false;
                Session.Close();
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            BeltIdentifier.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            BeltIdentifier.Stop();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            BeltIdentifier.Reset();
        }

        private void UpdateForm()
        {
            UpdateButtons();
            UpdateIndicators();
        }

        private void UpdateButtons()
        {
            if (BeltIdentifier.MotorOn)
            {
                btnStop.Enabled = true;
                btnStart.Enabled = false;
            }
            else if (Session.Connected)
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

            if (rbAutomatic.Checked)
            {
                BeltIdentifier.IsAuto = true;
            }
            else
            {
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
                Properties.Resources.green_led_on :
                Properties.Resources.green_led_off;
            pBusyStatus.BackgroundImage = BeltIdentifier.IsBusy ?
                Properties.Resources.green_led_on :
                Properties.Resources.green_led_off;
            pErrorStatus.BackgroundImage = BeltIdentifier.IsError ?
                Properties.Resources.red_led_on :
                Properties.Resources.red_led_off;

            if (BeltIdentifier.IsModule1)
            {
                pTransparent.BackgroundImage = BeltIdentifier.Transparent ?
                    Properties.Resources.green_led_on :
                    Properties.Resources.green_led_off;
                pMetallic.BackgroundImage = BeltIdentifier.Metallic ?
                    Properties.Resources.green_led_on :
                    Properties.Resources.green_led_off;
                pNonMetallic.BackgroundImage = BeltIdentifier.NonMetallic ?
                    Properties.Resources.green_led_on :
                    Properties.Resources.green_led_off;
                tbQuantityTransparent.Text = BeltIdentifier.TransparentQuantity.ToString();
                tbQuantityMetallic.Text = BeltIdentifier.MetallicQuantity.ToString();
                tbQuantityNonMetallic.Text = BeltIdentifier.NonMetallicQuantity.ToString();
            }
            else
            {
                pBarrier1.BackgroundImage = BeltIdentifier.Barrier1 ?
                    Properties.Resources.green_led_on :
                    Properties.Resources.green_led_off;
                pBarrier2.BackgroundImage = BeltIdentifier.Barrier2 ?
                    Properties.Resources.green_led_on :
                    Properties.Resources.green_led_off;
                pBarrier3.BackgroundImage = BeltIdentifier.Barrier3 ?
                    Properties.Resources.green_led_on :
                    Properties.Resources.green_led_off;
                pPhotoSensor.BackgroundImage = BeltIdentifier.PhotoSensor ?
                    Properties.Resources.green_led_on :
                    Properties.Resources.green_led_off;
                /* 
                 * Lógica abaixo diferente, devido os sensores capacitivos e 
                 * indutivos serem normalmente fechados (NF).
                */
                pCapacitive.BackgroundImage = BeltIdentifier.Capacitive ?
                    Properties.Resources.green_led_off :
                    Properties.Resources.green_led_on;
                pInductive.BackgroundImage = BeltIdentifier.Inductive ?
                    Properties.Resources.green_led_off :
                    Properties.Resources.green_led_on;
            }
        }

        private void TimerUpdateForm_Tick(object sender, EventArgs e)
        {
            if (!Session.Connected)
            {
                btnConect.Text = "Conectar";
                btnConect.BackColor = Color.LightGreen;
                btnStart.Enabled = false;
                btnStop.Enabled = false;
                btnReset.Enabled = false;
                BeltIdentifier.MotorOn = false;
                BeltIdentifier.IsBusy = false;
                BeltIdentifier.IsError = false;
                BeltIdentifier.Transparent = false;
                BeltIdentifier.Metallic = false;
                BeltIdentifier.NonMetallic = false;
                BeltIdentifier.Barrier1 = false;
                BeltIdentifier.Barrier2 = false;
                BeltIdentifier.Barrier3 = false;
                BeltIdentifier.PhotoSensor = false;
                BeltIdentifier.Capacitive = true;
                BeltIdentifier.Inductive = true;
                Session.Close();
            } else
            {
                BeltIdentifier.ReadOpc();
            }
            UpdateForm();
        }
    }
}