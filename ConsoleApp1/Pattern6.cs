using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
*
 **
  ***
   ****
    *****
    */
namespace PatternExample
{
    internal class Pattern6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++) // row
            {
                for (int j = 1; j <= i; j++) //column
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(); // to go to next line
            }
        }
    }
}
