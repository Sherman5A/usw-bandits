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
            ButtonAddProduct = new Button();
            TableProductDetails = new TableLayoutPanel();
            LabelRate = new Label();
            LabelAccName = new Label();
            TextAccName = new TextBox();
            LabelId = new Label();
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
            LabelTitle.Location = new Point(231, 12);
            LabelTitle.Margin = new Padding(4, 0, 4, 0);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(139, 45);
            LabelTitle.TabIndex = 1;
            LabelTitle.Text = "Product";
            // 
            // ButtonAddProduct
            // 
            ButtonAddProduct.Location = new Point(231, 478);
            ButtonAddProduct.Margin = new Padding(4, 5, 4, 5);
            ButtonAddProduct.Name = "ButtonAddProduct";
            ButtonAddProduct.Size = new Size(257, 103);
            ButtonAddProduct.TabIndex = 3;
            ButtonAddProduct.Text = "Add Product";
            ButtonAddProduct.UseVisualStyleBackColor = true;
            // 
            // TableProductDetails
            // 
            TableProductDetails.ColumnCount = 2;
            TableProductDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.54474F));
            TableProductDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.45526F));
            TableProductDetails.Controls.Add(LabelRate, 0, 3);
            TableProductDetails.Controls.Add(LabelAccName, 0, 1);
            TableProductDetails.Controls.Add(TextAccName, 1, 1);
            TableProductDetails.Controls.Add(LabelId, 1, 0);
            TableProductDetails.Controls.Add(ComboStatus, 1, 2);
            TableProductDetails.Controls.Add(NumericRate, 1, 3);
            TableProductDetails.Controls.Add(LabelStatus, 0, 2);
            TableProductDetails.Controls.Add(LabelLabelID, 0, 0);
            TableProductDetails.Location = new Point(231, 67);
            TableProductDetails.Margin = new Padding(4, 5, 4, 5);
            TableProductDetails.Name = "TableProductDetails";
            TableProductDetails.RowCount = 4;
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableProductDetails.Size = new Size(543, 402);
            TableProductDetails.TabIndex = 4;
            // 
            // LabelRate
            // 
            LabelRate.Anchor = AnchorStyles.Right;
            LabelRate.AutoSize = true;
            LabelRate.BackColor = Color.Transparent;
            LabelRate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelRate.Location = new Point(34, 331);
            LabelRate.Margin = new Padding(4, 0, 4, 0);
            LabelRate.Name = "LabelRate";
            LabelRate.Size = new Size(171, 40);
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
            LabelAccName.Location = new Point(84, 110);
            LabelAccName.Margin = new Padding(4, 0, 4, 0);
            LabelAccName.Name = "LabelAccName";
            LabelAccName.Size = new Size(121, 80);
            LabelAccName.TabIndex = 9;
            LabelAccName.Text = "Account Name";
            LabelAccName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TextAccName
            // 
            TextAccName.Anchor = AnchorStyles.Left;
            TextAccName.Location = new Point(213, 134);
            TextAccName.Margin = new Padding(4, 5, 4, 5);
            TextAccName.Name = "TextAccName";
            TextAccName.Size = new Size(314, 31);
            TextAccName.TabIndex = 1;
            // 
            // LabelId
            // 
            LabelId.Anchor = AnchorStyles.Left;
            LabelId.AutoSize = true;
            LabelId.BackColor = Color.Transparent;
            LabelId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelId.Location = new Point(213, 30);
            LabelId.Margin = new Padding(4, 0, 4, 0);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(81, 40);
            LabelId.TabIndex = 5;
            LabelId.Text = "2321";
            // 
            // ComboStatus
            // 
            ComboStatus.Anchor = AnchorStyles.Left;
            ComboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboStatus.FormattingEnabled = true;
            ComboStatus.Items.AddRange(new object[] { "Closed", "Open" });
            ComboStatus.Location = new Point(213, 233);
            ComboStatus.Margin = new Padding(4, 5, 4, 5);
            ComboStatus.MaxDropDownItems = 2;
            ComboStatus.Name = "ComboStatus";
            ComboStatus.Size = new Size(314, 33);
            ComboStatus.Sorted = true;
            ComboStatus.TabIndex = 6;
            // 
            // NumericRate
            // 
            NumericRate.Anchor = AnchorStyles.Left;
            NumericRate.DecimalPlaces = 5;
            NumericRate.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NumericRate.Location = new Point(213, 335);
            NumericRate.Margin = new Padding(4, 5, 4, 5);
            NumericRate.Name = "NumericRate";
            NumericRate.Size = new Size(316, 31);
            NumericRate.TabIndex = 7;
            // 
            // LabelStatus
            // 
            LabelStatus.Anchor = AnchorStyles.Right;
            LabelStatus.AutoSize = true;
            LabelStatus.BackColor = Color.Transparent;
            LabelStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelStatus.Location = new Point(111, 230);
            LabelStatus.Margin = new Padding(4, 0, 4, 0);
            LabelStatus.Name = "LabelStatus";
            LabelStatus.Size = new Size(94, 40);
            LabelStatus.TabIndex = 10;
            LabelStatus.Text = "Status";
            LabelStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelLabelID
            // 
            LabelLabelID.Anchor = AnchorStyles.Right;
            LabelLabelID.BackColor = Color.Transparent;
            LabelLabelID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelLabelID.Location = new Point(61, 29);
            LabelLabelID.Margin = new Padding(4, 0, 4, 0);
            LabelLabelID.Name = "LabelLabelID";
            LabelLabelID.Size = new Size(144, 42);
            LabelLabelID.TabIndex = 8;
            LabelLabelID.Text = "Product ID";
            LabelLabelID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(0);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(6, 10, 6, 10);
            SideNav.Size = new Size(214, 667);
            SideNav.TabIndex = 5;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(517, 478);
            ButtonDelete.Margin = new Padding(4, 5, 4, 5);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(257, 103);
            ButtonDelete.TabIndex = 6;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonDelete);
            Controls.Add(SideNav);
            Controls.Add(TableProductDetails);
            Controls.Add(ButtonAddProduct);
            Controls.Add(LabelTitle);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Product";
            Size = new Size(1000, 667);
            Load += OnProductLoad;
            TableProductDetails.ResumeLayout(false);
            TableProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitle;
        private Button ButtonAddProduct;
        private TableLayoutPanel TableProductDetails;
        private TextBox TextAccName;
        private Label LabelId;
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
