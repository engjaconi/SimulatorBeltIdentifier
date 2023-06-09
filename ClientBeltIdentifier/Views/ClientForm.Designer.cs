﻿namespace ClientBeltIdentifier
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
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
            gbControlType = new GroupBox();
            rbAutomatic = new RadioButton();
            rbManual = new RadioButton();
            gbBeltStatus = new GroupBox();
            lblErrorStatus = new Label();
            pErrorStatus = new Panel();
            lblBusyStatus = new Label();
            pBusyStatus = new Panel();
            pMotorStatus = new Panel();
            lblMotor = new Label();
            btnReset = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblTitle = new Label();
            btnConect = new Button();
            tbServerUrl = new TextBox();
            tbcModules.SuspendLayout();
            tpModule1.SuspendLayout();
            gbOpcStatusModule1.SuspendLayout();
            tpModule2.SuspendLayout();
            gbOpcStatusModule2.SuspendLayout();
            gbControlType.SuspendLayout();
            gbBeltStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblServerUrl
            // 
            lblServerUrl.AutoSize = true;
            lblServerUrl.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblServerUrl.Location = new Point(10, 71);
            lblServerUrl.Name = "lblServerUrl";
            lblServerUrl.Size = new Size(151, 23);
            lblServerUrl.TabIndex = 1;
            lblServerUrl.Text = "URL do Servidor ";
            lblServerUrl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            btnStart.Cursor = Cursors.Hand;
            btnStart.Enabled = false;
            btnStart.FlatAppearance.MouseDownBackColor = Color.Red;
            btnStart.FlatAppearance.MouseOverBackColor = Color.Blue;
            btnStart.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnStart.Location = new Point(367, 125);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(134, 60);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += BtnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnStop.Location = new Point(507, 125);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(134, 60);
            btnStop.TabIndex = 3;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += BtnStop_Click;
            // 
            // timerUpdateForm
            // 
            timerUpdateForm.Interval = 200;
            timerUpdateForm.Tick += TimerUpdateForm_Tick;
            // 
            // tbcModules
            // 
            tbcModules.Controls.Add(tpModule1);
            tbcModules.Controls.Add(tpModule2);
            tbcModules.Enabled = false;
            tbcModules.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbcModules.Location = new Point(227, 191);
            tbcModules.Name = "tbcModules";
            tbcModules.SelectedIndex = 0;
            tbcModules.Size = new Size(559, 304);
            tbcModules.TabIndex = 5;
            // 
            // tpModule1
            // 
            tpModule1.Controls.Add(gbOpcStatusModule1);
            tpModule1.Location = new Point(4, 34);
            tpModule1.Name = "tpModule1";
            tpModule1.Padding = new Padding(3);
            tpModule1.Size = new Size(551, 266);
            tpModule1.TabIndex = 1;
            tpModule1.Text = "Módulo 1";
            tpModule1.UseVisualStyleBackColor = true;
            // 
            // gbOpcStatusModule1
            // 
            gbOpcStatusModule1.BackColor = Color.Transparent;
            gbOpcStatusModule1.Controls.Add(tbQuantityNonMetallic);
            gbOpcStatusModule1.Controls.Add(lblNonMetallic);
            gbOpcStatusModule1.Controls.Add(tbQuantityMetallic);
            gbOpcStatusModule1.Controls.Add(lblMetallic);
            gbOpcStatusModule1.Controls.Add(tbQuantityTransparent);
            gbOpcStatusModule1.Controls.Add(lblTransparent);
            gbOpcStatusModule1.Controls.Add(pNonMetallic);
            gbOpcStatusModule1.Controls.Add(pMetallic);
            gbOpcStatusModule1.Controls.Add(pTransparent);
            gbOpcStatusModule1.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            gbOpcStatusModule1.Location = new Point(6, 5);
            gbOpcStatusModule1.Name = "gbOpcStatusModule1";
            gbOpcStatusModule1.Size = new Size(539, 256);
            gbOpcStatusModule1.TabIndex = 2;
            gbOpcStatusModule1.TabStop = false;
            gbOpcStatusModule1.Text = "Estado das variáveis disponibilizadas via OPC";
            // 
            // tbQuantityNonMetallic
            // 
            tbQuantityNonMetallic.Location = new Point(417, 164);
            tbQuantityNonMetallic.Name = "tbQuantityNonMetallic";
            tbQuantityNonMetallic.ReadOnly = true;
            tbQuantityNonMetallic.Size = new Size(86, 31);
            tbQuantityNonMetallic.TabIndex = 8;
            // 
            // lblNonMetallic
            // 
            lblNonMetallic.AutoSize = true;
            lblNonMetallic.Location = new Point(398, 135);
            lblNonMetallic.Name = "lblNonMetallic";
            lblNonMetallic.Size = new Size(124, 23);
            lblNonMetallic.TabIndex = 7;
            lblNonMetallic.Text = "Não Metálica";
            // 
            // tbQuantityMetallic
            // 
            tbQuantityMetallic.Location = new Point(226, 164);
            tbQuantityMetallic.Name = "tbQuantityMetallic";
            tbQuantityMetallic.ReadOnly = true;
            tbQuantityMetallic.Size = new Size(86, 31);
            tbQuantityMetallic.TabIndex = 6;
            // 
            // lblMetallic
            // 
            lblMetallic.AutoSize = true;
            lblMetallic.Location = new Point(228, 135);
            lblMetallic.Name = "lblMetallic";
            lblMetallic.Size = new Size(83, 23);
            lblMetallic.TabIndex = 5;
            lblMetallic.Text = "Metálica";
            // 
            // tbQuantityTransparent
            // 
            tbQuantityTransparent.Location = new Point(32, 164);
            tbQuantityTransparent.Name = "tbQuantityTransparent";
            tbQuantityTransparent.ReadOnly = true;
            tbQuantityTransparent.Size = new Size(86, 31);
            tbQuantityTransparent.TabIndex = 4;
            // 
            // lblTransparent
            // 
            lblTransparent.AutoSize = true;
            lblTransparent.Location = new Point(14, 135);
            lblTransparent.Name = "lblTransparent";
            lblTransparent.Size = new Size(122, 23);
            lblTransparent.TabIndex = 3;
            lblTransparent.Text = "Transparente";
            // 
            // pNonMetallic
            // 
            pNonMetallic.BackColor = Color.Transparent;
            pNonMetallic.BackgroundImage = Properties.Resources.green_led_off;
            pNonMetallic.BackgroundImageLayout = ImageLayout.Stretch;
            pNonMetallic.Location = new Point(435, 76);
            pNonMetallic.Name = "pNonMetallic";
            pNonMetallic.Size = new Size(50, 51);
            pNonMetallic.TabIndex = 2;
            // 
            // pMetallic
            // 
            pMetallic.BackColor = Color.Transparent;
            pMetallic.BackgroundImage = Properties.Resources.green_led_off;
            pMetallic.BackgroundImageLayout = ImageLayout.Stretch;
            pMetallic.Location = new Point(244, 76);
            pMetallic.Name = "pMetallic";
            pMetallic.Size = new Size(50, 51);
            pMetallic.TabIndex = 2;
            // 
            // pTransparent
            // 
            pTransparent.BackColor = Color.Transparent;
            pTransparent.BackgroundImage = Properties.Resources.green_led_off;
            pTransparent.BackgroundImageLayout = ImageLayout.Stretch;
            pTransparent.Location = new Point(50, 76);
            pTransparent.Name = "pTransparent";
            pTransparent.Size = new Size(50, 51);
            pTransparent.TabIndex = 1;
            // 
            // tpModule2
            // 
            tpModule2.Controls.Add(gbOpcStatusModule2);
            tpModule2.Location = new Point(4, 34);
            tpModule2.Name = "tpModule2";
            tpModule2.Padding = new Padding(3);
            tpModule2.Size = new Size(551, 266);
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
            gbOpcStatusModule2.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            gbOpcStatusModule2.Location = new Point(6, 5);
            gbOpcStatusModule2.Name = "gbOpcStatusModule2";
            gbOpcStatusModule2.Size = new Size(539, 255);
            gbOpcStatusModule2.TabIndex = 0;
            gbOpcStatusModule2.TabStop = false;
            gbOpcStatusModule2.Text = "Estado das variáveis disponibilizadas via OPC";
            // 
            // lblBarrier3
            // 
            lblBarrier3.AutoSize = true;
            lblBarrier3.Location = new Point(418, 208);
            lblBarrier3.Name = "lblBarrier3";
            lblBarrier3.Size = new Size(92, 23);
            lblBarrier3.TabIndex = 11;
            lblBarrier3.Text = "Barreira 3";
            // 
            // lblInductive
            // 
            lblInductive.AutoSize = true;
            lblInductive.Location = new Point(229, 208);
            lblInductive.Name = "lblInductive";
            lblInductive.Size = new Size(80, 23);
            lblInductive.TabIndex = 11;
            lblInductive.Text = "Indutivo";
            // 
            // pBarrier3
            // 
            pBarrier3.BackColor = Color.Transparent;
            pBarrier3.BackgroundImage = Properties.Resources.green_led_off;
            pBarrier3.BackgroundImageLayout = ImageLayout.Stretch;
            pBarrier3.Location = new Point(439, 149);
            pBarrier3.Name = "pBarrier3";
            pBarrier3.Size = new Size(50, 51);
            pBarrier3.TabIndex = 10;
            // 
            // lblCapacitive
            // 
            lblCapacitive.AutoSize = true;
            lblCapacitive.Location = new Point(26, 208);
            lblCapacitive.Name = "lblCapacitive";
            lblCapacitive.Size = new Size(99, 23);
            lblCapacitive.TabIndex = 7;
            lblCapacitive.Text = "Capacitivo";
            // 
            // lblPhotoSensor
            // 
            lblPhotoSensor.AutoSize = true;
            lblPhotoSensor.Location = new Point(408, 93);
            lblPhotoSensor.Name = "lblPhotoSensor";
            lblPhotoSensor.Size = new Size(112, 23);
            lblPhotoSensor.TabIndex = 9;
            lblPhotoSensor.Text = "Fotoelétrico";
            // 
            // pInductive
            // 
            pInductive.BackColor = Color.Transparent;
            pInductive.BackgroundImage = Properties.Resources.green_led_off;
            pInductive.BackgroundImageLayout = ImageLayout.Stretch;
            pInductive.Location = new Point(244, 149);
            pInductive.Name = "pInductive";
            pInductive.Size = new Size(50, 51);
            pInductive.TabIndex = 10;
            // 
            // pPhotoSensor
            // 
            pPhotoSensor.BackColor = Color.Transparent;
            pPhotoSensor.BackgroundImage = Properties.Resources.green_led_off;
            pPhotoSensor.BackgroundImageLayout = ImageLayout.Stretch;
            pPhotoSensor.Location = new Point(439, 35);
            pPhotoSensor.Name = "pPhotoSensor";
            pPhotoSensor.Size = new Size(50, 51);
            pPhotoSensor.TabIndex = 8;
            // 
            // pCapacitive
            // 
            pCapacitive.BackColor = Color.Transparent;
            pCapacitive.BackgroundImage = Properties.Resources.green_led_off;
            pCapacitive.BackgroundImageLayout = ImageLayout.Stretch;
            pCapacitive.Location = new Point(50, 149);
            pCapacitive.Name = "pCapacitive";
            pCapacitive.Size = new Size(50, 51);
            pCapacitive.TabIndex = 6;
            // 
            // lblBarrier2
            // 
            lblBarrier2.AutoSize = true;
            lblBarrier2.Location = new Point(223, 93);
            lblBarrier2.Name = "lblBarrier2";
            lblBarrier2.Size = new Size(92, 23);
            lblBarrier2.TabIndex = 9;
            lblBarrier2.Text = "Barreira 2";
            // 
            // lblBarrier1
            // 
            lblBarrier1.AutoSize = true;
            lblBarrier1.Location = new Point(29, 93);
            lblBarrier1.Name = "lblBarrier1";
            lblBarrier1.Size = new Size(92, 23);
            lblBarrier1.TabIndex = 5;
            lblBarrier1.Text = "Barreira 1";
            // 
            // pBarrier2
            // 
            pBarrier2.BackColor = Color.Transparent;
            pBarrier2.BackgroundImage = Properties.Resources.green_led_off;
            pBarrier2.BackgroundImageLayout = ImageLayout.Stretch;
            pBarrier2.Location = new Point(244, 35);
            pBarrier2.Name = "pBarrier2";
            pBarrier2.Size = new Size(50, 51);
            pBarrier2.TabIndex = 8;
            // 
            // pBarrier1
            // 
            pBarrier1.BackColor = Color.Transparent;
            pBarrier1.BackgroundImage = Properties.Resources.green_led_off;
            pBarrier1.BackgroundImageLayout = ImageLayout.Stretch;
            pBarrier1.Location = new Point(50, 35);
            pBarrier1.Name = "pBarrier1";
            pBarrier1.Size = new Size(50, 51);
            pBarrier1.TabIndex = 4;
            // 
            // gbControlType
            // 
            gbControlType.BackColor = SystemColors.ControlLightLight;
            gbControlType.Controls.Add(rbAutomatic);
            gbControlType.Controls.Add(rbManual);
            gbControlType.Enabled = false;
            gbControlType.FlatStyle = FlatStyle.Flat;
            gbControlType.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            gbControlType.ForeColor = SystemColors.Desktop;
            gbControlType.Location = new Point(12, 112);
            gbControlType.Name = "gbControlType";
            gbControlType.Size = new Size(209, 103);
            gbControlType.TabIndex = 6;
            gbControlType.TabStop = false;
            gbControlType.Text = "Tipo de Controle";
            // 
            // rbAutomatic
            // 
            rbAutomatic.AutoSize = true;
            rbAutomatic.Location = new Point(8, 66);
            rbAutomatic.Name = "rbAutomatic";
            rbAutomatic.Size = new Size(131, 27);
            rbAutomatic.TabIndex = 1;
            rbAutomatic.Text = "Automático";
            rbAutomatic.UseVisualStyleBackColor = true;
            // 
            // rbManual
            // 
            rbManual.AutoSize = true;
            rbManual.Checked = true;
            rbManual.Location = new Point(8, 30);
            rbManual.Name = "rbManual";
            rbManual.Size = new Size(95, 27);
            rbManual.TabIndex = 0;
            rbManual.TabStop = true;
            rbManual.Text = "Manual";
            rbManual.UseVisualStyleBackColor = true;
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
            gbBeltStatus.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            gbBeltStatus.ForeColor = SystemColors.Desktop;
            gbBeltStatus.Location = new Point(12, 221);
            gbBeltStatus.Name = "gbBeltStatus";
            gbBeltStatus.Size = new Size(209, 140);
            gbBeltStatus.TabIndex = 8;
            gbBeltStatus.TabStop = false;
            gbBeltStatus.Text = "Estado da Esteira";
            // 
            // lblErrorStatus
            // 
            lblErrorStatus.AutoSize = true;
            lblErrorStatus.Location = new Point(46, 105);
            lblErrorStatus.Name = "lblErrorStatus";
            lblErrorStatus.Size = new Size(45, 23);
            lblErrorStatus.TabIndex = 5;
            lblErrorStatus.Text = "Erro";
            // 
            // pErrorStatus
            // 
            pErrorStatus.BackColor = Color.Transparent;
            pErrorStatus.BackgroundImage = Properties.Resources.red_led_off;
            pErrorStatus.BackgroundImageLayout = ImageLayout.Stretch;
            pErrorStatus.Location = new Point(10, 101);
            pErrorStatus.Name = "pErrorStatus";
            pErrorStatus.Size = new Size(30, 30);
            pErrorStatus.TabIndex = 2;
            // 
            // lblBusyStatus
            // 
            lblBusyStatus.AutoSize = true;
            lblBusyStatus.Location = new Point(45, 68);
            lblBusyStatus.Name = "lblBusyStatus";
            lblBusyStatus.Size = new Size(87, 23);
            lblBusyStatus.TabIndex = 4;
            lblBusyStatus.Text = "Ocupada";
            // 
            // pBusyStatus
            // 
            pBusyStatus.BackColor = Color.Transparent;
            pBusyStatus.BackgroundImage = Properties.Resources.green_led_off;
            pBusyStatus.BackgroundImageLayout = ImageLayout.Stretch;
            pBusyStatus.Location = new Point(10, 64);
            pBusyStatus.Name = "pBusyStatus";
            pBusyStatus.Size = new Size(30, 30);
            pBusyStatus.TabIndex = 1;
            // 
            // pMotorStatus
            // 
            pMotorStatus.BackColor = Color.Transparent;
            pMotorStatus.BackgroundImage = Properties.Resources.green_led_off;
            pMotorStatus.BackgroundImageLayout = ImageLayout.Stretch;
            pMotorStatus.Location = new Point(10, 28);
            pMotorStatus.Name = "pMotorStatus";
            pMotorStatus.Size = new Size(30, 30);
            pMotorStatus.TabIndex = 0;
            // 
            // lblMotor
            // 
            lblMotor.AutoSize = true;
            lblMotor.Location = new Point(46, 32);
            lblMotor.Name = "lblMotor";
            lblMotor.Size = new Size(125, 23);
            lblMotor.TabIndex = 3;
            lblMotor.Text = "Motor Ligado";
            // 
            // btnReset
            // 
            btnReset.Enabled = false;
            btnReset.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnReset.Location = new Point(647, 125);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(134, 60);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnReset_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.OPC_UA_Logo;
            pictureBox1.Location = new Point(649, 68);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo_ucl_blue;
            pictureBox2.Location = new Point(12, 433);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Georgia", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.HotTrack;
            lblTitle.Location = new Point(110, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(587, 39);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "Cliente da Esteira Identificadora";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConect
            // 
            btnConect.BackColor = Color.LightGreen;
            btnConect.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnConect.Location = new Point(227, 124);
            btnConect.Name = "btnConect";
            btnConect.Size = new Size(134, 61);
            btnConect.TabIndex = 13;
            btnConect.Text = "Conectar";
            btnConect.UseVisualStyleBackColor = false;
            btnConect.Click += BtnConect_Click;
            // 
            // tbServerUrl
            // 
            tbServerUrl.Font = new Font("Microsoft JhengHei", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            tbServerUrl.Location = new Point(167, 68);
            tbServerUrl.Name = "tbServerUrl";
            tbServerUrl.PlaceholderText = "Exemplo: opc.tcp://localhost:26543/ServerBeltIdentifier";
            tbServerUrl.Size = new Size(476, 31);
            tbServerUrl.TabIndex = 14;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(797, 503);
            Controls.Add(tbServerUrl);
            Controls.Add(btnConect);
            Controls.Add(lblTitle);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnStop);
            Controls.Add(btnReset);
            Controls.Add(gbBeltStatus);
            Controls.Add(gbControlType);
            Controls.Add(btnStart);
            Controls.Add(lblServerUrl);
            Controls.Add(tbcModules);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(815, 550);
            MinimumSize = new Size(815, 550);
            Name = "ClientForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Client Belt Identifier";
            tbcModules.ResumeLayout(false);
            tpModule1.ResumeLayout(false);
            gbOpcStatusModule1.ResumeLayout(false);
            gbOpcStatusModule1.PerformLayout();
            tpModule2.ResumeLayout(false);
            gbOpcStatusModule2.ResumeLayout(false);
            gbOpcStatusModule2.PerformLayout();
            gbControlType.ResumeLayout(false);
            gbControlType.PerformLayout();
            gbBeltStatus.ResumeLayout(false);
            gbBeltStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private System.Windows.Forms.Timer timerAuto;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblTitle;
        private Button btnConect;
        private TextBox tbServerUrl;
    }
}