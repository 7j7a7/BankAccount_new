namespace BankAccounts
{
    partial class CurrentAccount
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnC_Deposit = new System.Windows.Forms.Button();
            this.btnC_Withdraw = new System.Windows.Forms.Button();
            this.txtDepositC = new System.Windows.Forms.TextBox();
            this.txtWithdrawC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(390, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnC_Deposit
            // 
            this.btnC_Deposit.Location = new System.Drawing.Point(624, 115);
            this.btnC_Deposit.Name = "btnC_Deposit";
            this.btnC_Deposit.Size = new System.Drawing.Size(75, 23);
            this.btnC_Deposit.TabIndex = 12;
            this.btnC_Deposit.Text = "deposit";
            this.btnC_Deposit.UseVisualStyleBackColor = true;
            this.btnC_Deposit.Click += new System.EventHandler(this.btnC_Deposit_Click);
            // 
            // btnC_Withdraw
            // 
            this.btnC_Withdraw.Location = new System.Drawing.Point(270, 115);
            this.btnC_Withdraw.Name = "btnC_Withdraw";
            this.btnC_Withdraw.Size = new System.Drawing.Size(75, 23);
            this.btnC_Withdraw.TabIndex = 11;
            this.btnC_Withdraw.Text = "withdraw";
            this.btnC_Withdraw.UseVisualStyleBackColor = true;
            this.btnC_Withdraw.Click += new System.EventHandler(this.btnS_Withdraw_Click);
            // 
            // txtDepositC
            // 
            this.txtDepositC.Location = new System.Drawing.Point(469, 115);
            this.txtDepositC.Name = "txtDepositC";
            this.txtDepositC.Size = new System.Drawing.Size(116, 20);
            this.txtDepositC.TabIndex = 10;
            this.txtDepositC.TextChanged += new System.EventHandler(this.txtDepositC_TextChanged);
            // 
            // txtWithdrawC
            // 
            this.txtWithdrawC.Location = new System.Drawing.Point(105, 115);
            this.txtWithdrawC.Name = "txtWithdrawC";
            this.txtWithdrawC.Size = new System.Drawing.Size(126, 20);
            this.txtWithdrawC.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "deposit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "withdraw";
            // 
            // CurrentAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnC_Deposit);
            this.Controls.Add(this.btnC_Withdraw);
            this.Controls.Add(this.txtDepositC);
            this.Controls.Add(this.txtWithdrawC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CurrentAccount";
            this.Text = "CurrentAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnC_Deposit;
        private System.Windows.Forms.Button btnC_Withdraw;
        private System.Windows.Forms.TextBox txtDepositC;
        private System.Windows.Forms.TextBox txtWithdrawC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}