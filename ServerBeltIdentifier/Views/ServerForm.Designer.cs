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
            cbServerUrl.Location = new Point(121, 9);
            cbServerUrl.Name = "cbServerUrl";
            cbServerUrl.Size = new Size(465, 22);
            cbServerUrl.TabIndex = 0;
            // 
            // lblServerUrl
            // 
            lblServerUrl.AutoSize = true;
            lblServerUrl.Location = new Point(14, 12);
            lblServerUrl.Name = "lblServerUrl";
            lblServerUrl.Size = new Size(94, 15);
            lblServerUrl.TabIndex = 1;
            lblServerUrl.Text = "URL do Servidor ";
            lblServerUrl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatAppearance.MouseDownBackColor = Color.Red;
            btnStart.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnStart.Location = new Point(14, 152);
            btnStart.Margin = new Padding(3, 2, 3, 2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(130, 45);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(149, 152);
            btnStop.Margin = new Padding(3, 2, 3, 2);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(130, 45);
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
            tbcModules.Location = new Point(285, 152);
            tbcModules.Margin = new Padding(3, 2, 3, 2);
            tbcModules.Name = "tbcModules";
            tbcModules.SelectedIndex = 0;
            tbcModules.Size = new Size(414, 228);
            tbcModules.TabIndex = 5;
            // 
            // tpModule1
            // 
            tpModule1.Controls.Add(gbOpcStatusModule1);
            tpModule1.Location = new Point(4, 24);
            tpModule1.Margin = new Padding(3, 2, 3, 2);
            tpModule1.Name = "tpModule1";
            tpModule1.Padding = new Padding(3, 2, 3, 2);
            tpModule1.Size = new Size(406, 200);
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
            gbOpcStatusModule1.Location = new Point(5, 4);
            gbOpcStatusModule1.Margin = new Padding(3, 2, 3, 2);
            gbOpcStatusModule1.Name = "gbOpcStatusModule1";
            gbOpcStatusModule1.Padding = new Padding(3, 2, 3, 2);
            gbOpcStatusModule1.Size = new Size(395, 192);
            gbOpcStatusModule1.TabIndex = 2;
            gbOpcStatusModule1.TabStop = false;
            gbOpcStatusModule1.Text = "Estado das variáveis disponibilizadas via OPC";
            // 
            // tbQuantityNonMetallic
            // 
            tbQuantityNonMetallic.Location = new Point(296, 105);
            tbQuantityNonMetallic.Margin = new Padding(3, 2, 3, 2);
            tbQuantityNonMetallic.Name = "tbQuantityNonMetallic";
            tbQuantityNonMetallic.ReadOnly = true;
            tbQuantityNonMetallic.Size = new Size(76, 23);
            tbQuantityNonMetallic.TabIndex = 8;
            // 
            // lblNonMetallic
            // 
            lblNonMetallic.AutoSize = true;
            lblNonMetallic.Location = new Point(292, 83);
            lblNonMetallic.Name = "lblNonMetallic";
            lblNonMetallic.Size = new Size(77, 15);
            lblNonMetallic.TabIndex = 7;
            lblNonMetallic.Text = "Não Metálica";
            // 
            // tbQuantityMetallic
            // 
            tbQuantityMetallic.Location = new Point(158, 105);
            tbQuantityMetallic.Margin = new Padding(3, 2, 3, 2);
            tbQuantityMetallic.Name = "tbQuantityMetallic";
            tbQuantityMetallic.ReadOnly = true;
            tbQuantityMetallic.Size = new Size(76, 23);
            tbQuantityMetallic.TabIndex = 6;
            // 
            // lblMetallic
            // 
            lblMetallic.AutoSize = true;
            lblMetallic.Location = new Point(167, 83);
            lblMetallic.Name = "lblMetallic";
            lblMetallic.Size = new Size(52, 15);
            lblMetallic.TabIndex = 5;
            lblMetallic.Text = "Metálica";
            // 
            // tbQuantityTransparent
            // 
            tbQuantityTransparent.Location = new Point(15, 105);
            tbQuantityTransparent.Margin = new Padding(3, 2, 3, 2);
            tbQuantityTransparent.Name = "tbQuantityTransparent";
            tbQuantityTransparent.ReadOnly = true;
            tbQuantityTransparent.Size = new Size(76, 23);
            tbQuantityTransparent.TabIndex = 4;
            // 
            // lblTransparent
            // 
            lblTransparent.AutoSize = true;
            lblTransparent.Location = new Point(11, 83);
            lblTransparent.Name = "lblTransparent";
            lblTransparent.Size = new Size(74, 15);
            lblTransparent.TabIndex = 3;
            lblTransparent.Text = "Transparente";
            // 
            // pNonMetallic
            // 
            pNonMetallic.BackColor = Color.Transparent;
            pNonMetallic.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pNonMetallic.BackgroundImageLayout = ImageLayout.Stretch;
            pNonMetallic.Location = new Point(312, 39);
            pNonMetallic.Margin = new Padding(3, 2, 3, 2);
            pNonMetallic.Name = "pNonMetallic";
            pNonMetallic.Size = new Size(44, 38);
            pNonMetallic.TabIndex = 2;
            // 
            // pMetallic
            // 
            pMetallic.BackColor = Color.Transparent;
            pMetallic.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pMetallic.BackgroundImageLayout = ImageLayout.Stretch;
            pMetallic.Location = new Point(172, 39);
            pMetallic.Margin = new Padding(3, 2, 3, 2);
            pMetallic.Name = "pMetallic";
            pMetallic.Size = new Size(44, 38);
            pMetallic.TabIndex = 2;
            // 
            // pTransparent
            // 
            pTransparent.BackColor = Color.Transparent;
            pTransparent.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pTransparent.BackgroundImageLayout = ImageLayout.Stretch;
            pTransparent.Location = new Point(30, 39);
            pTransparent.Margin = new Padding(3, 2, 3, 2);
            pTransparent.Name = "pTransparent";
            pTransparent.Size = new Size(44, 38);
            pTransparent.TabIndex = 1;
            // 
            // tpModule2
            // 
            tpModule2.Controls.Add(gbOpcStatusModule2);
            tpModule2.Location = new Point(4, 24);
            tpModule2.Margin = new Padding(3, 2, 3, 2);
            tpModule2.Name = "tpModule2";
            tpModule2.Padding = new Padding(3, 2, 3, 2);
            tpModule2.Size = new Size(406, 200);
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
            gbOpcStatusModule2.Location = new Point(5, 4);
            gbOpcStatusModule2.Margin = new Padding(3, 2, 3, 2);
            gbOpcStatusModule2.Name = "gbOpcStatusModule2";
            gbOpcStatusModule2.Padding = new Padding(3, 2, 3, 2);
            gbOpcStatusModule2.Size = new Size(395, 184);
            gbOpcStatusModule2.TabIndex = 0;
            gbOpcStatusModule2.TabStop = false;
            gbOpcStatusModule2.Text = "Estado das variáveis disponibilizadas via OPC";
            // 
            // lblBarrier3
            // 
            lblBarrier3.AutoSize = true;
            lblBarrier3.Location = new Point(297, 156);
            lblBarrier3.Name = "lblBarrier3";
            lblBarrier3.Size = new Size(56, 15);
            lblBarrier3.TabIndex = 11;
            lblBarrier3.Text = "Barreira 3";
            // 
            // lblInductive
            // 
            lblInductive.AutoSize = true;
            lblInductive.Location = new Point(178, 156);
            lblInductive.Name = "lblInductive";
            lblInductive.Size = new Size(51, 15);
            lblInductive.TabIndex = 11;
            lblInductive.Text = "Indutivo";
            // 
            // pBarrier3
            // 
            pBarrier3.BackColor = Color.Transparent;
            pBarrier3.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pBarrier3.BackgroundImageLayout = ImageLayout.Stretch;
            pBarrier3.Location = new Point(306, 112);
            pBarrier3.Margin = new Padding(3, 2, 3, 2);
            pBarrier3.Name = "pBarrier3";
            pBarrier3.Size = new Size(44, 38);
            pBarrier3.TabIndex = 10;
            // 
            // lblCapacitive
            // 
            lblCapacitive.AutoSize = true;
            lblCapacitive.Location = new Point(46, 156);
            lblCapacitive.Name = "lblCapacitive";
            lblCapacitive.Size = new Size(63, 15);
            lblCapacitive.TabIndex = 7;
            lblCapacitive.Text = "Capacitivo";
            // 
            // lblPhotoSensor
            // 
            lblPhotoSensor.AutoSize = true;
            lblPhotoSensor.Location = new Point(304, 70);
            lblPhotoSensor.Name = "lblPhotoSensor";
            lblPhotoSensor.Size = new Size(70, 15);
            lblPhotoSensor.TabIndex = 9;
            lblPhotoSensor.Text = "Fotoelétrico";
            // 
            // pInductive
            // 
            pInductive.BackColor = Color.Transparent;
            pInductive.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pInductive.BackgroundImageLayout = ImageLayout.Stretch;
            pInductive.Location = new Point(179, 112);
            pInductive.Margin = new Padding(3, 2, 3, 2);
            pInductive.Name = "pInductive";
            pInductive.Size = new Size(44, 38);
            pInductive.TabIndex = 10;
            // 
            // pPhotoSensor
            // 
            pPhotoSensor.BackColor = Color.Transparent;
            pPhotoSensor.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pPhotoSensor.BackgroundImageLayout = ImageLayout.Stretch;
            pPhotoSensor.Location = new Point(306, 26);
            pPhotoSensor.Margin = new Padding(3, 2, 3, 2);
            pPhotoSensor.Name = "pPhotoSensor";
            pPhotoSensor.Size = new Size(44, 38);
            pPhotoSensor.TabIndex = 8;
            // 
            // pCapacitive
            // 
            pCapacitive.BackColor = Color.Transparent;
            pCapacitive.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pCapacitive.BackgroundImageLayout = ImageLayout.Stretch;
            pCapacitive.Location = new Point(48, 112);
            pCapacitive.Margin = new Padding(3, 2, 3, 2);
            pCapacitive.Name = "pCapacitive";
            pCapacitive.Size = new Size(44, 38);
            pCapacitive.TabIndex = 6;
            // 
            // lblBarrier2
            // 
            lblBarrier2.AutoSize = true;
            lblBarrier2.Location = new Point(170, 70);
            lblBarrier2.Name = "lblBarrier2";
            lblBarrier2.Size = new Size(56, 15);
            lblBarrier2.TabIndex = 9;
            lblBarrier2.Text = "Barreira 2";
            // 
            // lblBarrier1
            // 
            lblBarrier1.AutoSize = true;
            lblBarrier1.Location = new Point(38, 70);
            lblBarrier1.Name = "lblBarrier1";
            lblBarrier1.Size = new Size(56, 15);
            lblBarrier1.TabIndex = 5;
            lblBarrier1.Text = "Barreira 1";
            // 
            // pBarrier2
            // 
            pBarrier2.BackColor = Color.Transparent;
            pBarrier2.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pBarrier2.BackgroundImageLayout = ImageLayout.Stretch;
            pBarrier2.Location = new Point(179, 26);
            pBarrier2.Margin = new Padding(3, 2, 3, 2);
            pBarrier2.Name = "pBarrier2";
            pBarrier2.Size = new Size(44, 38);
            pBarrier2.TabIndex = 8;
            // 
            // pBarrier1
            // 
            pBarrier1.BackColor = Color.Transparent;
            pBarrier1.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pBarrier1.BackgroundImageLayout = ImageLayout.Stretch;
            pBarrier1.Location = new Point(48, 26);
            pBarrier1.Margin = new Padding(3, 2, 3, 2);
            pBarrier1.Name = "pBarrier1";
            pBarrier1.Size = new Size(44, 38);
            pBarrier1.TabIndex = 4;
            // 
            // btnAddPiece
            // 
            btnAddPiece.Cursor = Cursors.Hand;
            btnAddPiece.Enabled = false;
            btnAddPiece.Location = new Point(14, 201);
            btnAddPiece.Margin = new Padding(3, 2, 3, 2);
            btnAddPiece.Name = "btnAddPiece";
            btnAddPiece.Size = new Size(130, 45);
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
            gbTypePiece.Location = new Point(374, 51);
            gbTypePiece.Margin = new Padding(3, 2, 3, 2);
            gbTypePiece.Name = "gbTypePiece";
            gbTypePiece.Padding = new Padding(3, 2, 3, 2);
            gbTypePiece.Size = new Size(181, 98);
            gbTypePiece.TabIndex = 0;
            gbTypePiece.TabStop = false;
            gbTypePiece.Text = "Selecione o tipo da peça";
            // 
            // rbNonMetallic
            // 
            rbNonMetallic.AutoSize = true;
            rbNonMetallic.Location = new Point(6, 64);
            rbNonMetallic.Margin = new Padding(3, 2, 3, 2);
            rbNonMetallic.Name = "rbNonMetallic";
            rbNonMetallic.Size = new Size(95, 19);
            rbNonMetallic.TabIndex = 2;
            rbNonMetallic.Text = "Não Metálica";
            rbNonMetallic.UseVisualStyleBackColor = true;
            // 
            // rbMetallic
            // 
            rbMetallic.AutoSize = true;
            rbMetallic.Location = new Point(6, 42);
            rbMetallic.Margin = new Padding(3, 2, 3, 2);
            rbMetallic.Name = "rbMetallic";
            rbMetallic.Size = new Size(70, 19);
            rbMetallic.TabIndex = 1;
            rbMetallic.Text = "Metálica";
            rbMetallic.UseVisualStyleBackColor = true;
            // 
            // rbTransparent
            // 
            rbTransparent.AutoSize = true;
            rbTransparent.Checked = true;
            rbTransparent.Location = new Point(6, 20);
            rbTransparent.Margin = new Padding(3, 2, 3, 2);
            rbTransparent.Name = "rbTransparent";
            rbTransparent.Size = new Size(92, 19);
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
            gbControlType.Location = new Point(14, 50);
            gbControlType.Margin = new Padding(3, 2, 3, 2);
            gbControlType.Name = "gbControlType";
            gbControlType.Padding = new Padding(3, 2, 3, 2);
            gbControlType.Size = new Size(130, 98);
            gbControlType.TabIndex = 6;
            gbControlType.TabStop = false;
            gbControlType.Text = "Tipo de Controle";
            // 
            // rbAutomatic
            // 
            rbAutomatic.AutoSize = true;
            rbAutomatic.Location = new Point(6, 44);
            rbAutomatic.Margin = new Padding(3, 2, 3, 2);
            rbAutomatic.Name = "rbAutomatic";
            rbAutomatic.Size = new Size(88, 19);
            rbAutomatic.TabIndex = 1;
            rbAutomatic.Text = "Automatico";
            rbAutomatic.UseVisualStyleBackColor = true;
            // 
            // rbManual
            // 
            rbManual.AutoSize = true;
            rbManual.Checked = true;
            rbManual.Location = new Point(6, 21);
            rbManual.Margin = new Padding(3, 2, 3, 2);
            rbManual.Name = "rbManual";
            rbManual.Size = new Size(65, 19);
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
            gbBeltTimes.Location = new Point(150, 51);
            gbBeltTimes.Margin = new Padding(3, 2, 3, 2);
            gbBeltTimes.Name = "gbBeltTimes";
            gbBeltTimes.Padding = new Padding(3, 2, 3, 2);
            gbBeltTimes.Size = new Size(218, 97);
            gbBeltTimes.TabIndex = 7;
            gbBeltTimes.TabStop = false;
            gbBeltTimes.Text = "Tempos da Esteira";
            // 
            // tbInterval
            // 
            tbInterval.CausesValidation = false;
            tbInterval.Location = new Point(81, 45);
            tbInterval.Margin = new Padding(3, 2, 3, 2);
            tbInterval.Name = "tbInterval";
            tbInterval.Size = new Size(119, 23);
            tbInterval.TabIndex = 3;
            tbInterval.Text = "1";
            tbInterval.Enter += TbInterval_Enter;
            tbInterval.Leave += TbInterval_Leave;
            // 
            // lblInterval
            // 
            lblInterval.AutoSize = true;
            lblInterval.Location = new Point(6, 47);
            lblInterval.Name = "lblInterval";
            lblInterval.Size = new Size(69, 15);
            lblInterval.TabIndex = 2;
            lblInterval.Text = "Intervalo(s):";
            // 
            // lblJourneyTime
            // 
            lblJourneyTime.AutoSize = true;
            lblJourneyTime.Location = new Point(6, 22);
            lblJourneyTime.Name = "lblJourneyTime";
            lblJourneyTime.Size = new Size(69, 15);
            lblJourneyTime.TabIndex = 1;
            lblJourneyTime.Text = "Percurso(s):";
            // 
            // tbJourneyTime
            // 
            tbJourneyTime.CausesValidation = false;
            tbJourneyTime.Location = new Point(81, 20);
            tbJourneyTime.Margin = new Padding(3, 2, 3, 2);
            tbJourneyTime.Name = "tbJourneyTime";
            tbJourneyTime.Size = new Size(119, 23);
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
            gbBeltStatus.Location = new Point(561, 51);
            gbBeltStatus.Margin = new Padding(3, 2, 3, 2);
            gbBeltStatus.Name = "gbBeltStatus";
            gbBeltStatus.Padding = new Padding(3, 2, 3, 2);
            gbBeltStatus.Size = new Size(138, 97);
            gbBeltStatus.TabIndex = 8;
            gbBeltStatus.TabStop = false;
            gbBeltStatus.Text = "Estado da Esteira";
            // 
            // lblErrorStatus
            // 
            lblErrorStatus.AutoSize = true;
            lblErrorStatus.Location = new Point(36, 71);
            lblErrorStatus.Name = "lblErrorStatus";
            lblErrorStatus.Size = new Size(28, 15);
            lblErrorStatus.TabIndex = 5;
            lblErrorStatus.Text = "Erro";
            // 
            // pErrorStatus
            // 
            pErrorStatus.BackColor = Color.Transparent;
            pErrorStatus.BackgroundImage = ServerBeltIdentifier.Properties.Resources.red_led_off;
            pErrorStatus.BackgroundImageLayout = ImageLayout.Stretch;
            pErrorStatus.Location = new Point(6, 69);
            pErrorStatus.Margin = new Padding(3, 2, 3, 2);
            pErrorStatus.Name = "pErrorStatus";
            pErrorStatus.Size = new Size(24, 21);
            pErrorStatus.TabIndex = 2;
            // 
            // lblBusyStatus
            // 
            lblBusyStatus.AutoSize = true;
            lblBusyStatus.Location = new Point(36, 46);
            lblBusyStatus.Name = "lblBusyStatus";
            lblBusyStatus.Size = new Size(55, 15);
            lblBusyStatus.TabIndex = 4;
            lblBusyStatus.Text = "Ocupada";
            // 
            // pBusyStatus
            // 
            pBusyStatus.BackColor = Color.Transparent;
            pBusyStatus.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pBusyStatus.BackgroundImageLayout = ImageLayout.Stretch;
            pBusyStatus.Location = new Point(6, 44);
            pBusyStatus.Margin = new Padding(3, 2, 3, 2);
            pBusyStatus.Name = "pBusyStatus";
            pBusyStatus.Size = new Size(24, 21);
            pBusyStatus.TabIndex = 1;
            // 
            // pMotorStatus
            // 
            pMotorStatus.BackColor = Color.Transparent;
            pMotorStatus.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pMotorStatus.BackgroundImageLayout = ImageLayout.Stretch;
            pMotorStatus.Location = new Point(6, 18);
            pMotorStatus.Margin = new Padding(3, 2, 3, 2);
            pMotorStatus.Name = "pMotorStatus";
            pMotorStatus.Size = new Size(24, 21);
            pMotorStatus.TabIndex = 0;
            // 
            // lblMotor
            // 
            lblMotor.AutoSize = true;
            lblMotor.Location = new Point(36, 21);
            lblMotor.Name = "lblMotor";
            lblMotor.Size = new Size(40, 15);
            lblMotor.TabIndex = 3;
            lblMotor.Text = "Motor";
            // 
            // btnReset
            // 
            btnReset.Enabled = false;
            btnReset.Location = new Point(150, 201);
            btnReset.Margin = new Padding(3, 2, 3, 2);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(130, 45);
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
            pictureBox1.Location = new Point(592, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = ServerBeltIdentifier.Properties.Resources.logo_ucl_blue;
            pictureBox2.Location = new Point(14, 345);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(714, 396);
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
            ImeMode = ImeMode.Off;
            MaximizeBox = false;
            MaximumSize = new Size(730, 435);
            MinimumSize = new Size(730, 435);
            Name = "ServerForm";
            ShowIcon = false;
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