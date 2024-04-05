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
            topMenu = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            recentsToolStripMenuItem = new ToolStripMenuItem();
            bobToolStripMenuItem = new ToolStripMenuItem();
            testToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            host = new Panel();
            topMenu.SuspendLayout();
            SuspendLayout();
            // 
            // topMenu
            // 
            topMenu.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            topMenu.Location = new Point(0, 0);
            topMenu.Name = "topMenu";
            topMenu.Size = new Size(800, 24);
            topMenu.TabIndex = 0;
            topMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, recentsToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(180, 22);
            openFileToolStripMenuItem.Text = "&Open file";
            // 
            // recentsToolStripMenuItem
            // 
            recentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bobToolStripMenuItem, testToolStripMenuItem });
            recentsToolStripMenuItem.Name = "recentsToolStripMenuItem";
            recentsToolStripMenuItem.Size = new Size(180, 22);
            recentsToolStripMenuItem.Text = "&Recents";
            // 
            // bobToolStripMenuItem
            // 
            bobToolStripMenuItem.Name = "bobToolStripMenuItem";
            bobToolStripMenuItem.Size = new Size(95, 22);
            bobToolStripMenuItem.Text = "Bob";
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new Size(95, 22);
            testToolStripMenuItem.Text = "Test";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // host
            // 
            host.Location = new Point(0, 27);
            host.Name = "host";
            host.Size = new Size(800, 424);
            host.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(host);
            Controls.Add(topMenu);
            MainMenuStrip = topMenu;
            Name = "Main";
            Text = "Outlaw Hess";
            topMenu.ResumeLayout(false);
            topMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip topMenu;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem recentsToolStripMenuItem;
        private ToolStripMenuItem bobToolStripMenuItem;
        private ToolStripMenuItem testToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel host;
    }
}