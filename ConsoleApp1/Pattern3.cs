using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
54321
5432
543
543
54
5
*/
namespace PatternExample
{
    internal class Pattern3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=5; i++) // row
            {
                for (int j = 5; j >= i; j--) //column
                {
                    Console.Write(j);
                }
                Console.WriteLine(); // to go to next line
            }
        }
    }
}
