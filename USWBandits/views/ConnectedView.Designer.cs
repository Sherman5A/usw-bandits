namespace USWBandits.views
{
    partial class ConnectedView
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
            sideNav.Size = new Size(156, 350);
            sideNav.TabIndex = 1;
            // 
            // ConnectedViews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sideNav);
            Name = "ConnectedViews";
            Size = new Size(614, 350);
            ResumeLayout(false);
        }

        #endregion

        public components.SideNav sideNav;
    }
}
