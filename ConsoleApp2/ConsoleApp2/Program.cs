using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down your name");

            string name = Console.ReadLine();

            Console.WriteLine(name);


            Console.WriteLine("Write down your age");

            string age = Console.ReadLine();

            Console.WriteLine("" + age);

            Console.WriteLine("Are you alive?");

            string answear = Console.ReadLine();

            switch (answear)
            {
                case "yes":
                    Console.WriteLine("True");
                    break;
                case "no":
                    Console.WriteLine("false");
                    break;
            }

            Console.WriteLine();

        }
    }
}
