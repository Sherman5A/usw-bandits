namespace USWBandits
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TopMenu = new MenuStrip();
            Host = new Panel();
            ButtonMenu = new ToolStrip();
            ButtonDisconnect = new ToolStripButton();
            LabelConnected = new ToolStripLabel();
            toolStripSeparator1 = new ToolStripSeparator();
            ButtonMenu.SuspendLayout();
            SuspendLayout();
            // 
            // TopMenu
            // 
            TopMenu.BackColor = SystemColors.ControlLight;
            TopMenu.Location = new Point(0, 0);
            TopMenu.Name = "TopMenu";
            TopMenu.Size = new Size(684, 24);
            TopMenu.TabIndex = 0;
            TopMenu.Text = "menuStrip1";
            // 
            // Host
            // 
            Host.Dock = DockStyle.Fill;
            Host.Location = new Point(0, 49);
            Host.Name = "Host";
            Host.Size = new Size(684, 412);
            Host.TabIndex = 2;
            Host.ControlAdded += HostControlAdded;
            // 
            // ButtonMenu
            // 
            ButtonMenu.BackColor = SystemColors.ControlLight;
            ButtonMenu.GripStyle = ToolStripGripStyle.Hidden;
            ButtonMenu.Items.AddRange(new ToolStripItem[] { ButtonDisconnect, LabelConnected, toolStripSeparator1 });
            ButtonMenu.Location = new Point(0, 24);
            ButtonMenu.Name = "ButtonMenu";
            ButtonMenu.Padding = new Padding(10, 0, 0, 0);
            ButtonMenu.Size = new Size(684, 25);
            ButtonMenu.Stretch = true;
            ButtonMenu.TabIndex = 1;
            // 
            // ButtonDisconnect
            // 
            ButtonDisconnect.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ButtonDisconnect.Image = Properties.Resources.Disconnect;
            ButtonDisconnect.ImageTransparentColor = Color.Magenta;
            ButtonDisconnect.Name = "ButtonDisconnect";
            ButtonDisconnect.Size = new Size(23, 22);
            ButtonDisconnect.Text = "Disconnect";
            ButtonDisconnect.ToolTipText = "Disconnect";
            ButtonDisconnect.Click += DisconnectClick;
            // 
            // LabelConnected
            // 
            LabelConnected.Name = "LabelConnected";
            LabelConnected.Size = new Size(79, 22);
            LabelConnected.Text = "Disconnected";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 461);
            Controls.Add(Host);
            Controls.Add(ButtonMenu);
            Controls.Add(TopMenu);
            MainMenuStrip = TopMenu;
            MinimumSize = new Size(700, 500);
            Name = "MainForm";
            Text = "Outlaw Hess";
            Load += MainFormLoad;
            ButtonMenu.ResumeLayout(false);
            ButtonMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip TopMenu;
        private Panel Host;
        private ToolStrip ButtonMenu;
        private ToolStripButton ButtonDisconnect;
        private ToolStripLabel LabelConnected;
        private ToolStripSeparator toolStripSeparator1;
    }
}
