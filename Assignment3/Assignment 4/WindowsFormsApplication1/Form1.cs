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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //clearing listbox
            lb_games.Items.Clear();
            
        }

        public void ReadIntoArray()
        {
            const int SIZE = 16;
            double[] numbers = new double[SIZE];
            string[] names = new string[SIZE];
            int count = 0;
            StreamReader inputfile = File.OpenText("GameSales.txt");
            char[] delim = { '@', '=' };

            while (!inputfile.EndOfStream && count < numbers.Length)
            {
                string line = inputfile.ReadLine().Trim();
                string[] splitline = line.Split(delim);
                string gamename = splitline[0];
                Double gameamount = double.Parse(splitline[1]);
                numbers[count] = gameamount;
                names[count] = gamename;
                count++;
            }
            inputfile.Close();
            
            for (int index = 0; index < count; index++)
            {
                lb_games.Items.Add(names[index] + " ==> $" + numbers[index]);
            }
            
        }

        public void SelectionSortByName()
        {
            const int SIZE = 16;
            double[] numbers = new double[SIZE];
            string[] names = new string[SIZE];
            int count = 0;
            StreamReader inputfile = File.OpenText("GameSales.txt");
            char[] delim = { '@', '=' };

            while (!inputfile.EndOfStream && count < numbers.Length)
            {
                string line = inputfile.ReadLine().Trim();
                string[] splitline = line.Split(delim);
                string gamename = splitline[0];
                Double gameamount = double.Parse(splitline[1]);
                numbers[count] = gameamount;
                names[count] = gamename;
                count++;
            }
            inputfile.Close();
            Array.Sort(names);


            for (int index = 0; index < count; index++)
            {
                lb_games.Items.Add(names[index] + " ==> $" + numbers[index]);
            }
            
        }

        public void SelectionSortBySales()
        {
            const int SIZE = 16;
            double[] numbers = new double[SIZE];
            string[] names = new string[SIZE];
            int count = 0;
            StreamReader inputfile = File.OpenText("GameSales.txt");
            char[] delim = { '@', '=' };

            while (!inputfile.EndOfStream && count < numbers.Length)
            {
                string line = inputfile.ReadLine().Trim();
                string[] splitline = line.Split(delim);
                string gamename = splitline[0];
                Double gameamount = double.Parse(splitline[1]);
                numbers[count] = gameamount;
                names[count] = gamename;
                count++;
                
            }
            inputfile.Close();

            Array.Sort(numbers);
            Array.Reverse(numbers);

            for (int index = 0; index < count; index++)
            {
                lb_games.Items.Add(names[index] + " ==> $" + numbers[index]);
            }
            
        }

        public void BinSrch()
        {
            const int SIZE = 16;
            double[] numbers = new double[SIZE];
            string[] names = new string[SIZE];
            int count = 0;
            StreamReader inputfile = File.OpenText("GameSales.txt");
            char[] delim = { '@', '=' };

            while (!inputfile.EndOfStream && count < numbers.Length)
            {
                string line = inputfile.ReadLine().Trim();
                string[] splitline = line.Split(delim);
                string gamename = splitline[0];
                Double gameamount = double.Parse(splitline[1]);
                numbers[count] = gameamount;
                names[count] = gamename;
                count++;
            }
            inputfile.Close();
            string search = txt_search.Text.Trim();
            //double.Parse(search);

            //double index1 = Array.BinarySearch(numbers, search);
        }

        public void DisplaySales()
        {
            ReadIntoArray();
        }

        public void btn_name_Click(object sender, EventArgs e)
        {
            lb_games.Items.Clear();
            SelectionSortByName();
        }

        public void btn_sales_Click(object sender, EventArgs e)
        {
            lb_games.Items.Clear();
            SelectionSortBySales();
        }

        public void btn_search_Click(object sender, EventArgs e)
        {
            lb_games.Items.Clear();
            const int SIZE = 16;
            double[] numbers = new double[SIZE];
            string[] names = new string[SIZE];
            int count = 0;
            StreamReader inputfile = File.OpenText("GameSales.txt");
            char[] delim = { '@', '=' };

            while (!inputfile.EndOfStream && count < numbers.Length)
            {
                string line = inputfile.ReadLine().Trim();
                string[] splitline = line.Split(delim);
                string gamename = splitline[0];
                Double gameamount = double.Parse(splitline[1]);
                numbers[count] = gameamount;
                names[count] = gamename;
                count++;
            }
            inputfile.Close();
            //if(splitline[].Contains(double search = txt_search.Text.Trim())
            {
                
            }

            for (int index = 0; index < count; index++)
            {
                lb_games.Items.Add(names[index] + " ==> $" + numbers[index]);
            }

        }

        public void rb_name_CheckedChanged(object sender, EventArgs e)
        {
            
            string search = txt_search.Text.Trim().ToLower();
            //if (names.contains(search))
            { 
                
            }
        }

        public void rb_sales_CheckedChanged(object sender, EventArgs e)
        {
            

        }
    }
}
