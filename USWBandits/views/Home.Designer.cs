namespace USWBandits.views
{
    partial class Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sideNav = new components.SideNav();
            SuspendLayout();
            // 
            // sideNav
            // 
            sideNav.Dock = DockStyle.Left;
            sideNav.Location = new Point(0, 0);
            sideNav.Name = "sideNav";
            sideNav.Size = new Size(156, 411);
            sideNav.TabIndex = 0;
            // 
            // ConnectedHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sideNav);
            Name = "ConnectedHome";
            Size = new Size(770, 411);
            ResumeLayout(false);
        }

        #endregion

        public components.SideNav sideNav;
    }
}
