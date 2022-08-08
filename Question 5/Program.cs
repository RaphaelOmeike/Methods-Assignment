using System;

namespace Question_5
{
    class Program
    {
        static void Main(string[] args)
        {
        // Question 5.
            Console.WriteLine("Enter The Number, N.");
            int inputN = int.Parse(Console.ReadLine());
            int n1 = 0;
            int n2 = 1;
            Console.WriteLine("Fibonacci Series.");
            Console.Write(n1 + " " + n2 + " ");
            for(int i = 2; i < inputN; i++)
            {
                int n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
