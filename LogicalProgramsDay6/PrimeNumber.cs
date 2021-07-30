using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramsDay6
{
    class PrimeNumber
    {
        public void checkNumber(int number)
        {
            int isPrime = 0;
            //check input number is divisable and find factors
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                isPrime = 1;
                if (number % i == 0)
                {
                    isPrime = 0;
                }
            }
            if (isPrime == 1 || number==2)
            {
                Console.WriteLine(" {0} is a prime number.", number);
            }
            else
            {
                Console.WriteLine(" {0} is not a prime number.", number);
            }
        }

        public void TakeInput()
        {
            Console.Write(" Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            checkNumber(number);
        }
    }
}
