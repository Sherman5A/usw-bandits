namespace USWBandits.views
{
    partial class Stats
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
            ButtonCalcInterest = new Button();
            ButtonCustomerByHoldings = new Button();
            ButtonTotalTransaction = new Button();
            LabelTitle = new Label();
            TableButtons = new TableLayoutPanel();
            ButtonTransactionByCustomer = new Button();
            TableButtons.SuspendLayout();
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
            SideNav.TabIndex = 5;
            // 
            // ButtonCalcInterest
            // 
            ButtonCalcInterest.Dock = DockStyle.Fill;
            ButtonCalcInterest.Location = new Point(10, 10);
            ButtonCalcInterest.Margin = new Padding(10);
            ButtonCalcInterest.Name = "ButtonCalcInterest";
            ButtonCalcInterest.Size = new Size(567, 103);
            ButtonCalcInterest.TabIndex = 6;
            ButtonCalcInterest.Text = "Calculate Accrued Interest";
            ButtonCalcInterest.UseVisualStyleBackColor = true;
            // 
            // ButtonCustomerByHoldings
            // 
            ButtonCustomerByHoldings.Dock = DockStyle.Fill;
            ButtonCustomerByHoldings.Location = new Point(10, 133);
            ButtonCustomerByHoldings.Margin = new Padding(10);
            ButtonCustomerByHoldings.Name = "ButtonCustomerByHoldings";
            ButtonCustomerByHoldings.Size = new Size(567, 103);
            ButtonCustomerByHoldings.TabIndex = 7;
            ButtonCustomerByHoldings.Text = "List Customers According to their Holdings";
            ButtonCustomerByHoldings.UseVisualStyleBackColor = true;
            // 
            // ButtonTotalTransaction
            // 
            ButtonTotalTransaction.Dock = DockStyle.Fill;
            ButtonTotalTransaction.Location = new Point(10, 256);
            ButtonTotalTransaction.Margin = new Padding(10);
            ButtonTotalTransaction.Name = "ButtonTotalTransaction";
            ButtonTotalTransaction.Size = new Size(567, 103);
            ButtonTotalTransaction.TabIndex = 8;
            ButtonTotalTransaction.Text = "Report Total Transactions by Date";
            ButtonTotalTransaction.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(178, 9);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(80, 37);
            LabelTitle.TabIndex = 12;
            LabelTitle.Text = "Stats";
            // 
            // TableButtons
            // 
            TableButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableButtons.ColumnCount = 1;
            TableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableButtons.Controls.Add(ButtonTransactionByCustomer, 0, 3);
            TableButtons.Controls.Add(ButtonCalcInterest, 0, 0);
            TableButtons.Controls.Add(ButtonCustomerByHoldings, 0, 1);
            TableButtons.Controls.Add(ButtonTotalTransaction, 0, 2);
            TableButtons.Location = new Point(178, 53);
            TableButtons.Margin = new Padding(3, 4, 3, 4);
            TableButtons.Name = "TableButtons";
            TableButtons.RowCount = 4;
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            TableButtons.Size = new Size(587, 492);
            TableButtons.TabIndex = 13;
            // 
            // ButtonTransactionByCustomer
            // 
            ButtonTransactionByCustomer.Dock = DockStyle.Fill;
            ButtonTransactionByCustomer.Location = new Point(10, 379);
            ButtonTransactionByCustomer.Margin = new Padding(10);
            ButtonTransactionByCustomer.Name = "ButtonTransactionByCustomer";
            ButtonTransactionByCustomer.Size = new Size(567, 103);
            ButtonTransactionByCustomer.TabIndex = 14;
            ButtonTransactionByCustomer.Text = "Display Transactions by Customer Key";
            ButtonTransactionByCustomer.UseVisualStyleBackColor = true;
            // 
            // Stats
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableButtons);
            Controls.Add(LabelTitle);
            Controls.Add(SideNav);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Stats";
            Size = new Size(782, 549);
            Load += OnProductLoad;
            TableButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private components.SideNav SideNav;
        private Button ButtonCalcInterest;
        private Button ButtonCustomerByHoldings;
        private Button ButtonTotalTransaction;
        private Label LabelTitle;
        private TableLayoutPanel TableButtons;
        private Button ButtonTransactionByCustomer;
    }
}
