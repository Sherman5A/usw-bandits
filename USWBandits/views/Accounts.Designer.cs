namespace USWBandits.views
{
    partial class Accounts
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
            LabelTitle = new Label();
            SuspendLayout();
            // 
            // sideNav
            // 
            sideNav.Size = new Size(156, 354);
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(162, 11);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(108, 30);
            LabelTitle.TabIndex = 1;
            LabelTitle.Text = "Accounts";
            // 
            // Accounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LabelTitle);
            Name = "Accounts";
            Size = new Size(663, 354);
            Load += OnAccountsLoad;
            Controls.SetChildIndex(sideNav, 0);
            Controls.SetChildIndex(LabelTitle, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitle;
    }
}
