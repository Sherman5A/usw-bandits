namespace USWBandits.views
{
    partial class Product
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
            ButtonUpdate = new Button();
            TableProductDetails = new TableLayoutPanel();
            LabelRate = new Label();
            LabelAccName = new Label();
            TextAccName = new TextBox();
            LabelID = new Label();
            ComboStatus = new ComboBox();
            NumericRate = new NumericUpDown();
            LabelStatus = new Label();
            LabelLabelID = new Label();
            SideNav = new components.SideNav();
            ButtonDelete = new Button();
            TableProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericRate).BeginInit();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(162, 7);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(96, 30);
            LabelTitle.TabIndex = 1;
            LabelTitle.Text = "Product";
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(162, 287);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(180, 62);
            ButtonUpdate.TabIndex = 3;
            ButtonUpdate.Text = "Update";
            ButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // TableProductDetails
            // 
            TableProductDetails.ColumnCount = 2;
            TableProductDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.54474F));
            TableProductDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.45526F));
            TableProductDetails.Controls.Add(LabelRate, 0, 3);
            TableProductDetails.Controls.Add(LabelAccName, 0, 1);
            TableProductDetails.Controls.Add(TextAccName, 1, 1);
            TableProductDetails.Controls.Add(LabelID, 1, 0);
            TableProductDetails.Controls.Add(ComboStatus, 1, 2);
            TableProductDetails.Controls.Add(NumericRate, 1, 3);
            TableProductDetails.Controls.Add(LabelStatus, 0, 2);
            TableProductDetails.Controls.Add(LabelLabelID, 0, 0);
            TableProductDetails.Location = new Point(162, 40);
            TableProductDetails.Name = "TableProductDetails";
            TableProductDetails.RowCount = 4;
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableProductDetails.Size = new Size(380, 241);
            TableProductDetails.TabIndex = 4;
            // 
            // LabelRate
            // 
            LabelRate.Anchor = AnchorStyles.Right;
            LabelRate.AutoSize = true;
            LabelRate.BackColor = Color.Transparent;
            LabelRate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelRate.Location = new Point(30, 198);
            LabelRate.Name = "LabelRate";
            LabelRate.Size = new Size(113, 25);
            LabelRate.TabIndex = 11;
            LabelRate.Text = "Interest rate";
            LabelRate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelAccName
            // 
            LabelAccName.Anchor = AnchorStyles.Right;
            LabelAccName.AutoSize = true;
            LabelAccName.BackColor = Color.Transparent;
            LabelAccName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAccName.Location = new Point(7, 77);
            LabelAccName.Name = "LabelAccName";
            LabelAccName.Size = new Size(136, 25);
            LabelAccName.TabIndex = 9;
            LabelAccName.Text = "Account Name";
            LabelAccName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TextAccName
            // 
            TextAccName.Anchor = AnchorStyles.Left;
            TextAccName.Location = new Point(149, 78);
            TextAccName.Name = "TextAccName";
            TextAccName.Size = new Size(221, 23);
            TextAccName.TabIndex = 1;
            // 
            // LabelID
            // 
            LabelID.Anchor = AnchorStyles.Left;
            LabelID.AutoSize = true;
            LabelID.BackColor = Color.Transparent;
            LabelID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelID.Location = new Point(149, 17);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(52, 25);
            LabelID.TabIndex = 5;
            LabelID.Text = "2321";
            // 
            // ComboStatus
            // 
            ComboStatus.Anchor = AnchorStyles.Left;
            ComboStatus.FormattingEnabled = true;
            ComboStatus.Location = new Point(149, 138);
            ComboStatus.Name = "ComboStatus";
            ComboStatus.Size = new Size(221, 23);
            ComboStatus.Sorted = true;
            ComboStatus.TabIndex = 6;
            // 
            // NumericRate
            // 
            NumericRate.Anchor = AnchorStyles.Left;
            NumericRate.DecimalPlaces = 5;
            NumericRate.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NumericRate.Location = new Point(149, 199);
            NumericRate.Name = "NumericRate";
            NumericRate.Size = new Size(221, 23);
            NumericRate.TabIndex = 7;
            // 
            // LabelStatus
            // 
            LabelStatus.Anchor = AnchorStyles.Right;
            LabelStatus.AutoSize = true;
            LabelStatus.BackColor = Color.Transparent;
            LabelStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelStatus.Location = new Point(81, 137);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new Size(62, 25);
            LabelStatus.TabIndex = 10;
            LabelStatus.Text = "Status";
            LabelStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelLabelID
            // 
            LabelLabelID.Anchor = AnchorStyles.Right;
            LabelLabelID.BackColor = Color.Transparent;
            LabelLabelID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLabelID.Location = new Point(42, 17);
            LabelLabelID.Name = "LabelLabelID";
            LabelLabelID.Size = new Size(101, 25);
            LabelLabelID.TabIndex = 8;
            LabelLabelID.Text = "Product ID";
            LabelLabelID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Name = "SideNav";
            SideNav.Size = new Size(150, 400);
            SideNav.TabIndex = 5;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(362, 287);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(180, 62);
            ButtonDelete.TabIndex = 6;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonDelete);
            Controls.Add(SideNav);
            Controls.Add(TableProductDetails);
            Controls.Add(ButtonUpdate);
            Controls.Add(LabelTitle);
            Name = "Product";
            Size = new Size(600, 400);
            Load += OnProductLoad;
            TableProductDetails.ResumeLayout(false);
            TableProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitle;
        private Button ButtonUpdate;
        private TableLayoutPanel TableProductDetails;
        private TextBox TextAccName;
        private Label LabelID;
        private ComboBox ComboStatus;
        private NumericUpDown NumericRate;
        private Label LabelAccName;
        private Label LabelLabelID;
        private Label LabelRate;
        private Label LabelStatus;
        private components.SideNav SideNav;
        private Button ButtonDelete;
    }
}
