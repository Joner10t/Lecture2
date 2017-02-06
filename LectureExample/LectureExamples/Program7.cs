using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture2
{
    class Program7
    {
        public static void Main()
        {
            Console.WriteLine(System.Math.Ceiling(14.1)); // 15 as ceiling rounds up 
            Console.WriteLine(System.Math.Floor(20.9)); // 20 as floor rounds down
            Console.WriteLine(Math.Round(3.5)); // 4

            Console.WriteLine(Math.Round(3.8543, 2)); // 3.85
            Console.WriteLine(Math.(3.8543, 2)); // 3.86
        }
    }
}
