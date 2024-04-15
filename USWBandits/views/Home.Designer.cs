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
            SideNav.Margin = new Padding(3, 4, 3, 4);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(4, 6, 4, 6);
            SideNav.Size = new Size(150, 400);
            SideNav.TabIndex = 6;
            // 
            // ButtonCustomers
            // 
            ButtonCustomers.Location = new Point(156, 40);
            ButtonCustomers.Name = "ButtonCustomers";
            ButtonCustomers.Size = new Size(201, 82);
            ButtonCustomers.TabIndex = 7;
            ButtonCustomers.Text = "Customers";
            ButtonCustomers.UseVisualStyleBackColor = true;
            // 
            // ButtonAccount
            // 
            ButtonAccount.Location = new Point(380, 40);
            ButtonAccount.Name = "ButtonAccount";
            ButtonAccount.Size = new Size(201, 82);
            ButtonAccount.TabIndex = 8;
            ButtonAccount.Text = "Accounts";
            ButtonAccount.UseVisualStyleBackColor = true;
            // 
            // ButtonTransactions
            // 
            ButtonTransactions.Location = new Point(156, 146);
            ButtonTransactions.Name = "ButtonTransactions";
            ButtonTransactions.Size = new Size(201, 82);
            ButtonTransactions.TabIndex = 9;
            ButtonTransactions.Text = "Transactions";
            ButtonTransactions.UseVisualStyleBackColor = true;
            // 
            // ButtonProducts
            // 
            ButtonProducts.Location = new Point(380, 146);
            ButtonProducts.Name = "ButtonProducts";
            ButtonProducts.Size = new Size(201, 82);
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
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LabelTitle);
            Controls.Add(ButtonProducts);
            Controls.Add(ButtonTransactions);
            Controls.Add(ButtonAccount);
            Controls.Add(ButtonCustomers);
            Controls.Add(SideNav);
            Name = "Home";
            Size = new Size(700, 400);
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
