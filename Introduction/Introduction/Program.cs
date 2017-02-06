using System;

namespace Examample
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter your email: ");
            string email = Console.ReadLine();
            Console.WriteLine(name+"\n"+email+"\nGood Morning "+name);          
            //Console.Write("Please enter your first name: ");
            //string FirstName = Console.ReadLine();
            //Console.Write("Please enter your last name: ");
            //string LastName = Console.ReadLine();
            ////Console.WriteLine("Good Morning " + name + "!");
            //Console.WriteLine("Good Morning {0} {1}!", FirstName, LastName);

        }
      
    }
}
