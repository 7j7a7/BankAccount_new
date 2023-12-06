using System;
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
    public partial class CurrentAccount : Form
    {
        double withdrawalAmount, depositAmount;
        double balanceC = FrmMain.BalanceCurrent;
        public CurrentAccount()
        {
            InitializeComponent();
        }

        private void btnS_Withdraw_Click(object sender, EventArgs e)
        {
            DialogResult w;
            withdrawalAmount = double.Parse(txtWithdrawC.Text);
            if ((FrmMain.status_S == "active") && (balanceC > 15))
            {
                balanceC = balanceC - withdrawalAmount;
                FrmMain.withdrawalCounterC = FrmMain.withdrawalCounterC + 1;
                FrmMain.BalanceCurrent = balanceC;
                w = MessageBox.Show("account balance", FrmMain.BalanceCurrent.ToString());
            }
            else
            {
                w = MessageBox.Show("account balance is low, please top up now");
            }
        }

        private void txtDepositC_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbStatusCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnC_Deposit_Click(object sender, EventArgs e)
        {
            DialogResult d;
            depositAmount = double.Parse(txtDepositC.Text);
            if ((FrmMain.status_C == "active") && (balanceC > 15))
            {
                balanceC = balanceC + depositAmount;
                FrmMain.BalanceCurrent = balanceC;
                d = MessageBox.Show("account balance", FrmMain.BalanceCurrent.ToString());
                FrmMain.AnnualInterestRate = FrmMain.BalanceCurrent * 0.04;
            }
            else
            {
                d = MessageBox.Show("your account balance is low, please top up now");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
