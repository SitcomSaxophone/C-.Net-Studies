using System;

namespace BasicCalculator
{
    public static class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("This is a simple calculator for use in the console.");
            Console.WriteLine("\nPlease enter you first number!");
            int x = Console.Read();
            Console.WriteLine("\nEnter your math operator.");
            string operation = Console.ReadLine();
            if (operation != "+" || operation != "-" || operation != "*" || operation != "/")
            {
                Console.WriteLine("\nYou must enter a valid operator.");
            }
            Console.WriteLine("\nPlease enter your second number!");
            int y = Console.Read();
            float result;
        }
    }
}