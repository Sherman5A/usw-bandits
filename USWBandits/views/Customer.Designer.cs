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
            LabelCustomerTitle = new Label();
            LabelCustomerId = new Label();
            LabelFirstName = new Label();
            LabelForCustomerId = new Label();
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
            TableAccountDetails.Controls.Add(LabelCustomerTitle, 0, 1);
            TableAccountDetails.Controls.Add(LabelCustomerId, 1, 0);
            TableAccountDetails.Controls.Add(LabelFirstName, 0, 2);
            TableAccountDetails.Controls.Add(LabelForCustomerId, 0, 0);
            TableAccountDetails.Controls.Add(DatePickDOB, 1, 4);
            TableAccountDetails.Controls.Add(LabelNI, 0, 5);
            TableAccountDetails.Controls.Add(MaskedNI, 1, 5);
            TableAccountDetails.Controls.Add(LabelEmail, 0, 6);
            TableAccountDetails.Controls.Add(TextFirstName, 1, 2);
            TableAccountDetails.Controls.Add(TextTitle, 1, 1);
            TableAccountDetails.Location = new Point(178, 52);
            TableAccountDetails.Margin = new Padding(3, 4, 3, 4);
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
            TableAccountDetails.Size = new Size(597, 385);
            TableAccountDetails.TabIndex = 12;
            // 
            // NumericAllowance
            // 
            NumericAllowance.Anchor = AnchorStyles.Left;
            NumericAllowance.DecimalPlaces = 2;
            NumericAllowance.Location = new Point(230, 347);
            NumericAllowance.Margin = new Padding(3, 4, 3, 4);
            NumericAllowance.Name = "NumericAllowance";
            NumericAllowance.Size = new Size(363, 27);
            NumericAllowance.TabIndex = 23;
            NumericAllowance.ThousandsSeparator = true;
            // 
            // LabelAllowance
            // 
            LabelAllowance.Anchor = AnchorStyles.Right;
            LabelAllowance.AutoSize = true;
            LabelAllowance.BackColor = Color.Transparent;
            LabelAllowance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAllowance.Location = new Point(102, 344);
            LabelAllowance.Name = "LabelAllowance";
            LabelAllowance.Size = new Size(122, 32);
            LabelAllowance.TabIndex = 22;
            LabelAllowance.Text = "Allowance";
            LabelAllowance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextPassword
            // 
            TextPassword.Anchor = AnchorStyles.Left;
            TextPassword.Location = new Point(230, 301);
            TextPassword.Margin = new Padding(3, 4, 3, 4);
            TextPassword.Name = "TextPassword";
            TextPassword.Size = new Size(363, 27);
            TextPassword.TabIndex = 21;
            // 
            // LabelPassword
            // 
            LabelPassword.Anchor = AnchorStyles.Right;
            LabelPassword.AutoSize = true;
            LabelPassword.BackColor = Color.Transparent;
            LabelPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPassword.Location = new Point(113, 299);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(111, 32);
            LabelPassword.TabIndex = 20;
            LabelPassword.Text = "Password";
            LabelPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MaskedEmail
            // 
            MaskedEmail.Anchor = AnchorStyles.Left;
            MaskedEmail.Location = new Point(230, 259);
            MaskedEmail.Margin = new Padding(3, 4, 3, 4);
            MaskedEmail.Name = "MaskedEmail";
            MaskedEmail.Size = new Size(363, 27);
            MaskedEmail.TabIndex = 19;
            // 
            // TextLastName
            // 
            TextLastName.Anchor = AnchorStyles.Left;
            TextLastName.Location = new Point(230, 133);
            TextLastName.Margin = new Padding(3, 4, 3, 4);
            TextLastName.Name = "TextLastName";
            TextLastName.Size = new Size(363, 27);
            TextLastName.TabIndex = 18;
            // 
            // LabelDOB
            // 
            LabelDOB.Anchor = AnchorStyles.Right;
            LabelDOB.AutoSize = true;
            LabelDOB.BackColor = Color.Transparent;
            LabelDOB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDOB.Location = new Point(74, 173);
            LabelDOB.Name = "LabelDOB";
            LabelDOB.Size = new Size(150, 32);
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
            LabelBalance.Location = new Point(98, 131);
            LabelBalance.Name = "LabelBalance";
            LabelBalance.Size = new Size(126, 32);
            LabelBalance.TabIndex = 11;
            LabelBalance.Text = "Last Name";
            LabelBalance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelCustomerTitle
            // 
            LabelCustomerTitle.Anchor = AnchorStyles.Right;
            LabelCustomerTitle.AutoSize = true;
            LabelCustomerTitle.BackColor = Color.Transparent;
            LabelCustomerTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCustomerTitle.Location = new Point(164, 47);
            LabelCustomerTitle.Name = "LabelCustomerTitle";
            LabelCustomerTitle.Size = new Size(60, 32);
            LabelCustomerTitle.TabIndex = 9;
            LabelCustomerTitle.Text = "Title";
            LabelCustomerTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelCustomerId
            // 
            LabelCustomerId.Anchor = AnchorStyles.Left;
            LabelCustomerId.AutoSize = true;
            LabelCustomerId.BackColor = Color.Transparent;
            LabelCustomerId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCustomerId.Location = new Point(230, 5);
            LabelCustomerId.Name = "LabelCustomerId";
            LabelCustomerId.Size = new Size(66, 32);
            LabelCustomerId.TabIndex = 5;
            LabelCustomerId.Text = "2321";
            // 
            // LabelFirstName
            // 
            LabelFirstName.Anchor = AnchorStyles.Right;
            LabelFirstName.AutoSize = true;
            LabelFirstName.BackColor = Color.Transparent;
            LabelFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelFirstName.Location = new Point(95, 89);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(129, 32);
            LabelFirstName.TabIndex = 10;
            LabelFirstName.Text = "First Name";
            LabelFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelForCustomerId
            // 
            LabelForCustomerId.Anchor = AnchorStyles.Right;
            LabelForCustomerId.AutoSize = true;
            LabelForCustomerId.BackColor = Color.Transparent;
            LabelForCustomerId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelForCustomerId.Location = new Point(77, 5);
            LabelForCustomerId.Name = "LabelForCustomerId";
            LabelForCustomerId.Size = new Size(147, 32);
            LabelForCustomerId.TabIndex = 8;
            LabelForCustomerId.Text = "Customer ID";
            LabelForCustomerId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DatePickDOB
            // 
            DatePickDOB.Anchor = AnchorStyles.Left;
            DatePickDOB.Location = new Point(230, 175);
            DatePickDOB.Margin = new Padding(3, 4, 3, 4);
            DatePickDOB.Name = "DatePickDOB";
            DatePickDOB.Size = new Size(363, 27);
            DatePickDOB.TabIndex = 13;
            // 
            // LabelNI
            // 
            LabelNI.Anchor = AnchorStyles.Right;
            LabelNI.AutoSize = true;
            LabelNI.BackColor = Color.Transparent;
            LabelNI.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNI.Location = new Point(11, 215);
            LabelNI.Name = "LabelNI";
            LabelNI.Size = new Size(213, 32);
            LabelNI.TabIndex = 14;
            LabelNI.Text = "National Insurance";
            LabelNI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MaskedNI
            // 
            MaskedNI.Anchor = AnchorStyles.Left;
            MaskedNI.Location = new Point(230, 217);
            MaskedNI.Margin = new Padding(3, 4, 3, 4);
            MaskedNI.Name = "MaskedNI";
            MaskedNI.Size = new Size(363, 27);
            MaskedNI.TabIndex = 15;
            // 
            // LabelEmail
            // 
            LabelEmail.Anchor = AnchorStyles.Right;
            LabelEmail.AutoSize = true;
            LabelEmail.BackColor = Color.Transparent;
            LabelEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelEmail.Location = new Point(153, 257);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(71, 32);
            LabelEmail.TabIndex = 16;
            LabelEmail.Text = "Email";
            LabelEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextFirstName
            // 
            TextFirstName.Anchor = AnchorStyles.Left;
            TextFirstName.Location = new Point(230, 91);
            TextFirstName.Margin = new Padding(3, 4, 3, 4);
            TextFirstName.Name = "TextFirstName";
            TextFirstName.Size = new Size(363, 27);
            TextFirstName.TabIndex = 17;
            // 
            // TextTitle
            // 
            TextTitle.Anchor = AnchorStyles.Left;
            TextTitle.Location = new Point(230, 49);
            TextTitle.Margin = new Padding(3, 4, 3, 4);
            TextTitle.Name = "TextTitle";
            TextTitle.Size = new Size(363, 27);
            TextTitle.TabIndex = 18;
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(3, 5, 3, 5);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(5, 8, 5, 8);
            SideNav.Size = new Size(171, 533);
            SideNav.TabIndex = 10;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(489, 445);
            ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(285, 83);
            ButtonDelete.TabIndex = 14;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonAddCustomer
            // 
            ButtonAddCustomer.Location = new Point(178, 445);
            ButtonAddCustomer.Margin = new Padding(3, 4, 3, 4);
            ButtonAddCustomer.Name = "ButtonAddCustomer";
            ButtonAddCustomer.Size = new Size(289, 83);
            ButtonAddCustomer.TabIndex = 13;
            ButtonAddCustomer.Text = "Add customer";
            ButtonAddCustomer.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(178, 8);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(141, 37);
            LabelTitle.TabIndex = 11;
            LabelTitle.Text = "Customer";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableAccountDetails);
            Controls.Add(SideNav);
            Controls.Add(ButtonDelete);
            Controls.Add(ButtonAddCustomer);
            Controls.Add(LabelTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Customer";
            Size = new Size(800, 533);
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
        private Label LabelCustomerTitle;
        private Label LabelCustomerId;
        private Label LabelFirstName;
        private Label LabelForCustomerId;
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
