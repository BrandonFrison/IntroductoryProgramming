using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalloonPaymentConsole
{
    class Program
    {
        static void Main(string[] args)
        {
                string message = "Error while calculating payment\nPlease check your input";        
                decimal Amt = 0.0m;
                decimal Loan = 0.0m;
                double r = 0.0;
                double n = 0.0;
                decimal monthly_value = 0.0m;
                string loanInput, periodInput, rateInput, amtInput;
                double denom1;
                double denom2;
                
            try
            {             
            
                Console.WriteLine("Balloon Loan Payment");
                Console.WriteLine("");
           
                    
                Console.WriteLine("Please enter Loan Value (decimal):");
                loanInput = Console.ReadLine();
                Loan = decimal.Parse(loanInput);

                Console.WriteLine("Please enter Balloon Amount (decimal):");
                amtInput = Console.ReadLine();
                Amt = decimal.Parse(amtInput);

                Console.WriteLine("Please enter period in years (decimal):");
                periodInput = Console.ReadLine();
                n = double.Parse(periodInput);

                Console.WriteLine("Please enter rate per month in % (decimal):");
                rateInput = Console.ReadLine();
                r = double.Parse(rateInput);

                n *= 12;
                r *= 0.01;

                denom1 = Math.Pow((1.0 + r), n);
                denom2 = Math.Pow((1.0 + r), -n);
                monthly_value = (decimal)(((double)Loan-((double)Amt/denom1))*(r/(1.0-denom2)));

                Console.WriteLine("Monthly Payment : {0:C}", monthly_value);

                }
                catch
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
