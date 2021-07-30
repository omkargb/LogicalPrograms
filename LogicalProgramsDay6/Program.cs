using System;

namespace LogicalProgramsDay6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to Logical Programming Problems ");
            Console.WriteLine("\n Here is the list of programs : ");
            Console.WriteLine( " 1. Fibonacci Series\n" +
                " 2. Perfect Number\n" +
                " 3. Prime Number\n" +
                " 4. Reverse a number\n" +
                " 5. Coupon Numbers\n" +
                " 6. Simulate Stopwatch Program \n");

            Console.Write(" Select an option number to run a program : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Fibonci fib = new Fibonci();
                    fib.TakeInput();
                    break;
                case 2:
                    PerfectNumber pf = new PerfectNumber();
                    pf.TakeInput();
                    break;
                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.TakeInput();
                    break;
                case 4:
                    ReverseNumber rev = new ReverseNumber();
                    rev.TakeInput();
                    break;
                case 5:
                    CouponNumbers cnum = new CouponNumbers();
                    cnum.TakeInput();
                    break;
                case 6:
                    StopwatchSimulation sim = new StopwatchSimulation();
                    sim.ShowTime();
                    break;
                default:
                    Console.WriteLine(" Invalid option. ");
                    break;
            }
        }
    }
}
