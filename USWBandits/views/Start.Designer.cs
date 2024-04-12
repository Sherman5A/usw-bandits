namespace USWBandits.views
{
    partial class Start
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
            BtnConnect = new Button();
            SuspendLayout();
            // 
            // BtnConnect
            // 
            BtnConnect.AutoSize = true;
            BtnConnect.Location = new Point(21, 16);
            BtnConnect.Name = "BtnConnect";
            BtnConnect.Size = new Size(305, 217);
            BtnConnect.TabIndex = 0;
            BtnConnect.Text = "Connect";
            BtnConnect.UseVisualStyleBackColor = true;
            BtnConnect.Click += OnBtnConnectClick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            Controls.Add(BtnConnect);
            Name = "Home";
            Size = new Size(1016, 637);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnConnect;
    }
}
