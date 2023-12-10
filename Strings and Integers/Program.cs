using System;
using System.Collections.Generic;

namespace Strings_and_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            nums.Add(24);
            nums.Add(67);
            nums.Add(888);
            nums.Add(3);
            nums.Add(90);
            nums.Add(1);

            Console.WriteLine("What number would you like to divide the list by?");
            try
            {
                decimal userNum = Convert.ToDecimal(Console.ReadLine());
                for (int i = 0; i < nums.Count; i++)
                {
                    decimal result = nums[i] / userNum;
                    Console.WriteLine(result);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Please don't divide by 0");
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Please only enter a number");
            }
        }
    }
}
