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
            SuspendLayout();
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(3, 5, 3, 5);
            SideNav.Name = "SideNav";
            SideNav.Size = new Size(171, 533);
            SideNav.TabIndex = 6;
            // 
            // ButtonCustomers
            // 
            ButtonCustomers.Location = new Point(178, 54);
            ButtonCustomers.Margin = new Padding(3, 4, 3, 4);
            ButtonCustomers.Name = "ButtonCustomers";
            ButtonCustomers.Size = new Size(230, 109);
            ButtonCustomers.TabIndex = 7;
            ButtonCustomers.Text = "Customers";
            ButtonCustomers.UseVisualStyleBackColor = true;
            // 
            // ButtonAccount
            // 
            ButtonAccount.Location = new Point(434, 54);
            ButtonAccount.Margin = new Padding(3, 4, 3, 4);
            ButtonAccount.Name = "ButtonAccount";
            ButtonAccount.Size = new Size(230, 109);
            ButtonAccount.TabIndex = 8;
            ButtonAccount.Text = "Accounts";
            ButtonAccount.UseVisualStyleBackColor = true;
            // 
            // ButtonTransactions
            // 
            ButtonTransactions.Location = new Point(178, 194);
            ButtonTransactions.Margin = new Padding(3, 4, 3, 4);
            ButtonTransactions.Name = "ButtonTransactions";
            ButtonTransactions.Size = new Size(230, 109);
            ButtonTransactions.TabIndex = 9;
            ButtonTransactions.Text = "Transactions";
            ButtonTransactions.UseVisualStyleBackColor = true;
            // 
            // ButtonProducts
            // 
            ButtonProducts.Location = new Point(434, 194);
            ButtonProducts.Margin = new Padding(3, 4, 3, 4);
            ButtonProducts.Name = "ButtonProducts";
            ButtonProducts.Size = new Size(230, 109);
            ButtonProducts.TabIndex = 10;
            ButtonProducts.Text = "Products";
            ButtonProducts.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(178, 9);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(95, 37);
            LabelTitle.TabIndex = 11;
            LabelTitle.Text = "Home";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LabelTitle);
            Controls.Add(ButtonProducts);
            Controls.Add(ButtonTransactions);
            Controls.Add(ButtonAccount);
            Controls.Add(ButtonCustomers);
            Controls.Add(SideNav);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Home";
            Size = new Size(686, 533);
            Load += OnHomeLoad;
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
    }
}
