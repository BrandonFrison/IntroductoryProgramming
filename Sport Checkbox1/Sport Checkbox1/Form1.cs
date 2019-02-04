using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sport_Checkbox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            string selected = "";

            if (tennisChk.Checked == true)
                
                selected = selected + tennisChk.Text;
            if (cricketChk.Checked == true)
                
                selected = selected + cricketChk.Text;
            if (golfChk.Checked == true)
                
                selected = selected + golfChk.Text;

            selectTxt.Text = selected;

            if (tennisChk.Checked == true & cricketChk.Checked == true & golfChk.Checked == true)
                allChk.Checked = true;
            else
                allChk.Checked = false;
        }
    }
}
