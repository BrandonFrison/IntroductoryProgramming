using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoesAutomotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //list box info and settings
            lb_misc.Items.Add("Inspection ($15.00)");
            lb_misc.Items.Add("Replace Muffler ($87.50)");
            lb_misc.Items.Add("Tire Rotation ($25.50)");
            lb_misc.Items.Add("Purchase New Tires ($75.50 each)");
            lb_tires.Visible = false;
            //enter number of tires here
            AddTires(7);
            lb_tires.SelectedIndex = 0;            
        }

        private void lb_misc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_misc.SelectedIndex == 3)
            {
                lb_tires.Visible = true;
            }
            else
            {
                lb_tires.Visible = false;
            }
        }        

        private int OilLubeCharges()
        {
            int total = 0;
            if (cb_lube.Checked == true)
            {
                total += 18;
            }
            if (cb_oil.Checked == true)
            {
                total += 26;
            }
            return total;
        }
        
         private int FlushCharges()
        {
            int total = 0;
            if (cb_rad.Checked == true)
            { 
                total += 30;
            }
            if (cb_trans.Checked == true)
            {
                total += 80;
            }
            return total;
        }
        
        private double MiscCharges()
        {
            double total = 0.0;
            if (lb_misc.SelectedIndex == 0)
            {
                total += 15;
            }
            if (lb_misc.SelectedIndex == 1)
            {
                total += 87.50;
            }
            if (lb_misc.SelectedIndex == 2)
            {
                total += 25.50;
            }
            if (lb_misc.SelectedIndex == 3)
            {
                total = ((double)lb_tires.SelectedIndex + 1) * 75.50;
            }
            return total;
        }
        
        private double OtherCharges()
        {
            const double wage = 18.8;
            double total, labor = 0.0;

            if (double.TryParse(txt_hrs.Text, out labor))
            { }
            else
            {
                labor = 0.0;
            }
            total = labor * wage;
            return total;
        }

        private double TaxCharges()
        {
            double taxtotal, partstotal = 0.0;
            const double tax = 0.06;
            try
            {
                partstotal = double.Parse(txt_parts.Text);
            }
            catch
            { }
           
            return taxtotal = tax * partstotal;
        }

        private double TotalCharges()
        {
            double total = OtherCharges() + TaxCharges() + MiscCharges() + FlushCharges() + OilLubeCharges();
            return total;
        }
        
        private void ClearOilLube()
        {
            cb_oil.Checked = false;
            cb_lube.Checked = false;
        }

        private void ClearFlushes()
        {
            cb_rad.Checked = false;
            cb_trans.Checked = false;
        }

        private void ClearMisc()
        {
            lb_tires.Visible = false;
            lb_tires.SelectedIndex = 0;
            lb_misc.SelectedIndex = -1;
        }

        private void ClearOther()
        {
            txt_hrs.Clear();
            txt_parts.Clear();
            lbl_errorlabor.Text = "";
            lbl_errorparts.Text = "";
        }

        private void ClearFees()
        {
            lbl_parts.Text = "";
            lbl_serv.Text = "";
            lbl_tax.Text = "";
            lbl_total.Text = "";
        }
        
        private void AddTires(int total)
        {
            int tre = 0;
            while (total > tre)
            {
                tre++;
                lb_tires.Items.Add(tre + " tire(s)");
                
            }
        }

        private bool CheckForNumeric()
        {
            bool nume = true;
            double value;
            if (!double.TryParse(txt_hrs.Text, out value))
            {
                lbl_errorlabor.Text = "Labor NOT numeric - 0 hrs assumed";
                nume = false;
            }
            double value2;
            if (!double.TryParse(txt_parts.Text, out value2))
            {
                lbl_errorparts.Text = "Parts NOT numeric - $0 assumed";
                nume = false;
            }
            return nume;
        }
     
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_clearmisc_Click(object sender, EventArgs e)
        {
            ClearMisc();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            ClearMisc();
            ClearFees();
            ClearFlushes();
            ClearOilLube();
            ClearOther();
        }

        private void btn_calc_Click(object sender, EventArgs e)
        {
            lbl_errorlabor.Text = "";
            lbl_errorparts.Text = "";

            double parts = 0.0;
            double.TryParse(txt_parts.Text, out parts);

            lbl_tax.Text = TaxCharges().ToString("c");
            lbl_total.Text = (parts + TotalCharges()).ToString("c");
            lbl_parts.Text = parts.ToString("c");
            lbl_serv.Text = (OilLubeCharges() + FlushCharges() + MiscCharges() + OtherCharges()).ToString("c");
            CheckForNumeric();
        }

    }
}
