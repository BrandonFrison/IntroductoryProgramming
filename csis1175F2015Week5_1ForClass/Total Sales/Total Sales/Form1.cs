using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Total_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Variables
                decimal sales;        // To hold a sales amount
                decimal total = 0m;   // Accumulator, set to 0

                // Declare a StreamReader variable.
                StreamReader inputFile;

                inputFile = File.OpenText("sales.txt");
                while (!inputFile.EndOfStream)
                {
                    sales = decimal.Parse(inputFile.ReadLine());
                    total += sales;
                }

                inputFile.Close();


                // Display the total.
                totalLabel.Text = total.ToString("C");

            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
