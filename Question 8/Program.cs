using System;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
        // Question 8.
            Console.WriteLine("Enter The Number, N.");
            int inputN = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialN2 = 1;
            int factorialN1 = 1;
            for(int i = inputN; i > 0; i--)
            {
                factorialN *= i;
            }
            int n1 = inputN * 2;
            for(int j = n1; j > 0; j--)
            {
                factorialN2 *= j;
            }
            int n2 = inputN + 1;
            for(int c = n2; c > 0; c--)
            {
                factorialN1 *= c;
            }
            int result = factorialN2/(factorialN * factorialN1);
            Console.WriteLine($"2n!/(n+1)!n! = {result}.");
        }
    }
}
