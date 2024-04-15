namespace USWBandits.views
{
    partial class Account
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
            SideNav = new components.SideNav();
            TableAccountDetails = new TableLayoutPanel();
            ComboCustomerID = new ComboBox();
            NumericAccrued = new NumericUpDown();
            LabelAccrued = new Label();
            LabelBalance = new Label();
            LabelCustomerID = new Label();
            LabelAccountID = new Label();
            ComboProductID = new ComboBox();
            NumericBalance = new NumericUpDown();
            LabelProductID = new Label();
            LabelForAccountID = new Label();
            LabelTitle = new Label();
            ButtonDelete = new Button();
            ButtonAdd = new Button();
            TableAccountDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericAccrued).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericBalance).BeginInit();
            SuspendLayout();
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(3, 4, 3, 4);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(4, 6, 4, 6);
            SideNav.Size = new Size(150, 400);
            SideNav.TabIndex = 3;
            // 
            // TableAccountDetails
            // 
            TableAccountDetails.ColumnCount = 2;
            TableAccountDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.54474F));
            TableAccountDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.45526F));
            TableAccountDetails.Controls.Add(ComboCustomerID, 1, 1);
            TableAccountDetails.Controls.Add(NumericAccrued, 1, 4);
            TableAccountDetails.Controls.Add(LabelAccrued, 0, 4);
            TableAccountDetails.Controls.Add(LabelBalance, 0, 3);
            TableAccountDetails.Controls.Add(LabelCustomerID, 0, 1);
            TableAccountDetails.Controls.Add(LabelAccountID, 1, 0);
            TableAccountDetails.Controls.Add(ComboProductID, 1, 2);
            TableAccountDetails.Controls.Add(NumericBalance, 1, 3);
            TableAccountDetails.Controls.Add(LabelProductID, 0, 2);
            TableAccountDetails.Controls.Add(LabelForAccountID, 0, 0);
            TableAccountDetails.Location = new Point(156, 39);
            TableAccountDetails.Name = "TableAccountDetails";
            TableAccountDetails.RowCount = 5;
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableAccountDetails.Size = new Size(380, 289);
            TableAccountDetails.TabIndex = 7;
            // 
            // ComboCustomerID
            // 
            ComboCustomerID.Anchor = AnchorStyles.Left;
            ComboCustomerID.FormattingEnabled = true;
            ComboCustomerID.Location = new Point(149, 74);
            ComboCustomerID.Name = "ComboCustomerID";
            ComboCustomerID.Size = new Size(221, 23);
            ComboCustomerID.TabIndex = 8;
            // 
            // NumericAccrued
            // 
            NumericAccrued.Anchor = AnchorStyles.Left;
            NumericAccrued.DecimalPlaces = 2;
            NumericAccrued.Location = new Point(149, 247);
            NumericAccrued.Name = "NumericAccrued";
            NumericAccrued.Size = new Size(221, 23);
            NumericAccrued.TabIndex = 8;
            NumericAccrued.ThousandsSeparator = true;
            // 
            // LabelAccrued
            // 
            LabelAccrued.Anchor = AnchorStyles.Right;
            LabelAccrued.AutoSize = true;
            LabelAccrued.BackColor = Color.Transparent;
            LabelAccrued.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAccrued.Location = new Point(62, 246);
            LabelAccrued.Name = "LabelAccrued";
            LabelAccrued.Size = new Size(81, 25);
            LabelAccrued.TabIndex = 12;
            LabelAccrued.Text = "Accrued";
            LabelAccrued.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelBalance
            // 
            LabelBalance.Anchor = AnchorStyles.Right;
            LabelBalance.AutoSize = true;
            LabelBalance.BackColor = Color.Transparent;
            LabelBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBalance.Location = new Point(65, 187);
            LabelBalance.Name = "LabelBalance";
            LabelBalance.Size = new Size(78, 25);
            LabelBalance.TabIndex = 11;
            LabelBalance.Text = "Balance";
            LabelBalance.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelCustomerID
            // 
            LabelCustomerID.Anchor = AnchorStyles.Right;
            LabelCustomerID.AutoSize = true;
            LabelCustomerID.BackColor = Color.Transparent;
            LabelCustomerID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCustomerID.Location = new Point(27, 73);
            LabelCustomerID.Name = "LabelCustomerID";
            LabelCustomerID.Size = new Size(116, 25);
            LabelCustomerID.TabIndex = 9;
            LabelCustomerID.Text = "Customer ID";
            LabelCustomerID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelAccountID
            // 
            LabelAccountID.Anchor = AnchorStyles.Left;
            LabelAccountID.AutoSize = true;
            LabelAccountID.BackColor = Color.Transparent;
            LabelAccountID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAccountID.Location = new Point(149, 16);
            LabelAccountID.Name = "LabelAccountID";
            LabelAccountID.Size = new Size(52, 25);
            LabelAccountID.TabIndex = 5;
            LabelAccountID.Text = "2321";
            // 
            // ComboProductID
            // 
            ComboProductID.Anchor = AnchorStyles.Left;
            ComboProductID.FormattingEnabled = true;
            ComboProductID.Location = new Point(149, 131);
            ComboProductID.Name = "ComboProductID";
            ComboProductID.Size = new Size(221, 23);
            ComboProductID.TabIndex = 6;
            // 
            // NumericBalance
            // 
            NumericBalance.Anchor = AnchorStyles.Left;
            NumericBalance.DecimalPlaces = 2;
            NumericBalance.Location = new Point(149, 188);
            NumericBalance.Name = "NumericBalance";
            NumericBalance.Size = new Size(221, 23);
            NumericBalance.TabIndex = 7;
            NumericBalance.ThousandsSeparator = true;
            // 
            // LabelProductID
            // 
            LabelProductID.Anchor = AnchorStyles.Right;
            LabelProductID.AutoSize = true;
            LabelProductID.BackColor = Color.Transparent;
            LabelProductID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelProductID.Location = new Point(42, 130);
            LabelProductID.Name = "LabelProductID";
            LabelProductID.Size = new Size(101, 25);
            LabelProductID.TabIndex = 10;
            LabelProductID.Text = "Product ID";
            LabelProductID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelForAccountID
            // 
            LabelForAccountID.Anchor = AnchorStyles.Right;
            LabelForAccountID.AutoSize = true;
            LabelForAccountID.BackColor = Color.Transparent;
            LabelForAccountID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelForAccountID.Location = new Point(39, 16);
            LabelForAccountID.Name = "LabelForAccountID";
            LabelForAccountID.Size = new Size(104, 25);
            LabelForAccountID.TabIndex = 8;
            LabelForAccountID.Text = "Account ID";
            LabelForAccountID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(156, 6);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(98, 30);
            LabelTitle.TabIndex = 5;
            LabelTitle.Text = "Account";
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(355, 338);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(180, 53);
            ButtonDelete.TabIndex = 9;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new Point(156, 338);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(180, 53);
            ButtonAdd.TabIndex = 8;
            ButtonAdd.Text = "Add Account";
            ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonAdd);
            Controls.Add(TableAccountDetails);
            Controls.Add(LabelTitle);
            Controls.Add(SideNav);
            Name = "Account";
            Size = new Size(600, 400);
            Load += OnAccountLoad;
            TableAccountDetails.ResumeLayout(false);
            TableAccountDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericAccrued).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericBalance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private components.SideNav SideNav;
        private TableLayoutPanel TableAccountDetails;
        private Label LabelBalance;
        private Label LabelCustomerID;
        private Label LabelAccountID;
        private ComboBox ComboProductID;
        private NumericUpDown NumericBalance;
        private Label LabelProductID;
        private Label LabelForAccountID;
        private Label LabelTitle;
        private Label LabelAccrued;
        private NumericUpDown NumericAccrued;
        private ComboBox ComboCustomerID;
        private Button ButtonDelete;
        private Button ButtonAdd;
    }
}
