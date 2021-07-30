using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LogicalProgramsDay6
{
    class StopwatchSimulation
    {
        public void ShowTime()
        {
            Console.Write(" To start a stopWatch press 1 : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Stopwatch sw = new Stopwatch();
            if (number == 1)
            {
                sw.Start();
                Console.WriteLine(" Stopwatch started ... ");
                Console.Write(" To stop a stopWatch press 0 : ");
                int stopNum = Convert.ToInt32(Console.ReadLine());
                if (stopNum == 0)
                {
                    sw.Stop();                    
                    // Get the elapsed time as a TimeSpan value.
                    TimeSpan ts = sw.Elapsed;
                    string elapsedTime = String.Format("{0:00}:{1:00}.{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds/10);
                    Console.WriteLine("\n Time elapsed (min:sec.millisec) = {0} ", elapsedTime);
                }
                else
                {
                    Console.WriteLine(" Please enter digit 0 to Stop a stopwatch. ");
                }
            }
            else
            {
                Console.WriteLine(" Please enter digit 1 to Start a stopwatch. ");
            }
        }
    }
}
