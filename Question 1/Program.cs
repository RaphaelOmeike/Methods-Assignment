using System;

namespace Methods_A
{
    class Program
    {
        static void Main(string[] args)
        {
        // Chapter 9 :- Methods.
        // Question 1.
            Console.WriteLine("Enter Your Name.");
            string name = Console.ReadLine();
            PrintName(name);
        }
        public static void PrintName(string name)
        {
            Console.WriteLine($"\"Hello, {name}!\"");
            return;
        }
    }
}
