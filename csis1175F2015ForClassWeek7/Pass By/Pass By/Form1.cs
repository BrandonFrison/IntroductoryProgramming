using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_By
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChgValues(int num1)
        {
            num1++;

            MessageBox.Show("From inside ChgValues " + num1.ToString());

        }

        

        

        private void passByValueButton_Click(object sender, EventArgs e)
        {
            int orig1 = 0;
            
            ChgValues(orig1);
            
            MessageBox.Show("From outside ChgValues " + orig1.ToString());



        }

        private void Chngvaluesbyref(ref int num1)
        {

            num1++;

            MessageBox.Show("From inside ChgValues " + num1.ToString());
        
        }

        private void passByRefButton_Click(object sender, EventArgs e)
        {


            int orig2 = 100;
            Chngvaluesbyref(ref orig2);

            MessageBox.Show("From outside ChgValues " + orig2.ToString());

        }
    }
}
