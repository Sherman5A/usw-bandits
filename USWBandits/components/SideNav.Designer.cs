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
            TreeNode treeNode6 = new TreeNode("Stats");
            TreeNav = new TreeView();
            SuspendLayout();
            // 
            // TreeNav
            // 
            TreeNav.Dock = DockStyle.Fill;
            TreeNav.HideSelection = false;
            TreeNav.Location = new Point(5, 10);
            TreeNav.Margin = new Padding(6, 7, 6, 7);
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
            treeNode6.Name = "NodeStats";
            treeNode6.Text = "Stats";
            TreeNav.Nodes.AddRange(new TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6 });
            TreeNav.Size = new Size(170, 404);
            TreeNav.TabIndex = 4;
            TreeNav.AfterSelect += OnTreeNavAfterSelect;
            // 
            // SideNav
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TreeNav);
            Margin = new Padding(0);
            Name = "SideNav";
            Padding = new Padding(5, 10, 5, 10);
            Size = new Size(180, 424);
            ResumeLayout(false);
        }

        #endregion

        private TreeView TreeNav;
    }
}
