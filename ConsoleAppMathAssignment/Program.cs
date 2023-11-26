using System;

namespace ConsoleAppMathAssignment
{
    class Program
    {
        static void Main()
        {
            //multiply input by 50
            //Console.WriteLine("Please enter a whole number");
            //int input1 = Convert.ToInt32(Console.ReadLine());
            //int multi50 = input1 * 50;
            //Console.WriteLine(input1 + " multiplied by 50 is " + multi50);

            //add 25 to input
            //Console.WriteLine("Please enter a whole number");
            //int input2 = Convert.ToInt32(Console.ReadLine());
            //int add25 = input2 + 25;
            //Console.WriteLine(input2 + " plus 25 is " + add25);

            //divide input by 12.5
            //Console.WriteLine("Please enter a number");
            //double input3 = Convert.ToDouble(Console.ReadLine());
            //double divide = input3 / 12.5;
            //Console.WriteLine(input3 + " divided by 12.5 is " + divide);

            //check if greater than 50
            //Console.WriteLine("Please enter a whole number");
            //int input4 = Convert.ToInt32(Console.ReadLine());
            //bool greaterThan50 = input4 > 50;
            //Console.WriteLine("It is " + greaterThan50 + " that " + input4 + " is greater than 50.");

            //divide by 7 and print remainder
            Console.WriteLine("Please enter a whole number");
            int input5 = Convert.ToInt32(Console.ReadLine());
            int modulus7 = input5 % 7;
            Console.WriteLine(modulus7 + " is the remainder of " + input5 + " divided by 7.");
        }
    }
}
