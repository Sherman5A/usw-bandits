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
            TreeNode productNode = new TreeNode("Products");
            TreeNode accountNode = new TreeNode("Accounts");
            TreeNode customerNode = new TreeNode("Customers");
            TreeNode transactionNode = new TreeNode("Transactions");
            TreeNav = new TreeView();
            SuspendLayout();
            // 
            // TreeNav
            // 
            TreeNav.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TreeNav.Location = new Point(5, 5);
            TreeNav.Margin = new Padding(5);
            TreeNav.Name = "TreeNav";
            productNode.Name = "NodeProducts";
            productNode.Text = "Products";
            accountNode.Name = "NodeAccounts";
            accountNode.Text = "Accounts";
            customerNode.Name = "NodeCustomers";
            customerNode.Text = "Customers";
            transactionNode.Name = "NodeTransactions";
            transactionNode.Text = "Transactions";
            TreeNav.Nodes.AddRange(new TreeNode[] { productNode, accountNode, customerNode, transactionNode });
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
