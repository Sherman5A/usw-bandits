namespace USWBandits.views
{
    partial class CustomersByHoldings
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
            ListCustomers.Location = new Point(178, 57);
            ListCustomers.Name = "ListCustomers";
            ListCustomers.Size = new Size(586, 484);
            ListCustomers.TabIndex = 18;
            // 
            // CustomersByHoldings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ListCustomers);
            Controls.Add(LabelTitle);
            Controls.Add(SideNav);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomersByHoldings";
            Size = new Size(782, 549);
            Load += OnCustomersLoad;
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
        private ListBox ListCustomers;
    }
}
