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
            LabelAccrued = new Label();
            LabelBalance = new Label();
            LabelCustomerID = new Label();
            LabelAccountID = new Label();
            ComboProductID = new ComboBox();
            NumericBalance = new NumericUpDown();
            LabelProductID = new Label();
            LabelForAccountID = new Label();
            NumericAccrued = new NumericUpDown();
            LabelTitle = new Label();
            ButtonDelete = new Button();
            ButtonAdd = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            TableAccountDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericBalance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericAccrued).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(3, 5, 3, 5);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(5, 8, 5, 8);
            SideNav.Size = new Size(171, 549);
            SideNav.TabIndex = 3;
            // 
            // TableAccountDetails
            // 
            TableAccountDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TableAccountDetails.ColumnCount = 2;
            TableAccountDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.4063435F));
            TableAccountDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.59366F));
            TableAccountDetails.Controls.Add(ComboCustomerID, 1, 1);
            TableAccountDetails.Controls.Add(LabelAccrued, 0, 4);
            TableAccountDetails.Controls.Add(LabelBalance, 0, 3);
            TableAccountDetails.Controls.Add(LabelCustomerID, 0, 1);
            TableAccountDetails.Controls.Add(LabelAccountID, 1, 0);
            TableAccountDetails.Controls.Add(ComboProductID, 1, 2);
            TableAccountDetails.Controls.Add(NumericBalance, 1, 3);
            TableAccountDetails.Controls.Add(LabelProductID, 0, 2);
            TableAccountDetails.Controls.Add(LabelForAccountID, 0, 0);
            TableAccountDetails.Controls.Add(NumericAccrued, 1, 4);
            TableAccountDetails.Location = new Point(177, 49);
            TableAccountDetails.Margin = new Padding(3, 4, 3, 4);
            TableAccountDetails.Name = "TableAccountDetails";
            TableAccountDetails.RowCount = 5;
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.Size = new Size(587, 388);
            TableAccountDetails.TabIndex = 7;
            // 
            // ComboCustomerID
            // 
            ComboCustomerID.Anchor = AnchorStyles.Left;
            ComboCustomerID.FormattingEnabled = true;
            ComboCustomerID.Location = new Point(152, 101);
            ComboCustomerID.Margin = new Padding(3, 4, 3, 4);
            ComboCustomerID.Name = "ComboCustomerID";
            ComboCustomerID.Size = new Size(431, 28);
            ComboCustomerID.TabIndex = 8;
            // 
            // LabelAccrued
            // 
            LabelAccrued.Anchor = AnchorStyles.Right;
            LabelAccrued.AutoSize = true;
            LabelAccrued.BackColor = Color.Transparent;
            LabelAccrued.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAccrued.Location = new Point(46, 332);
            LabelAccrued.Name = "LabelAccrued";
            LabelAccrued.Size = new Size(100, 32);
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
            LabelBalance.Location = new Point(50, 253);
            LabelBalance.Name = "LabelBalance";
            LabelBalance.Size = new Size(96, 32);
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
            LabelCustomerID.Location = new Point(29, 83);
            LabelCustomerID.Name = "LabelCustomerID";
            LabelCustomerID.Size = new Size(117, 64);
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
            LabelAccountID.Location = new Point(152, 22);
            LabelAccountID.Name = "LabelAccountID";
            LabelAccountID.Size = new Size(66, 32);
            LabelAccountID.TabIndex = 5;
            LabelAccountID.Text = "2321";
            // 
            // ComboProductID
            // 
            ComboProductID.Anchor = AnchorStyles.Left;
            ComboProductID.FormattingEnabled = true;
            ComboProductID.Location = new Point(152, 178);
            ComboProductID.Margin = new Padding(3, 4, 3, 4);
            ComboProductID.Name = "ComboProductID";
            ComboProductID.Size = new Size(431, 28);
            ComboProductID.TabIndex = 6;
            // 
            // NumericBalance
            // 
            NumericBalance.Anchor = AnchorStyles.Left;
            NumericBalance.DecimalPlaces = 2;
            NumericBalance.Location = new Point(152, 256);
            NumericBalance.Margin = new Padding(3, 4, 3, 4);
            NumericBalance.Name = "NumericBalance";
            NumericBalance.Size = new Size(432, 27);
            NumericBalance.TabIndex = 7;
            NumericBalance.ThousandsSeparator = true;
            // 
            // LabelProductID
            // 
            LabelProductID.Anchor = AnchorStyles.Right;
            LabelProductID.AutoSize = true;
            LabelProductID.BackColor = Color.Transparent;
            LabelProductID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelProductID.Location = new Point(20, 176);
            LabelProductID.Name = "LabelProductID";
            LabelProductID.Size = new Size(126, 32);
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
            LabelForAccountID.Location = new Point(15, 22);
            LabelForAccountID.Name = "LabelForAccountID";
            LabelForAccountID.Size = new Size(131, 32);
            LabelForAccountID.TabIndex = 8;
            LabelForAccountID.Text = "Account ID";
            LabelForAccountID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NumericAccrued
            // 
            NumericAccrued.Anchor = AnchorStyles.Left;
            NumericAccrued.DecimalPlaces = 2;
            NumericAccrued.Location = new Point(152, 334);
            NumericAccrued.Margin = new Padding(3, 4, 3, 4);
            NumericAccrued.Name = "NumericAccrued";
            NumericAccrued.Size = new Size(432, 27);
            NumericAccrued.TabIndex = 8;
            NumericAccrued.ThousandsSeparator = true;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(178, 8);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(122, 37);
            LabelTitle.TabIndex = 5;
            LabelTitle.Text = "Account";
            // 
            // ButtonDelete
            // 
            ButtonDelete.Dock = DockStyle.Fill;
            ButtonDelete.Location = new Point(298, 4);
            ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(290, 72);
            ButtonDelete.TabIndex = 9;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Dock = DockStyle.Fill;
            ButtonAdd.Location = new Point(3, 4);
            ButtonAdd.Margin = new Padding(3, 4, 3, 4);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new Size(289, 72);
            ButtonAdd.TabIndex = 8;
            ButtonAdd.Text = "Add Account";
            ButtonAdd.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ButtonAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(ButtonDelete, 1, 0);
            tableLayoutPanel1.Location = new Point(177, 465);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(591, 80);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(TableAccountDetails);
            Controls.Add(LabelTitle);
            Controls.Add(SideNav);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Account";
            Size = new Size(782, 549);
            Load += OnAccountLoad;
            TableAccountDetails.ResumeLayout(false);
            TableAccountDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericBalance).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericAccrued).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
    }
}
