namespace USWBandits.views
{
    partial class Customers
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
            ButtonSearch = new Button();
            ButtonAddCustomer = new Button();
            SideNav = new components.SideNav();
            LabelTitle = new Label();
            ButtonTransactions = new Button();
            ButtonAddTransaction = new Button();
            TableButtons = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            TableButtons.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonSearch
            // 
            ButtonSearch.Dock = DockStyle.Fill;
            ButtonSearch.Location = new Point(260, 3);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(252, 178);
            ButtonSearch.TabIndex = 9;
            ButtonSearch.Text = "Search for customers";
            ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // ButtonAddCustomer
            // 
            ButtonAddCustomer.Dock = DockStyle.Fill;
            ButtonAddCustomer.Location = new Point(3, 3);
            ButtonAddCustomer.Name = "ButtonAddCustomer";
            ButtonAddCustomer.Size = new Size(251, 178);
            ButtonAddCustomer.TabIndex = 8;
            ButtonAddCustomer.Text = "Add new customers";
            ButtonAddCustomer.UseVisualStyleBackColor = true;
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(3, 4, 3, 4);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(4, 6, 4, 6);
            SideNav.Size = new Size(150, 412);
            SideNav.TabIndex = 7;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(156, 8);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(123, 30);
            LabelTitle.TabIndex = 6;
            LabelTitle.Text = "Customers";
            // 
            // ButtonTransactions
            // 
            ButtonTransactions.Dock = DockStyle.Fill;
            ButtonTransactions.Location = new Point(3, 187);
            ButtonTransactions.Name = "ButtonTransactions";
            ButtonTransactions.Size = new Size(251, 178);
            ButtonTransactions.TabIndex = 10;
            ButtonTransactions.Text = "Display Transactions By Customer";
            ButtonTransactions.UseVisualStyleBackColor = true;
            // 
            // ButtonAddTransaction
            // 
            ButtonAddTransaction.Dock = DockStyle.Fill;
            ButtonAddTransaction.Location = new Point(260, 187);
            ButtonAddTransaction.Name = "ButtonAddTransaction";
            ButtonAddTransaction.Size = new Size(252, 178);
            ButtonAddTransaction.TabIndex = 11;
            ButtonAddTransaction.Text = "Add Customer Transaction";
            ButtonAddTransaction.UseVisualStyleBackColor = true;
            // 
            // TableButtons
            // 
            TableButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableButtons.ColumnCount = 2;
            TableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableButtons.Controls.Add(ButtonAddCustomer, 0, 0);
            TableButtons.Controls.Add(ButtonAddTransaction, 1, 1);
            TableButtons.Controls.Add(ButtonSearch, 1, 0);
            TableButtons.Controls.Add(ButtonTransactions, 0, 1);
            TableButtons.Location = new Point(157, 41);
            TableButtons.Name = "TableButtons";
            TableButtons.RowCount = 2;
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableButtons.Size = new Size(515, 368);
            TableButtons.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 94);
            button1.TabIndex = 8;
            button1.Text = "Add new customers";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(103, 187);
            button2.Name = "button2";
            button2.Size = new Size(94, 178);
            button2.TabIndex = 11;
            button2.Text = "Add Customer Transaction";
            button2.UseVisualStyleBackColor = true;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableButtons);
            Controls.Add(SideNav);
            Controls.Add(LabelTitle);
            Name = "Customers";
            Size = new Size(684, 412);
            Load += OnCustomersLoad;
            TableButtons.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonSearch;
        private Button ButtonAddCustomer;
        private components.SideNav SideNav;
        private Label LabelTitle;
        private Button ButtonTransactions;
        private Button ButtonAddTransaction;
        private TableLayoutPanel TableButtons;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
    }
}
