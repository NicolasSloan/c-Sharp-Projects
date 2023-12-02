using System;

namespace Boolean_Logic_Car_Insurance_Program
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            short age = Convert.ToInt16(Console.ReadLine());


            //if else statements to assign boolean values to the variable hasDUI based on the input of "Yes" or "No"
            Console.WriteLine("Have you ever had a DUI? (Please enter \"Yes\" or \"No\")");
            string DUI = Console.ReadLine();
            bool hasDUI = true;
            if (DUI == "Yes")
            {
                hasDUI = true;
            }
            else if (DUI == "No")
            {
                hasDUI = false;
            }
            else
            {
                Console.WriteLine("Please start over and enter \"Yes\" or \"No\"");
            }

            Console.WriteLine("How many speeding tickets do you have?");
            short tickets = Convert.ToInt16(Console.ReadLine());


            if (age > 15 && hasDUI == false && tickets < 3)
            {
                Console.WriteLine("You are qualified for insurance!");
            }
            else
            {
                Console.WriteLine("Sorry, but you are not qualified for insurance");
            }
        }
    }
}
