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
            SuspendLayout();
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(376, 71);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(178, 63);
            ButtonSearch.TabIndex = 9;
            ButtonSearch.Text = "Search for customers";
            ButtonSearch.UseVisualStyleBackColor = true;
            // 
            // ButtonAddCustomer
            // 
            ButtonAddCustomer.Location = new Point(156, 71);
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
            SideNav.Name = "SideNav";
            SideNav.Size = new Size(150, 400);
            SideNav.TabIndex = 7;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(156, 9);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(123, 30);
            LabelTitle.TabIndex = 6;
            LabelTitle.Text = "Customers";
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ButtonSearch);
            Controls.Add(ButtonAddCustomer);
            Controls.Add(SideNav);
            Controls.Add(LabelTitle);
            Name = "Customers";
            Size = new Size(600, 400);
            Load += OnCustomersLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ButtonSearch;
        private Button ButtonAddCustomer;
        private components.SideNav SideNav;
        private Label LabelTitle;
    }
}
