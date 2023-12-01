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
    public partial class FrmMain : Form
    {
        //variable declaration
        public static double MonthlyInterestRate, AnnualInterestRate, Balance;
        public static double withdrawalAmount, BalanceSaving = 0,MonthlyInterest, BalanceCurrent = 0;
        public static int withdrawalCounter = 0, savingsCounter = 0;
        public static string status_S, status_C;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtInterestRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSavingsAccount_Click(object sender, EventArgs e)
        {
            BalanceSaving = double.Parse(txtBalanceSaving.Text);
            SavingsAccount form2 = new SavingsAccount();
            form2.Visible = true;
            status_S = cmbStatusSaving.Text;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCurrentAccount_Click(object sender, EventArgs e)
        {
            CurrentAccount form3 = new CurrentAccount();
            form3.Visible = true;
        }

        public void calculateInterest() 
        {
            //calculation
            AnnualInterestRate= double.Parse(txtInterestRate.Text);
            double Balance = double.Parse(txtBalanceCurrent.Text);
            MonthlyInterestRate = (AnnualInterestRate / 12);
            MonthlyInterest = Balance * MonthlyInterestRate;
            Balance = Balance + MonthlyInterest;

            //display
            txtBalanceCurrent.Text=Balance.ToString();
        }

        public void withdraw(double amt)
        {
            withdrawalAmount =amt;
            Balance = Balance - withdrawalAmount;
            
            txtBalanceCurrent.Text=Balance.ToString();
            withdrawalCounter++;
            txtWithdrawals.Text= withdrawalCounter.ToString();
        }
    }
}
