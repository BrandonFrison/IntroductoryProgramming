using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Two_D_Arrays1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Display2DArray(int[,] arr)
        {
            string line = "";
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    line = line + (arr[row, col]).ToString() + " ";

                }
                displayListBox.Items.Add(line);
                line = "";
            }
        }

        private int SumArray(int[,] arr)
        {
            int total = 0;
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    total = total + (arr[row, col]);

                }
                
            }

            return total;
        }



        private void ShowButton_Click(object sender, EventArgs e)
        {
            int[,] table = {
                {28,84,47,72},
                {69,26,45,6},
                {91,40,28,4},
                {42,34,37,87},
                {13,26,57,35}
                            };
            Display2DArray(table);
            displayListBox.Items.Add("======================");

            MessageBox.Show(SumArray(table).ToString());

   /*         string line = "";

            MessageBox.Show(table[3,2].ToString()); // 3,2 is row,col

            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    line = line + (table[row, col]).ToString() + " ";
                    
                }
                displayListBox.Items.Add(line);
                line = "";
            }

            MessageBox.Show(table.Length.ToString()); //all elements
            MessageBox.Show(table.Rank.ToString()); //2d array
            MessageBox.Show(table.GetLength(0).ToString()); //shows number of rows (0)
            MessageBox.Show(table.GetLength(1).ToString()); // shows number of columns (1)
           */ 

        }
    }
}
