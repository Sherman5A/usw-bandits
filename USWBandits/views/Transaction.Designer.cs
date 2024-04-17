namespace USWBandits.views
{
    partial class Transaction
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
            TableProductDetails = new TableLayoutPanel();
            LabelEvent = new Label();
            LabelAmount = new Label();
            LabelAccountID = new Label();
            LabelId = new Label();
            ComboAction = new ComboBox();
            NumericAmount = new NumericUpDown();
            LabelAction = new Label();
            LabelForTranId = new Label();
            ComboAccountID = new ComboBox();
            DateTransactionEvent = new DateTimePicker();
            ButtonAddTran = new Button();
            LabelTitle = new Label();
            ButtonDelete = new Button();
            SideNav = new components.SideNav();
            TableBottomButtons = new TableLayoutPanel();
            TableProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericAmount).BeginInit();
            TableBottomButtons.SuspendLayout();
            SuspendLayout();
            // 
            // TableProductDetails
            // 
            TableProductDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TableProductDetails.ColumnCount = 2;
            TableProductDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.54474F));
            TableProductDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.45526F));
            TableProductDetails.Controls.Add(LabelEvent, 0, 4);
            TableProductDetails.Controls.Add(LabelAmount, 0, 3);
            TableProductDetails.Controls.Add(LabelAccountID, 0, 1);
            TableProductDetails.Controls.Add(LabelId, 1, 0);
            TableProductDetails.Controls.Add(ComboAction, 1, 2);
            TableProductDetails.Controls.Add(NumericAmount, 1, 3);
            TableProductDetails.Controls.Add(LabelAction, 0, 2);
            TableProductDetails.Controls.Add(LabelForTranId, 0, 0);
            TableProductDetails.Controls.Add(ComboAccountID, 1, 1);
            TableProductDetails.Controls.Add(DateTransactionEvent, 1, 4);
            TableProductDetails.Location = new Point(156, 40);
            TableProductDetails.Name = "TableProductDetails";
            TableProductDetails.RowCount = 5;
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.Size = new Size(518, 290);
            TableProductDetails.TabIndex = 9;
            // 
            // LabelEvent
            // 
            LabelEvent.Anchor = AnchorStyles.Right;
            LabelEvent.AutoSize = true;
            LabelEvent.BackColor = Color.Transparent;
            LabelEvent.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelEvent.Location = new Point(138, 248);
            LabelEvent.Name = "LabelEvent";
            LabelEvent.Size = new Size(58, 25);
            LabelEvent.TabIndex = 12;
            LabelEvent.Text = "Event";
            LabelEvent.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelAmount
            // 
            LabelAmount.Anchor = AnchorStyles.Right;
            LabelAmount.AutoSize = true;
            LabelAmount.BackColor = Color.Transparent;
            LabelAmount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAmount.Location = new Point(117, 190);
            LabelAmount.Name = "LabelAmount";
            LabelAmount.Size = new Size(79, 25);
            LabelAmount.TabIndex = 11;
            LabelAmount.Text = "Amount";
            LabelAmount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelAccountID
            // 
            LabelAccountID.Anchor = AnchorStyles.Right;
            LabelAccountID.AutoSize = true;
            LabelAccountID.BackColor = Color.Transparent;
            LabelAccountID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAccountID.Location = new Point(92, 74);
            LabelAccountID.Name = "LabelAccountID";
            LabelAccountID.Size = new Size(104, 25);
            LabelAccountID.TabIndex = 9;
            LabelAccountID.Text = "Account ID";
            LabelAccountID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelId
            // 
            LabelId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            LabelId.AutoSize = true;
            LabelId.BackColor = Color.Transparent;
            LabelId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelId.Location = new Point(202, 16);
            LabelId.Name = "LabelId";
            LabelId.Size = new Size(313, 25);
            LabelId.TabIndex = 5;
            LabelId.Text = "2321";
            // 
            // ComboAction
            // 
            ComboAction.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComboAction.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboAction.FormattingEnabled = true;
            ComboAction.Items.AddRange(new object[] { "Deposit", "Transfer In", "Transfer Out", "Withdraw" });
            ComboAction.Location = new Point(202, 133);
            ComboAction.Name = "ComboAction";
            ComboAction.Size = new Size(313, 23);
            ComboAction.Sorted = true;
            ComboAction.TabIndex = 6;
            // 
            // NumericAmount
            // 
            NumericAmount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            NumericAmount.DecimalPlaces = 2;
            NumericAmount.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            NumericAmount.Location = new Point(202, 191);
            NumericAmount.Name = "NumericAmount";
            NumericAmount.Size = new Size(313, 23);
            NumericAmount.TabIndex = 7;
            // 
            // LabelAction
            // 
            LabelAction.Anchor = AnchorStyles.Right;
            LabelAction.AutoSize = true;
            LabelAction.BackColor = Color.Transparent;
            LabelAction.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAction.Location = new Point(130, 132);
            LabelAction.Name = "LabelAction";
            LabelAction.Size = new Size(66, 25);
            LabelAction.TabIndex = 10;
            LabelAction.Text = "Action";
            LabelAction.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelForTranId
            // 
            LabelForTranId.Anchor = AnchorStyles.Right;
            LabelForTranId.AutoSize = true;
            LabelForTranId.BackColor = Color.Transparent;
            LabelForTranId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelForTranId.Location = new Point(65, 16);
            LabelForTranId.Name = "LabelForTranId";
            LabelForTranId.Size = new Size(131, 25);
            LabelForTranId.TabIndex = 8;
            LabelForTranId.Text = "Transaction ID";
            LabelForTranId.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ComboAccountID
            // 
            ComboAccountID.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ComboAccountID.FormattingEnabled = true;
            ComboAccountID.Location = new Point(202, 75);
            ComboAccountID.Name = "ComboAccountID";
            ComboAccountID.Size = new Size(313, 23);
            ComboAccountID.TabIndex = 12;
            // 
            // DateTransactionEvent
            // 
            DateTransactionEvent.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DateTransactionEvent.Format = DateTimePickerFormat.Custom;
            DateTransactionEvent.Location = new Point(202, 249);
            DateTransactionEvent.Name = "DateTransactionEvent";
            DateTransactionEvent.Size = new Size(313, 23);
            DateTransactionEvent.TabIndex = 13;
            // 
            // ButtonAddTran
            // 
            ButtonAddTran.Dock = DockStyle.Fill;
            ButtonAddTran.Location = new Point(3, 3);
            ButtonAddTran.Name = "ButtonAddTran";
            ButtonAddTran.Size = new Size(253, 56);
            ButtonAddTran.TabIndex = 8;
            ButtonAddTran.Text = "Add transaction";
            ButtonAddTran.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(156, 7);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(132, 30);
            LabelTitle.TabIndex = 7;
            LabelTitle.Text = "Transaction";
            // 
            // ButtonDelete
            // 
            ButtonDelete.Dock = DockStyle.Fill;
            ButtonDelete.Enabled = false;
            ButtonDelete.Location = new Point(262, 3);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(253, 56);
            ButtonDelete.TabIndex = 11;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
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
            // TableBottomButtons
            // 
            TableBottomButtons.Anchor = AnchorStyles.Bottom;
            TableBottomButtons.ColumnCount = 2;
            TableBottomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableBottomButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            TableBottomButtons.Controls.Add(ButtonAddTran, 0, 0);
            TableBottomButtons.Controls.Add(ButtonDelete, 1, 0);
            TableBottomButtons.Location = new Point(156, 348);
            TableBottomButtons.Name = "TableBottomButtons";
            TableBottomButtons.RowCount = 1;
            TableBottomButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            TableBottomButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            TableBottomButtons.Size = new Size(518, 62);
            TableBottomButtons.TabIndex = 16;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableBottomButtons);
            Controls.Add(TableProductDetails);
            Controls.Add(LabelTitle);
            Controls.Add(SideNav);
            Name = "Transaction";
            Size = new Size(684, 412);
            Load += OnTransactionLoad;
            TableProductDetails.ResumeLayout(false);
            TableProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericAmount).EndInit();
            TableBottomButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel TableProductDetails;
        private Label LabelAmount;
        private Label LabelAccountID;
        private Label LabelId;
        private ComboBox ComboAction;
        private NumericUpDown NumericAmount;
        private Label LabelAction;
        private Label LabelForTranId;
        private Button ButtonAddTran;
        private Label LabelTitle;
        private Button ButtonDelete;
        private components.SideNav SideNav;
        private ComboBox ComboAccountID;
        private Label LabelEvent;
        private DateTimePicker DateTransactionEvent;
        private TableLayoutPanel TableBottomButtons;
    }
}
