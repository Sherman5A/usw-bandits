namespace USWBandits.views
{
    partial class Products
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
            ButtonAddProduct = new Button();
            ButtonSearch = new Button();
            SideNav = new components.SideNav();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(162, 11);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(106, 30);
            LabelTitle.TabIndex = 1;
            LabelTitle.Text = "Products";
            // 
            // ButtonAddProduct
            // 
            ButtonAddProduct.Location = new Point(162, 58);
            ButtonAddProduct.Name = "ButtonAddProduct";
            ButtonAddProduct.Size = new Size(205, 63);
            ButtonAddProduct.TabIndex = 2;
            ButtonAddProduct.Text = "Add new product";
            ButtonAddProduct.UseVisualStyleBackColor = true;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(383, 58);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(205, 63);
            ButtonSearch.TabIndex = 3;
            ButtonSearch.Text = "Search for product";
            ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(0);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(4, 6, 4, 6);
            SideNav.Size = new Size(150, 400);
            SideNav.TabIndex = 4;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SideNav);
            Controls.Add(ButtonSearch);
            Controls.Add(ButtonAddProduct);
            Controls.Add(LabelTitle);
            Name = "Products";
            Size = new Size(600, 400);
            Load += OnProductsLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitle;
        private Button ButtonAddProduct;
        private Button ButtonSearch;
        private components.SideNav SideNav;
    }
}
