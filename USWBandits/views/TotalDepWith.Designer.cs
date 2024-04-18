namespace USWBandits.views
{
    partial class TotalDepWith
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
            DateTo = new DateTimePicker();
            DateFrom = new DateTimePicker();
            LabelToDate = new Label();
            ComboTransactionType = new ComboBox();
            LabelProductID = new Label();
            LabelFromDate = new Label();
            LabelTitle = new Label();
            ButtonSearch = new Button();
            ListSearchResults = new ListBox();
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
            // TableAccountDetails
            // 
            TableAccountDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TableAccountDetails.ColumnCount = 2;
            TableAccountDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.4063435F));
            TableAccountDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.59366F));
            TableAccountDetails.Controls.Add(DateTo, 1, 1);
            TableAccountDetails.Controls.Add(DateFrom, 1, 0);
            TableAccountDetails.Controls.Add(LabelToDate, 0, 1);
            TableAccountDetails.Controls.Add(ComboTransactionType, 1, 2);
            TableAccountDetails.Controls.Add(LabelProductID, 0, 2);
            TableAccountDetails.Controls.Add(LabelFromDate, 0, 0);
            TableAccountDetails.Location = new Point(177, 53);
            TableAccountDetails.Margin = new Padding(3, 4, 3, 4);
            TableAccountDetails.Name = "TableAccountDetails";
            TableAccountDetails.RowCount = 3;
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableAccountDetails.Size = new Size(587, 119);
            TableAccountDetails.TabIndex = 7;
            // 
            // DateTo
            // 
            DateTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DateTo.Format = DateTimePickerFormat.Custom;
            DateTo.Location = new Point(152, 45);
            DateTo.Margin = new Padding(3, 4, 3, 4);
            DateTo.Name = "DateTo";
            DateTo.Size = new Size(432, 27);
            DateTo.TabIndex = 18;
            // 
            // DateFrom
            // 
            DateFrom.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DateFrom.Format = DateTimePickerFormat.Custom;
            DateFrom.Location = new Point(152, 6);
            DateFrom.Margin = new Padding(3, 4, 3, 4);
            DateFrom.Name = "DateFrom";
            DateFrom.Size = new Size(432, 27);
            DateFrom.TabIndex = 14;
            // 
            // LabelToDate
            // 
            LabelToDate.Anchor = AnchorStyles.Right;
            LabelToDate.AutoSize = true;
            LabelToDate.BackColor = Color.Transparent;
            LabelToDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelToDate.Location = new Point(50, 42);
            LabelToDate.Name = "LabelToDate";
            LabelToDate.Size = new Size(96, 32);
            LabelToDate.TabIndex = 9;
            LabelToDate.Text = "To Date";
            LabelToDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ComboTransactionType
            // 
            ComboTransactionType.Anchor = AnchorStyles.Left;
            ComboTransactionType.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboTransactionType.FormattingEnabled = true;
            ComboTransactionType.Items.AddRange(new object[] { "All", "Deposit", "Transfer In", "Transfer Out", "Withdraw" });
            ComboTransactionType.Location = new Point(152, 84);
            ComboTransactionType.Margin = new Padding(3, 4, 3, 4);
            ComboTransactionType.Name = "ComboTransactionType";
            ComboTransactionType.Size = new Size(431, 28);
            ComboTransactionType.TabIndex = 6;
            // 
            // LabelProductID
            // 
            LabelProductID.Anchor = AnchorStyles.Right;
            LabelProductID.AutoSize = true;
            LabelProductID.BackColor = Color.Transparent;
            LabelProductID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelProductID.Location = new Point(81, 82);
            LabelProductID.Name = "LabelProductID";
            LabelProductID.Size = new Size(65, 32);
            LabelProductID.TabIndex = 10;
            LabelProductID.Text = "Type";
            LabelProductID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelFromDate
            // 
            LabelFromDate.Anchor = AnchorStyles.Right;
            LabelFromDate.AutoSize = true;
            LabelFromDate.BackColor = Color.Transparent;
            LabelFromDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelFromDate.Location = new Point(20, 3);
            LabelFromDate.Name = "LabelFromDate";
            LabelFromDate.Size = new Size(126, 32);
            LabelFromDate.TabIndex = 8;
            LabelFromDate.Text = "From Date";
            LabelFromDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(178, 8);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(447, 37);
            LabelTitle.TabIndex = 5;
            LabelTitle.Text = "Total Transactions Between Dates";
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(177, 180);
            ButtonSearch.Margin = new Padding(3, 4, 3, 4);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(587, 72);
            ButtonSearch.TabIndex = 17;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // ListSearchResults
            // 
            ListSearchResults.FormattingEnabled = true;
            ListSearchResults.ItemHeight = 20;
            ListSearchResults.Location = new Point(178, 257);
            ListSearchResults.Name = "ListSearchResults";
            ListSearchResults.Size = new Size(586, 284);
            ListSearchResults.TabIndex = 18;
            // 
            // TotalDepWith
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ListSearchResults);
            Controls.Add(ButtonSearch);
            Controls.Add(TableAccountDetails);
            Controls.Add(LabelTitle);
            Controls.Add(SideNav);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TotalDepWith";
            Size = new Size(782, 549);
            Load += OnTotalDepWithLoad;
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
        private Label LabelProductID;
        private Label LabelFromDate;
        private Label LabelTitle;
        private Button ButtonSearch;
        private DateTimePicker DateTo;
        private DateTimePicker DateFrom;
        private ListBox ListSearchResults;
    }
}
