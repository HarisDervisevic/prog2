using System;
using System.Linq;

namespace Array_läxa
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = new string[5];

            Console.WriteLine("Write 5 words that u wanted reverted in a list");

            for (int i = 0; i < 5; i++)
            {
                words[i] = Console.ReadLine();

            }

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(words[i]);

            }

        }
    }
}
