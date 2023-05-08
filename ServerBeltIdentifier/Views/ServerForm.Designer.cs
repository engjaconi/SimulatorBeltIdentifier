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
            ServerUrlComboBox = new ComboBox();
            ServerUrlLabel = new Label();
            StartButton = new Button();
            StopButton = new Button();
            textBox1 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // ServerUrlComboBox
            // 
            ServerUrlComboBox.DropDownStyle = ComboBoxStyle.Simple;
            ServerUrlComboBox.FormattingEnabled = true;
            ServerUrlComboBox.Location = new Point(138, 11);
            ServerUrlComboBox.Margin = new Padding(3, 4, 3, 4);
            ServerUrlComboBox.Name = "ServerUrlComboBox";
            ServerUrlComboBox.Size = new Size(764, 28);
            ServerUrlComboBox.TabIndex = 0;
            ServerUrlComboBox.SelectedIndexChanged += ServerUrlComboBox_SelectedIndexChanged;
            // 
            // ServerUrlLabel
            // 
            ServerUrlLabel.AutoSize = true;
            ServerUrlLabel.Location = new Point(16, 14);
            ServerUrlLabel.Name = "ServerUrlLabel";
            ServerUrlLabel.Size = new Size(120, 20);
            ServerUrlLabel.TabIndex = 1;
            ServerUrlLabel.Text = "URL do Servidor ";
            ServerUrlLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StartButton
            // 
            StartButton.Cursor = Cursors.Hand;
            StartButton.FlatAppearance.MouseDownBackColor = Color.Red;
            StartButton.FlatAppearance.MouseOverBackColor = Color.Blue;
            StartButton.Location = new Point(16, 62);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(120, 29);
            StartButton.TabIndex = 2;
            StartButton.Text = "Start (ON)";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Location = new Point(16, 97);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(120, 29);
            StopButton.TabIndex = 3;
            StopButton.Text = "Stop (OFF)";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 62);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 4;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(932, 603);
            Controls.Add(textBox1);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            Controls.Add(ServerUrlLabel);
            Controls.Add(ServerUrlComboBox);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(950, 650);
            MinimumSize = new Size(950, 650);
            Name = "ServerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Belt Identifier Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ServerUrlComboBox;
        private Label ServerUrlLabel;
        private Button StartButton;
        private Button StopButton;
        private Label MotorSpeedLabel { get; set; }
        public TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
    }
}