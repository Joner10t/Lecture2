using System;

namespace Exercise
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Please enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Please enter your email: ");
            //string email = Console.ReadLine();
            //Console.WriteLine(name+"\n"+email+"\nGood Morning "+name);
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            double sq = (double)num * num;
            Console.WriteLine(sq);
        }
      
    }
}
