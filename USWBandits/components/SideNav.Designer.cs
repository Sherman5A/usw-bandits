namespace USWBandits.components
{
    partial class SideNav
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
            TreeNode treeNode1 = new TreeNode("Home");
            TreeNode treeNode2 = new TreeNode("Products");
            TreeNode treeNode3 = new TreeNode("Accounts");
            TreeNode treeNode4 = new TreeNode("Customers");
            TreeNode treeNode5 = new TreeNode("Transactions");
            TreeNav = new TreeView();
            SuspendLayout();
            // 
            // TreeNav
            // 
            TreeNav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TreeNav.HideSelection = false;
            TreeNav.Location = new Point(5, 5);
            TreeNav.Margin = new Padding(5);
            TreeNav.Name = "TreeNav";
            treeNode1.Name = "NodeHome";
            treeNode1.Text = "Home";
            treeNode2.Name = "NodeProducts";
            treeNode2.Text = "Products";
            treeNode3.Name = "NodeAccounts";
            treeNode3.Text = "Accounts";
            treeNode4.Name = "NodeCustomers";
            treeNode4.Text = "Customers";
            treeNode5.Name = "NodeTransactions";
            treeNode5.Text = "Transactions";
            TreeNav.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5 });
            TreeNav.Size = new Size(146, 308);
            TreeNav.TabIndex = 4;
            TreeNav.AfterSelect += OnTreeNavAfterSelect;
            // 
            // SideNav
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TreeNav);
            Name = "SideNav";
            Size = new Size(156, 318);
            ResumeLayout(false);
        }

        #endregion

        private TreeView TreeNav;
    }
}
