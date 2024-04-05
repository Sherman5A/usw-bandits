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
            FileItem = new ToolStripMenuItem();
            OpenFileItem = new ToolStripMenuItem();
            RecentsItem = new ToolStripMenuItem();
            ExitItem = new ToolStripMenuItem();
            ViewItem = new ToolStripMenuItem();
            Host = new Panel();
            ButtonMenu = new ToolStrip();
            BackButton = new ToolStripButton();
            ForwardButton = new ToolStripButton();
            DisconnectButton = new ToolStripButton();
            TopMenu.SuspendLayout();
            ButtonMenu.SuspendLayout();
            SuspendLayout();
            // 
            // TopMenu
            // 
            TopMenu.BackColor = Color.Silver;
            TopMenu.Items.AddRange(new ToolStripItem[] { FileItem, ViewItem });
            TopMenu.Location = new Point(0, 0);
            TopMenu.Name = "TopMenu";
            TopMenu.Size = new Size(609, 24);
            TopMenu.TabIndex = 0;
            TopMenu.Text = "menuStrip1";
            // 
            // FileItem
            // 
            FileItem.DropDownItems.AddRange(new ToolStripItem[] { OpenFileItem, RecentsItem, ExitItem });
            FileItem.Name = "FileItem";
            FileItem.Size = new Size(37, 20);
            FileItem.Text = "&File";
            // 
            // OpenFileItem
            // 
            OpenFileItem.Name = "OpenFileItem";
            OpenFileItem.Size = new Size(180, 22);
            OpenFileItem.Text = "&Open file";
            // 
            // RecentsItem
            // 
            RecentsItem.Name = "RecentsItem";
            RecentsItem.Size = new Size(180, 22);
            RecentsItem.Text = "&Recents";
            // 
            // ExitItem
            // 
            ExitItem.Name = "ExitItem";
            ExitItem.Size = new Size(180, 22);
            ExitItem.Text = "Exit";
            // 
            // ViewItem
            // 
            ViewItem.Name = "ViewItem";
            ViewItem.Size = new Size(44, 20);
            ViewItem.Text = "&View";
            // 
            // Host
            // 
            Host.Dock = DockStyle.Fill;
            Host.Location = new Point(0, 49);
            Host.Name = "Host";
            Host.Size = new Size(609, 388);
            Host.TabIndex = 2;
            Host.ControlAdded += HostControlAdded;
            // 
            // ButtonMenu
            // 
            ButtonMenu.BackColor = Color.Silver;
            ButtonMenu.GripStyle = ToolStripGripStyle.Hidden;
            ButtonMenu.Items.AddRange(new ToolStripItem[] { BackButton, ForwardButton, DisconnectButton });
            ButtonMenu.Location = new Point(0, 24);
            ButtonMenu.Name = "ButtonMenu";
            ButtonMenu.Padding = new Padding(10, 0, 0, 0);
            ButtonMenu.Size = new Size(609, 25);
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
            // DisconnectButton
            // 
            DisconnectButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            DisconnectButton.Image = (Image)resources.GetObject("DisconnectButton.Image");
            DisconnectButton.ImageTransparentColor = Color.Magenta;
            DisconnectButton.Name = "DisconnectButton";
            DisconnectButton.Size = new Size(23, 22);
            DisconnectButton.Text = "toolStripButton1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 437);
            Controls.Add(Host);
            Controls.Add(ButtonMenu);
            Controls.Add(TopMenu);
            MainMenuStrip = TopMenu;
            Name = "MainForm";
            Text = "Outlaw Hess";
            Load += MainForm_Load;
            TopMenu.ResumeLayout(false);
            TopMenu.PerformLayout();
            ButtonMenu.ResumeLayout(false);
            ButtonMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip TopMenu;
        private ToolStripMenuItem FileItem;
        private ToolStripMenuItem OpenFileItem;
        private ToolStripMenuItem RecentsItem;
        private ToolStripMenuItem ExitItem;
        private Panel Host;
        private ToolStripMenuItem ViewItem;
        private ToolStrip ButtonMenu;
        private ToolStripButton BackButton;
        private ToolStripButton ForwardButton;
        private ToolStripButton DisconnectButton;
    }
}
