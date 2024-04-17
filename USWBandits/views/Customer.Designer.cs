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
            TableBottomButtons = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            TableAccountDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericAllowance).BeginInit();
            TableBottomButtons.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TableAccountDetails
            // 
            TableAccountDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            TableAccountDetails.Location = new Point(155, 40);
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
            TableAccountDetails.Size = new Size(517, 289);
            TableAccountDetails.TabIndex = 12;
            // 
            // NumericAllowance
            // 
            NumericAllowance.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NumericAllowance.DecimalPlaces = 2;
            NumericAllowance.Location = new Point(199, 261);
            NumericAllowance.Name = "NumericAllowance";
            NumericAllowance.Size = new Size(315, 23);
            NumericAllowance.TabIndex = 23;
            NumericAllowance.ThousandsSeparator = true;
            // 
            // LabelAllowance
            // 
            LabelAllowance.Anchor = AnchorStyles.Right;
            LabelAllowance.AutoSize = true;
            LabelAllowance.BackColor = Color.Transparent;
            LabelAllowance.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAllowance.Location = new Point(94, 260);
            LabelAllowance.Name = "LabelAllowance";
            LabelAllowance.Size = new Size(99, 25);
            LabelAllowance.TabIndex = 22;
            LabelAllowance.Text = "Allowance";
            LabelAllowance.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextPassword
            // 
            TextPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TextPassword.Location = new Point(199, 228);
            TextPassword.Name = "TextPassword";
            TextPassword.Size = new Size(315, 23);
            TextPassword.TabIndex = 21;
            // 
            // LabelPassword
            // 
            LabelPassword.Anchor = AnchorStyles.Right;
            LabelPassword.AutoSize = true;
            LabelPassword.BackColor = Color.Transparent;
            LabelPassword.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelPassword.Location = new Point(102, 227);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(91, 25);
            LabelPassword.TabIndex = 20;
            LabelPassword.Text = "Password";
            LabelPassword.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MaskedEmail
            // 
            MaskedEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MaskedEmail.Location = new Point(199, 196);
            MaskedEmail.Name = "MaskedEmail";
            MaskedEmail.Size = new Size(315, 23);
            MaskedEmail.TabIndex = 19;
            // 
            // TextLastName
            // 
            TextLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TextLastName.Location = new Point(199, 100);
            TextLastName.Name = "TextLastName";
            TextLastName.Size = new Size(315, 23);
            TextLastName.TabIndex = 18;
            // 
            // LabelDOB
            // 
            LabelDOB.Anchor = AnchorStyles.Right;
            LabelDOB.AutoSize = true;
            LabelDOB.BackColor = Color.Transparent;
            LabelDOB.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelDOB.Location = new Point(75, 131);
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
            LabelBalance.Location = new Point(93, 99);
            LabelBalance.Name = "LabelBalance";
            LabelBalance.Size = new Size(100, 25);
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
            LabelCustomerTitle.Location = new Point(145, 35);
            LabelCustomerTitle.Name = "LabelCustomerTitle";
            LabelCustomerTitle.Size = new Size(48, 25);
            LabelCustomerTitle.TabIndex = 9;
            LabelCustomerTitle.Text = "Title";
            LabelCustomerTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LabelCustomerId
            // 
            LabelCustomerId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LabelCustomerId.AutoSize = true;
            LabelCustomerId.BackColor = Color.Transparent;
            LabelCustomerId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelCustomerId.Location = new Point(199, 3);
            LabelCustomerId.Name = "LabelCustomerId";
            LabelCustomerId.Size = new Size(315, 25);
            LabelCustomerId.TabIndex = 5;
            LabelCustomerId.Text = "2321";
            // 
            // LabelFirstName
            // 
            LabelFirstName.Anchor = AnchorStyles.Right;
            LabelFirstName.AutoSize = true;
            LabelFirstName.BackColor = Color.Transparent;
            LabelFirstName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelFirstName.Location = new Point(91, 67);
            LabelFirstName.Name = "LabelFirstName";
            LabelFirstName.Size = new Size(102, 25);
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
            LabelForCustomerId.Location = new Point(77, 3);
            LabelForCustomerId.Name = "LabelForCustomerId";
            LabelForCustomerId.Size = new Size(116, 25);
            LabelForCustomerId.TabIndex = 8;
            LabelForCustomerId.Text = "Customer ID";
            LabelForCustomerId.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DatePickDOB
            // 
            DatePickDOB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DatePickDOB.Format = DateTimePickerFormat.Short;
            DatePickDOB.Location = new Point(199, 132);
            DatePickDOB.Name = "DatePickDOB";
            DatePickDOB.Size = new Size(315, 23);
            DatePickDOB.TabIndex = 13;
            // 
            // LabelNI
            // 
            LabelNI.Anchor = AnchorStyles.Right;
            LabelNI.AutoSize = true;
            LabelNI.BackColor = Color.Transparent;
            LabelNI.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelNI.Location = new Point(22, 163);
            LabelNI.Name = "LabelNI";
            LabelNI.Size = new Size(171, 25);
            LabelNI.TabIndex = 14;
            LabelNI.Text = "National Insurance";
            LabelNI.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MaskedNI
            // 
            MaskedNI.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MaskedNI.Location = new Point(199, 164);
            MaskedNI.Name = "MaskedNI";
            MaskedNI.Size = new Size(315, 23);
            MaskedNI.TabIndex = 15;
            // 
            // LabelEmail
            // 
            LabelEmail.Anchor = AnchorStyles.Right;
            LabelEmail.AutoSize = true;
            LabelEmail.BackColor = Color.Transparent;
            LabelEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelEmail.Location = new Point(135, 195);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(58, 25);
            LabelEmail.TabIndex = 16;
            LabelEmail.Text = "Email";
            LabelEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TextFirstName
            // 
            TextFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TextFirstName.Location = new Point(199, 68);
            TextFirstName.Name = "TextFirstName";
            TextFirstName.Size = new Size(315, 23);
            TextFirstName.TabIndex = 17;
            // 
            // TextTitle
            // 
            TextTitle.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TextTitle.Location = new Point(199, 36);
            TextTitle.Name = "TextTitle";
            TextTitle.Size = new Size(315, 23);
            TextTitle.TabIndex = 18;
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(3, 4, 3, 4);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(4, 6, 4, 6);
            SideNav.Size = new Size(150, 412);
            SideNav.TabIndex = 10;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Dock = DockStyle.Fill;
            ButtonDelete.Location = new Point(261, 3);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(253, 54);
            ButtonDelete.TabIndex = 14;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // ButtonAddCustomer
            // 
            ButtonAddCustomer.Dock = DockStyle.Fill;
            ButtonAddCustomer.Location = new Point(3, 3);
            ButtonAddCustomer.Name = "ButtonAddCustomer";
            ButtonAddCustomer.Size = new Size(252, 54);
            ButtonAddCustomer.TabIndex = 13;
            ButtonAddCustomer.Text = "Add customer";
            ButtonAddCustomer.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            LabelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(155, 7);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(113, 30);
            LabelTitle.TabIndex = 11;
            LabelTitle.Text = "Customer";
            // 
            // TableBottomButtons
            // 
            TableBottomButtons.Anchor = AnchorStyles.Bottom;
            TableBottomButtons.ColumnCount = 2;
            TableBottomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableBottomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableBottomButtons.Controls.Add(ButtonDelete, 1, 0);
            TableBottomButtons.Controls.Add(ButtonAddCustomer, 0, 0);
            TableBottomButtons.Location = new Point(155, 349);
            TableBottomButtons.Name = "TableBottomButtons";
            TableBottomButtons.RowCount = 1;
            TableBottomButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableBottomButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableBottomButtons.Size = new Size(517, 60);
            TableBottomButtons.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom;
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
            button1.TabIndex = 14;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 94);
            button2.TabIndex = 13;
            button2.Text = "Add customer";
            button2.UseVisualStyleBackColor = true;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableBottomButtons);
            Controls.Add(TableAccountDetails);
            Controls.Add(SideNav);
            Controls.Add(LabelTitle);
            Name = "Customer";
            Size = new Size(684, 412);
            Load += OnCustomerLoad;
            TableAccountDetails.ResumeLayout(false);
            TableAccountDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericAllowance).EndInit();
            TableBottomButtons.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
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
        private TableLayoutPanel TableBottomButtons;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
    }
}
