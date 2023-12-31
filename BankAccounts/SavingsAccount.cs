﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccounts
{
    public partial class SavingsAccount : Form
    {
        double withdrawalAmount, depositAmount;
        double balanceS = FrmMain.BalanceSaving;
        public SavingsAccount()
        {
            InitializeComponent();
        }
           
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SavingsAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnS_Deposit_Click(object sender, EventArgs e)
        {
            DialogResult d;
            depositAmount = double.Parse(txtDepositS.Text);
            if((FrmMain.status_S == "active") && (balanceS > 15))
            {
                balanceS = balanceS + depositAmount;
                FrmMain.BalanceSaving = balanceS;
                d = MessageBox.Show("account balance", FrmMain.BalanceSaving.ToString());
                FrmMain.AnnualInterestRate = FrmMain.BalanceSaving * 0.04;
            }
            else 
            {
                d = MessageBox.Show("your account balance is low, please top up now");
            }
        }

        private void cmbStatusSaving_Click(object sender, EventArgs e)
        {

        }

        private void btnS_Withdraw_Click(object sender, EventArgs e)
        {
            DialogResult w;
            withdrawalAmount = double.Parse(txtWithdrawS.Text);
            if((FrmMain.status_S == "active")&&(balanceS> 15))
            {
                balanceS = balanceS - withdrawalAmount;
                FrmMain.withdrawalCounterS = FrmMain.withdrawalCounterS + 1;
                FrmMain.BalanceSaving = balanceS;
                w = MessageBox.Show("account balance", FrmMain.BalanceSaving.ToString());
            }
            else 
            {
                w = MessageBox.Show("account balance is low, please top up now");
            }
        }
    }
}
