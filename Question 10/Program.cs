using System;

namespace Question_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter The Number.");
            int num = int.Parse(Console.ReadLine());
            PrintFactorial(num);
        }
        public static void PrintFactorial(int numb)
        {
            int factorial = 1;
            if(numb > 0 && numb < 101)
            {
                int i = numb;
                while(i > 0)
                {
                    factorial *= i;
                    i--;
                }
                Console.WriteLine($"{numb}! = {factorial}.");
            }
            else{
                Console.WriteLine("Invalid Input.");
            }
        }
    }
}
