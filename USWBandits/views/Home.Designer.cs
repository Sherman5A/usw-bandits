namespace USWBandits.views
{
    partial class Home
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
            ButtonCustomers = new Button();
            ButtonAccount = new Button();
            ButtonTransactions = new Button();
            ButtonProducts = new Button();
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
            SideNav.TabIndex = 6;
            // 
            // ButtonCustomers
            // 
            ButtonCustomers.Dock = DockStyle.Fill;
            ButtonCustomers.Location = new Point(3, 3);
            ButtonCustomers.Name = "ButtonCustomers";
            ButtonCustomers.Size = new Size(251, 178);
            ButtonCustomers.TabIndex = 7;
            ButtonCustomers.Text = "Customers";
            ButtonCustomers.UseVisualStyleBackColor = true;
            // 
            // ButtonAccount
            // 
            ButtonAccount.Dock = DockStyle.Fill;
            ButtonAccount.Location = new Point(260, 3);
            ButtonAccount.Name = "ButtonAccount";
            ButtonAccount.Size = new Size(252, 178);
            ButtonAccount.TabIndex = 8;
            ButtonAccount.Text = "Accounts";
            ButtonAccount.UseVisualStyleBackColor = true;
            // 
            // ButtonTransactions
            // 
            ButtonTransactions.Dock = DockStyle.Fill;
            ButtonTransactions.Location = new Point(3, 187);
            ButtonTransactions.Name = "ButtonTransactions";
            ButtonTransactions.Size = new Size(251, 179);
            ButtonTransactions.TabIndex = 9;
            ButtonTransactions.Text = "Transactions";
            ButtonTransactions.UseVisualStyleBackColor = true;
            // 
            // ButtonProducts
            // 
            ButtonProducts.Dock = DockStyle.Fill;
            ButtonProducts.Location = new Point(260, 187);
            ButtonProducts.Name = "ButtonProducts";
            ButtonProducts.Size = new Size(252, 179);
            ButtonProducts.TabIndex = 10;
            ButtonProducts.Text = "Products";
            ButtonProducts.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(156, 7);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(75, 30);
            LabelTitle.TabIndex = 11;
            LabelTitle.Text = "Home";
            // 
            // TableButtons
            // 
            TableButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableButtons.ColumnCount = 2;
            TableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableButtons.Controls.Add(ButtonCustomers, 0, 0);
            TableButtons.Controls.Add(ButtonAccount, 1, 0);
            TableButtons.Controls.Add(ButtonProducts, 1, 1);
            TableButtons.Controls.Add(ButtonTransactions, 0, 1);
            TableButtons.Location = new Point(156, 40);
            TableButtons.Name = "TableButtons";
            TableButtons.RowCount = 2;
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableButtons.Size = new Size(515, 369);
            TableButtons.TabIndex = 13;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableButtons);
            Controls.Add(LabelTitle);
            Controls.Add(SideNav);
            Name = "Home";
            Size = new Size(684, 412);
            Load += OnHomeLoad;
            TableButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private components.SideNav SideNav;
        private Button ButtonCustomers;
        private Button ButtonAccount;
        private Button ButtonTransactions;
        private Button ButtonProducts;
        private Label LabelTitle;
        private TableLayoutPanel TableButtons;
    }
}
