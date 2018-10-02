using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            Console.WriteLine("Hello, What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age");
            int age = int.Parse(Console.ReadLine());
            if (age >= 21)
            {
                Console.WriteLine("You can get any drink in this machine");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("You cannot get a drink at this machine");
                Console.ReadLine();
                Environment.Exit(0);
            }

            string[] Drinks = new string[4];
            Drinks[0] = "Vodka";
            Drinks[1] = "Gin";
            Drinks[2] = "Tequilla";
            Drinks[3] = "Rum";

            foreach (var item in Drinks)
            {
                Console.WriteLine(count + " " + item);
                count++;
            }

            Console.WriteLine("");
            Console.WriteLine("Choose the corresponding number for the drink you would like");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine("You have selected " + Drinks[input - 1]);
            Console.ReadLine();
        }
    }
}