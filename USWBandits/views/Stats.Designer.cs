﻿namespace USWBandits.views
{
    partial class Stats
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
            SideNav = new components.SideNav();
            ButtonCalcInterest = new Button();
            ButtonListCustByDeposit = new Button();
            ButtonTotalTransaction = new Button();
            LabelTitle = new Label();
            SuspendLayout();
            // 
            // SideNav
            // 
            SideNav.Dock = DockStyle.Left;
            SideNav.Location = new Point(0, 0);
            SideNav.Margin = new Padding(3, 4, 3, 4);
            SideNav.Name = "SideNav";
            SideNav.Padding = new Padding(4, 6, 4, 6);
            SideNav.Size = new Size(150, 400);
            SideNav.TabIndex = 5;
            // 
            // ButtonCalcInterest
            // 
            ButtonCalcInterest.Location = new Point(163, 42);
            ButtonCalcInterest.Margin = new Padding(3, 2, 3, 2);
            ButtonCalcInterest.Name = "ButtonCalcInterest";
            ButtonCalcInterest.Size = new Size(424, 52);
            ButtonCalcInterest.TabIndex = 6;
            ButtonCalcInterest.Text = "Calculate Accrued Interest";
            ButtonCalcInterest.UseVisualStyleBackColor = true;
            // 
            // ButtonListCustByDeposit
            // 
            ButtonListCustByDeposit.Location = new Point(163, 112);
            ButtonListCustByDeposit.Margin = new Padding(3, 2, 3, 2);
            ButtonListCustByDeposit.Name = "ButtonListCustByDeposit";
            ButtonListCustByDeposit.Size = new Size(424, 52);
            ButtonListCustByDeposit.TabIndex = 7;
            ButtonListCustByDeposit.Text = "List Customers by Deposit";
            ButtonListCustByDeposit.UseVisualStyleBackColor = true;
            // 
            // ButtonTotalTransaction
            // 
            ButtonTotalTransaction.Location = new Point(163, 184);
            ButtonTotalTransaction.Margin = new Padding(3, 2, 3, 2);
            ButtonTotalTransaction.Name = "ButtonTotalTransaction";
            ButtonTotalTransaction.Size = new Size(424, 52);
            ButtonTotalTransaction.TabIndex = 8;
            ButtonTotalTransaction.Text = "Report Total Transactions by Date";
            ButtonTotalTransaction.UseVisualStyleBackColor = true;
            // 
            // LabelTitle
            // 
            LabelTitle.AutoSize = true;
            LabelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTitle.Location = new Point(163, 7);
            LabelTitle.Name = "LabelTitle";
            LabelTitle.Size = new Size(64, 30);
            LabelTitle.TabIndex = 12;
            LabelTitle.Text = "Stats";
            // 
            // Stats
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LabelTitle);
            Controls.Add(ButtonTotalTransaction);
            Controls.Add(ButtonListCustByDeposit);
            Controls.Add(ButtonCalcInterest);
            Controls.Add(SideNav);
            Name = "Stats";
            Size = new Size(700, 400);
            Load += OnProductLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private components.SideNav SideNav;
        private Button ButtonCalcInterest;
        private Button ButtonListCustByDeposit;
        private Button ButtonTotalTransaction;
        private Label LabelTitle;
    }
}
