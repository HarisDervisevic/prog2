using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace main
{
    class main
        {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the website" + "/n");

            Console.WriteLine(" Do you want to add a new user?");

            string selectedPage = Console.ReadLine();

            selectedPage.ToLower();

             bool page = false;

            switch (selectedPage)
            {

                case "yes":
                    Console.WriteLine("Creating a new user.....");
                    page = true;
                    break;

                case "no":
                    Console.WriteLine(" BYE");
                    Environment.Exit(1);
                    break;

            }


            Console.WriteLine("What is your name");

            var customerName = Console.ReadLine();

            var customer = new Customer();

            customer.name = customerName;

            var shopping = false;

            var product = new Product();


            while (shopping)

                Console.WriteLine("Write the nummber to the corresponding order" + "/n");
                Console.WriteLine("1.porsche " + "2 BMW " + "3 Mercedes " + "4 cart " + " 5.Stop shopping");
                string selectedProduct = Console.ReadLine();
            {

                switch (selectedProduct)
                {

                    case "1":
                        Console.WriteLine("Added porsche");
                        product.carMake = "porsche";
                        customer.cart.Add(product);
                        break;

                    case "2":
                        Console.WriteLine(" Added BMW");
                        product.carMake = "BMW";
                        customer.cart.Add(product);

                        break;

                    case "3":
                        Console.WriteLine(" Added Mercedes");
                        product.carMake = "Mercedes";
                        customer.cart.Add(product);
                        break;

                    case "5":
                        Console.WriteLine(" Quitting....");
                        shopping = true;
                        break;

                }
            }

            Console.WriteLine("You are done shopping");
            Console.WriteLine("You are welcome back!");



        }
    }
}

