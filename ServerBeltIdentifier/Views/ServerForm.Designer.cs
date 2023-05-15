using ServerBeltIdentifier.Models;

namespace BeltIdentifierServer
{
    partial class ServerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            cbServerUrl = new ComboBox();
            lblServerUrl = new Label();
            btnStart = new Button();
            btnStop = new Button();
            timerUpdateForm = new System.Windows.Forms.Timer(components);
            tbcModules = new TabControl();
            tpModule1 = new TabPage();
            gbOpcStatusModule1 = new GroupBox();
            tbQuantityNonMetallic = new TextBox();
            lblNonMetallic = new Label();
            tbQuantityMetallic = new TextBox();
            lblMetallic = new Label();
            tbQuantityTransparent = new TextBox();
            lblTransparent = new Label();
            pNonMetallic = new Panel();
            pMetallic = new Panel();
            pTransparent = new Panel();
            tpModule2 = new TabPage();
            gbOpcStatusModule2 = new GroupBox();
            lblBarrier3 = new Label();
            lblInductive = new Label();
            pBarrier3 = new Panel();
            lblCapacitive = new Label();
            lblPhotoSensor = new Label();
            pInductive = new Panel();
            pPhotoSensor = new Panel();
            pCapacitive = new Panel();
            lblBarrier2 = new Label();
            lblBarrier1 = new Label();
            pBarrier2 = new Panel();
            pBarrier1 = new Panel();
            btnAddPiece = new Button();
            gbTypePiece = new GroupBox();
            rbNonMetallic = new RadioButton();
            rbMetallic = new RadioButton();
            rbTransparent = new RadioButton();
            gbControlType = new GroupBox();
            rbAutomatic = new RadioButton();
            rbManual = new RadioButton();
            gbBeltTimes = new GroupBox();
            tbInterval = new TextBox();
            lblInterval = new Label();
            lblJourneyTime = new Label();
            tbJourneyTime = new TextBox();
            gbBeltStatus = new GroupBox();
            lblErrorStatus = new Label();
            pErrorStatus = new Panel();
            lblBusyStatus = new Label();
            pBusyStatus = new Panel();
            pMotorStatus = new Panel();
            lblMotor = new Label();
            btnReset = new Button();
            timerAutoModule1 = new System.Windows.Forms.Timer(components);
            timerAutoModule2 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tbcModules.SuspendLayout();
            tpModule1.SuspendLayout();
            gbOpcStatusModule1.SuspendLayout();
            tpModule2.SuspendLayout();
            gbOpcStatusModule2.SuspendLayout();
            gbTypePiece.SuspendLayout();
            gbControlType.SuspendLayout();
            gbBeltTimes.SuspendLayout();
            gbBeltStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // cbServerUrl
            // 
            cbServerUrl.DropDownStyle = ComboBoxStyle.Simple;
            cbServerUrl.FormattingEnabled = true;
            cbServerUrl.Location = new Point(138, 12);
            cbServerUrl.Margin = new Padding(3, 4, 3, 4);
            cbServerUrl.Name = "cbServerUrl";
            cbServerUrl.Size = new Size(531, 28);
            cbServerUrl.TabIndex = 0;
            // 
            // lblServerUrl
            // 
            lblServerUrl.AutoSize = true;
            lblServerUrl.Location = new Point(16, 16);
            lblServerUrl.Name = "lblServerUrl";
            lblServerUrl.Size = new Size(120, 20);
            lblServerUrl.TabIndex = 1;
            lblServerUrl.Text = "URL do Servidor ";
            lblServerUrl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatAppearance.MouseDownBackColor = Color.Red;
            btnStart.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnStart.Location = new Point(16, 203);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(149, 60);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(170, 203);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(149, 60);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += BtnStop_Click;
            // 
            // timerUpdateForm
            // 
            timerUpdateForm.Enabled = true;
            timerUpdateForm.Tick += TimerUpdateForm_Tick;
            // 
            // tbcModules
            // 
            tbcModules.Controls.Add(tpModule1);
            tbcModules.Controls.Add(tpModule2);
            tbcModules.Location = new Point(326, 203);
            tbcModules.Name = "tbcModules";
            tbcModules.SelectedIndex = 0;
            tbcModules.Size = new Size(473, 304);
            tbcModules.TabIndex = 5;
            // 
            // tpModule1
            // 
            tpModule1.Controls.Add(gbOpcStatusModule1);
            tpModule1.Location = new Point(4, 29);
            tpModule1.Name = "tpModule1";
            tpModule1.Padding = new Padding(3);
            tpModule1.Size = new Size(465, 271);
            tpModule1.TabIndex = 1;
            tpModule1.Text = "Módulo 1";
            tpModule1.UseVisualStyleBackColor = true;
            // 
            // gbOpcStatusModule1
            // 
            gbOpcStatusModule1.BackColor = Color.WhiteSmoke;
            gbOpcStatusModule1.Controls.Add(tbQuantityNonMetallic);
            gbOpcStatusModule1.Controls.Add(lblNonMetallic);
            gbOpcStatusModule1.Controls.Add(tbQuantityMetallic);
            gbOpcStatusModule1.Controls.Add(lblMetallic);
            gbOpcStatusModule1.Controls.Add(tbQuantityTransparent);
            gbOpcStatusModule1.Controls.Add(lblTransparent);
            gbOpcStatusModule1.Controls.Add(pNonMetallic);
            gbOpcStatusModule1.Controls.Add(pMetallic);
            gbOpcStatusModule1.Controls.Add(pTransparent);
            gbOpcStatusModule1.Location = new Point(6, 5);
            gbOpcStatusModule1.Name = "gbOpcStatusModule1";
            gbOpcStatusModule1.Size = new Size(451, 256);
            gbOpcStatusModule1.TabIndex = 2;
            gbOpcStatusModule1.TabStop = false;
            gbOpcStatusModule1.Text = "Estado das variáveis disponibilizadas via OPC";
            // 
            // tbQuantityNonMetallic
            // 
            tbQuantityNonMetallic.Location = new Point(338, 140);
            tbQuantityNonMetallic.Name = "tbQuantityNonMetallic";
            tbQuantityNonMetallic.ReadOnly = true;
            tbQuantityNonMetallic.Size = new Size(86, 27);
            tbQuantityNonMetallic.TabIndex = 8;
            // 
            // lblNonMetallic
            // 
            lblNonMetallic.AutoSize = true;
            lblNonMetallic.Location = new Point(334, 111);
            lblNonMetallic.Name = "lblNonMetallic";
            lblNonMetallic.Size = new Size(98, 20);
            lblNonMetallic.TabIndex = 7;
            lblNonMetallic.Text = "Não Metálica";
            // 
            // tbQuantityMetallic
            // 
            tbQuantityMetallic.Location = new Point(181, 140);
            tbQuantityMetallic.Name = "tbQuantityMetallic";
            tbQuantityMetallic.ReadOnly = true;
            tbQuantityMetallic.Size = new Size(86, 27);
            tbQuantityMetallic.TabIndex = 6;
            // 
            // lblMetallic
            // 
            lblMetallic.AutoSize = true;
            lblMetallic.Location = new Point(191, 111);
            lblMetallic.Name = "lblMetallic";
            lblMetallic.Size = new Size(66, 20);
            lblMetallic.TabIndex = 5;
            lblMetallic.Text = "Metálica";
            // 
            // tbQuantityTransparent
            // 
            tbQuantityTransparent.Location = new Point(17, 140);
            tbQuantityTransparent.Name = "tbQuantityTransparent";
            tbQuantityTransparent.ReadOnly = true;
            tbQuantityTransparent.Size = new Size(86, 27);
            tbQuantityTransparent.TabIndex = 4;
            // 
            // lblTransparent
            // 
            lblTransparent.AutoSize = true;
            lblTransparent.Location = new Point(13, 111);
            lblTransparent.Name = "lblTransparent";
            lblTransparent.Size = new Size(94, 20);
            lblTransparent.TabIndex = 3;
            lblTransparent.Text = "Transparente";
            // 
            // pNonMetallic
            // 
            pNonMetallic.BackColor = Color.Transparent;
            pNonMetallic.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pNonMetallic.BackgroundImageLayout = ImageLayout.Stretch;
            pNonMetallic.Location = new Point(357, 52);
            pNonMetallic.Name = "pNonMetallic";
            pNonMetallic.Size = new Size(50, 51);
            pNonMetallic.TabIndex = 2;
            // 
            // pMetallic
            // 
            pMetallic.BackColor = Color.Transparent;
            pMetallic.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pMetallic.BackgroundImageLayout = ImageLayout.Stretch;
            pMetallic.Location = new Point(197, 52);
            pMetallic.Name = "pMetallic";
            pMetallic.Size = new Size(50, 51);
            pMetallic.TabIndex = 2;
            // 
            // pTransparent
            // 
            pTransparent.BackColor = Color.Transparent;
            pTransparent.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pTransparent.BackgroundImageLayout = ImageLayout.Stretch;
            pTransparent.Location = new Point(34, 52);
            pTransparent.Name = "pTransparent";
            pTransparent.Size = new Size(50, 51);
            pTransparent.TabIndex = 1;
            // 
            // tpModule2
            // 
            tpModule2.Controls.Add(gbOpcStatusModule2);
            tpModule2.Location = new Point(4, 29);
            tpModule2.Name = "tpModule2";
            tpModule2.Padding = new Padding(3);
            tpModule2.Size = new Size(465, 271);
            tpModule2.TabIndex = 0;
            tpModule2.Text = "Módulo 2";
            tpModule2.UseVisualStyleBackColor = true;
            // 
            // gbOpcStatusModule2
            // 
            gbOpcStatusModule2.Controls.Add(lblBarrier3);
            gbOpcStatusModule2.Controls.Add(lblInductive);
            gbOpcStatusModule2.Controls.Add(pBarrier3);
            gbOpcStatusModule2.Controls.Add(lblCapacitive);
            gbOpcStatusModule2.Controls.Add(lblPhotoSensor);
            gbOpcStatusModule2.Controls.Add(pInductive);
            gbOpcStatusModule2.Controls.Add(pPhotoSensor);
            gbOpcStatusModule2.Controls.Add(pCapacitive);
            gbOpcStatusModule2.Controls.Add(lblBarrier2);
            gbOpcStatusModule2.Controls.Add(lblBarrier1);
            gbOpcStatusModule2.Controls.Add(pBarrier2);
            gbOpcStatusModule2.Controls.Add(pBarrier1);
            gbOpcStatusModule2.Location = new Point(6, 5);
            gbOpcStatusModule2.Name = "gbOpcStatusModule2";
            gbOpcStatusModule2.Size = new Size(451, 245);
            gbOpcStatusModule2.TabIndex = 0;
            gbOpcStatusModule2.TabStop = false;
            gbOpcStatusModule2.Text = "Estado das variáveis disponibilizadas via OPC";
            // 
            // lblBarrier3
            // 
            lblBarrier3.AutoSize = true;
            lblBarrier3.Location = new Point(339, 208);
            lblBarrier3.Name = "lblBarrier3";
            lblBarrier3.Size = new Size(73, 20);
            lblBarrier3.TabIndex = 11;
            lblBarrier3.Text = "Barreira 3";
            // 
            // lblInductive
            // 
            lblInductive.AutoSize = true;
            lblInductive.Location = new Point(203, 208);
            lblInductive.Name = "lblInductive";
            lblInductive.Size = new Size(63, 20);
            lblInductive.TabIndex = 11;
            lblInductive.Text = "Indutivo";
            // 
            // pBarrier3
            // 
            pBarrier3.BackColor = Color.Transparent;
            pBarrier3.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pBarrier3.BackgroundImageLayout = ImageLayout.Stretch;
            pBarrier3.Location = new Point(350, 149);
            pBarrier3.Name = "pBarrier3";
            pBarrier3.Size = new Size(50, 51);
            pBarrier3.TabIndex = 10;
            // 
            // lblCapacitive
            // 
            lblCapacitive.AutoSize = true;
            lblCapacitive.Location = new Point(53, 208);
            lblCapacitive.Name = "lblCapacitive";
            lblCapacitive.Size = new Size(79, 20);
            lblCapacitive.TabIndex = 7;
            lblCapacitive.Text = "Capacitivo";
            // 
            // lblPhotoSensor
            // 
            lblPhotoSensor.AutoSize = true;
            lblPhotoSensor.Location = new Point(347, 93);
            lblPhotoSensor.Name = "lblPhotoSensor";
            lblPhotoSensor.Size = new Size(89, 20);
            lblPhotoSensor.TabIndex = 9;
            lblPhotoSensor.Text = "Fotoelétrico";
            // 
            // pInductive
            // 
            pInductive.BackColor = Color.Transparent;
            pInductive.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pInductive.BackgroundImageLayout = ImageLayout.Stretch;
            pInductive.Location = new Point(205, 149);
            pInductive.Name = "pInductive";
            pInductive.Size = new Size(50, 51);
            pInductive.TabIndex = 10;
            // 
            // pPhotoSensor
            // 
            pPhotoSensor.BackColor = Color.Transparent;
            pPhotoSensor.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pPhotoSensor.BackgroundImageLayout = ImageLayout.Stretch;
            pPhotoSensor.Location = new Point(350, 35);
            pPhotoSensor.Name = "pPhotoSensor";
            pPhotoSensor.Size = new Size(50, 51);
            pPhotoSensor.TabIndex = 8;
            // 
            // pCapacitive
            // 
            pCapacitive.BackColor = Color.Transparent;
            pCapacitive.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pCapacitive.BackgroundImageLayout = ImageLayout.Stretch;
            pCapacitive.Location = new Point(55, 149);
            pCapacitive.Name = "pCapacitive";
            pCapacitive.Size = new Size(50, 51);
            pCapacitive.TabIndex = 6;
            // 
            // lblBarrier2
            // 
            lblBarrier2.AutoSize = true;
            lblBarrier2.Location = new Point(194, 93);
            lblBarrier2.Name = "lblBarrier2";
            lblBarrier2.Size = new Size(73, 20);
            lblBarrier2.TabIndex = 9;
            lblBarrier2.Text = "Barreira 2";
            // 
            // lblBarrier1
            // 
            lblBarrier1.AutoSize = true;
            lblBarrier1.Location = new Point(43, 93);
            lblBarrier1.Name = "lblBarrier1";
            lblBarrier1.Size = new Size(73, 20);
            lblBarrier1.TabIndex = 5;
            lblBarrier1.Text = "Barreira 1";
            // 
            // pBarrier2
            // 
            pBarrier2.BackColor = Color.Transparent;
            pBarrier2.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pBarrier2.BackgroundImageLayout = ImageLayout.Stretch;
            pBarrier2.Location = new Point(205, 35);
            pBarrier2.Name = "pBarrier2";
            pBarrier2.Size = new Size(50, 51);
            pBarrier2.TabIndex = 8;
            // 
            // pBarrier1
            // 
            pBarrier1.BackColor = Color.Transparent;
            pBarrier1.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pBarrier1.BackgroundImageLayout = ImageLayout.Stretch;
            pBarrier1.Location = new Point(55, 35);
            pBarrier1.Name = "pBarrier1";
            pBarrier1.Size = new Size(50, 51);
            pBarrier1.TabIndex = 4;
            // 
            // btnAddPiece
            // 
            btnAddPiece.Cursor = Cursors.Hand;
            btnAddPiece.Enabled = false;
            btnAddPiece.Location = new Point(16, 268);
            btnAddPiece.Name = "btnAddPiece";
            btnAddPiece.Size = new Size(149, 60);
            btnAddPiece.TabIndex = 1;
            btnAddPiece.Text = "Adicionar Peça";
            btnAddPiece.UseVisualStyleBackColor = true;
            btnAddPiece.Click += BtnAddPiece_Click;
            // 
            // gbTypePiece
            // 
            gbTypePiece.Controls.Add(rbNonMetallic);
            gbTypePiece.Controls.Add(rbMetallic);
            gbTypePiece.Controls.Add(rbTransparent);
            gbTypePiece.Location = new Point(427, 68);
            gbTypePiece.Name = "gbTypePiece";
            gbTypePiece.Size = new Size(207, 131);
            gbTypePiece.TabIndex = 0;
            gbTypePiece.TabStop = false;
            gbTypePiece.Text = "Selecione o tipo da peça";
            // 
            // rbNonMetallic
            // 
            rbNonMetallic.AutoSize = true;
            rbNonMetallic.Location = new Point(7, 85);
            rbNonMetallic.Name = "rbNonMetallic";
            rbNonMetallic.Size = new Size(119, 24);
            rbNonMetallic.TabIndex = 2;
            rbNonMetallic.Text = "Não Metálica";
            rbNonMetallic.UseVisualStyleBackColor = true;
            // 
            // rbMetallic
            // 
            rbMetallic.AutoSize = true;
            rbMetallic.Location = new Point(7, 56);
            rbMetallic.Name = "rbMetallic";
            rbMetallic.Size = new Size(87, 24);
            rbMetallic.TabIndex = 1;
            rbMetallic.Text = "Metálica";
            rbMetallic.UseVisualStyleBackColor = true;
            // 
            // rbTransparent
            // 
            rbTransparent.AutoSize = true;
            rbTransparent.Checked = true;
            rbTransparent.Location = new Point(7, 27);
            rbTransparent.Name = "rbTransparent";
            rbTransparent.Size = new Size(115, 24);
            rbTransparent.TabIndex = 0;
            rbTransparent.TabStop = true;
            rbTransparent.Text = "Transparente";
            rbTransparent.UseVisualStyleBackColor = true;
            // 
            // gbControlType
            // 
            gbControlType.BackColor = SystemColors.ControlLightLight;
            gbControlType.Controls.Add(rbAutomatic);
            gbControlType.Controls.Add(rbManual);
            gbControlType.FlatStyle = FlatStyle.Flat;
            gbControlType.ForeColor = SystemColors.Desktop;
            gbControlType.Location = new Point(16, 67);
            gbControlType.Name = "gbControlType";
            gbControlType.Size = new Size(149, 131);
            gbControlType.TabIndex = 6;
            gbControlType.TabStop = false;
            gbControlType.Text = "Tipo de Controle";
            // 
            // rbAutomatic
            // 
            rbAutomatic.AutoSize = true;
            rbAutomatic.Location = new Point(7, 59);
            rbAutomatic.Name = "rbAutomatic";
            rbAutomatic.Size = new Size(108, 24);
            rbAutomatic.TabIndex = 1;
            rbAutomatic.Text = "Automatico";
            rbAutomatic.UseVisualStyleBackColor = true;
            // 
            // rbManual
            // 
            rbManual.AutoSize = true;
            rbManual.Checked = true;
            rbManual.Location = new Point(7, 28);
            rbManual.Name = "rbManual";
            rbManual.Size = new Size(79, 24);
            rbManual.TabIndex = 0;
            rbManual.TabStop = true;
            rbManual.Text = "Manual";
            rbManual.UseVisualStyleBackColor = true;
            // 
            // gbBeltTimes
            // 
            gbBeltTimes.BackColor = SystemColors.ControlLightLight;
            gbBeltTimes.Controls.Add(tbInterval);
            gbBeltTimes.Controls.Add(lblInterval);
            gbBeltTimes.Controls.Add(lblJourneyTime);
            gbBeltTimes.Controls.Add(tbJourneyTime);
            gbBeltTimes.FlatStyle = FlatStyle.Flat;
            gbBeltTimes.ForeColor = SystemColors.Desktop;
            gbBeltTimes.Location = new Point(171, 68);
            gbBeltTimes.Name = "gbBeltTimes";
            gbBeltTimes.Size = new Size(249, 129);
            gbBeltTimes.TabIndex = 7;
            gbBeltTimes.TabStop = false;
            gbBeltTimes.Text = "Tempos da Esteira";
            // 
            // tbInterval
            // 
            tbInterval.CausesValidation = false;
            tbInterval.Location = new Point(93, 60);
            tbInterval.Name = "tbInterval";
            tbInterval.Size = new Size(135, 27);
            tbInterval.TabIndex = 3;
            tbInterval.Text = "1";
            tbInterval.Enter += TbInterval_Enter;
            tbInterval.Leave += TbInterval_Leave;
            // 
            // lblInterval
            // 
            lblInterval.AutoSize = true;
            lblInterval.Location = new Point(7, 63);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new Size(86, 20);
            lblInterval.TabIndex = 2;
            lblInterval.Text = "Intervalo(s):";
            // 
            // lblJourneyTime
            // 
            lblJourneyTime.AutoSize = true;
            lblJourneyTime.Location = new Point(7, 29);
            lblJourneyTime.Name = "lblJourneyTime";
            lblJourneyTime.Size = new Size(83, 20);
            lblJourneyTime.TabIndex = 1;
            lblJourneyTime.Text = "Percurso(s):";
            // 
            // tbJourneyTime
            // 
            tbJourneyTime.CausesValidation = false;
            tbJourneyTime.Location = new Point(93, 27);
            tbJourneyTime.Name = "tbJourneyTime";
            tbJourneyTime.Size = new Size(135, 27);
            tbJourneyTime.TabIndex = 0;
            tbJourneyTime.Text = "1";
            tbJourneyTime.Enter += TbJourneyTime_Enter;
            tbJourneyTime.Leave += TbJourneyTime_Leave;
            // 
            // gbBeltStatus
            // 
            gbBeltStatus.BackColor = SystemColors.ControlLightLight;
            gbBeltStatus.Controls.Add(lblErrorStatus);
            gbBeltStatus.Controls.Add(pErrorStatus);
            gbBeltStatus.Controls.Add(lblBusyStatus);
            gbBeltStatus.Controls.Add(pBusyStatus);
            gbBeltStatus.Controls.Add(pMotorStatus);
            gbBeltStatus.Controls.Add(lblMotor);
            gbBeltStatus.FlatStyle = FlatStyle.Flat;
            gbBeltStatus.ForeColor = SystemColors.Desktop;
            gbBeltStatus.Location = new Point(641, 68);
            gbBeltStatus.Name = "gbBeltStatus";
            gbBeltStatus.Size = new Size(158, 129);
            gbBeltStatus.TabIndex = 8;
            gbBeltStatus.TabStop = false;
            gbBeltStatus.Text = "Estado da Esteira";
            // 
            // lblErrorStatus
            // 
            lblErrorStatus.AutoSize = true;
            lblErrorStatus.Location = new Point(41, 95);
            lblErrorStatus.Name = "lblErrorStatus";
            lblErrorStatus.Size = new Size(36, 20);
            lblErrorStatus.TabIndex = 5;
            lblErrorStatus.Text = "Erro";
            // 
            // pErrorStatus
            // 
            pErrorStatus.BackColor = Color.Transparent;
            pErrorStatus.BackgroundImage = ServerBeltIdentifier.Properties.Resources.red_led_off;
            pErrorStatus.BackgroundImageLayout = ImageLayout.Stretch;
            pErrorStatus.Location = new Point(7, 92);
            pErrorStatus.Name = "pErrorStatus";
            pErrorStatus.Size = new Size(27, 28);
            pErrorStatus.TabIndex = 2;
            // 
            // lblBusyStatus
            // 
            lblBusyStatus.AutoSize = true;
            lblBusyStatus.Location = new Point(41, 61);
            lblBusyStatus.Name = "lblBusyStatus";
            lblBusyStatus.Size = new Size(69, 20);
            lblBusyStatus.TabIndex = 4;
            lblBusyStatus.Text = "Ocupada";
            // 
            // pBusyStatus
            // 
            pBusyStatus.BackColor = Color.Transparent;
            pBusyStatus.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pBusyStatus.BackgroundImageLayout = ImageLayout.Stretch;
            pBusyStatus.Location = new Point(7, 59);
            pBusyStatus.Name = "pBusyStatus";
            pBusyStatus.Size = new Size(27, 28);
            pBusyStatus.TabIndex = 1;
            // 
            // pMotorStatus
            // 
            pMotorStatus.BackColor = Color.Transparent;
            pMotorStatus.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pMotorStatus.BackgroundImageLayout = ImageLayout.Stretch;
            pMotorStatus.Location = new Point(7, 24);
            pMotorStatus.Name = "pMotorStatus";
            pMotorStatus.Size = new Size(27, 28);
            pMotorStatus.TabIndex = 0;
            // 
            // lblMotor
            // 
            lblMotor.AutoSize = true;
            lblMotor.Location = new Point(41, 28);
            lblMotor.Name = "lblMotor";
            lblMotor.Size = new Size(50, 20);
            lblMotor.TabIndex = 3;
            lblMotor.Text = "Motor";
            // 
            // btnReset
            // 
            btnReset.Enabled = false;
            btnReset.Location = new Point(171, 268);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(149, 60);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnReset_Click;
            // 
            // timerAutoModule1
            // 
            timerAutoModule1.Enabled = true;
            timerAutoModule1.Interval = 4001;
            timerAutoModule1.Tick += TimerModule1_Tick;
            // 
            // timerAutoModule2
            // 
            timerAutoModule2.Enabled = true;
            timerAutoModule2.Interval = 24001;
            timerAutoModule2.Tick += TimerAutoModule2_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ServerBeltIdentifier.Properties.Resources.OPC_UA_Logo;
            pictureBox1.Location = new Point(677, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = ServerBeltIdentifier.Properties.Resources.logo_ucl_blue;
            pictureBox2.Location = new Point(16, 460);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(107, 47);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(814, 517);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnStop);
            Controls.Add(btnAddPiece);
            Controls.Add(btnReset);
            Controls.Add(gbBeltTimes);
            Controls.Add(gbTypePiece);
            Controls.Add(gbBeltStatus);
            Controls.Add(gbControlType);
            Controls.Add(btnStart);
            Controls.Add(lblServerUrl);
            Controls.Add(cbServerUrl);
            Controls.Add(tbcModules);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(832, 564);
            MinimumSize = new Size(832, 564);
            Name = "ServerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servidor da Esteira Identificadora de Peças";
            Load += ServerForm_Load;
            tbcModules.ResumeLayout(false);
            tpModule1.ResumeLayout(false);
            gbOpcStatusModule1.ResumeLayout(false);
            gbOpcStatusModule1.PerformLayout();
            tpModule2.ResumeLayout(false);
            gbOpcStatusModule2.ResumeLayout(false);
            gbOpcStatusModule2.PerformLayout();
            gbTypePiece.ResumeLayout(false);
            gbTypePiece.PerformLayout();
            gbControlType.ResumeLayout(false);
            gbControlType.PerformLayout();
            gbBeltTimes.ResumeLayout(false);
            gbBeltTimes.PerformLayout();
            gbBeltStatus.ResumeLayout(false);
            gbBeltStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbServerUrl;
        private Label lblServerUrl;
        private Button btnStart;
        private Button btnStop;
        private System.Windows.Forms.Timer timerUpdateForm;
        private TabControl tbcModules;
        private TabPage tpModule2;
        private TabPage tpModule1;
        private GroupBox gbControlType;
        private RadioButton rbAutomatic;
        private RadioButton rbManual;
        private GroupBox gbBeltTimes;
        private GroupBox gbBeltStatus;
        private Button btnReset;
        private Label lblErrorStatus;
        private Panel pErrorStatus;
        private Label lblBusyStatus;
        private Panel pBusyStatus;
        private Panel pMotorStatus;
        private Label lblMotor;
        private GroupBox gbOpcStatusModule1;
        private Label lblTransparent;
        private Panel pNonMetallic;
        private Panel pMetallic;
        private Panel pTransparent;
        private Button btnAddPiece;
        private GroupBox gbTypePiece;
        private RadioButton rbNonMetallic;
        private RadioButton rbMetallic;
        private RadioButton rbTransparent;
        private TextBox tbQuantityNonMetallic;
        private Label lblNonMetallic;
        private TextBox tbQuantityMetallic;
        private Label lblMetallic;
        private TextBox tbQuantityTransparent;
        private GroupBox gbOpcStatusModule2;
        private Label lblBarrier3;
        private Label lblInductive;
        private Panel pBarrier3;
        private Label lblCapacitive;
        private Label lblPhotoSensor;
        private Panel pInductive;
        private Panel pPhotoSensor;
        private Panel pCapacitive;
        private Label lblBarrier2;
        private Label lblBarrier1;
        private Panel pBarrier2;
        private Panel pBarrier1;
        private System.Windows.Forms.Timer timerAutoModule1;
        private System.Windows.Forms.Timer timerAutoModule2;
        private TextBox tbInterval;
        private Label lblInterval;
        private Label lblJourneyTime;
        private TextBox tbJourneyTime;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}