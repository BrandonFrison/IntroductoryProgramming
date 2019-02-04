using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace readFileStudent1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                string stdName;

                StreamReader infile;

                infile = File.OpenText("students.txt");

                while (infile.EndOfStream == false)
                {
                    //make sure it reads first and last record
                    stdName = infile.ReadLine();
                    Console.WriteLine(stdName);
                }

                infile.Close();
                
            }
                // c# official error message
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
        }
    }
}
