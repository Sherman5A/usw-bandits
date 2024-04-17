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
            ButtonListCustByDeposit = new Button();
            ButtonTotalTransaction = new Button();
            LabelTitle = new Label();
            TableButtons = new TableLayoutPanel();
            TableButtons.SuspendLayout();
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
            SideNav.TabIndex = 5;
            // 
            // ButtonCalcInterest
            // 
            ButtonCalcInterest.Dock = DockStyle.Fill;
            ButtonCalcInterest.Location = new Point(20, 20);
            ButtonCalcInterest.Margin = new Padding(20);
            ButtonCalcInterest.Name = "ButtonCalcInterest";
            ButtonCalcInterest.Size = new Size(474, 83);
            ButtonCalcInterest.TabIndex = 6;
            ButtonCalcInterest.Text = "Calculate Accrued Interest";
            ButtonCalcInterest.UseVisualStyleBackColor = true;
            // 
            // ButtonListCustByDeposit
            // 
            ButtonListCustByDeposit.Dock = DockStyle.Fill;
            ButtonListCustByDeposit.Location = new Point(20, 143);
            ButtonListCustByDeposit.Margin = new Padding(20);
            ButtonListCustByDeposit.Name = "ButtonListCustByDeposit";
            ButtonListCustByDeposit.Size = new Size(474, 83);
            ButtonListCustByDeposit.TabIndex = 7;
            ButtonListCustByDeposit.Text = "List Customers by Deposit";
            ButtonListCustByDeposit.UseVisualStyleBackColor = true;
            // 
            // ButtonTotalTransaction
            // 
            ButtonTotalTransaction.Dock = DockStyle.Fill;
            ButtonTotalTransaction.Location = new Point(20, 266);
            ButtonTotalTransaction.Margin = new Padding(20);
            ButtonTotalTransaction.Name = "ButtonTotalTransaction";
            ButtonTotalTransaction.Size = new Size(474, 83);
            ButtonTotalTransaction.TabIndex = 8;
            ButtonTotalTransaction.Text = "Report Total Transactions by Date";
            ButtonTotalTransaction.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(156, 7);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(64, 30);
            LabelTitle.TabIndex = 12;
            LabelTitle.Text = "Stats";
            // 
            // TableButtons
            // 
            TableButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableButtons.ColumnCount = 1;
            TableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            TableButtons.Controls.Add(ButtonCalcInterest, 0, 0);
            TableButtons.Controls.Add(ButtonListCustByDeposit, 0, 1);
            TableButtons.Controls.Add(ButtonTotalTransaction, 0, 2);
            TableButtons.Location = new Point(156, 40);
            TableButtons.Name = "TableButtons";
            TableButtons.RowCount = 3;
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            TableButtons.Size = new Size(514, 369);
            TableButtons.TabIndex = 13;
            // 
            // Stats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableButtons);
            Controls.Add(LabelTitle);
            Controls.Add(SideNav);
            Name = "Stats";
            Size = new Size(684, 412);
            Load += OnProductLoad;
            TableButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private components.SideNav SideNav;
        private Button ButtonCalcInterest;
        private Button ButtonListCustByDeposit;
        private Button ButtonTotalTransaction;
        private Label LabelTitle;
        private TableLayoutPanel TableButtons;
    }
}
