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

      /*        if (wood == "p" || wood == "P")
                  Console.WriteLine("pine 100");
              else
                  if (wood == "o" || wood == "O")
                      Console.WriteLine("oak 100");
                  else
                      if (wood == "M" || wood == "m")
                        Console.WriteLine("mahogany 100");
                      else
                          Console.WriteLine("idjit");
*/

            ///////////////////////////////////////////////////

              switch (wood)
              {
                  case "p":
                  case "P":
                  case  "1":
                      Console.WriteLine("pine 100");
                      break;

                  case "o":
                  case "O":
                      Console.WriteLine("oak 100");
                      break;

                  case "m":
                  case "M":
                      Console.WriteLine("Mahogany 100");
                      break;

                  default:
                      Console.WriteLine("idjit");
                      break;
              }

/////////////////////////////////////////////////////////////////

              int num = 4;

              switch (num)
              {
                  case 4:
                  case 5:
                  case 6:
                      Console.WriteLine("pine 100");
                      break;

                  

                  default:
                      Console.WriteLine("idjit");
                      break;
              }

              switch (num > 3)
              {
                  case true:
                      Console.WriteLine("true");
                      break;

                  case false:
                      Console.WriteLine("false");
                      break;

                 
              }








              
        
        }
    }
}
