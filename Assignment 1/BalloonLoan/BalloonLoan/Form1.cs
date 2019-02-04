using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalloonLoan
{
    public partial class Form1 : Form
    {
             
        public Form1()
           
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            try
            {
            decimal Amt; 
            decimal Loan;
            double r;
            double n;
            decimal monthly_value;
            double denom1;
            double denom2;
                      
            Amt = decimal.Parse(txtbx_amt.Text.Trim());
            Loan = decimal.Parse(txtbx_loan.Text.Trim());
            r = double.Parse(txtbx_rate.Text.Trim());
            n = double.Parse(txtbx_period.Text.Trim());
            n *= 12.0; //years to months
            r *= 0.01; //percentage

            denom1 = Math.Pow((1.0 + r), n);
            denom2 = Math.Pow((1.0 + r), -n);
            
            monthly_value = (decimal)(((double)Loan - ((double)Amt / denom1))* (r / (1.0 - denom2)));

            lbl_payment.Text = monthly_value.ToString("C");

            }
                catch
            {
                string message = "Error while calculating payment\nPlease check your input";
                MessageBox.Show(message);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txtbx_loan.Text = "";
            txtbx_rate.Text = "";
            txtbx_period.Text = "";
            txtbx_amt.Text = "";
            lbl_payment.Text = "";
        }
    }
}
