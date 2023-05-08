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
            timer1 = new System.Windows.Forms.Timer(components);
            tbcModules = new TabControl();
            tpModule1 = new TabPage();
            gbOpcStatusModule1 = new GroupBox();
            tbQuantityNonMetallic = new TextBox();
            lblNonMetallic = new Label();
            tbQuantityMetallic = new TextBox();
            lblMetallic = new Label();
            tbQuantityOpaque = new TextBox();
            lblOpaque = new Label();
            pNonMetallic = new Panel();
            pMetallic = new Panel();
            pOpaque = new Panel();
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
            rbOpaque = new RadioButton();
            gbControlType = new GroupBox();
            rbAutomatic = new RadioButton();
            rbManual = new RadioButton();
            gbBeltSpeed = new GroupBox();
            rbSpeed4 = new RadioButton();
            rbSpeed3 = new RadioButton();
            rbSpeed2 = new RadioButton();
            rbSpeed1 = new RadioButton();
            gbBeltStatus = new GroupBox();
            lblErrorStatus = new Label();
            pErrorStatus = new Panel();
            lblBusyStatus = new Label();
            pBusyStatus = new Panel();
            pMotorStatus = new Panel();
            lblMotor = new Label();
            btnReset = new Button();
            tbcModules.SuspendLayout();
            tpModule1.SuspendLayout();
            gbOpcStatusModule1.SuspendLayout();
            tpModule2.SuspendLayout();
            gbOpcStatusModule2.SuspendLayout();
            gbTypePiece.SuspendLayout();
            gbControlType.SuspendLayout();
            gbBeltSpeed.SuspendLayout();
            gbBeltStatus.SuspendLayout();
            SuspendLayout();
            // 
            // cbServerUrl
            // 
            cbServerUrl.DropDownStyle = ComboBoxStyle.Simple;
            cbServerUrl.FormattingEnabled = true;
            cbServerUrl.Location = new Point(138, 11);
            cbServerUrl.Margin = new Padding(3, 4, 3, 4);
            cbServerUrl.Name = "cbServerUrl";
            cbServerUrl.Size = new Size(564, 28);
            cbServerUrl.TabIndex = 0;
            cbServerUrl.SelectedIndexChanged += ServerUrlComboBox_SelectedIndexChanged;
            // 
            // lblServerUrl
            // 
            lblServerUrl.AutoSize = true;
            lblServerUrl.Location = new Point(16, 14);
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
            btnStart.Location = new Point(16, 141);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(95, 29);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += StartButton_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(120, 141);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(95, 29);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += StopButton_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // tbcModules
            // 
            tbcModules.Controls.Add(tpModule1);
            tbcModules.Controls.Add(tpModule2);
            tbcModules.Location = new Point(231, 141);
            tbcModules.Name = "tbcModules";
            tbcModules.SelectedIndex = 0;
            tbcModules.Size = new Size(471, 301);
            tbcModules.TabIndex = 5;
            // 
            // tpModule1
            // 
            tpModule1.Controls.Add(gbOpcStatusModule1);
            tpModule1.Location = new Point(4, 29);
            tpModule1.Name = "tpModule1";
            tpModule1.Padding = new Padding(3);
            tpModule1.Size = new Size(463, 268);
            tpModule1.TabIndex = 1;
            tpModule1.Text = "Módulo 1";
            tpModule1.UseVisualStyleBackColor = true;
            tpModule1.Click += tpModule1_Click;
            // 
            // gbOpcStatusModule1
            // 
            gbOpcStatusModule1.Controls.Add(tbQuantityNonMetallic);
            gbOpcStatusModule1.Controls.Add(lblNonMetallic);
            gbOpcStatusModule1.Controls.Add(tbQuantityMetallic);
            gbOpcStatusModule1.Controls.Add(lblMetallic);
            gbOpcStatusModule1.Controls.Add(tbQuantityOpaque);
            gbOpcStatusModule1.Controls.Add(lblOpaque);
            gbOpcStatusModule1.Controls.Add(pNonMetallic);
            gbOpcStatusModule1.Controls.Add(pMetallic);
            gbOpcStatusModule1.Controls.Add(pOpaque);
            gbOpcStatusModule1.Location = new Point(6, 6);
            gbOpcStatusModule1.Name = "gbOpcStatusModule1";
            gbOpcStatusModule1.Size = new Size(451, 256);
            gbOpcStatusModule1.TabIndex = 2;
            gbOpcStatusModule1.TabStop = false;
            gbOpcStatusModule1.Text = "Estado das variáveis disponibilizadas via OPC";
            // 
            // tbQuantityNonMetallic
            // 
            tbQuantityNonMetallic.Location = new Point(338, 134);
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
            lblNonMetallic.Click += label3_Click;
            // 
            // tbQuantityMetallic
            // 
            tbQuantityMetallic.Location = new Point(180, 134);
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
            // tbQuantityOpaque
            // 
            tbQuantityOpaque.Location = new Point(17, 134);
            tbQuantityOpaque.Name = "tbQuantityOpaque";
            tbQuantityOpaque.ReadOnly = true;
            tbQuantityOpaque.Size = new Size(86, 27);
            tbQuantityOpaque.TabIndex = 4;
            // 
            // lblOpaque
            // 
            lblOpaque.AutoSize = true;
            lblOpaque.Location = new Point(32, 111);
            lblOpaque.Name = "lblOpaque";
            lblOpaque.Size = new Size(52, 20);
            lblOpaque.TabIndex = 3;
            lblOpaque.Text = "Opaca";
            lblOpaque.Click += label1_Click;
            // 
            // pNonMetallic
            // 
            pNonMetallic.BackColor = Color.Transparent;
            pNonMetallic.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pNonMetallic.BackgroundImageLayout = ImageLayout.Stretch;
            pNonMetallic.Location = new Point(357, 52);
            pNonMetallic.Name = "pNonMetallic";
            pNonMetallic.Size = new Size(50, 50);
            pNonMetallic.TabIndex = 2;
            // 
            // pMetallic
            // 
            pMetallic.BackColor = Color.Transparent;
            pMetallic.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pMetallic.BackgroundImageLayout = ImageLayout.Stretch;
            pMetallic.Location = new Point(197, 52);
            pMetallic.Name = "pMetallic";
            pMetallic.Size = new Size(50, 50);
            pMetallic.TabIndex = 2;
            // 
            // pOpaque
            // 
            pOpaque.BackColor = Color.Transparent;
            pOpaque.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pOpaque.BackgroundImageLayout = ImageLayout.Stretch;
            pOpaque.Location = new Point(34, 52);
            pOpaque.Name = "pOpaque";
            pOpaque.Size = new Size(50, 50);
            pOpaque.TabIndex = 1;
            // 
            // tpModule2
            // 
            tpModule2.Controls.Add(gbOpcStatusModule2);
            tpModule2.Location = new Point(4, 29);
            tpModule2.Name = "tpModule2";
            tpModule2.Padding = new Padding(3);
            tpModule2.Size = new Size(463, 268);
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
            gbOpcStatusModule2.Location = new Point(6, 6);
            gbOpcStatusModule2.Name = "gbOpcStatusModule2";
            gbOpcStatusModule2.Size = new Size(451, 256);
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
            pBarrier3.Size = new Size(50, 50);
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
            lblPhotoSensor.Location = new Point(348, 94);
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
            pInductive.Size = new Size(50, 50);
            pInductive.TabIndex = 10;
            // 
            // pPhotoSensor
            // 
            pPhotoSensor.BackColor = Color.Transparent;
            pPhotoSensor.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pPhotoSensor.BackgroundImageLayout = ImageLayout.Stretch;
            pPhotoSensor.Location = new Point(350, 35);
            pPhotoSensor.Name = "pPhotoSensor";
            pPhotoSensor.Size = new Size(50, 50);
            pPhotoSensor.TabIndex = 8;
            // 
            // pCapacitive
            // 
            pCapacitive.BackColor = Color.Transparent;
            pCapacitive.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pCapacitive.BackgroundImageLayout = ImageLayout.Stretch;
            pCapacitive.Location = new Point(55, 149);
            pCapacitive.Name = "pCapacitive";
            pCapacitive.Size = new Size(50, 50);
            pCapacitive.TabIndex = 6;
            // 
            // lblBarrier2
            // 
            lblBarrier2.AutoSize = true;
            lblBarrier2.Location = new Point(194, 94);
            lblBarrier2.Name = "lblBarrier2";
            lblBarrier2.Size = new Size(73, 20);
            lblBarrier2.TabIndex = 9;
            lblBarrier2.Text = "Barreira 2";
            // 
            // lblBarrier1
            // 
            lblBarrier1.AutoSize = true;
            lblBarrier1.Location = new Point(44, 94);
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
            pBarrier2.Size = new Size(50, 50);
            pBarrier2.TabIndex = 8;
            // 
            // pBarrier1
            // 
            pBarrier1.BackColor = Color.Transparent;
            pBarrier1.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pBarrier1.BackgroundImageLayout = ImageLayout.Stretch;
            pBarrier1.Location = new Point(55, 35);
            pBarrier1.Name = "pBarrier1";
            pBarrier1.Size = new Size(50, 50);
            pBarrier1.TabIndex = 4;
            // 
            // btnAddPiece
            // 
            btnAddPiece.Cursor = Cursors.Hand;
            btnAddPiece.Location = new Point(63, 335);
            btnAddPiece.Name = "btnAddPiece";
            btnAddPiece.Size = new Size(112, 49);
            btnAddPiece.TabIndex = 1;
            btnAddPiece.Text = "Colocar Peça na Esteira";
            btnAddPiece.UseVisualStyleBackColor = true;
            // 
            // gbTypePiece
            // 
            gbTypePiece.Controls.Add(rbNonMetallic);
            gbTypePiece.Controls.Add(rbMetallic);
            gbTypePiece.Controls.Add(rbOpaque);
            gbTypePiece.Location = new Point(16, 211);
            gbTypePiece.Name = "gbTypePiece";
            gbTypePiece.Size = new Size(195, 118);
            gbTypePiece.TabIndex = 0;
            gbTypePiece.TabStop = false;
            gbTypePiece.Text = "Selecione o tipo da peça";
            // 
            // rbNonMetallic
            // 
            rbNonMetallic.AutoSize = true;
            rbNonMetallic.Location = new Point(10, 83);
            rbNonMetallic.Name = "rbNonMetallic";
            rbNonMetallic.Size = new Size(119, 24);
            rbNonMetallic.TabIndex = 2;
            rbNonMetallic.Text = "Não Metálica";
            rbNonMetallic.UseVisualStyleBackColor = true;
            // 
            // rbMetallic
            // 
            rbMetallic.AutoSize = true;
            rbMetallic.Location = new Point(10, 55);
            rbMetallic.Name = "rbMetallic";
            rbMetallic.Size = new Size(87, 24);
            rbMetallic.TabIndex = 1;
            rbMetallic.Text = "Metálica";
            rbMetallic.UseVisualStyleBackColor = true;
            // 
            // rbOpaque
            // 
            rbOpaque.AutoSize = true;
            rbOpaque.Checked = true;
            rbOpaque.Location = new Point(11, 26);
            rbOpaque.Name = "rbOpaque";
            rbOpaque.Size = new Size(73, 24);
            rbOpaque.TabIndex = 0;
            rbOpaque.TabStop = true;
            rbOpaque.Text = "Opaca";
            rbOpaque.UseVisualStyleBackColor = true;
            // 
            // gbControlType
            // 
            gbControlType.BackColor = SystemColors.ControlLight;
            gbControlType.Controls.Add(rbAutomatic);
            gbControlType.Controls.Add(rbManual);
            gbControlType.FlatStyle = FlatStyle.Flat;
            gbControlType.ForeColor = SystemColors.Desktop;
            gbControlType.Location = new Point(16, 66);
            gbControlType.Name = "gbControlType";
            gbControlType.Size = new Size(200, 69);
            gbControlType.TabIndex = 6;
            gbControlType.TabStop = false;
            gbControlType.Text = "Tipo de Controle";
            // 
            // rbAutomatic
            // 
            rbAutomatic.AutoSize = true;
            rbAutomatic.Location = new Point(91, 32);
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
            rbManual.Location = new Point(6, 32);
            rbManual.Name = "rbManual";
            rbManual.Size = new Size(79, 24);
            rbManual.TabIndex = 0;
            rbManual.TabStop = true;
            rbManual.Text = "Manual";
            rbManual.UseVisualStyleBackColor = true;
            rbManual.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // gbBeltSpeed
            // 
            gbBeltSpeed.BackColor = SystemColors.ControlLight;
            gbBeltSpeed.Controls.Add(rbSpeed4);
            gbBeltSpeed.Controls.Add(rbSpeed3);
            gbBeltSpeed.Controls.Add(rbSpeed2);
            gbBeltSpeed.Controls.Add(rbSpeed1);
            gbBeltSpeed.FlatStyle = FlatStyle.Flat;
            gbBeltSpeed.ForeColor = SystemColors.Desktop;
            gbBeltSpeed.Location = new Point(231, 66);
            gbBeltSpeed.Name = "gbBeltSpeed";
            gbBeltSpeed.Size = new Size(178, 69);
            gbBeltSpeed.TabIndex = 7;
            gbBeltSpeed.TabStop = false;
            gbBeltSpeed.Text = "Velocidade da Esteira";
            // 
            // rbSpeed4
            // 
            rbSpeed4.AutoSize = true;
            rbSpeed4.Location = new Point(138, 32);
            rbSpeed4.Name = "rbSpeed4";
            rbSpeed4.Size = new Size(38, 24);
            rbSpeed4.TabIndex = 3;
            rbSpeed4.Text = "4";
            rbSpeed4.UseVisualStyleBackColor = true;
            // 
            // rbSpeed3
            // 
            rbSpeed3.AutoSize = true;
            rbSpeed3.Location = new Point(94, 32);
            rbSpeed3.Name = "rbSpeed3";
            rbSpeed3.Size = new Size(38, 24);
            rbSpeed3.TabIndex = 2;
            rbSpeed3.Text = "3";
            rbSpeed3.UseVisualStyleBackColor = true;
            // 
            // rbSpeed2
            // 
            rbSpeed2.AutoSize = true;
            rbSpeed2.Location = new Point(50, 32);
            rbSpeed2.Name = "rbSpeed2";
            rbSpeed2.Size = new Size(38, 24);
            rbSpeed2.TabIndex = 1;
            rbSpeed2.Text = "2";
            rbSpeed2.UseVisualStyleBackColor = true;
            // 
            // rbSpeed1
            // 
            rbSpeed1.AutoSize = true;
            rbSpeed1.Checked = true;
            rbSpeed1.Location = new Point(6, 32);
            rbSpeed1.Name = "rbSpeed1";
            rbSpeed1.Size = new Size(38, 24);
            rbSpeed1.TabIndex = 0;
            rbSpeed1.TabStop = true;
            rbSpeed1.Text = "1";
            rbSpeed1.UseVisualStyleBackColor = true;
            // 
            // gbBeltStatus
            // 
            gbBeltStatus.BackColor = SystemColors.ControlLight;
            gbBeltStatus.Controls.Add(lblErrorStatus);
            gbBeltStatus.Controls.Add(pErrorStatus);
            gbBeltStatus.Controls.Add(lblBusyStatus);
            gbBeltStatus.Controls.Add(pBusyStatus);
            gbBeltStatus.Controls.Add(pMotorStatus);
            gbBeltStatus.Controls.Add(lblMotor);
            gbBeltStatus.FlatStyle = FlatStyle.Flat;
            gbBeltStatus.ForeColor = SystemColors.Desktop;
            gbBeltStatus.Location = new Point(424, 66);
            gbBeltStatus.Name = "gbBeltStatus";
            gbBeltStatus.Size = new Size(278, 69);
            gbBeltStatus.TabIndex = 8;
            gbBeltStatus.TabStop = false;
            gbBeltStatus.Text = "Estado da Esteira";
            // 
            // lblErrorStatus
            // 
            lblErrorStatus.AutoSize = true;
            lblErrorStatus.Location = new Point(239, 36);
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
            pErrorStatus.Location = new Point(205, 33);
            pErrorStatus.Name = "pErrorStatus";
            pErrorStatus.Size = new Size(28, 28);
            pErrorStatus.TabIndex = 2;
            // 
            // lblBusyStatus
            // 
            lblBusyStatus.AutoSize = true;
            lblBusyStatus.Location = new Point(130, 36);
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
            pBusyStatus.Location = new Point(96, 33);
            pBusyStatus.Name = "pBusyStatus";
            pBusyStatus.Size = new Size(28, 28);
            pBusyStatus.TabIndex = 1;
            // 
            // pMotorStatus
            // 
            pMotorStatus.BackColor = Color.Transparent;
            pMotorStatus.BackgroundImage = ServerBeltIdentifier.Properties.Resources.green_led_off;
            pMotorStatus.BackgroundImageLayout = ImageLayout.Stretch;
            pMotorStatus.Location = new Point(6, 33);
            pMotorStatus.Name = "pMotorStatus";
            pMotorStatus.Size = new Size(28, 28);
            pMotorStatus.TabIndex = 0;
            // 
            // lblMotor
            // 
            lblMotor.AutoSize = true;
            lblMotor.Location = new Point(40, 36);
            lblMotor.Name = "lblMotor";
            lblMotor.Size = new Size(50, 20);
            lblMotor.TabIndex = 3;
            lblMotor.Text = "Motor";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(16, 176);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(95, 29);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(716, 456);
            Controls.Add(btnStop);
            Controls.Add(btnAddPiece);
            Controls.Add(btnReset);
            Controls.Add(gbTypePiece);
            Controls.Add(gbBeltStatus);
            Controls.Add(gbBeltSpeed);
            Controls.Add(gbControlType);
            Controls.Add(btnStart);
            Controls.Add(lblServerUrl);
            Controls.Add(cbServerUrl);
            Controls.Add(tbcModules);
            ImeMode = ImeMode.Off;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(950, 650);
            Name = "ServerForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servidor da Esteira Identificadora de Peças";
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
            gbBeltSpeed.ResumeLayout(false);
            gbBeltSpeed.PerformLayout();
            gbBeltStatus.ResumeLayout(false);
            gbBeltStatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbServerUrl;
        private Label lblServerUrl;
        private Button btnStart;
        private Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private TabControl tbcModules;
        private TabPage tpModule2;
        private TabPage tpModule1;
        private GroupBox gbControlType;
        private RadioButton rbAutomatic;
        private RadioButton rbManual;
        private GroupBox gbBeltSpeed;
        private RadioButton rbSpeed4;
        private RadioButton rbSpeed3;
        private RadioButton rbSpeed2;
        private RadioButton rbSpeed1;
        private GroupBox gbBeltStatus;
        private Button btnReset;
        private Label lblErrorStatus;
        private Panel pErrorStatus;
        private Label lblBusyStatus;
        private Panel pBusyStatus;
        private Panel pMotorStatus;
        private Label lblMotor;
        private GroupBox gbOpcStatusModule1;
        private Label lblOpaque;
        private Panel pNonMetallic;
        private Panel pMetallic;
        private Panel pOpaque;
        private Button btnAddPiece;
        private GroupBox gbTypePiece;
        private RadioButton rbNonMetallic;
        private RadioButton rbMetallic;
        private RadioButton rbOpaque;
        private TextBox tbQuantityNonMetallic;
        private Label lblNonMetallic;
        private TextBox tbQuantityMetallic;
        private Label lblMetallic;
        private TextBox tbQuantityOpaque;
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
    }
}