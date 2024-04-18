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
            ButtonAddTransaction = new Button();
            TableButtons = new TableLayoutPanel();
            TableButtons.SuspendLayout();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(153, 11);
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
            SideNav.Size = new Size(150, 412);
            SideNav.TabIndex = 5;
            // 
            // ButtonAddTransaction
            // 
            ButtonAddTransaction.Dock = DockStyle.Fill;
            ButtonAddTransaction.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAddTransaction.Location = new Point(3, 3);
            ButtonAddTransaction.Name = "ButtonAddTransaction";
            ButtonAddTransaction.Size = new Size(510, 359);
            ButtonAddTransaction.TabIndex = 6;
            ButtonAddTransaction.Text = "Add new transaction";
            ButtonAddTransaction.UseVisualStyleBackColor = true;
            // 
            // TableButtons
            // 
            TableButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableButtons.ColumnCount = 1;
            TableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableButtons.Controls.Add(ButtonAddTransaction, 0, 0);
            TableButtons.Location = new Point(153, 44);
            TableButtons.Name = "TableButtons";
            TableButtons.RowCount = 1;
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableButtons.Size = new Size(516, 365);
            TableButtons.TabIndex = 8;
            // 
            // Transactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableButtons);
            Controls.Add(SideNav);
            Controls.Add(LabelTitle);
            Name = "Transactions";
            Size = new Size(684, 412);
            Load += OnTransactionsLoad;
            TableButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitle;
        private components.SideNav SideNav;
        private Button ButtonAddTransaction;
        private TableLayoutPanel TableButtons;
    }
}
