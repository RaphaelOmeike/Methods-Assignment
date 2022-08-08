using System;

namespace Question_7
{
    class Program
    {
        static void Main(string[] args)
        {
        // Question 7.
            Console.WriteLine("Enter The Number, N.");
            int inputN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Number, K.");
            int inputK = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialK = 1;
            int factorialKN = 1;
            if(inputK > 1 && inputK < inputN)
            {
                for(int i = inputN; i > 0; i--)
                {
                    factorialN *= i;
                }
                for(int j = inputK; j > 0; j--)
                {
                    factorialK *= j;
                }
                int n1 = inputN - inputK;
                int result = factorialN * factorialK;
                for(int c = n1; c > 0; c--)
                {
                    factorialKN *= c;
                }
                int result1 = result / factorialKN;
                Console.WriteLine($"N!*K!/(N-K)! = {result1}.");
            }
            else{
                Console.WriteLine("Invalid Input.");
            }
        }
    }
}
