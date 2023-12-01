namespace BankAccounts
{
    partial class SavingsAccount
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWithdrawS = new System.Windows.Forms.TextBox();
            this.txtDepositS = new System.Windows.Forms.TextBox();
            this.btnS_Withdraw = new System.Windows.Forms.Button();
            this.btnS_Deposit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "withdraw";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "deposit";
            // 
            // txtWithdrawS
            // 
            this.txtWithdrawS.Location = new System.Drawing.Point(52, 85);
            this.txtWithdrawS.Name = "txtWithdrawS";
            this.txtWithdrawS.Size = new System.Drawing.Size(126, 20);
            this.txtWithdrawS.TabIndex = 2;
            this.txtWithdrawS.Text = "£";
            // 
            // txtDepositS
            // 
            this.txtDepositS.Location = new System.Drawing.Point(416, 85);
            this.txtDepositS.Name = "txtDepositS";
            this.txtDepositS.Size = new System.Drawing.Size(116, 20);
            this.txtDepositS.TabIndex = 3;
            this.txtDepositS.Text = "£";
            // 
            // btnS_Withdraw
            // 
            this.btnS_Withdraw.Location = new System.Drawing.Point(217, 85);
            this.btnS_Withdraw.Name = "btnS_Withdraw";
            this.btnS_Withdraw.Size = new System.Drawing.Size(75, 23);
            this.btnS_Withdraw.TabIndex = 4;
            this.btnS_Withdraw.Text = "withdraw";
            this.btnS_Withdraw.UseVisualStyleBackColor = true;
            this.btnS_Withdraw.Click += new System.EventHandler(this.btnS_Withdraw_Click);
            // 
            // btnS_Deposit
            // 
            this.btnS_Deposit.Location = new System.Drawing.Point(571, 85);
            this.btnS_Deposit.Name = "btnS_Deposit";
            this.btnS_Deposit.Size = new System.Drawing.Size(75, 23);
            this.btnS_Deposit.TabIndex = 5;
            this.btnS_Deposit.Text = "deposit";
            this.btnS_Deposit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(337, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // SavingsAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnS_Deposit);
            this.Controls.Add(this.btnS_Withdraw);
            this.Controls.Add(this.txtDepositS);
            this.Controls.Add(this.txtWithdrawS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SavingsAccount";
            this.Text = "SavingsAccount";
            this.Load += new System.EventHandler(this.SavingsAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWithdrawS;
        private System.Windows.Forms.TextBox txtDepositS;
        private System.Windows.Forms.Button btnS_Withdraw;
        private System.Windows.Forms.Button btnS_Deposit;
        private System.Windows.Forms.Button btnExit;
    }
}