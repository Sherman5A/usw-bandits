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
            SideNav.Margin = new Padding(3, 4, 3, 4);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(4, 6, 4, 6);
            SideNav.Size = new Size(150, 412);
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
            TableAccountDetails.Location = new Point(155, 40);
            TableAccountDetails.Name = "TableAccountDetails";
            TableAccountDetails.RowCount = 3;
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            TableAccountDetails.Size = new Size(514, 89);
            TableAccountDetails.TabIndex = 7;
            // 
            // DateTo
            // 
            DateTo.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DateTo.CustomFormat = "yyyy:MM:dd HH:mm";
            DateTo.Format = DateTimePickerFormat.Custom;
            DateTo.Location = new Point(133, 32);
            DateTo.Name = "DateTo";
            DateTo.Size = new Size(378, 23);
            DateTo.TabIndex = 18;
            // 
            // DateFrom
            // 
            DateFrom.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DateFrom.CustomFormat = "yyyy:MM:dd HH:mm";
            DateFrom.Format = DateTimePickerFormat.Custom;
            DateFrom.Location = new Point(133, 3);
            DateFrom.Name = "DateFrom";
            DateFrom.Size = new Size(378, 23);
            DateFrom.TabIndex = 14;
            // 
            // LabelToDate
            // 
            LabelToDate.Anchor = AnchorStyles.Right;
            LabelToDate.AutoSize = true;
            LabelToDate.BackColor = Color.Transparent;
            LabelToDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelToDate.Location = new Point(52, 31);
            LabelToDate.Name = "LabelToDate";
            LabelToDate.Size = new Size(75, 25);
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
            ComboTransactionType.Location = new Point(133, 62);
            ComboTransactionType.Name = "ComboTransactionType";
            ComboTransactionType.Size = new Size(378, 23);
            ComboTransactionType.TabIndex = 6;
            // 
            // LabelProductID
            // 
            LabelProductID.Anchor = AnchorStyles.Right;
            LabelProductID.AutoSize = true;
            LabelProductID.BackColor = Color.Transparent;
            LabelProductID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelProductID.Location = new Point(76, 61);
            LabelProductID.Name = "LabelProductID";
            LabelProductID.Size = new Size(51, 25);
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
            LabelFromDate.Location = new Point(28, 2);
            LabelFromDate.Name = "LabelFromDate";
            LabelFromDate.Size = new Size(99, 25);
            LabelFromDate.TabIndex = 8;
            LabelFromDate.Text = "From Date";
            LabelFromDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(156, 6);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(360, 30);
            LabelTitle.TabIndex = 5;
            LabelTitle.Text = "Total Transactions Between Dates";
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(155, 135);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(514, 54);
            ButtonSearch.TabIndex = 17;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // ListSearchResults
            // 
            ListSearchResults.FormattingEnabled = true;
            ListSearchResults.ItemHeight = 15;
            ListSearchResults.Location = new Point(156, 193);
            ListSearchResults.Margin = new Padding(3, 2, 3, 2);
            ListSearchResults.Name = "ListSearchResults";
            ListSearchResults.Size = new Size(513, 214);
            ListSearchResults.TabIndex = 18;
            // 
            // TotalDepWith
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ListSearchResults);
            Controls.Add(ButtonSearch);
            Controls.Add(TableAccountDetails);
            Controls.Add(LabelTitle);
            Controls.Add(SideNav);
            Name = "TotalDepWith";
            Size = new Size(684, 412);
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
