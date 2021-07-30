using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramsDay6
{
    class Fibonci
    {
        public void DisplaySeries(int number)
        {
            int term1 = 0, term2 = 1, i, numNext;
            Console.Write(" {0} {1}", term1, term2);
            for (i=2; i<number; i++)
            {
                numNext = term1 + term2;
                term1 = term2;
                term2 = numNext;

                Console.Write(" {0}",term2);
            }
        }

        public void TakeInput()
        {
            Console.Write(" Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Fibonacci series of {0} terms : ",number);

            DisplaySeries(number);
        }
    }
}
