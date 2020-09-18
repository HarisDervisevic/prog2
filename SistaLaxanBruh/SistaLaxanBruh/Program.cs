using System;
using System.Linq;

namespace SistaLaxanBruh

{
    class Program

    {
        private static object array;

        static void Main(string[] args)
        {
            int[] randomNummbers = { 1, 2, 3, 4, 5 };

            var words = new string[5];


            Console.WriteLine(AddNummbers(randomNummbers));



            Console.WriteLine("Skriv in 5 ord som du vill få tillbaks i omvänd ordning");

            for (int i = 0; i < 5; i++)
            {
                words[i] = Console.ReadLine();

            }

            revertedWordsList(words);


            int[] nummbers = { 3, 2, 8, 6, 5, 9, 14 };

            Console.WriteLine(highestNummber(nummbers));

        }


        public static int AddNummbers(int[] randomNummbers)
        {
            int sum = 0;

            for (int i = 0; i <= 4; i++)
            {
                sum += randomNummbers[i];
                continue;
            }
            return sum;
        }




        static void revertedWordsList(string[] words)
        {

            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }

        }



        static int highestNummber(int[] nummbers)
        {

            int temp = 0;

          Boolean loop = false;


            while (loop)
            {
                for (int i = 0; i < 6; i++)
                {
                    if (nummbers[i] > nummbers[i + 1]) {

                        temp = nummbers[i + 1];
                        nummbers[i + 1] = nummbers[i];
                        nummbers[i] = temp;


                    }
                }
                else
                {

                }

                Console.WriteLine(nummbers[6]);
            }


            return temp;
        }
    }
}
