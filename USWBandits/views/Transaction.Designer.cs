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
            LabelID = new Label();
            ComboAction = new ComboBox();
            NumericAmount = new NumericUpDown();
            LabelAction = new Label();
            LabelForTranID = new Label();
            ComboAccountID = new ComboBox();
            DatePickEvent = new DateTimePicker();
            ButtonUpdate = new Button();
            LabelTitle = new Label();
            ButtonDelete = new Button();
            SideNav = new components.SideNav();
            TableProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericAmount).BeginInit();
            SuspendLayout();
            // 
            // TableProductDetails
            // 
            TableProductDetails.ColumnCount = 2;
            TableProductDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.54474F));
            TableProductDetails.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.45526F));
            TableProductDetails.Controls.Add(LabelEvent, 0, 4);
            TableProductDetails.Controls.Add(LabelAmount, 0, 3);
            TableProductDetails.Controls.Add(LabelAccountID, 0, 1);
            TableProductDetails.Controls.Add(LabelID, 1, 0);
            TableProductDetails.Controls.Add(ComboAction, 1, 2);
            TableProductDetails.Controls.Add(NumericAmount, 1, 3);
            TableProductDetails.Controls.Add(LabelAction, 0, 2);
            TableProductDetails.Controls.Add(LabelForTranID, 0, 0);
            TableProductDetails.Controls.Add(ComboAccountID, 1, 1);
            TableProductDetails.Controls.Add(DatePickEvent, 1, 4);
            TableProductDetails.Location = new Point(155, 40);
            TableProductDetails.Name = "TableProductDetails";
            TableProductDetails.RowCount = 5;
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.Size = new Size(430, 285);
            TableProductDetails.TabIndex = 9;
            // 
            // LabelEvent
            // 
            LabelEvent.Anchor = AnchorStyles.Right;
            LabelEvent.AutoSize = true;
            LabelEvent.BackColor = Color.Transparent;
            LabelEvent.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelEvent.Location = new Point(104, 244);
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
            LabelAmount.Location = new Point(83, 187);
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
            LabelAccountID.Location = new Point(58, 73);
            LabelAccountID.Name = "LabelAccountID";
            LabelAccountID.Size = new Size(104, 25);
            LabelAccountID.TabIndex = 9;
            LabelAccountID.Text = "Account ID";
            LabelAccountID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelID
            // 
            LabelID.Anchor = AnchorStyles.Left;
            LabelID.AutoSize = true;
            LabelID.BackColor = Color.Transparent;
            LabelID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelID.Location = new Point(168, 16);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(52, 25);
            LabelID.TabIndex = 5;
            LabelID.Text = "2321";
            // 
            // ComboAction
            // 
            ComboAction.Anchor = AnchorStyles.Left;
            ComboAction.FormattingEnabled = true;
            ComboAction.Location = new Point(168, 131);
            ComboAction.Name = "ComboAction";
            ComboAction.Size = new Size(228, 23);
            ComboAction.Sorted = true;
            ComboAction.TabIndex = 6;
            // 
            // NumericAmount
            // 
            NumericAmount.Anchor = AnchorStyles.Left;
            NumericAmount.DecimalPlaces = 2;
            NumericAmount.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            NumericAmount.Location = new Point(168, 188);
            NumericAmount.Name = "NumericAmount";
            NumericAmount.Size = new Size(228, 23);
            NumericAmount.TabIndex = 7;
            // 
            // LabelAction
            // 
            LabelAction.Anchor = AnchorStyles.Right;
            LabelAction.AutoSize = true;
            LabelAction.BackColor = Color.Transparent;
            LabelAction.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAction.Location = new Point(96, 130);
            LabelAction.Name = "LabelAction";
            LabelAction.Size = new Size(66, 25);
            LabelAction.TabIndex = 10;
            LabelAction.Text = "Action";
            LabelAction.TextAlign = ContentAlignment.MiddleRight;
            // 
            // LabelForTranID
            // 
            LabelForTranID.Anchor = AnchorStyles.Right;
            LabelForTranID.AutoSize = true;
            LabelForTranID.BackColor = Color.Transparent;
            LabelForTranID.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelForTranID.Location = new Point(31, 16);
            LabelForTranID.Name = "LabelForTranID";
            LabelForTranID.Size = new Size(131, 25);
            LabelForTranID.TabIndex = 8;
            LabelForTranID.Text = "Transaction ID";
            LabelForTranID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ComboAccountID
            // 
            ComboAccountID.Anchor = AnchorStyles.Left;
            ComboAccountID.FormattingEnabled = true;
            ComboAccountID.Location = new Point(168, 74);
            ComboAccountID.Name = "ComboAccountID";
            ComboAccountID.Size = new Size(228, 23);
            ComboAccountID.Sorted = true;
            ComboAccountID.TabIndex = 12;
            // 
            // DatePickEvent
            // 
            DatePickEvent.Anchor = AnchorStyles.Left;
            DatePickEvent.Location = new Point(168, 245);
            DatePickEvent.Name = "DatePickEvent";
            DatePickEvent.Size = new Size(228, 23);
            DatePickEvent.TabIndex = 13;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(155, 331);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(214, 62);
            ButtonUpdate.TabIndex = 8;
            ButtonUpdate.Text = "Update";
            ButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(191, 7);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(132, 30);
            LabelTitle.TabIndex = 7;
            LabelTitle.Text = "Transaction";
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(387, 331);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(198, 62);
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
            SideNav.Size = new Size(150, 400);
            SideNav.TabIndex = 10;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableProductDetails);
            Controls.Add(ButtonUpdate);
            Controls.Add(LabelTitle);
            Controls.Add(ButtonDelete);
            Controls.Add(SideNav);
            Name = "Transaction";
            Size = new Size(700, 400);
            Load += OnTransactionLoad;
            TableProductDetails.ResumeLayout(false);
            TableProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel TableProductDetails;
        private Label LabelAmount;
        private Label LabelAccountID;
        private Label LabelID;
        private ComboBox ComboAction;
        private NumericUpDown NumericAmount;
        private Label LabelAction;
        private Label LabelForTranID;
        private Button ButtonUpdate;
        private Label LabelTitle;
        private Button ButtonDelete;
        private components.SideNav SideNav;
        private ComboBox ComboAccountID;
        private Label LabelEvent;
        private DateTimePicker DatePickEvent;
    }
}
