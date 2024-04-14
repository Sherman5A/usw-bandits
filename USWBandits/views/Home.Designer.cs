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
            SuspendLayout();
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Name = "SideNav";
            SideNav.Size = new Size(150, 400);
            SideNav.TabIndex = 6;
            // 
            // ButtonCustomers
            // 
            ButtonCustomers.Location = new Point(156, 23);
            ButtonCustomers.Name = "ButtonCustomers";
            ButtonCustomers.Size = new Size(201, 82);
            ButtonCustomers.TabIndex = 7;
            ButtonCustomers.Text = "Customers";
            ButtonCustomers.UseVisualStyleBackColor = true;
            // 
            // ButtonAccount
            // 
            ButtonAccount.Location = new Point(380, 23);
            ButtonAccount.Name = "ButtonAccount";
            ButtonAccount.Size = new Size(201, 82);
            ButtonAccount.TabIndex = 8;
            ButtonAccount.Text = "Accounts";
            ButtonAccount.UseVisualStyleBackColor = true;
            // 
            // ButtonTransactions
            // 
            ButtonTransactions.Location = new Point(156, 128);
            ButtonTransactions.Name = "ButtonTransactions";
            ButtonTransactions.Size = new Size(201, 82);
            ButtonTransactions.TabIndex = 9;
            ButtonTransactions.Text = "Transactions";
            ButtonTransactions.UseVisualStyleBackColor = true;
            // 
            // ButtonProducts
            // 
            ButtonProducts.Location = new Point(380, 128);
            ButtonProducts.Name = "ButtonProducts";
            ButtonProducts.Size = new Size(201, 82);
            ButtonProducts.TabIndex = 10;
            ButtonProducts.Text = "Products";
            ButtonProducts.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonProducts);
            Controls.Add(ButtonTransactions);
            Controls.Add(ButtonAccount);
            Controls.Add(ButtonCustomers);
            Controls.Add(SideNav);
            Name = "Home";
            Size = new Size(600, 400);
            Load += OnHomeLoad;
            ResumeLayout(false);
        }

        #endregion

        private components.SideNav SideNav;
        private Button ButtonCustomers;
        private Button ButtonAccount;
        private Button ButtonTransactions;
        private Button ButtonProducts;
    }
}
