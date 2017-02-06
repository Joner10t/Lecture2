using System;

namespace Lecture2
{
    class Program5
    {
        public static void Main()
        {
            int a = 1;
            Console.WriteLine(a); // 1

            a++; // "++" would add 1
            Console.WriteLine(a); // 2

            a--; // "--" would minus one
            Console.WriteLine(a); // 1 since a is now 2 after a++

            ++a;
            Console.WriteLine(a); // 2. when as a stand alone, no difference to a++

            int b = a; // at this point b = 2

            Console.WriteLine(a++); //2
            Console.WriteLine(b); b = b + 1; //2
            Console.WriteLine(++a); // 4
            b = b + 1; Console.WriteLine(b); //4
        }
    }
}
