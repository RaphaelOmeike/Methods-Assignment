using System;

namespace Question_6
{
    class Program
    {
        static void Main(string[] args)
        {
        // Question 6.
            Console.WriteLine("Enter The Number, N.");
            int inputN = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Number, K.");
            int inputK = int.Parse(Console.ReadLine());
            int factorialN = 1;
            int factorialK = 1;
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
                int result = factorialN / factorialK;
                Console.WriteLine($"N!/K! = {result}.");
            }
            else{
                Console.WriteLine("Invalid Input.");
            }
        }
    }
}
