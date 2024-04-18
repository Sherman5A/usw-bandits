namespace USWBandits.views
{
    partial class TransactionsByCustomer
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
            LabelTitle = new Label();
            ListCustomers = new ListBox();
            TableAccountDetails = new TableLayoutPanel();
            LabelAccountID = new Label();
            LabelForAccountID = new Label();
            TableAccountDetails.SuspendLayout();
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
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(178, 8);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(315, 37);
            LabelTitle.TabIndex = 5;
            LabelTitle.Text = "Customers By Holdings";
            // 
            // ListCustomers
            // 
            ListCustomers.FormattingEnabled = true;
            ListCustomers.ItemHeight = 20;
            ListCustomers.Location = new Point(178, 117);
            ListCustomers.Name = "ListCustomers";
            ListCustomers.Size = new Size(586, 424);
            ListCustomers.TabIndex = 18;
            // 
            // TableAccountDetails
            // 
            TableAccountDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TableAccountDetails.ColumnCount = 2;
            TableAccountDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.4063435F));
            TableAccountDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.59366F));
            TableAccountDetails.Controls.Add(LabelAccountID, 1, 0);
            TableAccountDetails.Controls.Add(LabelForAccountID, 0, 0);
            TableAccountDetails.Location = new Point(177, 49);
            TableAccountDetails.Margin = new Padding(3, 4, 3, 4);
            TableAccountDetails.Name = "TableAccountDetails";
            TableAccountDetails.RowCount = 1;
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.Size = new Size(587, 61);
            TableAccountDetails.TabIndex = 19;
            // 
            // LabelAccountID
            // 
            LabelAccountID.Anchor = AnchorStyles.Left;
            LabelAccountID.AutoSize = true;
            LabelAccountID.BackColor = Color.Transparent;
            LabelAccountID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAccountID.Location = new Point(152, 14);
            LabelAccountID.Name = "LabelAccountID";
            LabelAccountID.Size = new Size(66, 32);
            LabelAccountID.TabIndex = 5;
            LabelAccountID.Text = "2321";
            // 
            // LabelForAccountID
            // 
            LabelForAccountID.Anchor = AnchorStyles.Right;
            LabelForAccountID.AutoSize = true;
            LabelForAccountID.BackColor = Color.Transparent;
            LabelForAccountID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelForAccountID.Location = new Point(15, 14);
            LabelForAccountID.Name = "LabelForAccountID";
            LabelForAccountID.Size = new Size(131, 32);
            LabelForAccountID.TabIndex = 8;
            LabelForAccountID.Text = "Account ID";
            LabelForAccountID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TransactionsByCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableAccountDetails);
            Controls.Add(ListCustomers);
            Controls.Add(LabelTitle);
            Controls.Add(SideNav);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TransactionsByCustomer";
            Size = new Size(782, 549);
            Load += OnCustomersLoad;
            TableAccountDetails.ResumeLayout(false);
            TableAccountDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private components.SideNav SideNav;
        private TableLayoutPanel TableAccountDetails;
        private Label LabelToDate;
        private ComboBox ComboTransactionType;
        private Label LabelFromDate;
        private Label LabelTitle;
        private Button ButtonSearch;
        private DateTimePicker DateTo;
        private DateTimePicker DateFrom;
        private ListBox ListCustomers;
        private Label LabelAccountID;
        private Label LabelForAccountID;
    }
}
