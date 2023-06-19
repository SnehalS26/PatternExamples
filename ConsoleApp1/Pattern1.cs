using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternExample
{
    internal class Pattern1
    {
        static void Main(string[] args)
        {
            //* * * * *
            //* * * * * 
            //* * * * *
            //* * * * *
            // nested loop
            for (int i = 1; i <= 4; i++) // row
            {
                for (int j = 1; j <= 5; j++) //column
                {
                    Console.Write("* ");
                }
                Console.WriteLine(); // to go to next line
            }

        }
    }
}
