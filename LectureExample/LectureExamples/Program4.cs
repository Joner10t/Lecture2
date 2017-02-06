using System;

namespace Lecture2
{
    class Program4
    {
        public static void Main()
        {
            Console.WriteLine("Entrance Ticket: $25.00.");
            Console.Write("Please enter the number of tickets that you want: ");

            //string input = Console.ReadLine();
            int numTix = Convert.ToInt32(Console.ReadLine()); // converts input string to integer

            Console.WriteLine("Total Cost = ${0:0.00}", numTix * 25); // displays total cost
                        
        }            
    }
}
