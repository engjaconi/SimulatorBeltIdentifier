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
            ServerUrlComboBox = new ComboBox();
            ServerUrlLabel = new Label();
            SuspendLayout();
            // 
            // ServerUrlComboBox
            // 
            ServerUrlComboBox.DropDownStyle = ComboBoxStyle.Simple;
            ServerUrlComboBox.Enabled = false;
            ServerUrlComboBox.FormattingEnabled = true;
            ServerUrlComboBox.Location = new Point(138, 11);
            ServerUrlComboBox.Margin = new Padding(3, 4, 3, 4);
            ServerUrlComboBox.Name = "ServerUrlComboBox";
            ServerUrlComboBox.Size = new Size(764, 28);
            ServerUrlComboBox.TabIndex = 0;
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
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(932, 603);
            Controls.Add(ServerUrlLabel);
            Controls.Add(ServerUrlComboBox);
            Enabled = false;
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
    }
}