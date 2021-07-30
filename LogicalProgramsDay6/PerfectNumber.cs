using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramsDay6
{
    class PerfectNumber
    {
        public void checkNumber(int number)
        {
            int factorAdd =0;
            //check input number is divisable and find factors
            for (int i = 1; i <= number/2; i++)
            {
                if (number % i == 0)
                {
                    int factor = i;
                    factorAdd += factor;
                    Console.Write(" "+factor);
                }
            }
            Console.WriteLine("\n Factors addition is : "+factorAdd);

            if(factorAdd==number)
            {
                Console.WriteLine(" {0} is a perfect number.", number);
            }
            else
            {
                Console.WriteLine(" {0} is not a perfect number.", number);
            }
        }

        public void TakeInput()
        {
            Console.Write(" Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Factors of number {0} are : ",number);
            checkNumber(number);
        }
    }
}
