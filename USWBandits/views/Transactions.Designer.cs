namespace USWBandits.views
{
    partial class Transactions
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
            LabelTitle = new Label();
            SideNav = new components.SideNav();
            ButtonSearch = new Button();
            ButtonAddProduct = new Button();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(162, 11);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(142, 30);
            LabelTitle.TabIndex = 1;
            LabelTitle.Text = "Transactions";
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(0);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(4, 6, 4, 6);
            SideNav.Size = new Size(150, 400);
            SideNav.TabIndex = 5;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(396, 59);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(178, 63);
            ButtonSearch.TabIndex = 7;
            ButtonSearch.Text = "Search for product";
            ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // ButtonAddProduct
            // 
            ButtonAddProduct.Location = new Point(162, 59);
            ButtonAddProduct.Name = "ButtonAddProduct";
            ButtonAddProduct.Size = new Size(178, 63);
            ButtonAddProduct.TabIndex = 6;
            ButtonAddProduct.Text = "Add new transaction";
            ButtonAddProduct.UseVisualStyleBackColor = true;
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonSearch);
            Controls.Add(ButtonAddProduct);
            Controls.Add(SideNav);
            Controls.Add(LabelTitle);
            Name = "Transactions";
            Size = new Size(600, 400);
            Load += OnTransactionsLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitle;
        private components.SideNav SideNav;
        private Button ButtonSearch;
        private Button ButtonAddProduct;
    }
}
