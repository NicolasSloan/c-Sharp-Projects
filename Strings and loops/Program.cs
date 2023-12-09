using System;

namespace _6PartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "nic", "michael", "joesph", "sally" };

            Console.WriteLine("Please enter a last name");
            string userInput = Convert.ToString(Console.ReadLine());
            
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i] + " " + userInput;
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
