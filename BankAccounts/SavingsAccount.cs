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
    public partial class SavingsAccount : Form
    {
        double withdrawalAmount;
        int withdrawalCounter = 0;
        public SavingsAccount()
        {
            double withdrawalAmount,wBalance;
            InitializeComponent();
        }
           
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SavingsAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnS_Withdraw_Click(object sender, EventArgs e)
        {
         
        }
    }
}
