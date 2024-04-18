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
            LabelCustomerId = new Label();
            ComboCustomerId = new ComboBox();
            ButtonSearch = new Button();
            TableAccountDetails.SuspendLayout();
            SuspendLayout();
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(3, 4, 3, 4);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(4, 6, 4, 6);
            SideNav.Size = new Size(150, 412);
            SideNav.TabIndex = 3;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(156, 6);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(280, 30);
            LabelTitle.TabIndex = 5;
            LabelTitle.Text = "Transactions by Customer";
            // 
            // ListCustomers
            // 
            ListCustomers.FormattingEnabled = true;
            ListCustomers.ItemHeight = 15;
            ListCustomers.Location = new Point(156, 146);
            ListCustomers.Margin = new Padding(3, 2, 3, 2);
            ListCustomers.Name = "ListCustomers";
            ListCustomers.Size = new Size(513, 259);
            ListCustomers.TabIndex = 18;
            // 
            // TableAccountDetails
            // 
            TableAccountDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TableAccountDetails.ColumnCount = 2;
            TableAccountDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.4063435F));
            TableAccountDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.59366F));
            TableAccountDetails.Controls.Add(LabelCustomerId, 0, 0);
            TableAccountDetails.Controls.Add(ComboCustomerId, 1, 0);
            TableAccountDetails.Location = new Point(155, 37);
            TableAccountDetails.Name = "TableAccountDetails";
            TableAccountDetails.RowCount = 1;
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.Size = new Size(514, 46);
            TableAccountDetails.TabIndex = 19;
            // 
            // LabelCustomerId
            // 
            LabelCustomerId.Anchor = AnchorStyles.Right;
            LabelCustomerId.AutoSize = true;
            LabelCustomerId.BackColor = Color.Transparent;
            LabelCustomerId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCustomerId.Location = new Point(11, 10);
            LabelCustomerId.Name = "LabelCustomerId";
            LabelCustomerId.Size = new Size(116, 25);
            LabelCustomerId.TabIndex = 21;
            LabelCustomerId.Text = "Customer ID";
            LabelCustomerId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ComboCustomerId
            // 
            ComboCustomerId.Anchor = AnchorStyles.Left;
            ComboCustomerId.FormattingEnabled = true;
            ComboCustomerId.Location = new Point(133, 11);
            ComboCustomerId.Name = "ComboCustomerId";
            ComboCustomerId.Size = new Size(378, 23);
            ComboCustomerId.TabIndex = 20;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(156, 89);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(513, 52);
            ButtonSearch.TabIndex = 20;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // TransactionsByCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonSearch);
            Controls.Add(TableAccountDetails);
            Controls.Add(ListCustomers);
            Controls.Add(LabelTitle);
            Controls.Add(SideNav);
            Name = "TransactionsByCustomer";
            Size = new Size(684, 412);
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
        private Label LabelCustomerId;
        private ComboBox ComboCustomerId;
    }
}
