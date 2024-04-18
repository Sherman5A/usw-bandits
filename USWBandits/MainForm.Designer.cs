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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            TopMenu = new MenuStrip();
            Host = new Panel();
            ButtonMenu = new ToolStrip();
            BackButton = new ToolStripButton();
            ForwardButton = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
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
            ButtonMenu.Items.AddRange(new ToolStripItem[] { BackButton, ForwardButton, toolStripLabel1, toolStripSeparator1 });
            ButtonMenu.Location = new Point(0, 24);
            ButtonMenu.Name = "ButtonMenu";
            ButtonMenu.Padding = new Padding(10, 0, 0, 0);
            ButtonMenu.Size = new Size(684, 25);
            ButtonMenu.Stretch = true;
            ButtonMenu.TabIndex = 1;
            // 
            // BackButton
            // 
            BackButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            BackButton.Image = (Image)resources.GetObject("BackButton.Image");
            BackButton.ImageTransparentColor = Color.Magenta;
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(23, 22);
            BackButton.Text = "toolStripButton1";
            // 
            // ForwardButton
            // 
            ForwardButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ForwardButton.Image = (Image)resources.GetObject("ForwardButton.Image");
            ForwardButton.ImageTransparentColor = Color.Magenta;
            ForwardButton.Name = "ForwardButton";
            ForwardButton.Size = new Size(23, 22);
            ForwardButton.Text = "toolStripButton2";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(65, 22);
            toolStripLabel1.Text = "Connected";
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
        private ToolStripButton BackButton;
        private ToolStripButton ForwardButton;
        private ToolStripLabel toolStripLabel1;
        private ToolStripSeparator toolStripSeparator1;
    }
}
