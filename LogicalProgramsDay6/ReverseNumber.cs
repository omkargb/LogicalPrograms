using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalProgramsDay6
{
    class ReverseNumber
    {
        public void ReverseNum(int number)
        {
            int tempNum = number;
            int remainder=0, reverse=0;
            while(tempNum > 0)
            {
                remainder = tempNum % 10;
                reverse = (reverse * 10) + remainder;
                tempNum = tempNum / 10;
            }
            Console.WriteLine(" Reverse of {0} : {1} ",number,reverse);
        }

        public void TakeInput()
        {
            Console.Write(" Display Reverse of input number \n Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            ReverseNum(number);
        }
    }
}
