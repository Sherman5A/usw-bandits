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
            TableProductDetails.Location = new Point(177, 53);
            TableProductDetails.Margin = new Padding(3, 4, 3, 4);
            TableProductDetails.Name = "TableProductDetails";
            TableProductDetails.RowCount = 5;
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            TableProductDetails.Size = new Size(491, 380);
            TableProductDetails.TabIndex = 9;
            // 
            // LabelEvent
            // 
            LabelEvent.Anchor = AnchorStyles.Right;
            LabelEvent.AutoSize = true;
            LabelEvent.BackColor = Color.Transparent;
            LabelEvent.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelEvent.Location = new Point(113, 326);
            LabelEvent.Name = "LabelEvent";
            LabelEvent.Size = new Size(73, 32);
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
            LabelAmount.Location = new Point(86, 250);
            LabelAmount.Name = "LabelAmount";
            LabelAmount.Size = new Size(100, 32);
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
            LabelAccountID.Location = new Point(55, 98);
            LabelAccountID.Name = "LabelAccountID";
            LabelAccountID.Size = new Size(131, 32);
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
            LabelID.Location = new Point(192, 22);
            LabelID.Name = "LabelID";
            LabelID.Size = new Size(66, 32);
            LabelID.TabIndex = 5;
            LabelID.Text = "2321";
            // 
            // ComboAction
            // 
            ComboAction.Anchor = AnchorStyles.Left;
            ComboAction.FormattingEnabled = true;
            ComboAction.Location = new Point(192, 176);
            ComboAction.Margin = new Padding(3, 4, 3, 4);
            ComboAction.Name = "ComboAction";
            ComboAction.Size = new Size(260, 28);
            ComboAction.Sorted = true;
            ComboAction.TabIndex = 6;
            // 
            // NumericAmount
            // 
            NumericAmount.Anchor = AnchorStyles.Left;
            NumericAmount.DecimalPlaces = 2;
            NumericAmount.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            NumericAmount.Location = new Point(192, 252);
            NumericAmount.Margin = new Padding(3, 4, 3, 4);
            NumericAmount.Name = "NumericAmount";
            NumericAmount.Size = new Size(261, 27);
            NumericAmount.TabIndex = 7;
            // 
            // LabelAction
            // 
            LabelAction.Anchor = AnchorStyles.Right;
            LabelAction.AutoSize = true;
            LabelAction.BackColor = Color.Transparent;
            LabelAction.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LabelAction.Location = new Point(104, 174);
            LabelAction.Name = "LabelAction";
            LabelAction.Size = new Size(82, 32);
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
            LabelForTranID.Location = new Point(22, 22);
            LabelForTranID.Name = "LabelForTranID";
            LabelForTranID.Size = new Size(164, 32);
            LabelForTranID.TabIndex = 8;
            LabelForTranID.Text = "Transaction ID";
            LabelForTranID.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ComboAccountID
            // 
            ComboAccountID.Anchor = AnchorStyles.Left;
            ComboAccountID.FormattingEnabled = true;
            ComboAccountID.Location = new Point(192, 100);
            ComboAccountID.Margin = new Padding(3, 4, 3, 4);
            ComboAccountID.Name = "ComboAccountID";
            ComboAccountID.Size = new Size(260, 28);
            ComboAccountID.Sorted = true;
            ComboAccountID.TabIndex = 12;
            // 
            // DatePickEvent
            // 
            DatePickEvent.Anchor = AnchorStyles.Left;
            DatePickEvent.Location = new Point(192, 328);
            DatePickEvent.Margin = new Padding(3, 4, 3, 4);
            DatePickEvent.Name = "DatePickEvent";
            DatePickEvent.Size = new Size(260, 27);
            DatePickEvent.TabIndex = 13;
            // 
            // ButtonUpdate
            // 
            ButtonUpdate.Location = new Point(177, 441);
            ButtonUpdate.Margin = new Padding(3, 4, 3, 4);
            ButtonUpdate.Name = "ButtonUpdate";
            ButtonUpdate.Size = new Size(244, 83);
            ButtonUpdate.TabIndex = 8;
            ButtonUpdate.Text = "Update";
            ButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.BackColor = Color.Transparent;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(218, 9);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(165, 37);
            LabelTitle.TabIndex = 7;
            LabelTitle.Text = "Transaction";
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new Point(442, 441);
            ButtonDelete.Margin = new Padding(3, 4, 3, 4);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new Size(226, 83);
            ButtonDelete.TabIndex = 11;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(3, 5, 3, 5);
            SideNav.Name = "SideNav";
            SideNav.Size = new Size(171, 533);
            SideNav.TabIndex = 10;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TableProductDetails);
            Controls.Add(ButtonUpdate);
            Controls.Add(LabelTitle);
            Controls.Add(ButtonDelete);
            Controls.Add(SideNav);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Transaction";
            Size = new Size(686, 533);
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
