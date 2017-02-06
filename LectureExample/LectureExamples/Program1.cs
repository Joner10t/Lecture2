using System;

namespace Lecture2
{
    class Program1
    {
        public static void Main()
        {
            //Console.WriteLine("Welcome to ISS");
            //Console.Write("Please enter your name: ");
            //string name = Console.ReadLine();
            //Console.Write("Please enter your email: ");
            //string email = Console.ReadLine();
            //Console.WriteLine(name + "\n"+ email);
            //Console.WriteLine("Good Morning " + name);

            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");

            Console.WriteLine("1");//1
            Console.Write("2");
            Console.Write("3");
            Console.WriteLine("4");//234
            Console.WriteLine("5" + "6" + "7");//567
            Console.WriteLine(5 + 6 + 7); //18

            int a = 5;
            Console.WriteLine(a);//5
            Console.WriteLine("a");//a
            int b = 10;
            Console.WriteLine(a + b);//15
            Console.WriteLine("a" + "b");//ab
            Console.WriteLine(a + "b");//5b = "5" + "b" (VS converts variable 'a' into a string)

            Console.WriteLine("She says \"Hello\"");//She says "Hello"

            //BREAK

            Console.WriteLine("Thriple double quotes \"\"\"");//Thriple double quotes """
            Console.WriteLine("In C# to write \" in a string you must use \\\""); //In C# to write " in a string you must use \"

            //*
            //**
            //***
            Console.WriteLine("*\n**\n***");

            //Name             Age
            //John Smith       21
            //Jane Spencer     22
            //Jimbo Shade      23
            Console.WriteLine("Name \t\t Age");
            Console.WriteLine("John Smith \t 21");
            Console.WriteLine("Jane Spencer \t 22");
            Console.WriteLine("Jimbo Shade \t 23");

            string doubleQuote = "\"";
            Console.WriteLine(doubleQuote + doubleQuote + doubleQuote);

            //previously, a=5 and b=10
            //5 + 10 = 15
            Console.WriteLine(a + " + " + b + " = " + a + b); //5 + 10 = 510
            Console.WriteLine(a + " + " + b + " = " + (a + b)); //5 + 10 = 15
            Console.WriteLine("{0} + {1} = {2}",a,b,a+b);//5 + 10 = 15
            Console.WriteLine("{2} = {1} + {0}", a, b, a + b);//15 = 10 + 5
        }
    }
}
