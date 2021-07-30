using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicalProgramsDay6
{
    class CouponNumbers
    {
        public static void CouponSave(int number)
        {
            List<int> couponList = new List<int>();
            Random ran = new Random();
            int counter=0, couponItem;
            while (couponList.Count != number)
            {
                couponItem = ran.Next(1, number+1);
                counter++;
                Console.Write(" " + couponItem);
                if (couponList.Contains(couponItem))
                {
                    continue;
                }
                else
                {
                    couponList.Add(couponItem);
                }
            }

            Console.WriteLine("\n Saved Coupons : ");
            for (int i = 0; i < couponList.Count; i++)
            {
                Console.Write(" "+couponList[i]); 
            }
            Console.WriteLine("\n Attempts : "+counter);
        }

        public void TakeInput()
        {
            Console.Write("\n Enter a total number of coupons to generate (1 to Number) : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(" Generating coupons : ");
            CouponSave(number);
        }
    }
}
