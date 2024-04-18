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
            ButtonFolder = new Button();
            LabelDatabasePathTitle = new Label();
            LabelDatabasePath = new Label();
            SuspendLayout();
            // 
            // BtnConnect
            // 
            BtnConnect.AutoSize = true;
            BtnConnect.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            BtnConnect.Location = new Point(45, 257);
            BtnConnect.Name = "BtnConnect";
            BtnConnect.Size = new Size(609, 122);
            BtnConnect.TabIndex = 0;
            BtnConnect.Text = "Connect";
            BtnConnect.UseVisualStyleBackColor = true;
            BtnConnect.Click += OnBtnConnectClick;
            // 
            // ButtonFolder
            // 
            ButtonFolder.AutoSize = true;
            ButtonFolder.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonFolder.Location = new Point(45, 99);
            ButtonFolder.Name = "ButtonFolder";
            ButtonFolder.Size = new Size(609, 122);
            ButtonFolder.TabIndex = 1;
            ButtonFolder.Text = "Browse for Database";
            ButtonFolder.UseVisualStyleBackColor = true;
            ButtonFolder.Click += ButtonFolderClick;
            // 
            // LabelDatabasePathTitle
            // 
            LabelDatabasePathTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDatabasePathTitle.Location = new Point(45, 40);
            LabelDatabasePathTitle.Name = "LabelDatabasePathTitle";
            LabelDatabasePathTitle.Size = new Size(67, 46);
            LabelDatabasePathTitle.TabIndex = 2;
            LabelDatabasePathTitle.Text = "Path";
            // 
            // LabelDatabasePath
            // 
            LabelDatabasePath.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDatabasePath.Location = new Point(133, 40);
            LabelDatabasePath.Name = "LabelDatabasePath";
            LabelDatabasePath.Size = new Size(504, 46);
            LabelDatabasePath.TabIndex = 3;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.Control;
            Controls.Add(LabelDatabasePath);
            Controls.Add(LabelDatabasePathTitle);
            Controls.Add(ButtonFolder);
            Controls.Add(BtnConnect);
            Name = "Start";
            Size = new Size(684, 412);
            Load += StartLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnConnect;
        private Button ButtonFolder;
        private Label LabelDatabasePathTitle;
        private Label LabelDatabasePath;
    }
}
