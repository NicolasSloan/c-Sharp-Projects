using System;

namespace Daily_Report_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- THE TECH ACADEMY ---\n");
            Console.WriteLine("Student Daily Report:\n");


            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("\nWhat course are you on?");
            string course = Console.ReadLine();

            // Gets a string value from the user and explictly converts it into an unsigned short
            Console.WriteLine("\nWhat page number");
            ushort pageNum = Convert.ToUInt16(Console.ReadLine());

            // Gets a string value from the user and explictly converts it into a boolean
            Console.WriteLine("\nDo you need help with anything? Please answer \"True\" or \"False\".");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\nWere there any positive experiences you'd like to share? Please give specifics.");
            string posXP = Console.ReadLine();

            Console.WriteLine("\nIs there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            // Gets a string value from the user and explictly converts it into a byte
            Console.WriteLine("\nHow many hours did you study today?");
            byte hoursStudied  = Convert.ToByte(Console.ReadLine());

            //Exit message
            Console.WriteLine("\n\nthank you for your answers. an instructor will respond to this shortly. have a great day!");
            Console.ReadLine();
        }
    }
}
