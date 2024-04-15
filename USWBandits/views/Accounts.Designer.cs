namespace USWBandits.views
{
    partial class Accounts
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
            LabelTitle.Location = new Point(185, 15);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(134, 37);
            LabelTitle.TabIndex = 1;
            LabelTitle.Text = "Accounts";
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(3, 5, 3, 5);
            SideNav.Name = "SideNav";
            SideNav.Size = new Size(171, 533);
            SideNav.TabIndex = 2;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(453, 95);
            ButtonSearch.Margin = new Padding(3, 4, 3, 4);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(203, 84);
            ButtonSearch.TabIndex = 5;
            ButtonSearch.Text = "Search for product";
            ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // ButtonAddProduct
            // 
            ButtonAddProduct.Location = new Point(185, 95);
            ButtonAddProduct.Margin = new Padding(3, 4, 3, 4);
            ButtonAddProduct.Name = "ButtonAddProduct";
            ButtonAddProduct.Size = new Size(203, 84);
            ButtonAddProduct.TabIndex = 4;
            ButtonAddProduct.Text = "Add new product";
            ButtonAddProduct.UseVisualStyleBackColor = true;
            // 
            // Accounts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonSearch);
            Controls.Add(ButtonAddProduct);
            Controls.Add(SideNav);
            Controls.Add(LabelTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Accounts";
            Size = new Size(686, 533);
            Load += OnAccountsLoad;
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
