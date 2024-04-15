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
            BtnConnect.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            BtnConnect.Location = new Point(34, 36);
            BtnConnect.Margin = new Padding(3, 4, 3, 4);
            BtnConnect.Name = "BtnConnect";
            BtnConnect.Size = new Size(614, 245);
            BtnConnect.TabIndex = 0;
            BtnConnect.Text = "Connect";
            BtnConnect.UseVisualStyleBackColor = true;
            BtnConnect.Click += OnBtnConnectClick;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            Controls.Add(BtnConnect);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Start";
            Size = new Size(686, 533);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnConnect;
    }
}
