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
            ButtonAddAccount = new Button();
            TableButtons = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            TableButtons.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(156, 10);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(108, 30);
            LabelTitle.TabIndex = 1;
            LabelTitle.Text = "Accounts";
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(3, 4, 3, 4);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(4, 6, 4, 6);
            SideNav.Size = new Size(150, 412);
            SideNav.TabIndex = 2;
            // 
            // ButtonAddAccount
            // 
            ButtonAddAccount.Dock = DockStyle.Fill;
            ButtonAddAccount.Font = new Font("Segoe UI", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            ButtonAddAccount.Location = new Point(3, 3);
            ButtonAddAccount.Name = "ButtonAddAccount";
            ButtonAddAccount.Size = new Size(509, 359);
            ButtonAddAccount.TabIndex = 4;
            ButtonAddAccount.Text = "Add new account";
            ButtonAddAccount.UseVisualStyleBackColor = true;
            // 
            // TableButtons
            // 
            TableButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TableButtons.ColumnCount = 1;
            TableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableButtons.Controls.Add(ButtonAddAccount, 0, 0);
            TableButtons.Location = new Point(156, 44);
            TableButtons.Name = "TableButtons";
            TableButtons.RowCount = 1;
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableButtons.Size = new Size(515, 365);
            TableButtons.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(103, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 94);
            button1.TabIndex = 5;
            button1.Text = "Search for product";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 347);
            button2.TabIndex = 4;
            button2.Text = "Add new account";
            button2.UseVisualStyleBackColor = true;
            // 
            // Accounts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableButtons);
            Controls.Add(SideNav);
            Controls.Add(LabelTitle);
            Name = "Accounts";
            Size = new Size(684, 412);
            Load += OnAccountsLoad;
            TableButtons.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelTitle;
        private components.SideNav SideNav;
        private Button ButtonAddAccount;
        private TableLayoutPanel TableButtons;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
    }
}
