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
            SuspendLayout();
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(378, 50);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(178, 63);
            ButtonSearch.TabIndex = 9;
            ButtonSearch.Text = "Search for customers";
            ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // ButtonAddCustomer
            // 
            ButtonAddCustomer.Location = new Point(166, 50);
            ButtonAddCustomer.Name = "ButtonAddCustomer";
            ButtonAddCustomer.Size = new Size(178, 63);
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
            SideNav.Size = new Size(150, 400);
            SideNav.TabIndex = 7;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(166, 8);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(123, 30);
            LabelTitle.TabIndex = 6;
            LabelTitle.Text = "Customers";
            // 
            // ButtonTransactions
            // 
            ButtonTransactions.Location = new Point(166, 126);
            ButtonTransactions.Name = "ButtonTransactions";
            ButtonTransactions.Size = new Size(178, 63);
            ButtonTransactions.TabIndex = 10;
            ButtonTransactions.Text = "Display Transactions By Customer";
            ButtonTransactions.UseVisualStyleBackColor = true;
            // 
            // ButtonAddTransaction
            // 
            ButtonAddTransaction.Location = new Point(378, 126);
            ButtonAddTransaction.Name = "ButtonAddTransaction";
            ButtonAddTransaction.Size = new Size(178, 63);
            ButtonAddTransaction.TabIndex = 11;
            ButtonAddTransaction.Text = "Add Customer Transaction";
            ButtonAddTransaction.UseVisualStyleBackColor = true;
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonAddTransaction);
            Controls.Add(ButtonTransactions);
            Controls.Add(ButtonSearch);
            Controls.Add(ButtonAddCustomer);
            Controls.Add(SideNav);
            Controls.Add(LabelTitle);
            Name = "Customers";
            Size = new Size(700, 400);
            Load += OnCustomersLoad;
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
    }
}
