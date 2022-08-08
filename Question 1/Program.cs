using System;

namespace Question_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chapter 6:- Loops.
        // Question 1.
            Console.WriteLine("Enter The Number.");
            int inputN = int.Parse(Console.ReadLine());
            for(int i = 0; i <= inputN; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
