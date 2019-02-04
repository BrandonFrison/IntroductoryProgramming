using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileCourse1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                // project/bin/debug
                StreamWriter outFile;

                outFile = File.AppendText("courses.txt");

             /*   outFile = File.CreateText("courses.txt");   */

                outFile.WriteLine("intro to files");
                outFile.WriteLine("csis1175");
                outFile.WriteLine("intro to more data");
                outFile.WriteLine("csis1275");  

                outFile.Close();

                Console.WriteLine("Finished Writing");
            }
            catch
            {
                Console.WriteLine("there was an error file processsing");
            }
        }
    }
}
