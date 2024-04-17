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
            TableButtons = new TableLayoutPanel();
            TableButtons.SuspendLayout();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(156, 11);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(106, 30);
            LabelTitle.TabIndex = 1;
            LabelTitle.Text = "Products";
            // 
            // ButtonAddProduct
            // 
            ButtonAddProduct.Dock = DockStyle.Fill;
            ButtonAddProduct.Location = new Point(3, 3);
            ButtonAddProduct.Name = "ButtonAddProduct";
            ButtonAddProduct.Size = new Size(249, 359);
            ButtonAddProduct.TabIndex = 2;
            ButtonAddProduct.Text = "Add new product";
            ButtonAddProduct.UseVisualStyleBackColor = true;
            // 
            // ButtonSearch
            // 
            ButtonSearch.Dock = DockStyle.Fill;
            ButtonSearch.Location = new Point(258, 3);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(249, 359);
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
            SideNav.Size = new Size(150, 412);
            SideNav.TabIndex = 4;
            // 
            // TableButtons
            // 
            TableButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableButtons.ColumnCount = 2;
            TableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableButtons.Controls.Add(ButtonAddProduct, 0, 0);
            TableButtons.Controls.Add(ButtonSearch, 1, 0);
            TableButtons.Location = new Point(158, 44);
            TableButtons.Name = "TableButtons";
            TableButtons.RowCount = 1;
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableButtons.Size = new Size(510, 365);
            TableButtons.TabIndex = 13;
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableButtons);
            Controls.Add(SideNav);
            Controls.Add(LabelTitle);
            Name = "Products";
            Size = new Size(684, 412);
            Load += OnProductsLoad;
            TableButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitle;
        private Button ButtonAddProduct;
        private Button ButtonSearch;
        private components.SideNav SideNav;
        private TableLayoutPanel TableButtons;
    }
}
