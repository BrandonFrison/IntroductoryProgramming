using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchCaseTest1
{
    class Program
    {
        static void Main(string[] args)
        {
          string wood;

          
            Console.Write("please enter type of Wood (P,O or M, e to exit): ");
              wood = Console.ReadLine().Trim();

         /*     if (wood == "p" || wood == "P")
                  Console.WriteLine("Pine $100");
              else
                  if (wood == "o" || wood == "O")
                      Console.WriteLine("Oak $225");
                  else
                      if (wood == "m" || wood == "M")
                          Console.WriteLine("Mahoghany $310");
                      else
                          Console.WriteLine("error");               */

              switch (wood)
              { 
                  case "p":
                  case "P":
                      Console.WriteLine("Pine $100");
                      break;

                  case "o":
                  case "O":
                      Console.WriteLine("oak $225");
                      break;

                  case "m":
                  case "M":
                      Console.WriteLine("mahoghany $310");
                      break;


                      default:
                       Console.WriteLine("error");
                       break;


              }

              
        
        }
    }
}
