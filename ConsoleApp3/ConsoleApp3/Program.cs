﻿using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How is your day going?, Good or bad?");

            string mood = Console.ReadLine();

            switch (mood)
            {


                case "good":
                    Console.WriteLine("Noice:)");
                    break;


                case "bad":
                    Console.WriteLine("shet:(" + "bye");
                    break;
            }

            for (int i = 0; i < 3; i++)
            {
                if (i == 2)
                {
                    Console.WriteLine("Yup thats teh nummber");
                }
            }

            for (int i = 0; i < 3; i--)
            {
                while (i > 3)
                    Console.WriteLine("Ye");
                break;
            }




        }
    }
}
