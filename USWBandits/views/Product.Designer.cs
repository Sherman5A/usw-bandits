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
            LabelId = new Label();
            ComboStatus = new ComboBox();
            NumericRate = new NumericUpDown();
            LabelStatus = new Label();
            LabelLabelID = new Label();
            TextAccName = new TextBox();
            SideNav = new components.SideNav();
            ButtonDelete = new Button();
            Table = new TableLayoutPanel();
            TableProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericRate).BeginInit();
            Table.SuspendLayout();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(153, 7);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(96, 30);
            LabelTitle.TabIndex = 1;
            LabelTitle.Text = "Product";
            // 
            // ButtonAddProduct
            // 
            ButtonAddProduct.Dock = DockStyle.Fill;
            ButtonAddProduct.Location = new Point(3, 3);
            ButtonAddProduct.Name = "ButtonAddProduct";
            ButtonAddProduct.Size = new Size(252, 56);
            ButtonAddProduct.TabIndex = 3;
            ButtonAddProduct.Text = "Add Product";
            ButtonAddProduct.UseVisualStyleBackColor = true;
            // 
            // TableProductDetails
            // 
            TableProductDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TableProductDetails.ColumnCount = 2;
            TableProductDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.54474F));
            TableProductDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.45526F));
            TableProductDetails.Controls.Add(LabelRate, 0, 3);
            TableProductDetails.Controls.Add(LabelAccName, 0, 1);
            TableProductDetails.Controls.Add(LabelId, 1, 0);
            TableProductDetails.Controls.Add(ComboStatus, 1, 2);
            TableProductDetails.Controls.Add(NumericRate, 1, 3);
            TableProductDetails.Controls.Add(LabelStatus, 0, 2);
            TableProductDetails.Controls.Add(LabelLabelID, 0, 0);
            TableProductDetails.Controls.Add(TextAccName, 1, 1);
            TableProductDetails.Location = new Point(153, 40);
            TableProductDetails.Name = "TableProductDetails";
            TableProductDetails.RowCount = 4;
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableProductDetails.Size = new Size(517, 290);
            TableProductDetails.TabIndex = 4;
            // 
            // LabelRate
            // 
            LabelRate.Anchor = AnchorStyles.Right;
            LabelRate.AutoSize = true;
            LabelRate.BackColor = Color.Transparent;
            LabelRate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelRate.Location = new Point(83, 240);
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
            LabelAccName.Location = new Point(60, 95);
            LabelAccName.Name = "LabelAccName";
            LabelAccName.Size = new Size(136, 25);
            LabelAccName.TabIndex = 9;
            LabelAccName.Text = "Account Name";
            LabelAccName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelId
            // 
            LabelId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LabelId.AutoSize = true;
            LabelId.BackColor = Color.Transparent;
            LabelId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelId.Location = new Point(202, 23);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(312, 25);
            LabelId.TabIndex = 5;
            LabelId.Text = "2321";
            // 
            // ComboStatus
            // 
            ComboStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboStatus.FormattingEnabled = true;
            ComboStatus.Items.AddRange(new object[] { "Closed", "Open" });
            ComboStatus.Location = new Point(202, 168);
            ComboStatus.MaxDropDownItems = 2;
            ComboStatus.Name = "ComboStatus";
            ComboStatus.Size = new Size(312, 23);
            ComboStatus.Sorted = true;
            ComboStatus.TabIndex = 6;
            // 
            // NumericRate
            // 
            NumericRate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NumericRate.DecimalPlaces = 5;
            NumericRate.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NumericRate.Location = new Point(202, 241);
            NumericRate.Name = "NumericRate";
            NumericRate.Size = new Size(312, 23);
            NumericRate.TabIndex = 7;
            // 
            // LabelStatus
            // 
            LabelStatus.Anchor = AnchorStyles.Right;
            LabelStatus.AutoSize = true;
            LabelStatus.BackColor = Color.Transparent;
            LabelStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelStatus.Location = new Point(134, 167);
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
            LabelLabelID.Location = new Point(95, 23);
            LabelLabelID.Name = "LabelLabelID";
            LabelLabelID.Size = new Size(101, 25);
            LabelLabelID.TabIndex = 8;
            LabelLabelID.Text = "Product ID";
            LabelLabelID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TextAccName
            // 
            TextAccName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TextAccName.Location = new Point(202, 96);
            TextAccName.Name = "TextAccName";
            TextAccName.Size = new Size(312, 23);
            TextAccName.TabIndex = 1;
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(0);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(4, 6, 4, 6);
            SideNav.Size = new Size(150, 412);
            SideNav.TabIndex = 5;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Dock = DockStyle.Fill;
            ButtonDelete.Enabled = false;
            ButtonDelete.Location = new Point(261, 3);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(253, 56);
            ButtonDelete.TabIndex = 6;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // Table
            // 
            Table.Anchor = AnchorStyles.Bottom;
            Table.ColumnCount = 2;
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            Table.Controls.Add(ButtonAddProduct, 0, 0);
            Table.Controls.Add(ButtonDelete, 1, 0);
            Table.Location = new Point(153, 347);
            Table.Name = "Table";
            Table.RowCount = 1;
            Table.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Table.Size = new Size(517, 62);
            Table.TabIndex = 17;
            // 
            // Product
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Table);
            Controls.Add(SideNav);
            Controls.Add(TableProductDetails);
            Controls.Add(LabelTitle);
            Name = "Product";
            Size = new Size(684, 412);
            Load += OnProductLoad;
            TableProductDetails.ResumeLayout(false);
            TableProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericRate).EndInit();
            Table.ResumeLayout(false);
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
        private TableLayoutPanel Table;
    }
}
