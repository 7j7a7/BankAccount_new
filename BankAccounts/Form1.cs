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
    public partial class FrmMain : Form
    {
        //variable declaration
        public static double MonthlyInterestRate, AnnualInterestRate, Balance;
        public static double withdrawalAmount, BalanceSaving = 0,MonthlyInterest, BalanceCurrent = 0;
        public static int withdrawalCounter = 0, savingsCounter = 0, depositCounterS, withdrawalCounterS, withdrawalCounterC, depositCounterC, despositCounterC;
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

        private void cmbStatusCurrent_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (BalanceSaving > 0)
            {
                SavingMain();
            }
            if (BalanceCurrent > 0)
            {
                CurrentMain();
            }
        }

        public void SavingMain()
        {
            txtBalanceSaving.Text = BalanceSaving.ToString();
            txtWithdrawalSaving.Text = withdrawalCounterS.ToString();
            txtDepositSaving.Text = depositCounterS.ToString();
            txtServiceChargeSaving.Text = AnnualInterestRate.ToString();
            MonthlyInterest = BalanceSaving * 0.15;
            txtInterestRateSaving.Text = MonthlyInterest.ToString();
        }

        public void CurrentMain() 
        {
            txtBalanceCurrent.Text = BalanceCurrent.ToString();
            txtWithdrawalCurrent.Text = withdrawalCounterC.ToString();
            txtDepositCurrent.Text = despositCounterC.ToString();
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
            BalanceCurrent = double.Parse(txtBalanceCurrent.Text);
            CurrentAccount form3 = new CurrentAccount();
            form3.Visible = true;
            status_C = cmbStatusCurrent.Text;
        }

        public void calculateInterest() 
        {
            ////calculation
            //AnnualInterestRate= double.Parse(txtInterestRateSaving.Text);
            //double Balance = double.Parse(txtBalanceCurrent.Text);
            //MonthlyInterestRate = (AnnualInterestRate / 12);
            //MonthlyInterest = Balance * MonthlyInterestRate;
            //Balance = Balance + MonthlyInterest;

            ////display
            //txtBalanceCurrent.Text=Balance.ToString();
        }

        public void withdraw(double amt)
        {
            //withdrawalAmount =amt;
            //Balance = Balance - withdrawalAmount;
            
            //txtBalanceCurrent.Text=Balance.ToString();
            //withdrawalCounter++;
            //txtWithdrawalCurrent.Text= withdrawalCounter.ToString();
        }
    }
}
