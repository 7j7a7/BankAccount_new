namespace BankAccounts
{
    partial class FrmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.rchAddress = new System.Windows.Forms.RichTextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbStatusCurrent = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtServiceCharge = new System.Windows.Forms.TextBox();
            this.txtInterestRateSaving = new System.Windows.Forms.TextBox();
            this.txtWithdrawalCurrent = new System.Windows.Forms.TextBox();
            this.txtDepositCurrent = new System.Windows.Forms.TextBox();
            this.txtBalanceCurrent = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCurrentAccount = new System.Windows.Forms.Button();
            this.btnSavingsAccount = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtDepositSavings = new System.Windows.Forms.TextBox();
            this.txtBalanceSaving = new System.Windows.Forms.TextBox();
            this.cmbStatusSaving = new System.Windows.Forms.Label();
            this.txtServiceChargeSaving = new System.Windows.Forms.Label();
            this.txtWithdrawalSaving = new System.Windows.Forms.Label();
            this.txtDepositSaving = new System.Windows.Forms.Label();
            this.lbel13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox1.Controls.Add(this.cmbCity);
            this.groupBox1.Controls.Add(this.rchAddress);
            this.groupBox1.Controls.Add(this.txtMobile);
            this.groupBox1.Controls.Add(this.txtPostCode);
            this.groupBox1.Controls.Add(this.txtTown);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 494);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Bath",
            "Birmingham",
            "Bradford",
            "Brighton & Hove",
            "Bristol",
            "Cambridge",
            "Canterbury",
            "Carlisle",
            "Chelmsford",
            "Chester",
            "Chichester",
            "Colchester",
            "Coventry",
            "Derby",
            "Doncaster",
            "Durham",
            "Ely",
            "Exeter",
            "Gloucester",
            "Hereford",
            "Kingston-upon-Hull",
            "Lancaster",
            "Leeds",
            "Leicester",
            "Lichfield",
            "Lincoln",
            "Liverpool",
            "London",
            "Manchester",
            "Milton Keynes",
            "Newcastle-upon-Tyne",
            "Norwich",
            "Nottingham",
            "Oxford",
            "Peterborough",
            "Plymouth",
            "Portsmouth",
            "Preston",
            "Ripon",
            "Salford",
            "Salisbury",
            "Sheffield",
            "Southampton",
            "Southend-on-Sea",
            "St Albans",
            "Stoke on Trent",
            "Sunderland",
            "Truro",
            "Wakefield",
            "Wells",
            "Westminster",
            "Winchester",
            "Wolverhampton",
            "Worcester",
            "York"});
            this.cmbCity.Location = new System.Drawing.Point(74, 240);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(185, 26);
            this.cmbCity.TabIndex = 14;
            // 
            // rchAddress
            // 
            this.rchAddress.Location = new System.Drawing.Point(74, 152);
            this.rchAddress.Name = "rchAddress";
            this.rchAddress.Size = new System.Drawing.Size(185, 59);
            this.rchAddress.TabIndex = 13;
            this.rchAddress.Text = "";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(74, 459);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(185, 25);
            this.txtMobile.TabIndex = 12;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(74, 384);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(185, 25);
            this.txtPostCode.TabIndex = 11;
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(74, 311);
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(185, 25);
            this.txtTown.TabIndex = 10;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(74, 79);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(185, 25);
            this.txtFullName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mobile Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Post Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Town";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox2.Controls.Add(this.cmbStatusCurrent);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtServiceCharge);
            this.groupBox2.Controls.Add(this.txtInterestRateSaving);
            this.groupBox2.Controls.Add(this.txtWithdrawalCurrent);
            this.groupBox2.Controls.Add(this.txtDepositCurrent);
            this.groupBox2.Controls.Add(this.txtBalanceCurrent);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(405, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(509, 494);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "current";
            // 
            // cmbStatusCurrent
            // 
            this.cmbStatusCurrent.FormattingEnabled = true;
            this.cmbStatusCurrent.Items.AddRange(new object[] {
            "active",
            "inactive"});
            this.cmbStatusCurrent.Location = new System.Drawing.Point(336, 24);
            this.cmbStatusCurrent.Name = "cmbStatusCurrent";
            this.cmbStatusCurrent.Size = new System.Drawing.Size(121, 26);
            this.cmbStatusCurrent.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(281, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 18);
            this.label12.TabIndex = 13;
            this.label12.Text = "Status:";
            // 
            // txtServiceCharge
            // 
            this.txtServiceCharge.Location = new System.Drawing.Point(80, 458);
            this.txtServiceCharge.Name = "txtServiceCharge";
            this.txtServiceCharge.Size = new System.Drawing.Size(164, 25);
            this.txtServiceCharge.TabIndex = 9;
            // 
            // txtInterestRateSaving
            // 
            this.txtInterestRateSaving.Location = new System.Drawing.Point(80, 370);
            this.txtInterestRateSaving.Name = "txtInterestRateSaving";
            this.txtInterestRateSaving.Size = new System.Drawing.Size(164, 25);
            this.txtInterestRateSaving.TabIndex = 8;
            this.txtInterestRateSaving.TextChanged += new System.EventHandler(this.txtInterestRate_TextChanged);
            // 
            // txtWithdrawalCurrent
            // 
            this.txtWithdrawalCurrent.Location = new System.Drawing.Point(80, 277);
            this.txtWithdrawalCurrent.Name = "txtWithdrawalCurrent";
            this.txtWithdrawalCurrent.Size = new System.Drawing.Size(164, 25);
            this.txtWithdrawalCurrent.TabIndex = 7;
            // 
            // txtDepositCurrent
            // 
            this.txtDepositCurrent.Location = new System.Drawing.Point(80, 178);
            this.txtDepositCurrent.Name = "txtDepositCurrent";
            this.txtDepositCurrent.Size = new System.Drawing.Size(164, 25);
            this.txtDepositCurrent.TabIndex = 6;
            // 
            // txtBalanceCurrent
            // 
            this.txtBalanceCurrent.Location = new System.Drawing.Point(80, 74);
            this.txtBalanceCurrent.Name = "txtBalanceCurrent";
            this.txtBalanceCurrent.Size = new System.Drawing.Size(164, 25);
            this.txtBalanceCurrent.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 418);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "Monthly service charges:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "Annual interest rate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 18);
            this.label9.TabIndex = 2;
            this.label9.Text = "Withdrawals:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Deposits this month:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Balance";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.Location = new System.Drawing.Point(102, 618);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 34);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.Location = new System.Drawing.Point(1011, 611);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 29);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCurrentAccount
            // 
            this.btnCurrentAccount.BackColor = System.Drawing.Color.DarkGray;
            this.btnCurrentAccount.Location = new System.Drawing.Point(741, 609);
            this.btnCurrentAccount.Name = "btnCurrentAccount";
            this.btnCurrentAccount.Size = new System.Drawing.Size(133, 33);
            this.btnCurrentAccount.TabIndex = 11;
            this.btnCurrentAccount.Text = "Current Account";
            this.btnCurrentAccount.UseVisualStyleBackColor = false;
            this.btnCurrentAccount.Click += new System.EventHandler(this.btnCurrentAccount_Click);
            // 
            // btnSavingsAccount
            // 
            this.btnSavingsAccount.BackColor = System.Drawing.Color.DarkGray;
            this.btnSavingsAccount.Location = new System.Drawing.Point(427, 618);
            this.btnSavingsAccount.Name = "btnSavingsAccount";
            this.btnSavingsAccount.Size = new System.Drawing.Size(133, 33);
            this.btnSavingsAccount.TabIndex = 10;
            this.btnSavingsAccount.Text = "Savings Account";
            this.btnSavingsAccount.UseVisualStyleBackColor = false;
            this.btnSavingsAccount.Click += new System.EventHandler(this.btnSavingsAccount_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSalmon;
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.txtDepositSavings);
            this.groupBox3.Controls.Add(this.txtBalanceSaving);
            this.groupBox3.Controls.Add(this.cmbStatusSaving);
            this.groupBox3.Controls.Add(this.txtServiceChargeSaving);
            this.groupBox3.Controls.Add(this.txtWithdrawalSaving);
            this.groupBox3.Controls.Add(this.txtDepositSaving);
            this.groupBox3.Controls.Add(this.lbel13);
            this.groupBox3.Location = new System.Drawing.Point(961, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(497, 523);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Savings";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "active",
            "inactive"});
            this.comboBox1.Location = new System.Drawing.Point(318, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(82, 489);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(146, 20);
            this.textBox4.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 358);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(146, 20);
            this.textBox3.TabIndex = 7;
            // 
            // txtDepositSavings
            // 
            this.txtDepositSavings.Location = new System.Drawing.Point(82, 238);
            this.txtDepositSavings.Name = "txtDepositSavings";
            this.txtDepositSavings.Size = new System.Drawing.Size(146, 20);
            this.txtDepositSavings.TabIndex = 6;
            // 
            // txtBalanceSaving
            // 
            this.txtBalanceSaving.Location = new System.Drawing.Point(67, 104);
            this.txtBalanceSaving.Name = "txtBalanceSaving";
            this.txtBalanceSaving.Size = new System.Drawing.Size(148, 20);
            this.txtBalanceSaving.TabIndex = 5;
            this.txtBalanceSaving.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbStatusSaving
            // 
            this.cmbStatusSaving.AutoSize = true;
            this.cmbStatusSaving.Location = new System.Drawing.Point(279, 66);
            this.cmbStatusSaving.Name = "cmbStatusSaving";
            this.cmbStatusSaving.Size = new System.Drawing.Size(40, 13);
            this.cmbStatusSaving.TabIndex = 4;
            this.cmbStatusSaving.Text = "Status:";
            // 
            // txtServiceChargeSaving
            // 
            this.txtServiceChargeSaving.AutoSize = true;
            this.txtServiceChargeSaving.Location = new System.Drawing.Point(65, 466);
            this.txtServiceChargeSaving.Name = "txtServiceChargeSaving";
            this.txtServiceChargeSaving.Size = new System.Drawing.Size(120, 13);
            this.txtServiceChargeSaving.TabIndex = 3;
            this.txtServiceChargeSaving.Text = "Monthly service charge:";
            // 
            // txtWithdrawalSaving
            // 
            this.txtWithdrawalSaving.AutoSize = true;
            this.txtWithdrawalSaving.Location = new System.Drawing.Point(64, 332);
            this.txtWithdrawalSaving.Name = "txtWithdrawalSaving";
            this.txtWithdrawalSaving.Size = new System.Drawing.Size(74, 13);
            this.txtWithdrawalSaving.TabIndex = 2;
            this.txtWithdrawalSaving.Text = "Widthdrawals:";
            // 
            // txtDepositSaving
            // 
            this.txtDepositSaving.AutoSize = true;
            this.txtDepositSaving.Location = new System.Drawing.Point(65, 208);
            this.txtDepositSaving.Name = "txtDepositSaving";
            this.txtDepositSaving.Size = new System.Drawing.Size(48, 13);
            this.txtDepositSaving.TabIndex = 1;
            this.txtDepositSaving.Text = "Desposit";
            // 
            // lbel13
            // 
            this.lbel13.AutoSize = true;
            this.lbel13.Location = new System.Drawing.Point(66, 61);
            this.lbel13.Name = "lbel13";
            this.lbel13.Size = new System.Drawing.Size(46, 13);
            this.lbel13.TabIndex = 0;
            this.lbel13.Text = "Balance";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1497, 693);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSavingsAccount);
            this.Controls.Add(this.btnCurrentAccount);
            this.Name = "FrmMain";
            this.Text = "MyBankProject";
            this.Load += new System.EventHandler(this.FrmMain_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.RichTextBox rchAddress;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtServiceCharge;
        private System.Windows.Forms.TextBox txtInterestRateSaving;
        private System.Windows.Forms.TextBox txtWithdrawalCurrent;
        private System.Windows.Forms.TextBox txtDepositCurrent;
        private System.Windows.Forms.TextBox txtBalanceCurrent;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCurrentAccount;
        private System.Windows.Forms.Button btnSavingsAccount;
        private System.Windows.Forms.ComboBox cmbStatusCurrent;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label cmbStatusSaving;
        private System.Windows.Forms.Label txtServiceChargeSaving;
        private System.Windows.Forms.Label txtWithdrawalSaving;
        private System.Windows.Forms.Label txtDepositSaving;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtDepositSavings;
        private System.Windows.Forms.Label lbel13;
        private System.Windows.Forms.TextBox txtBalanceSaving;
    }
}

