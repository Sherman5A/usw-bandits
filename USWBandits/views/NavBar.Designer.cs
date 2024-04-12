namespace USWBandits.views
{
    partial class NavBar
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
            TreeNode treeNode1 = new TreeNode("Products");
            TreeNode treeNode2 = new TreeNode("Accounts");
            TreeNode treeNode3 = new TreeNode("Customers");
            TreeNode treeNode4 = new TreeNode("Transactions");
            TreeNav = new TreeView();
            SuspendLayout();
            // 
            // TreeNav
            // 
            TreeNav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TreeNav.Location = new Point(5, 5);
            TreeNav.Margin = new Padding(5);
            TreeNav.Name = "TreeNav";
            treeNode1.Name = "NodeProducts";
            treeNode1.Text = "Products";
            treeNode2.Name = "NodeAccounts";
            treeNode2.Text = "Accounts";
            treeNode3.Name = "NodeCustomers";
            treeNode3.Text = "Customers";
            treeNode4.Name = "NodeTransactions";
            treeNode4.Text = "Transactions";
            TreeNav.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4 });
            TreeNav.Size = new Size(145, 418);
            TreeNav.TabIndex = 3;
            TreeNav.AfterSelect += TreeNavAfterSelect;
            // 
            // NavBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TreeNav);
            Name = "NavBar";
            Size = new Size(813, 428);
            ResumeLayout(false);
        }

        #endregion

        private TreeView TreeNav;
    }
}
