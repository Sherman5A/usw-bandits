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
            SuspendLayout();
            // 
            // sideNav
            // 
            sideNav.Size = new Size(156, 354);
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
            ButtonSearch.Location = new Point(437, 58);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(205, 63);
            ButtonSearch.TabIndex = 3;
            ButtonSearch.Text = "Search for product";
            ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonSearch);
            Controls.Add(ButtonAddProduct);
            Controls.Add(LabelTitle);
            Name = "Products";
            Size = new Size(663, 354);
            Load += OnProductsLoad;
            Controls.SetChildIndex(sideNav, 0);
            Controls.SetChildIndex(LabelTitle, 0);
            Controls.SetChildIndex(ButtonAddProduct, 0);
            Controls.SetChildIndex(ButtonSearch, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitle;
        private Button ButtonAddProduct;
        private Button ButtonSearch;
    }
}
