using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SalesDataForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_totalsales_Click(object sender, EventArgs e)
        {
            try
            {
                //variable declaring
                string fullname, fname, lname, testname, testnumber;
                decimal sales;
                decimal total = 0m;
                StreamReader salesnames = File.OpenText("SalesPerson.txt");
                StreamReader salesnumbers = File.OpenText("SalesNumbers.txt");
                StreamWriter saleserrors = File.AppendText("SalesErrors.txt");

                lstbx_data.Items.Clear();

                //creation of text box data to a full name
                fname = txtfname.Text.Trim();
                lname = txtlname.Text.Trim();
                fullname = (fname + " " + lname).ToLower();
                gb_totalsales.Text = "Total Sales for " + fullname;
                
// read until end of file
                while (!salesnames.EndOfStream)
                {

                    testname = salesnames.ReadLine().Trim();
                    //testnumber did not need trim
                    testnumber = salesnumbers.ReadLine();
                    

                    try
                    {
                        //comparing text box input to text file
                        if (string.Compare(fullname, testname, true) == 0)
                        {
                            //parses string in salesnumbers to a decimal value
                            sales = decimal.Parse(testnumber);
                            
                            lstbx_data.Items.Add(testname + " " + sales);
                            
                            total += sales;
                        }

                    }
                    catch
                    {
                        //for check box, try-catch used for error in parsing the string to decimal because of char such as hh or gg
                        if (cb_error.Checked)
                        {
                            lstbx_data.Items.Add(testname + " " + testnumber + " ** ERROR");
                            saleserrors.WriteLine(testname + " " + testnumber);
                        }
                        else
                        {
                            saleserrors.WriteLine(testname + " " + testnumber);
                        }
                    }
                }
               // close all streams
                saleserrors.Close();
                salesnumbers.Close();
                salesnames.Close();

                // show total in label
                lbl_totalsales.Text = total.ToString("C");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
