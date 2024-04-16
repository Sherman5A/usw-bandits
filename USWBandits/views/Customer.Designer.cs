namespace USWBandits.views
{
    partial class Customer
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
            TableAccountDetails = new TableLayoutPanel();
            NumericAllowance = new NumericUpDown();
            LabelAllowance = new Label();
            TextPassword = new TextBox();
            LabelPassword = new Label();
            MaskedEmail = new MaskedTextBox();
            TextLastName = new TextBox();
            LabelDOB = new Label();
            LabelBalance = new Label();
            LabelCustomerID = new Label();
            LabelAccountID = new Label();
            LabelProductID = new Label();
            LabelForAccountID = new Label();
            DatePickDOB = new DateTimePicker();
            LabelNI = new Label();
            MaskedNI = new MaskedTextBox();
            LabelEmail = new Label();
            TextFirstName = new TextBox();
            TextTitle = new TextBox();
            SideNav = new components.SideNav();
            ButtonDelete = new Button();
            ButtonAddCustomer = new Button();
            LabelTitle = new Label();
            TableAccountDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericAllowance).BeginInit();
            SuspendLayout();
            // 
            // TableAccountDetails
            // 
            TableAccountDetails.ColumnCount = 2;
            TableAccountDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.04348F));
            TableAccountDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.95652F));
            TableAccountDetails.Controls.Add(NumericAllowance, 1, 8);
            TableAccountDetails.Controls.Add(LabelAllowance, 0, 8);
            TableAccountDetails.Controls.Add(TextPassword, 1, 7);
            TableAccountDetails.Controls.Add(LabelPassword, 0, 7);
            TableAccountDetails.Controls.Add(MaskedEmail, 1, 6);
            TableAccountDetails.Controls.Add(TextLastName, 1, 3);
            TableAccountDetails.Controls.Add(LabelDOB, 0, 4);
            TableAccountDetails.Controls.Add(LabelBalance, 0, 3);
            TableAccountDetails.Controls.Add(LabelCustomerID, 0, 1);
            TableAccountDetails.Controls.Add(LabelAccountID, 1, 0);
            TableAccountDetails.Controls.Add(LabelProductID, 0, 2);
            TableAccountDetails.Controls.Add(LabelForAccountID, 0, 0);
            TableAccountDetails.Controls.Add(DatePickDOB, 1, 4);
            TableAccountDetails.Controls.Add(LabelNI, 0, 5);
            TableAccountDetails.Controls.Add(MaskedNI, 1, 5);
            TableAccountDetails.Controls.Add(LabelEmail, 0, 6);
            TableAccountDetails.Controls.Add(TextFirstName, 1, 2);
            TableAccountDetails.Controls.Add(TextTitle, 1, 1);
            TableAccountDetails.Location = new Point(156, 39);
            TableAccountDetails.Name = "TableAccountDetails";
            TableAccountDetails.RowCount = 9;
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            TableAccountDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            TableAccountDetails.Size = new Size(522, 289);
            TableAccountDetails.TabIndex = 12;
            // 
            // NumericAllowance
            // 
            NumericAllowance.Anchor = AnchorStyles.Left;
            NumericAllowance.DecimalPlaces = 2;
            NumericAllowance.Location = new Point(201, 261);
            NumericAllowance.Name = "NumericAllowance";
            NumericAllowance.Size = new Size(318, 23);
            NumericAllowance.TabIndex = 23;
            NumericAllowance.ThousandsSeparator = true;
            // 
            // LabelAllowance
            // 
            LabelAllowance.Anchor = AnchorStyles.Right;
            LabelAllowance.AutoSize = true;
            LabelAllowance.BackColor = Color.Transparent;
            LabelAllowance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAllowance.Location = new Point(96, 260);
            LabelAllowance.Name = "LabelAllowance";
            LabelAllowance.Size = new Size(99, 25);
            LabelAllowance.TabIndex = 22;
            LabelAllowance.Text = "Allowance";
            LabelAllowance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextPassword
            // 
            TextPassword.Anchor = AnchorStyles.Left;
            TextPassword.Location = new Point(201, 228);
            TextPassword.Name = "TextPassword";
            TextPassword.Size = new Size(318, 23);
            TextPassword.TabIndex = 21;
            // 
            // LabelPassword
            // 
            LabelPassword.Anchor = AnchorStyles.Right;
            LabelPassword.AutoSize = true;
            LabelPassword.BackColor = Color.Transparent;
            LabelPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPassword.Location = new Point(104, 227);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(91, 25);
            LabelPassword.TabIndex = 20;
            LabelPassword.Text = "Password";
            LabelPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MaskedEmail
            // 
            MaskedEmail.Anchor = AnchorStyles.Left;
            MaskedEmail.Location = new Point(201, 196);
            MaskedEmail.Name = "MaskedEmail";
            MaskedEmail.Size = new Size(318, 23);
            MaskedEmail.TabIndex = 19;
            // 
            // TextLastName
            // 
            TextLastName.Anchor = AnchorStyles.Left;
            TextLastName.Location = new Point(201, 100);
            TextLastName.Name = "TextLastName";
            TextLastName.Size = new Size(318, 23);
            TextLastName.TabIndex = 18;
            // 
            // LabelDOB
            // 
            LabelDOB.Anchor = AnchorStyles.Right;
            LabelDOB.AutoSize = true;
            LabelDOB.BackColor = Color.Transparent;
            LabelDOB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDOB.Location = new Point(77, 131);
            LabelDOB.Name = "LabelDOB";
            LabelDOB.Size = new Size(118, 25);
            LabelDOB.TabIndex = 12;
            LabelDOB.Text = "Date of Birth";
            LabelDOB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelBalance
            // 
            LabelBalance.Anchor = AnchorStyles.Right;
            LabelBalance.AutoSize = true;
            LabelBalance.BackColor = Color.Transparent;
            LabelBalance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelBalance.Location = new Point(95, 99);
            LabelBalance.Name = "LabelBalance";
            LabelBalance.Size = new Size(100, 25);
            LabelBalance.TabIndex = 11;
            LabelBalance.Text = "Last Name";
            LabelBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelCustomerID
            // 
            LabelCustomerID.Anchor = AnchorStyles.Right;
            LabelCustomerID.AutoSize = true;
            LabelCustomerID.BackColor = Color.Transparent;
            LabelCustomerID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCustomerID.Location = new Point(147, 35);
            LabelCustomerID.Name = "LabelCustomerID";
            LabelCustomerID.Size = new Size(48, 25);
            LabelCustomerID.TabIndex = 9;
            LabelCustomerID.Text = "Title";
            LabelCustomerID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelAccountID
            // 
            LabelAccountID.Anchor = AnchorStyles.Left;
            LabelAccountID.AutoSize = true;
            LabelAccountID.BackColor = Color.Transparent;
            LabelAccountID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAccountID.Location = new Point(201, 3);
            LabelAccountID.Name = "LabelAccountID";
            LabelAccountID.Size = new Size(52, 25);
            LabelAccountID.TabIndex = 5;
            LabelAccountID.Text = "2321";
            // 
            // LabelProductID
            // 
            LabelProductID.Anchor = AnchorStyles.Right;
            LabelProductID.AutoSize = true;
            LabelProductID.BackColor = Color.Transparent;
            LabelProductID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelProductID.Location = new Point(93, 67);
            LabelProductID.Name = "LabelProductID";
            LabelProductID.Size = new Size(102, 25);
            LabelProductID.TabIndex = 10;
            LabelProductID.Text = "First Name";
            LabelProductID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelForAccountID
            // 
            LabelForAccountID.Anchor = AnchorStyles.Right;
            LabelForAccountID.AutoSize = true;
            LabelForAccountID.BackColor = Color.Transparent;
            LabelForAccountID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelForAccountID.Location = new Point(79, 3);
            LabelForAccountID.Name = "LabelForAccountID";
            LabelForAccountID.Size = new Size(116, 25);
            LabelForAccountID.TabIndex = 8;
            LabelForAccountID.Text = "Customer ID";
            LabelForAccountID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DatePickDOB
            // 
            DatePickDOB.Anchor = AnchorStyles.Left;
            DatePickDOB.Location = new Point(201, 132);
            DatePickDOB.Name = "DatePickDOB";
            DatePickDOB.Size = new Size(318, 23);
            DatePickDOB.TabIndex = 13;
            // 
            // LabelNI
            // 
            LabelNI.Anchor = AnchorStyles.Right;
            LabelNI.AutoSize = true;
            LabelNI.BackColor = Color.Transparent;
            LabelNI.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNI.Location = new Point(24, 163);
            LabelNI.Name = "LabelNI";
            LabelNI.Size = new Size(171, 25);
            LabelNI.TabIndex = 14;
            LabelNI.Text = "National Insurance";
            LabelNI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MaskedNI
            // 
            MaskedNI.Anchor = AnchorStyles.Left;
            MaskedNI.Location = new Point(201, 164);
            MaskedNI.Name = "MaskedNI";
            MaskedNI.Size = new Size(318, 23);
            MaskedNI.TabIndex = 15;
            // 
            // LabelEmail
            // 
            LabelEmail.Anchor = AnchorStyles.Right;
            LabelEmail.AutoSize = true;
            LabelEmail.BackColor = Color.Transparent;
            LabelEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelEmail.Location = new Point(137, 195);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(58, 25);
            LabelEmail.TabIndex = 16;
            LabelEmail.Text = "Email";
            LabelEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextFirstName
            // 
            TextFirstName.Anchor = AnchorStyles.Left;
            TextFirstName.Location = new Point(201, 68);
            TextFirstName.Name = "TextFirstName";
            TextFirstName.Size = new Size(318, 23);
            TextFirstName.TabIndex = 17;
            // 
            // TextTitle
            // 
            TextTitle.Anchor = AnchorStyles.Left;
            TextTitle.Location = new Point(201, 36);
            TextTitle.Name = "TextTitle";
            TextTitle.Size = new Size(318, 23);
            TextTitle.TabIndex = 18;
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(3, 4, 3, 4);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(4, 6, 4, 6);
            SideNav.Size = new Size(150, 400);
            SideNav.TabIndex = 10;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(428, 334);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(249, 62);
            ButtonDelete.TabIndex = 14;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonAddCustomer
            // 
            ButtonAddCustomer.Location = new Point(156, 334);
            ButtonAddCustomer.Name = "ButtonAddCustomer";
            ButtonAddCustomer.Size = new Size(253, 62);
            ButtonAddCustomer.TabIndex = 13;
            ButtonAddCustomer.Text = "Add customer";
            ButtonAddCustomer.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(156, 6);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(113, 30);
            LabelTitle.TabIndex = 11;
            LabelTitle.Text = "Customer";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableAccountDetails);
            Controls.Add(SideNav);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonAddCustomer);
            Controls.Add(LabelTitle);
            Name = "Customer";
            Size = new Size(700, 400);
            Load += OnCustomerLoad;
            TableAccountDetails.ResumeLayout(false);
            TableAccountDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericAllowance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel TableAccountDetails;
        private Label LabelDOB;
        private Label LabelBalance;
        private Label LabelCustomerID;
        private Label LabelAccountID;
        private Label LabelProductID;
        private Label LabelForAccountID;
        private components.SideNav SideNav;
        private Button ButtonDelete;
        private Button ButtonAddCustomer;
        private Label LabelTitle;
        private DateTimePicker DatePickDOB;
        private Label LabelNI;
        private MaskedTextBox MaskedNI;
        private Label LabelEmail;
        private TextBox TextFirstName;
        private TextBox TextLastName;
        private MaskedTextBox MaskedEmail;
        private Label LabelPassword;
        private TextBox TextPassword;
        private Label LabelAllowance;
        private NumericUpDown NumericAllowance;
        private TextBox TextTitle;
    }
}
